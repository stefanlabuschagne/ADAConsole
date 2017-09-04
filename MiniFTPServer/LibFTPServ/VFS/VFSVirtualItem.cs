using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibFTPServ.VFS
{
    /// <summary>
    /// Base class of VFS virtual items
    /// </summary>
    public abstract class VFSVirtualItem
    {
        private string _name;
        private long _size;
        private DateTime _date;

        /// <summary>
        /// The full path of the item in the VFS. 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// The size of the item in the VFS
        /// </summary>
        public long Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        /// Item date in the VFS
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// Creates a new instance of VFSVirtualItem
        /// </summary>
        /// <param name="name">The full path of the item in the VFS. </param>
        public VFSVirtualItem(string name)
        {
            _name = name;
            _date = DateTime.Now;
            _size = 0;
        }

        /// <summary>
        /// Creates a new instance of VFSVirtualItem
        /// </summary>
        /// <param name="name">The full path of the item in the VFS. </param>
        /// <param name="date">Item date in the VFS</param>
        /// <param name="size">The size of the item in the VFS</param>
        public VFSVirtualItem(string name, DateTime date, long size)
        {
            _name = name;
            _date = date;
            _size = size;
        }
    }
}
