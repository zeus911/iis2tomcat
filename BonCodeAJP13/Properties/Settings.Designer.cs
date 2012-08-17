﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BonCodeAJP13.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// port on which the AJP13 worker is active. Check your worker.properties files on tomcat.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("port on which the AJP13 worker is active. Check your worker.properties files on t" +
            "omcat.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8009")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
        }
        
        /// <summary>
        /// target server hosting tomcat instance.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("target server hosting tomcat instance.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string Server {
            get {
                return ((string)(this["Server"]));
            }
        }
        
        /// <summary>
        /// Maximum number of concurrent connections.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Maximum number of concurrent connections.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int MaxConnections {
            get {
                return ((int)(this["MaxConnections"]));
            }
        }
        
        /// <summary>
        /// determine whether we should attempt to detect http flushes. Set in tick counts. Set to zero to turn off.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("determine whether we should attempt to detect http flushes. Set in tick counts. S" +
            "et to zero to turn off.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int FlushThreshold {
            get {
                return ((int)(this["FlushThreshold"]));
            }
        }
        
        /// <summary>
        /// 0=turn off logging, 1=log errors, 2=log headers, 3=log packets (full debug)
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("0=turn off logging, 1=log errors, 2=log headers, 3=log packets (full debug)")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int LogLevel {
            get {
                return ((int)(this["LogLevel"]));
            }
        }
        
        /// <summary>
        /// Log Directory to use. If not provided the internet cache directory will be used for logging.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Log Directory to use. If not provided the internet cache directory will be used f" +
            "or logging.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogDir {
            get {
                return ((string)(this["LogDir"]));
            }
        }
        
        /// <summary>
        /// When remote admin is enabled users can access administrative pages via this connector
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("When remote admin is enabled users can access administrative pages via this conne" +
            "ctor")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableRemoteAdmin {
            get {
                return ((bool)(this["EnableRemoteAdmin"]));
            }
        }
        
        /// <summary>
        /// Should the connector compress content to client if client indicated that compressed streams can be handled.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Should the connector compress content to client if client indicated that compress" +
            "ed streams can be handled.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public bool AutoCompression {
            get {
                return ((bool)(this["AutoCompression"]));
            }
        }
        
        /// <summary>
        /// Add additional data to each header to support certain tomcat operations. Currently  X-Tomcat-DocRoot will be added to each request.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Add additional data to each header to support certain tomcat operations. Currentl" +
            "y  X-Tomcat-DocRoot will be added to each request.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableHeaderDataSupport {
            get {
                return ((bool)(this["EnableHeaderDataSupport"]));
            }
        }
        
        /// <summary>
        /// CSV list of HTTP headers that will not be send to Tomcat even if present
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("CSV list of HTTP headers that will not be send to Tomcat even if present")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HeaderBlacklist {
            get {
                return ((string)(this["HeaderBlacklist"]));
            }
        }
        
        /// <summary>
        /// CSV list of HTTP headers that will be transferred. Once white list is used, all other headers not on this list will not be transferred.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("CSV list of HTTP headers that will be transferred. Once white list is used, all o" +
            "ther headers not on this list will not be transferred.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string HeaderWhitelist {
            get {
                return ((string)(this["HeaderWhitelist"]));
            }
        }
        
        /// <summary>
        /// Number of milliseconds to wait before we stop listening for more traffic. 1000ms=1s. Default 120000 (20 min).
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of milliseconds to wait before we stop listening for more traffic. 1000ms=" +
            "1s. Default 120000 (20 min).")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1200000")]
        public int ReadTimeOut {
            get {
                return ((int)(this["ReadTimeOut"]));
            }
        }
        
        /// <summary>
        /// Number of milliseconds to wait until we stop writing to tomcat. 1000ms=1s. Default 30000 (30s).
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Number of milliseconds to wait until we stop writing to tomcat. 1000ms=1s. Defaul" +
            "t 30000 (30s).")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30000")]
        public int WriteTimeOut {
            get {
                return ((int)(this["WriteTimeOut"]));
            }
        }
        
        /// <summary>
        /// Forces SSL to tomcat; forces secure jsession cookie. Standard HTTP connection will be accepted but responses will be redirected to secure port.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Forces SSL to tomcat; forces secure jsession cookie. Standard HTTP connection wil" +
            "l be accepted but responses will be redirected to secure port.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ForceSecureSession {
            get {
                return ((bool)(this["ForceSecureSession"]));
            }
        }
        
        /// <summary>
        /// If another HTTP header contains valid IP instead of REMOTE_ADDR, it should be provided here. Set to blank if this is to be disabled. Used for XFF scenario, e.g. HTTP_X_FORWARDED_FOR which is the standard populated header when proxies are used.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("If another HTTP header contains valid IP instead of REMOTE_ADDR, it should be pro" +
            "vided here. Set to blank if this is to be disabled. Used for XFF scenario, e.g. " +
            "HTTP_X_FORWARDED_FOR which is the standard populated header when proxies are use" +
            "d.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ResolveRemoteAddrFrom {
            get {
                return ((string)(this["ResolveRemoteAddrFrom"]));
            }
        }
        
        /// <summary>
        /// By default the connector only sends HTTP headers that contain a value. If you need to see all headers all the time, you need to change this to True. Default False.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("By default the connector only sends HTTP headers that contain a value. If you nee" +
            "d to see all headers all the time, you need to change this to True. Default Fals" +
            "e.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowEmptyHeaders {
            get {
                return ((bool)(this["AllowEmptyHeaders"]));
            }
        }
        
        /// <summary>
        /// PATH-INFO HTTP header is not implemented in tomcat AJP protocol. The connector will send path info in this header instead. Default xajp-path-info
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("PATH-INFO HTTP header is not implemented in tomcat AJP protocol. The connector wi" +
            "ll send path info in this header instead. Default xajp-path-info")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xajp-path-info")]
        public string PathInfoHeader {
            get {
                return ((string)(this["PathInfoHeader"]));
            }
        }
        
        /// <summary>
        /// URL to which user is redirected is we cannot connect to Tomcat (server is down). If no value provided a default message will be displayed. Default: Blank
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("URL to which user is redirected is we cannot connect to Tomcat (server is down). " +
            "If no value provided a default message will be displayed. Default: Blank")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TomcatConnectErrorURL {
            get {
                return ((string)(this["TomcatConnectErrorURL"]));
            }
        }
        
        /// <summary>
        /// Whether HTTP status codes from Apache Tomcat are set in IIS. Default: True
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Whether HTTP status codes from Apache Tomcat are set in IIS. Default: True")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableHTTPStatusCodes {
            get {
                return ((bool)(this["EnableHTTPStatusCodes"]));
            }
        }
        
        /// <summary>
        /// Message to be displayed to user if we experience issues with TCP client connections to Tomcat.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Message to be displayed to user if we experience issues with TCP client connectio" +
            "ns to Tomcat.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TCPClientErrorMessage {
            get {
                return ((string)(this["TCPClientErrorMessage"]));
            }
        }
        
        /// <summary>
        /// Message to be displayed to user if we experience TCP Stream problems with Tomcat.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Message to be displayed to user if we experience TCP Stream problems with Tomcat." +
            "")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TCPStreamErrorMessage {
            get {
                return ((string)(this["TCPStreamErrorMessage"]));
            }
        }
        
        /// <summary>
        /// URL path prefix such as /axis that will be prefixed to any call from IIS to tomcat. Allows for easier mapping.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("URL path prefix such as /axis that will be prefixed to any call from IIS to tomca" +
            "t. Allows for easier mapping.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PathPrefix {
            get {
                return ((string)(this["PathPrefix"]));
            }
        }
        
        /// <summary>
        /// The packet size to use for AJP. If changed from default, this also needs to be changed on Apache Tomcat side in the server.xml file. Add packetSize attribute to AJP connection.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("The packet size to use for AJP. If changed from default, this also needs to be ch" +
            "anged on Apache Tomcat side in the server.xml file. Add packetSize attribute to " +
            "AJP connection.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8192")]
        public int PacketSize {
            get {
                return ((int)(this["PacketSize"]));
            }
        }
        
        /// <summary>
        /// Whether the connector will change behavior to support Adobe changes to AJP and adjust configuration options for best interchange.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(BonCodeAJP13.Config.BonCodeAJP13SettingProvider))]
        [global::System.Configuration.SettingsDescriptionAttribute("Whether the connector will change behavior to support Adobe changes to AJP and ad" +
            "just configuration options for best interchange.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableAdobeMode {
            get {
                return ((bool)(this["EnableAdobeMode"]));
            }
        }
    }
}
