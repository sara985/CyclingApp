﻿#pragma checksum "..\..\..\NonAdminPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21BBEB8B804461789031C748F8AE976735FE9239"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfApp1;
using WpfApp1.ViewModels;
using WpfApp1.Views;


namespace WpfApp1 {
    
    
    /// <summary>
    /// NonAdminPage
    /// </summary>
    public partial class NonAdminPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp1.NonAdminPage CyClbMemberMain;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMainMember;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMyAccount;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image myAccountImage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMemberOuting;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image outingImage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\NonAdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image logoutImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/nonadminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NonAdminPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CyClbMemberMain = ((WpfApp1.NonAdminPage)(target));
            return;
            case 2:
            this.lblMainMember = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnMyAccount = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\NonAdminPage.xaml"
            this.btnMyAccount.Click += new System.Windows.RoutedEventHandler(this.btnMyAccount_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.myAccountImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.btnMemberOuting = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\NonAdminPage.xaml"
            this.btnMemberOuting.Click += new System.Windows.RoutedEventHandler(this.btnMemberOuting_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.outingImage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\NonAdminPage.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.logoutImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

