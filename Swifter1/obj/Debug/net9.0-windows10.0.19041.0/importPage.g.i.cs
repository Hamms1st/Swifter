﻿#pragma checksum "..\..\..\importPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14A59A3080E51A8BD81F6659E99CCE9A4483247D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LoadingSpinnerControl;
using LoadingSpinnerControl.Converters;
using Swifter1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Swifter1 {
    
    
    /// <summary>
    /// importPage
    /// </summary>
    public partial class importPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\importPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Json;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\importPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Csharp;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\importPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Confirm;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\importPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DOne;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\importPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LoadingSpinnerControl.LoadingSpinner spin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Swifter1;component/importpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\importPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Json = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\importPage.xaml"
            this.Json.Click += new System.Windows.RoutedEventHandler(this.SelectJson_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Csharp = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\importPage.xaml"
            this.Csharp.Click += new System.Windows.RoutedEventHandler(this.SelectCs_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Confirm = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\importPage.xaml"
            this.Confirm.Click += new System.Windows.RoutedEventHandler(this.Import_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DOne = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.spin = ((LoadingSpinnerControl.LoadingSpinner)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

