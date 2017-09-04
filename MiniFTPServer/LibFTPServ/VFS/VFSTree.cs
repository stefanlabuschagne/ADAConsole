using System;
using System.Linq;
using System.Collections.Generic;
using LibFTPServ.FTP;
using System.Text;

namespace LibFTPServ.VFS
{
    internal class VFSDirectory: VFSVirtualItem
    {
        private List<VFSDirectory> _subdirs;
        private List<VFSVirtualItem> _files;
        //private string _name;
        //private DateTime _date;

        private string GetFileName(string path)
        {
            string[] parts = path.Split('/');
            return parts[parts.Length - 1];
        }

        public VFSDirectory(): base(null)
        {
            _subdirs = new List<VFSDirectory>();
            _files = new List<VFSVirtualItem>();
            base.Size = -1;
        }

        public VFSDirectory(string name): base(name.ToLower())
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name can't be null or empty");
            _subdirs = new List<VFSDirectory>();
            _files = new List<VFSVirtualItem>();
            base.Size = -1;
        }

        public VFSDirectory(string name, DateTime date) : base(name.ToLower(), date, -1)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name can't be null or empty");
            _subdirs = new List<VFSDirectory>();
            _files = new List<VFSVirtualItem>();
        }

        public bool ContainsDir(string dirname)
        {
            var q = from dir in _subdirs where dir.Name == dirname.ToLower() select dir;
            return q.ToList().Count > 0;
        }

        public VFSDirectory GetSubdirByName(string name)
        {
            var q = from dir in _subdirs where dir.Name == name.ToLower() select dir;
            return q.FirstOrDefault();
        }

        public List<FTPListItem> ListDirectory()
        {
            List<FTPListItem> ret = new List<FTPListItem>();
            FTPListItem tmp;

            foreach (VFSDirectory dir in Subdirs)
            {
                tmp = new FTPListItem();
                tmp.Name = dir.Name;
                tmp.IsDir = true;
                tmp.Date = dir.Date;
                ret.Add(tmp);
            }

            foreach (VFSVirtualItem itm in Files)
            {
                tmp = new FTPListItem();
                tmp.Name = GetFileName(itm.Name);
                tmp.Date = itm.Date;
                tmp.IsDir = false;
                tmp.Size = itm.Size;
                ret.Add(tmp);
            }

            return ret;
        }

        public List<VFSDirectory> Subdirs
        {
            get { return _subdirs; }
        }

        public List<VFSVirtualItem> Files
        {
            get { return _files; }
        }
    }
}
