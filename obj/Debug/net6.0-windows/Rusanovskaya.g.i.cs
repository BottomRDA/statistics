﻿#pragma checksum "..\..\..\Rusanovskaya.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CDE92351B0DCC75D7983B83C4536F822E51300F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ScottPlot;
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
using gitt;


namespace gitt {
    
    
    /// <summary>
    /// Rusanovskaya
    /// </summary>
    public partial class Rusanovskaya : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Rusanovskaya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScottPlot.WpfPlot WpfPlot1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Rusanovskaya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_N;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Rusanovskaya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_E;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Rusanovskaya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttton_1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Rusanovskaya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttton_2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Rusanovskaya.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttton_3;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/gitt;V1.0.0.0;component/rusanovskaya.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Rusanovskaya.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WpfPlot1 = ((ScottPlot.WpfPlot)(target));
            return;
            case 2:
            this.TextBox_N = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBox_E = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.buttton_1 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Rusanovskaya.xaml"
            this.buttton_1.Click += new System.Windows.RoutedEventHandler(this.buttton_1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttton_2 = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Rusanovskaya.xaml"
            this.buttton_2.Click += new System.Windows.RoutedEventHandler(this.buttton_2_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttton_3 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Rusanovskaya.xaml"
            this.buttton_3.Click += new System.Windows.RoutedEventHandler(this.buttton_3_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

