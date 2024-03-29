﻿#pragma checksum "..\..\..\Views\Dashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCB8E49ED18C073E64A30C285426D336"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using De.TorstenMandelkow.MetroChart;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using ShirtBiz.Views;
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


namespace ShirtBiz.Views {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 122 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderG2;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridTitle;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPower;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.DropShadowEffect GridShadow;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button staffBtn;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profileBtn;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tablesBtn;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deliveryBtn;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button productBtn;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button settingBtn;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockHeading;
        
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
            System.Uri resourceLocater = new System.Uri("/ShirtBiz;component/views/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Dashboard.xaml"
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
            this.BorderG2 = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.GridTitle = ((System.Windows.Controls.Grid)(target));
            
            #line 153 "..\..\..\Views\Dashboard.xaml"
            this.GridTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridTitle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnPower = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\Views\Dashboard.xaml"
            this.btnPower.Click += new System.Windows.RoutedEventHandler(this.btnPower_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GridShadow = ((System.Windows.Media.Effects.DropShadowEffect)(target));
            return;
            case 5:
            this.staffBtn = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\..\Views\Dashboard.xaml"
            this.staffBtn.Click += new System.Windows.RoutedEventHandler(this.staffBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.profileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 198 "..\..\..\Views\Dashboard.xaml"
            this.profileBtn.Click += new System.Windows.RoutedEventHandler(this.profileBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tablesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 204 "..\..\..\Views\Dashboard.xaml"
            this.tablesBtn.Click += new System.Windows.RoutedEventHandler(this.tablesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.deliveryBtn = ((System.Windows.Controls.Button)(target));
            
            #line 210 "..\..\..\Views\Dashboard.xaml"
            this.deliveryBtn.Click += new System.Windows.RoutedEventHandler(this.deliveryBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.productBtn = ((System.Windows.Controls.Button)(target));
            
            #line 220 "..\..\..\Views\Dashboard.xaml"
            this.productBtn.Click += new System.Windows.RoutedEventHandler(this.productBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.settingBtn = ((System.Windows.Controls.Button)(target));
            
            #line 226 "..\..\..\Views\Dashboard.xaml"
            this.settingBtn.Click += new System.Windows.RoutedEventHandler(this.settingBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textBlockHeading = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 239 "..\..\..\Views\Dashboard.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonRegister_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

