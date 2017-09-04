using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibFTPServ.FTP;
using System;
using System.Text;

namespace LibFTPServ.VFS
{
    public class VFSManager
    {
        private VFSDirectory _rootdir;
        private List<VFSVirtualItem> _items;
        private List<string> _virtualpaths;

        public VFSManager()
        {
            _rootdir = new VFSDirectory("/");
            _items = new List<VFSVirtualItem>();
            _virtualpaths = new List<string>();
        }

        private void RebuildTree()
        {
            string[] path;
            _rootdir = null;
            _virtualpaths.Clear();
            GC.Collect();
            _rootdir = new VFSDirectory("/");
            VFSDirectory currdir = _rootdir;
            foreach (VFSVirtualItem item in _items)
            {
                path = item.Name.Split('/');
                for (int i = 0; i < path.Length; i++)
                {
                    if (i != path.Length - 1) //directory
                    {
                        if (!string.IsNullOrEmpty(path[i]))
                        {
                            if (!currdir.ContainsDir(path[i])) currdir.Subdirs.Add(new VFSDirectory(path[i]));
                            currdir = currdir.GetSubdirByName(path[i]);
                        }
                    }
                    else currdir.Files.Add(item);
                }
            }

            foreach (VFSVirtualItem item in _items) _virtualpaths.Add(getPath(item.Name));
            _virtualpaths = _virtualpaths.Distinct().ToList();
        }

        private string getPath(string p)
        {
            string[] parts = p.Split('/');
            StringBuilder sb = new StringBuilder(p.Length);
            sb.Append("/");
            for (int i = 1; i < parts.Length - 1; i++)
            {
                sb.Append(parts[i]);
                if (i != parts.Length - 2) sb.Append("/");
            }
            return sb.ToString();
        }

        internal VFSDirectory GetDirectory(string path)
        {
            if (path == "/") return _rootdir;
            VFSDirectory currdir = _rootdir;
            string[] parts = path.Split('/');
            bool ok = true;
            for (int i = 1; i < parts.Length; i++)
            {

                if (currdir.ContainsDir(parts[i])) currdir = currdir.GetSubdirByName(parts[i]);
                else break;
            }
            if (!ok) return null;
            else return currdir;
        }

        internal bool IsVirtualFile(string path)
        {
            var q = from file in _items where file.Name.ToLower() == path.ToLower() select file;
            return q.ToList().Count > 0;
        }

        internal Stream GetFileContents(string path)
        {
            var q = from file in _items where file.Name.ToLower() == path.ToLower() select file;
            return ((VFSVirtualFile)q.FirstOrDefault()).RenderContents();
        }

        internal bool PathExists(string path)
        {
            string fix = HelperFunctions.FixPath(path);
            return _virtualpaths.Contains(fix);
        }

        public void AddItem(VFSVirtualItem item)
        {
            _items.Add(item);
            RebuildTree();
        }

        private void RemoveItem(VFSVirtualItem item)
        {
            _items.Remove(item);
            RebuildTree();
        }
    }
}
