﻿#pragma checksum "..\..\..\Pages\FridgePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "907907A09C6530682B12896CFA51CE468BFB5EA0C9D45386B547DA287774A9A7"
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
    /// FridgePage
    /// </summary>
    public partial class FridgePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NewNameText;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityText;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CategoryList;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertToFridge;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityToRemove;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveItem;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Pages\FridgePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox FridgeList;
        
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
            System.Uri resourceLocater = new System.Uri("/FridgeManagementApplication;component/pages/fridgepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\FridgePage.xaml"
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
            this.NewNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.QuantityText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CategoryList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.InsertToFridge = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Pages\FridgePage.xaml"
            this.InsertToFridge.Click += new System.Windows.RoutedEventHandler(this.InsertToFridge_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.QuantityToRemove = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.RemoveItem = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Pages\FridgePage.xaml"
            this.RemoveItem.Click += new System.Windows.RoutedEventHandler(this.RemoveItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FridgeList = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

