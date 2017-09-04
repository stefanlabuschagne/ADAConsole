using System;
using System.IO;

namespace LibFTPServ.VFS
{
    class VFSLinkFile: VFSVirtualFile
    {
        private string _source;

        public VFSLinkFile(string Name, string source): base(Name)
        {
            if (!File.Exists(source)) throw new ArgumentException("source file must exist");
            _source = source;
            FileInfo fi = new FileInfo(source);
            base.Date = fi.LastWriteTime;
            base.Size = fi.Length;
            fi = null;
        }

        public override Stream RenderContents()
        {
            return File.OpenRead(_source);
        }
    }
}
