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
//INTERFAZ METRO
using MahApps.Metro.Controls;


namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin
    {
        public MenuAdmin()
        {
            InitializeComponent();
            //ServidorJava.ModuloCajaClient serv = new ServidorJava.ModuloCajaClient();
            //MessageBox.Show(serv.hello("Angel")) ;
        }

        private void btn_usuario_Click(object sender, RoutedEventArgs e)
        {
            CrudUsuario form = new CrudUsuario();
            form.Show();
            this.Hide();
            
        }

        private void btn_proveedor_Click(object sender, RoutedEventArgs e)
        {
            CrudProveedor form = new CrudProveedor();
            form.Show();
            this.Hide();
        }

        private void btn_mesa_Click(object sender, RoutedEventArgs e)
        {
            CrudMesa form = new CrudMesa();
            form.Show();
            this.Hide();
        }

        private void btn_stock_Click(object sender, RoutedEventArgs e)
        {
            CrudStock form = new CrudStock();
            form.Show();
            this.Hide();
        }

        
    }
}
