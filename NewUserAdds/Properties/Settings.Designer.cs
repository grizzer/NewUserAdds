﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewUserAdds.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public string LastSSN {
            get {
                return ((string)(this["LastSSN"]));
            }
            set {
                this["LastSSN"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point MainWindowLocation {
            get {
                return ((global::System.Drawing.Point)(this["MainWindowLocation"]));
            }
            set {
                this["MainWindowLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point LogWindowLocation {
            get {
                return ((global::System.Drawing.Point)(this["LogWindowLocation"]));
            }
            set {
                this["LogWindowLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Point PendingUsersLocation {
            get {
                return ((global::System.Drawing.Point)(this["PendingUsersLocation"]));
            }
            set {
                this["PendingUsersLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string intSigFile {
            get {
                return ((string)(this["intSigFile"]));
            }
            set {
                this["intSigFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string extSigFile {
            get {
                return ((string)(this["extSigFile"]));
            }
            set {
                this["extSigFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FHS7/CHIW")]
        public string orderingServer {
            get {
                return ((string)(this["orderingServer"]));
            }
            set {
                this["orderingServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("fhs7.axolotl.com")]
        public string addsServer {
            get {
                return ((string)(this["addsServer"]));
            }
            set {
                this["addsServer"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NWTACFHIE1")]
        public string DataSource {
            get {
                return ((string)(this["DataSource"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RawData")]
        public string RawDataCatalog {
            get {
                return ((string)(this["RawDataCatalog"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("UserAddDb")]
        public string UserAddCatalog {
            get {
                return ((string)(this["UserAddCatalog"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=NWTACFHIE1;Initial Catalog=UserAddDb;Integrated Security=True")]
        public string UserAddDBConnectionString {
            get {
                return ((string)(this["UserAddDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=NWTACFHIE1;Initial Catalog=RawData;Integrated Security=True")]
        public string RawDataDBConnectionString {
            get {
                return ((string)(this["RawDataDBConnectionString"]));
            }
        }
        
        /// <summary>
        /// External Access Coordinator, to recieve copies of notificaiton emails. Use their entry in the GAL.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("External Access Coordinator, to recieve copies of notificaiton emails. Use their " +
            "entry in the GAL.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Jones, Janice (Tacoma)")]
        public string ExternalCoordinator {
            get {
                return ((string)(this["ExternalCoordinator"]));
            }
            set {
                this["ExternalCoordinator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(179-6120)")]
        public string IntContactNumber {
            get {
                return ((string)(this["IntContactNumber"]));
            }
            set {
                this["IntContactNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("253-779-6120")]
        public string ExtContactNumber {
            get {
                return ((string)(this["ExtContactNumber"]));
            }
            set {
                this["ExtContactNumber"] = value;
            }
        }
    }
}
