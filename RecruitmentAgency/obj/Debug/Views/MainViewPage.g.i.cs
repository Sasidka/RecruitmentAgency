﻿#pragma checksum "..\..\..\Views\MainViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "617FE540B57127D5BCEB818014738EF2A98CE047E23F5DD106910AE506CD44B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RecruitmentAgency.Views;
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


namespace RecruitmentAgency.Views {
    
    
    /// <summary>
    /// MainViewPage
    /// </summary>
    public partial class MainViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTxb;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_cmb;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filtrCmb;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AdminPanel;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBtn;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Views\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PersonalAreaBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/RecruitmentAgency;component/views/mainviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainViewPage.xaml"
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
            
            #line 9 "..\..\..\Views\MainViewPage.xaml"
            ((RecruitmentAgency.Views.MainViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\MainViewPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchTxb = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Views\MainViewPage.xaml"
            this.searchTxb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTxb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clear_cmb = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\MainViewPage.xaml"
            this.clear_cmb.Click += new System.Windows.RoutedEventHandler(this.clear_cmb_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.filtrCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\..\Views\MainViewPage.xaml"
            this.filtrCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filtrCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listView = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.AdminPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Views\MainViewPage.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\Views\MainViewPage.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.deleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\Views\MainViewPage.xaml"
            this.deleteBtn.Click += new System.Windows.RoutedEventHandler(this.deleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PersonalAreaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\Views\MainViewPage.xaml"
            this.PersonalAreaBtn.Click += new System.Windows.RoutedEventHandler(this.PersonalAreaBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
