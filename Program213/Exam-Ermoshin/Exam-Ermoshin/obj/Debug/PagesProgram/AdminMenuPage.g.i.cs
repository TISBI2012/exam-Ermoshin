﻿#pragma checksum "..\..\..\PagesProgram\AdminMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "926844395233277B25023BD04552190885C0A3AA9325AC9FC34C9AE69AE4E85C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Exam_Ermoshin.PagesProgram;
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


namespace Exam_Ermoshin.PagesProgram {
    
    
    /// <summary>
    /// AdminMenuPage
    /// </summary>
    public partial class AdminMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\PagesProgram\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddSotrudnik;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\PagesProgram\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteSotrudnik;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\PagesProgram\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedaktirovanieSotrudnik;
        
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
            System.Uri resourceLocater = new System.Uri("/Exam-Ermoshin;component/pagesprogram/adminmenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PagesProgram\AdminMenuPage.xaml"
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
            this.BtnAddSotrudnik = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\PagesProgram\AdminMenuPage.xaml"
            this.BtnAddSotrudnik.Click += new System.Windows.RoutedEventHandler(this.BtnAddSotrudnik_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnDeleteSotrudnik = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\PagesProgram\AdminMenuPage.xaml"
            this.BtnDeleteSotrudnik.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteSotrudnik_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RedaktirovanieSotrudnik = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\PagesProgram\AdminMenuPage.xaml"
            this.RedaktirovanieSotrudnik.Click += new System.Windows.RoutedEventHandler(this.RedaktirovanieSotrudnik_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

