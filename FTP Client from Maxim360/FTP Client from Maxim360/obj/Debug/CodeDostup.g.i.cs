﻿#pragma checksum "..\..\CodeDostup.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC9D2EF0490EBD66E9D32683F21F8949DF941C0710AB56C539EC3A78B9A12017"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FTP_Client_from_Maxim360;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace FTP_Client_from_Maxim360 {
    
    
    /// <summary>
    /// CodeDostup
    /// </summary>
    public partial class CodeDostup : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CodeDostup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox CodeDostupe;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CodeDostup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkBttn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CodeDostup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBttn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FTP Client from Maxim360;component/codedostup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CodeDostup.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CodeDostupe = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.OkBttn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CodeDostup.xaml"
            this.OkBttn.Click += new System.Windows.RoutedEventHandler(this.OkBttn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitBttn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\CodeDostup.xaml"
            this.ExitBttn.Click += new System.Windows.RoutedEventHandler(this.ExitBttn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
