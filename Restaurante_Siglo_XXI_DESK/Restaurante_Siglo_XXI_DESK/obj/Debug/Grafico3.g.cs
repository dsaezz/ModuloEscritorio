﻿#pragma checksum "..\..\Grafico3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B6DD5DC17C16D5250725D5D4E189A1929A9A5CA24839783BCD2F73CAC95C72FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
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
    /// Grafico3
    /// </summary>
    public partial class Grafico3 : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_botones;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_atras;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reporte;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_graf;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart gf_lineal;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_fecha;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Grafico3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_mes;
        
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
            System.Uri resourceLocater = new System.Uri("/Restaurante_Siglo_XXI_DESK;component/grafico3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Grafico3.xaml"
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
            this.grid_botones = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btn_atras = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Grafico3.xaml"
            this.btn_atras.Click += new System.Windows.RoutedEventHandler(this.btn_atras_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_reporte = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Grafico3.xaml"
            this.btn_reporte.Click += new System.Windows.RoutedEventHandler(this.btn_reporte_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grid_graf = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.gf_lineal = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 6:
            this.txt_fecha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txt_mes = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
