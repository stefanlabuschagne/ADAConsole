﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VulindlelaFTPServer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DC=vulprd,DC=pwv,DC=gov,DC=za")]
        public string VulDC {
            get {
                return ((string)(this["VulDC"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.123.45.180")]
        public string VulIP {
            get {
                return ((string)(this["VulIP"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=APPLICATION_RIGHTS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string VulCTXApp {
            get {
                return ((string)(this["VulCTXApp"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=GOVERNMENT_STRUCTURE,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string VulCTXGovt {
            get {
                return ((string)(this["VulCTXGovt"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=USERS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string VulCTXUsers {
            get {
                return ((string)(this["VulCTXUsers"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string VulRootContext {
            get {
                return ((string)(this["VulRootContext"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Qsadoh!Qsadoh")]
        public string VulMasterPassword {
            get {
                return ((string)(this["VulMasterPassword"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vulsystem")]
        public string VulMasterUser {
            get {
                return ((string)(this["VulMasterUser"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=10.123.45.180;Initial Catalog=Ads;Persist Security Info=True;User ID=" +
            "sa;Password=M33Q1Serv!ce09")]
        public string AdsPRDConnectionString {
            get {
                return ((string)(this["AdsPRDConnectionString"]));
            }
            set {
                this["AdsPRDConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=USERS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string AD_USERS_PRD {
            get {
                return ((string)(this["AD_USERS_PRD"]));
            }
            set {
                this["AD_USERS_PRD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=APPLICATION_RIGHTS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string AD_APPL_PRD {
            get {
                return ((string)(this["AD_APPL_PRD"]));
            }
            set {
                this["AD_APPL_PRD"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\_  FTPServerFiles")]
        public string FTPRoot {
            get {
                return ((string)(this["FTPRoot"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Qsadoh!Qsadoh")]
        public string pwd {
            get {
                return ((string)(this["pwd"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vulsystem")]
        public string usr {
            get {
                return ((string)(this["usr"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7000")]
        public string MIN_PASSV_PORT {
            get {
                return ((string)(this["MIN_PASSV_PORT"]));
            }
            set {
                this["MIN_PASSV_PORT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7100")]
        public string MAX_PASSV_PORT {
            get {
                return ((string)(this["MAX_PASSV_PORT"]));
            }
            set {
                this["MAX_PASSV_PORT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("21")]
        public string FTP_PORT {
            get {
                return ((string)(this["FTP_PORT"]));
            }
            set {
                this["FTP_PORT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AUTO_START_FTP {
            get {
                return ((bool)(this["AUTO_START_FTP"]));
            }
            set {
                this["AUTO_START_FTP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ENABLE_FTP_LOGGING {
            get {
                return ((bool)(this["ENABLE_FTP_LOGGING"]));
            }
            set {
                this["ENABLE_FTP_LOGGING"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ENABLE_NOTIFY_ICON {
            get {
                return ((bool)(this["ENABLE_NOTIFY_ICON"]));
            }
            set {
                this["ENABLE_NOTIFY_ICON"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ENABLE_FTPFOLDER_ICON {
            get {
                return ((bool)(this["ENABLE_FTPFOLDER_ICON"]));
            }
            set {
                this["ENABLE_FTPFOLDER_ICON"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ENABLE_QUICK_CONFIG_MENU {
            get {
                return ((bool)(this["ENABLE_QUICK_CONFIG_MENU"]));
            }
            set {
                this["ENABLE_QUICK_CONFIG_MENU"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AUTO_SEND_ERROR_REPORT {
            get {
                return ((bool)(this["AUTO_SEND_ERROR_REPORT"]));
            }
            set {
                this["AUTO_SEND_ERROR_REPORT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ENABLE_APD {
            get {
                return ((bool)(this["ENABLE_APD"]));
            }
            set {
                this["ENABLE_APD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dd/MM/yyyy hh:mm:sstt")]
        public string DATE_TIME_FORMAT {
            get {
                return ((string)(this["DATE_TIME_FORMAT"]));
            }
            set {
                this["DATE_TIME_FORMAT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OU=APPLICATION_RIGHTS,OU=Vulindlela3,DC=vulindlelaprd,DC=gov,DC=za")]
        public string AD_APPLICATION_PRD {
            get {
                return ((string)(this["AD_APPLICATION_PRD"]));
            }
            set {
                this["AD_APPLICATION_PRD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string HostName {
            get {
                return ((string)(this["HostName"]));
            }
            set {
                this["HostName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("21")]
        public string HstPortNumber {
            get {
                return ((string)(this["HstPortNumber"]));
            }
            set {
                this["HstPortNumber"] = value;
            }
        }
    }
}
