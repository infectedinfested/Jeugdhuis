﻿#pragma checksum "..\..\StockWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCECB89A60621A738CE20118BC3B50B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Juegdhuis_V3;
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


namespace Juegdhuis_V3 {
    
    
    /// <summary>
    /// StockWindow
    /// </summary>
    public partial class StockWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LBoxDrankOverzicht;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtVanNaar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEditPrijs;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblNaamDrank;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1_Copy;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtAddAll;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChBAdd;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\StockWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblInfoAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/Juegdhuis V3;component/stockwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StockWindow.xaml"
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
            
            #line 9 "..\..\StockWindow.xaml"
            ((Juegdhuis_V3.StockWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.StockWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LBoxDrankOverzicht = ((System.Windows.Controls.ListView)(target));
            
            #line 11 "..\..\StockWindow.xaml"
            this.LBoxDrankOverzicht.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LBoxDrankOverzicht_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\StockWindow.xaml"
            this.LBoxDrankOverzicht.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LBoxDrankOverzicht_DoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TxtVanNaar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnEditPrijs = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\StockWindow.xaml"
            this.BtnEditPrijs.Click += new System.Windows.RoutedEventHandler(this.BtnEditPrijs_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LblNaamDrank = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label1_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TxtAddAll = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ChBAdd = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.LblInfoAdd = ((System.Windows.Controls.Label)(target));
            
            #line 28 "..\..\StockWindow.xaml"
            this.LblInfoAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LblInfoAdd_Double);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

