using ControlzEx.Theming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para VentanaReportes.xaml
    /// </summary>
    public partial class VentanaReportes
    {
        public VentanaReportes()
        {
            InitializeComponent();
            ThemeManager.Current.ChangeTheme(this, "Light.Blue");
        }

        private void btn_line_Click(object sender, RoutedEventArgs e)
        {
            Grafico2 form = new Grafico2();
            form.Show();
            this.Hide();
        }

        private void btn_pie_Click(object sender, RoutedEventArgs e)
        {
            Grafico1 form = new Grafico1();
            form.Show();
            this.Hide();
        }

        private void btn_bar_Click(object sender, RoutedEventArgs e)
        {
            Grafico3 form = new Grafico3();
            form.Show();
            this.Hide();
        }
    }
}
