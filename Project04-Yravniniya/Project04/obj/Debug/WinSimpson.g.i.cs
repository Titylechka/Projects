﻿#pragma checksum "..\..\WinSimpson.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3527769E33F8BAE9923AF2161C617B9B655562FA40C217C9B612C5CD7A6E8C01"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Project04;
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


namespace Project04 {
    
    
    /// <summary>
    /// WinSimpsona
    /// </summary>
    public partial class WinSimpsona : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\WinSimpson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_A;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\WinSimpson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_B;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\WinSimpson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_N;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WinSimpson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Result;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\WinSimpson.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_Result;
        
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
            System.Uri resourceLocater = new System.Uri("/Project04;component/winsimpson.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WinSimpson.xaml"
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
            
            #line 12 "..\..\WinSimpson.xaml"
            ((Project04.WinSimpsona)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.S_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_A = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_B = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_N = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_Result = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\WinSimpson.xaml"
            this.btn_Result.Click += new System.Windows.RoutedEventHandler(this.btn_Result_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_Result = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

