﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Client.Resource", typeof(Resource).Assembly);
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
        
        /// <summary>
        ///   Looks up a localized string similar to body, table, tr, th, td
        ///        {
        ///            font-family: Cambria,Courier New;
        ///            font-size: 11px;
        ///        }
        ///        td.priority
        ///        {
        ///            font-weight: bold;
        ///        }
        ///        td.complete
        ///        {
        ///            font-weight: bold;
        ///        }
        ///        tr.tbhead td
        ///        {
        ///            font-weight: bold;
        ///        }
        ///        span.project
        ///        {
        ///            color: red;
        ///        }
        ///        span.context
        ///        {
        ///            color: blue;
        ///        }
        ///        span.isdate
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CSS {
            get {
                return ResourceManager.GetString("CSS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyboard shortcuts:
        ///    - O or Ctrl+O: open todo.txt file
        ///    - C or Ctrl+N: new todo.txt file
        ///    - N: new task
        ///    - ( or Shift+9: new task with priority
        ///    - J: next task
        ///    - K: prev task
        ///    - X: toggle task completion
        ///    - A: archive tasks
        ///    - D or Del or Backspace: delete task (with confirmation)
        ///    - U or F2: update task
        ///    - T: append text to selected tasks
        ///    - P: Postpone task (enter days to postpone, or day of week to postpone to)
        ///    - F: filter tasks (free-text, one filter condition per line)
        ///    - I: set priority
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HelpText {
            get {
                return ResourceManager.GetString("HelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://benrhughes.com/todotxt.net.
        /// </summary>
        internal static string SiteUrl {
            get {
                return ResourceManager.GetString("SiteUrl", resourceCulture);
            }
        }
    }
}
