﻿#pragma checksum "..\..\KassaWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D984305CA72F4CC813C9DF1495733145"
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
    /// KassaWindow
    /// </summary>
    public partial class KassaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStart;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListKluis;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListKassa;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txtaantal;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\KassaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
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
            System.Uri resourceLocater = new System.Uri("/Juegdhuis V3;component/kassawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KassaWindow.xaml"
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
            this.BtnStart = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\KassaWindow.xaml"
            this.BtnStart.Click += new System.Windows.RoutedEventHandler(this.BtnStart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\KassaWindow.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\KassaWindow.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.BtnDel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListKluis = ((System.Windows.Controls.ListView)(target));
            
            #line 13 "..\..\KassaWindow.xaml"
            this.ListKluis.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListKluis_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\KassaWindow.xaml"
            this.ListKluis.KeyDown += new System.Windows.Input.KeyEventHandler(this.ListKluis_KeyPressed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListKassa = ((System.Windows.Controls.ListView)(target));
            
            #line 21 "..\..\KassaWindow.xaml"
            this.ListKassa.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListKassa_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 21 "..\..\KassaWindow.xaml"
            this.ListKassa.KeyDown += new System.Windows.Input.KeyEventHandler(this.ListKassa_KeyPressed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Txtaantal = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\KassaWindow.xaml"
            this.Txtaantal.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

