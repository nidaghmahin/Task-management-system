﻿#pragma checksum "..\..\..\SideWindowCollection\ViewMember.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12DEF11B3EDD0B2CDAAB0BF05DEF099C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace Task_Software {
    
    
    /// <summary>
    /// ViewMember
    /// </summary>
    public partial class ViewMember : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\SideWindowCollection\ViewMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cloasebutton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\SideWindowCollection\ViewMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox memberlistbox;
        
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
            System.Uri resourceLocater = new System.Uri("/Task Software;component/sidewindowcollection/viewmember.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SideWindowCollection\ViewMember.xaml"
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
            
            #line 7 "..\..\..\SideWindowCollection\ViewMember.xaml"
            ((Task_Software.ViewMember)(target)).LocationChanged += new System.EventHandler(this.MetroWindow_LocationChanged);
            
            #line default
            #line hidden
            
            #line 7 "..\..\..\SideWindowCollection\ViewMember.xaml"
            ((Task_Software.ViewMember)(target)).Closed += new System.EventHandler(this.MetroWindow_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cloasebutton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\SideWindowCollection\ViewMember.xaml"
            this.cloasebutton.Click += new System.Windows.RoutedEventHandler(this.cloasebutton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.memberlistbox = ((System.Windows.Controls.ListBox)(target));
            
            #line 41 "..\..\..\SideWindowCollection\ViewMember.xaml"
            this.memberlistbox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.mousedown);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\SideWindowCollection\ViewMember.xaml"
            this.memberlistbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.memberlistbox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

