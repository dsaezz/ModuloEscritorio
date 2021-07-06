using System;
using System.Collections.Generic;
using System.Data;
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
using CapaNegocio;

namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para RPIngreso.xaml
    /// </summary>
    public partial class RPIngreso : Window
    {
        public RPIngreso()
        {
            InitializeComponent();
            PlatoBN p = new PlatoBN();
            BoletaBN b = new BoletaBN();
            var t = p.REPplato("05/2021", "06/2021");

            dg_x.ItemsSource = b.RePCLIENTEMENSUAL("05/2021", "06/2021").DefaultView;



        }
    }
}
