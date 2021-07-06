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
using MahApps.Metro.Controls.Dialogs;

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

        private async void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            
            string clave = tb_clave.Password;
            string password = ValidarRut.GetSHA256(clave);
            string usuario = tb_usuario.Text;
            // UsuarioBN usuario = new UsuarioBN().ValidarUsuario(tb_clave.Text, tb_usuario.Text);
            UsuarioBN u = new UsuarioBN();

        
                await this.ShowMessageAsync("","" + u.ValidarUsuario(usuario, password));

            VentanaReportes form = new VentanaReportes();
            form.Show();
            this.Hide();


        }
    }
}
