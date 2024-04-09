﻿#pragma checksum "..\..\..\TimeSelector.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F8E607F8BCBA66F731FA0B8CFC018970351155BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimpleTimer;
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


namespace SimpleTimer {
    
    
    /// <summary>
    /// TimeSelector
    /// </summary>
    public partial class TimeSelector : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle BackgroundRect;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BgBorder;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SimpleTimer.SpinLabel Hour;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SimpleTimer.SpinLabel Minute;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SimpleTimer.SpinLabel Second;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CtrlConfirmButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\TimeSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CtrlCancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.28.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab3;component/timeselector.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TimeSelector.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.28.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.28.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\TimeSelector.xaml"
            ((SimpleTimer.TimeSelector)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.TimeSelector_OnIsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackgroundRect = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 15 "..\..\..\TimeSelector.xaml"
            this.BackgroundRect.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.BackgroundRect_OnMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BgBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.Hour = ((SimpleTimer.SpinLabel)(target));
            return;
            case 5:
            this.Minute = ((SimpleTimer.SpinLabel)(target));
            return;
            case 6:
            this.Second = ((SimpleTimer.SpinLabel)(target));
            return;
            case 7:
            this.CtrlConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\TimeSelector.xaml"
            this.CtrlConfirmButton.Click += new System.Windows.RoutedEventHandler(this.CtrlConfirmButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CtrlCancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\TimeSelector.xaml"
            this.CtrlCancelButton.Click += new System.Windows.RoutedEventHandler(this.CtrlCancelButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
