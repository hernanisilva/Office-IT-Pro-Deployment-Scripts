﻿#pragma checksum "..\..\..\..\ExampleViews\OtherExamples.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "31DEC763CDB911DFFA38B558FF8598CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MetroDemo;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MetroDemo.ExampleViews {
    
    
    /// <summary>
    /// OtherExamples
    /// </summary>
    public partial class OtherExamples : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.TransitioningContentControl transitioning;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.TransitioningContentControl customTransitioning;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualState CustomTransition;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.TransitioningContentControl SecondcustomTransitioning;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.VisualState SecondCustomTransition;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowBannerCheckBox;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\ExampleViews\OtherExamples.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowMouseOverCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/MetroDemo.NET45;component/exampleviews/otherexamples.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ExampleViews\OtherExamples.xaml"
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
            this.transitioning = ((MahApps.Metro.Controls.TransitioningContentControl)(target));
            return;
            case 2:
            this.customTransitioning = ((MahApps.Metro.Controls.TransitioningContentControl)(target));
            return;
            case 3:
            this.CustomTransition = ((System.Windows.VisualState)(target));
            return;
            case 4:
            this.SecondcustomTransitioning = ((MahApps.Metro.Controls.TransitioningContentControl)(target));
            return;
            case 5:
            this.SecondCustomTransition = ((System.Windows.VisualState)(target));
            return;
            case 6:
            this.ShowBannerCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.ShowMouseOverCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            
            #line 161 "..\..\..\..\ExampleViews\OtherExamples.xaml"
            ((MahApps.Metro.Controls.FlipView)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FlipView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

