﻿#pragma checksum "..\..\MenuAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F79396AA2895CB8481CF8661EE2E4941E4E63D1BC2DC7017319E46F91EE3F9CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using Restaurante_Siglo_XXI_DESK;
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


namespace Restaurante_Siglo_XXI_DESK {
    
    
    /// <summary>
    /// MenuAdmin
    /// </summary>
    public partial class MenuAdmin : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btn_usuario;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btn_mesa;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btn_stock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.Tile btn_proveedor;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.FlyoutsControl fly_menu;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurante_Siglo_XXI_DESK;component/menuadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuAdmin.xaml"
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
            this.btn_usuario = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 11 "..\..\MenuAdmin.xaml"
            this.btn_usuario.Click += new System.Windows.RoutedEventHandler(this.btn_usuario_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_mesa = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 14 "..\..\MenuAdmin.xaml"
            this.btn_mesa.Click += new System.Windows.RoutedEventHandler(this.btn_mesa_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_stock = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 17 "..\..\MenuAdmin.xaml"
            this.btn_stock.Click += new System.Windows.RoutedEventHandler(this.btn_stock_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_proveedor = ((MahApps.Metro.Controls.Tile)(target));
            
            #line 20 "..\..\MenuAdmin.xaml"
            this.btn_proveedor.Click += new System.Windows.RoutedEventHandler(this.btn_proveedor_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.fly_menu = ((MahApps.Metro.Controls.FlyoutsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
