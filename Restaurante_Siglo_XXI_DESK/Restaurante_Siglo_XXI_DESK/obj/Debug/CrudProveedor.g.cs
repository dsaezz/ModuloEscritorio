﻿#pragma checksum "..\..\CrudProveedor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "817F9B79CB85470996612E1F67912E23A350B7E547ABC4E4F38345170ED2DB73"
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
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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
    /// CrudProveedor
    /// </summary>
    public partial class CrudProveedor : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_agregar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Modificar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_eliminar;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_idProveedor;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_tipoProveedor;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_nombre;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_proveedor;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CrudProveedor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_atras;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurante_Siglo_XXI_DESK;component/crudproveedor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CrudProveedor.xaml"
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
            this.btn_agregar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CrudProveedor.xaml"
            this.btn_agregar.Click += new System.Windows.RoutedEventHandler(this.btn_agregar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Modificar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\CrudProveedor.xaml"
            this.btn_Modificar.Click += new System.Windows.RoutedEventHandler(this.btn_Modificar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_eliminar = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\CrudProveedor.xaml"
            this.btn_eliminar.Click += new System.Windows.RoutedEventHandler(this.btn_eliminar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbox_idProveedor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbox_tipoProveedor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbox_nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dg_proveedor = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.btn_atras = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\CrudProveedor.xaml"
            this.btn_atras.Click += new System.Windows.RoutedEventHandler(this.btn_atras_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

