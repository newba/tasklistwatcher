﻿#pragma checksum "..\..\XTaskListWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "322F0E4A761C1889EA71B2BFEFE72C96"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
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


namespace X_Hub {
    
    
    /// <summary>
    /// XTaskListWindow
    /// </summary>
    public partial class XTaskListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.Border WindowFrame;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.RowDefinition HeaderRow;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.RowDefinition BodyRow;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.RowDefinition FooterRow;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.TextBlock HeaderTxt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.TextBlock FooterTxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.ListView ListViewStacker;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.StackPanel ListStacker;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.WrapPanel WrapPanel1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.Button DockTLW;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\XTaskListWindow.xaml"
        internal System.Windows.Controls.Button CloseTLW;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/X-Hub;component/xtasklistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\XTaskListWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WindowFrame = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.HeaderRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.BodyRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.FooterRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 5:
            this.HeaderTxt = ((System.Windows.Controls.TextBlock)(target));
            
            #line 25 "..\..\XTaskListWindow.xaml"
            this.HeaderTxt.MouseEnter += new System.Windows.Input.MouseEventHandler(this.TLMouseOverTitle);
            
            #line default
            #line hidden
            
            #line 25 "..\..\XTaskListWindow.xaml"
            this.HeaderTxt.MouseLeave += new System.Windows.Input.MouseEventHandler(this.TLMouseLeaveTitle);
            
            #line default
            #line hidden
            
            #line 25 "..\..\XTaskListWindow.xaml"
            this.HeaderTxt.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDragListTitle);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FooterTxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ListViewStacker = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.ListStacker = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.WrapPanel1 = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 10:
            this.DockTLW = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\XTaskListWindow.xaml"
            this.DockTLW.Click += new System.Windows.RoutedEventHandler(this.DockTLW_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CloseTLW = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\XTaskListWindow.xaml"
            this.CloseTLW.Click += new System.Windows.RoutedEventHandler(this.CloseTLW_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
