﻿#pragma checksum "..\..\LightDoubleSlider.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07F00F5DE2C57E3B48D1EB5C0A1A51DB"
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


namespace DSoft.RDLC {
    
    
    /// <summary>
    /// LightDoubleSlider
    /// </summary>
    public partial class LightDoubleSlider : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\LightDoubleSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SliderRow;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\LightDoubleSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FirstButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\LightDoubleSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\LightDoubleSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider ChartSlider;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\LightDoubleSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\LightDoubleSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LastButton;
        
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
            System.Uri resourceLocater = new System.Uri("/RDLCPrinter;component/lightdoubleslider.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LightDoubleSlider.xaml"
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
            this.SliderRow = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.FirstButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\LightDoubleSlider.xaml"
            this.FirstButton.Click += new System.Windows.RoutedEventHandler(this.FirstButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PreviousButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\LightDoubleSlider.xaml"
            this.PreviousButton.Click += new System.Windows.RoutedEventHandler(this.PreviousButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ChartSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 55 "..\..\LightDoubleSlider.xaml"
            this.ChartSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ChartSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\LightDoubleSlider.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.NextButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LastButton = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\LightDoubleSlider.xaml"
            this.LastButton.Click += new System.Windows.RoutedEventHandler(this.LastButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

