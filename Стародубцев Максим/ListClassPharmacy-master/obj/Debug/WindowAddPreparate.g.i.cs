﻿#pragma checksum "..\..\WindowAddPreparate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "23C4D0042F933539FBBEB2AB5C3D529B8A3E0DE6EDF9FD90D548A664A16FDA9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ListClass;
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


namespace ListClass {
    
    
    /// <summary>
    /// WindowAddPreparate
    /// </summary>
    public partial class WindowAddPreparate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbGroup;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbMath;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbHistory;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbPhysics;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbObzh;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbFrench;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\WindowAddPreparate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddPreparate;
        
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
            System.Uri resourceLocater = new System.Uri("/ListClass;component/windowaddpreparate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowAddPreparate.xaml"
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
            this.TxbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxbGroup = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxbMath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbHistory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxbPhysics = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxbObzh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxbFrench = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtnAddPreparate = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\WindowAddPreparate.xaml"
            this.BtnAddPreparate.Click += new System.Windows.RoutedEventHandler(this.BtnAddPreparate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

