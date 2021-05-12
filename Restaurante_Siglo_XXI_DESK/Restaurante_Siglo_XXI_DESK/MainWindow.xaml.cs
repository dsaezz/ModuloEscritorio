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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CapaNegocio;
//INTERFAZ METRO
using MahApps.Metro.Controls;


namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            string clave = tb_clave.Password;
            // UsuarioBN usuario = new UsuarioBN().ValidarUsuario(tb_clave.Text, tb_usuario.Text);
            try
            {
                UsuarioBN usuario = new UsuarioBN();
                usuario.ValidarUsuario("19895900-6", "123");
                MessageBox.Show("COREcto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            
        }
    }
}
