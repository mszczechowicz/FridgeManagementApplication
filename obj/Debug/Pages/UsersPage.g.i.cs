﻿#pragma checksum "..\..\..\Pages\UsersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C562A28A63DAEBE89B7D21EAFD0D8F26D04F89391ADF16F888BCAB8278501550"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using FridgeManagementApplication.Pages;
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


namespace FridgeManagementApplication.Pages {
    
    
    /// <summary>
    /// UsersPage
    /// </summary>
    public partial class UsersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\Pages\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SelectedUser;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewUserNick;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox UsersList;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Pages\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddUser;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Pages\UsersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveUser;
        
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
            System.Uri resourceLocater = new System.Uri("/FridgeManagementApplication;component/pages/userspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UsersPage.xaml"
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
            this.SelectedUser = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NewUserNick = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UsersList = ((System.Windows.Controls.ListBox)(target));
            
            #line 91 "..\..\..\Pages\UsersPage.xaml"
            this.UsersList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UsersList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddUser = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Pages\UsersPage.xaml"
            this.AddUser.Click += new System.Windows.RoutedEventHandler(this.AddUser_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RemoveUser = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\Pages\UsersPage.xaml"
            this.RemoveUser.Click += new System.Windows.RoutedEventHandler(this.RemoveUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

