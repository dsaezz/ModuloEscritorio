﻿#pragma checksum "..\..\ModuloCaja.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E62A8D7E8DDE057D4884E274809FFBE9B0FDCFB63AB5BF83DE787F105583293"
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
    /// ModuloCaja
    /// </summary>
    public partial class ModuloCaja : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wp_mesas;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_dinero;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_pagar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_fecha;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbox_monto_i;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_vuelto;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbox_tipo_pago;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ModuloCaja.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_orden;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurante_Siglo_XXI_DESK;component/modulocaja.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ModuloCaja.xaml"
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
            this.wp_mesas = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 2:
            this.lbl_dinero = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btn_pagar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ModuloCaja.xaml"
            this.btn_pagar.Click += new System.Windows.RoutedEventHandler(this.btn_pagar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbl_fecha = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.tbox_monto_i = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\ModuloCaja.xaml"
            this.tbox_monto_i.LostFocus += new System.Windows.RoutedEventHandler(this.tbox_monto_i_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_vuelto = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cbox_tipo_pago = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.dg_orden = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

