﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickSharp.Output {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuickSharp.Output.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static System.Drawing.Bitmap ClearOutput {
            get {
                object obj = ResourceManager.GetObject("ClearOutput", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap Error {
            get {
                object obj = ResourceManager.GetObject("Error", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap ListView {
            get {
                object obj = ResourceManager.GetObject("ListView", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Output.
        /// </summary>
        internal static string MainViewMenuOutput {
            get {
                return ResourceManager.GetString("MainViewMenuOutput", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon OutputIcon {
            get {
                object obj = ResourceManager.GetObject("OutputIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output.
        /// </summary>
        internal static string OutputWindowTitle {
            get {
                return ResourceManager.GetString("OutputWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regular expression group missing.
        /// </summary>
        internal static string RegexGroupMissing {
            get {
                return ResourceManager.GetString("RegexGroupMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to run process:.
        /// </summary>
        internal static string RunProcessErrorMessage {
            get {
                return ResourceManager.GetString("RunProcessErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Run.
        /// </summary>
        internal static string RunProcessErrorTitle {
            get {
                return ResourceManager.GetString("RunProcessErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process returned.
        /// </summary>
        internal static string RunProcessReturn {
            get {
                return ResourceManager.GetString("RunProcessReturn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running.
        /// </summary>
        internal static string RunProgramCaption {
            get {
                return ResourceManager.GetString("RunProgramCaption", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap TextView {
            get {
                object obj = ResourceManager.GetObject("TextView", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear output.
        /// </summary>
        internal static string ToolbarClearView {
            get {
                return ResourceManager.GetString("ToolbarClearView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View as list.
        /// </summary>
        internal static string ToolbarViewAsList {
            get {
                return ResourceManager.GetString("ToolbarViewAsList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View as text.
        /// </summary>
        internal static string ToolbarViewAsText {
            get {
                return ResourceManager.GetString("ToolbarViewAsText", resourceCulture);
            }
        }
    }
}
