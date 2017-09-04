using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using LibFTPServ.VFS;

namespace LibFTPServ.VFS
{
    /// <summary>
    /// stores the dynamic script parser paths
    /// </summary>
    public static class ParserPaths
    {
        /// <summary>
        /// The full Path to php.exe 
        /// </summary>
        public static string PhpPath = "";

        /// <summary>
        /// The full path to python.exe
        /// </summary>
        public static string PythonPath = "";

        /// <summary>
        /// the full path to ruby.exe
        /// </summary>
        public static string RubyPath = "";
    }

    /// <summary>
    /// Script type enumeration
    /// </summary>
    public enum ScriptType
    {
        /// <summary>
        /// PHP Script
        /// </summary>
        Php,
        
        /// <summary>
        /// Python script
        /// </summary>
        Python,

        /// <summary>
        /// Ruby script
        /// </summary>
        Ruby,

        /// <summary>
        /// Standalone program which doesn't need an interpreter
        /// </summary>
        Standalone
    }
}
