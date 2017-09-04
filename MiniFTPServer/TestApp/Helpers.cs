using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using LibFTPServ.FTP;

namespace TestApp
{
    internal class Helpers
    {
        public static string AppDir
        {
            get 
            { 
                string r = Path.GetDirectoryName(Application.ExecutablePath); 
                return r;
            }
        }

        public static string BoolConvert(bool value)
        {
            if (value) return "Yes";
            else return "No";
        }

        public static string FtpEventToString(FTPLogEventType t)
        {
            switch (t)
            {
                case FTPLogEventType.Abort:
                    return "Transfer abort";
                case FTPLogEventType.AppendFile:
                    return "Append file";
                case FTPLogEventType.ChangeType:
                    return "Transfer type change";
                case FTPLogEventType.ChangeWorkDir:
                    return "Work dir change";
                case FTPLogEventType.ConnectionReinitialize:
                    return "Connection reinitialization";
                case FTPLogEventType.DeleteDirectory:
                    return "Directory delete";
                case FTPLogEventType.DeleteFile:
                    return "File delete";
                case FTPLogEventType.DownloadFile:
                    return "File download";
                case FTPLogEventType.FeatureList:
                    return "Feature list query";
                case FTPLogEventType.FileModificationDate:
                    return "File modification date query";
                case FTPLogEventType.FileSize:
                    return "File size query";
                case FTPLogEventType.ListDirectory:
                    return "Directory list";
                case FTPLogEventType.ListFileNames:
                    return "Filenames list";
                case FTPLogEventType.MakeDirectory:
                    return "Direcory create";
                case FTPLogEventType.OptionReceived:
                    return "Options change";
                case FTPLogEventType.PassiveMode:
                    return "Passive mode for data transfer";
                case FTPLogEventType.PortCommand:
                    return "Data port change";
                case FTPLogEventType.Rename:
                    return "Rename";
                case FTPLogEventType.UploadFile:
                    return "File upload";
                case FTPLogEventType.UserConnect:
                    return "User connected";
                case FTPLogEventType.UserDisconnect:
                    return "User disconnect";
                default:
                    return "Unknown event";
            }
        }


    }
}
