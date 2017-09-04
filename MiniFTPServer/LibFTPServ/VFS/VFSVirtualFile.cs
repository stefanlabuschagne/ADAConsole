using System;
using System.IO;

namespace LibFTPServ.VFS
{
    /// <summary>
    /// A VFS Virtual File structure
    /// </summary>
    public abstract class VFSVirtualFile : VFSVirtualItem
    {
        /// <summary>
        /// Creates a new instance of VFSVirtualFile
        /// </summary>
        /// <param name="name">The full path of the file in the VFS</param>
        public VFSVirtualFile(string name) : base(name) { }

        /// <summary>
        /// Creates a new instance of VFSVirtualFile
        /// </summary>
        /// <param name="name">The full path of the file in the VFS</param>
        /// <param name="time">File last modification date</param>
        /// <param name="size">File size</param>
        public VFSVirtualFile(string name, DateTime time, long size) : base(name, time, size) { }


        /// <summary>
        /// Renders the contents of the file
        /// </summary>
        /// <returns>The rendered content as a stream</returns>
        public abstract Stream RenderContents();
    }
}
