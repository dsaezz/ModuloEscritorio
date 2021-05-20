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

using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
//INTERFAZ
using MahApps.Metro.Controls;
using CapaNegocio;
using MahApps.Metro.Controls.Dialogs;

namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para CrudUsuario.xaml
    /// </summary>
    public partial class CrudUsuario
    {
        UsuarioBN u = new UsuarioBN();
        public CrudUsuario()
        {

            InitializeComponent();
            //Listar Grid
            dg_usuario.ItemsSource = u.listarUsuario().DefaultView;

            //Listar cbox
            RolBN r = new RolBN();
            cbx_rol.ItemsSource = r.obtenerRol();
            
            cbx_rol.DisplayMemberPath = "tipo_rol";
            cbx_rol.SelectedValuePath = "id_rol";
            cbx_rol.SelectedIndex = 0;
        }

        public void Limpiar()
        {
            tbox_rut.Text = string.Empty;
            tbox_nombre.Text = string.Empty;
            tbox_apellidoP.Text = string.Empty;
            tbox_apellidoM.Text = string.Empty;
            tbox_correo.Text = string.Empty; 
            tbox_direccion.Text = string.Empty; 
            tbox_contrasena.Text = string.Empty;


        }
        
        
        private void btn_listar_Click(object sender, RoutedEventArgs e)
        {

             dg_usuario.ItemsSource = u.listarUsuario().DefaultView;
            
        }

        private async void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_rut.Text) && !string.IsNullOrEmpty(tbox_nombre.Text) && !string.IsNullOrEmpty(tbox_apellidoP.Text) && !string.IsNullOrEmpty(tbox_apellidoM.Text) &&
               !string.IsNullOrEmpty(tbox_correo.Text) && !string.IsNullOrEmpty(tbox_direccion.Text) && !string.IsNullOrEmpty(tbox_contrasena.Text))
            {
                bool respuesta = false;
                ValidarRut v = new ValidarRut();
                respuesta = v.validarRut(tbox_rut.Text);
                
                if (respuesta == true)
                {
                    try
                    {
                        string rut = tbox_rut.Text;
                        string nombre = tbox_nombre.Text;
                        string apellido_p = tbox_apellidoP.Text;
                        string apellido_m = tbox_apellidoM.Text;
                        int rol = Convert.ToInt32(cbx_rol.SelectedValue);
                        string correo = tbox_correo.Text;
                        string direccion = tbox_direccion.Text;
                        string contrasena = tbox_contrasena.Text;


                        u.agregarUsuario(rut, nombre, apellido_m, apellido_p, rol, correo, direccion, contrasena);

                        await this.ShowMessageAsync("Exito!", "El usuario se agrego de forma correcta" );
                        Limpiar();
                    }
                    catch (Exception )
                    {

                        
                        await this.ShowMessageAsync("Error de Usuario", "No se pudo agregar el usuario ");
                    }
                }
                else
                {
                    await this.ShowMessageAsync("Error!!", "El RUT ingresado es Erroneo");
                    tbox_rut.Text = string.Empty;
                }

        }
            else
            {
                await this.ShowMessageAsync("Error!!!", "Todos los campos son obligatorios");
        }
    }

        private async void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbox_rut.Text) && !string.IsNullOrEmpty(tbox_nombre.Text) && !string.IsNullOrEmpty(tbox_apellidoP.Text) && !string.IsNullOrEmpty(tbox_apellidoM.Text) &&
                !string.IsNullOrEmpty(tbox_correo.Text) && !string.IsNullOrEmpty(tbox_direccion.Text) && !string.IsNullOrEmpty(tbox_contrasena.Text))
            {
                
                    try
                    {
                        string rut = tbox_rut.Text;
                        string nombre = tbox_nombre.Text;
                        string apellido_p = tbox_apellidoP.Text;
                        string apellido_m = tbox_apellidoM.Text;
                        int rol = Convert.ToInt32(cbx_rol.SelectedValue);
                        string correo = tbox_correo.Text;
                        string direccion = tbox_direccion.Text;
                        string contrasena = tbox_contrasena.Text;
                        u.modificarUsuario(rut, nombre, apellido_m, apellido_p, rol, correo, direccion, contrasena);
                        await this.ShowMessageAsync("Exito!", "Los datos del Usuario fueron Modificados");
                        Limpiar();
                    }
                    catch (Exception)
                    {
                        await this.ShowMessageAsync("Error", "No se pudo Modifar el Usuario");
                    }
                }
                else
                {
                    await this.ShowMessageAsync("Error!!!", "No pueden existir campos vacios");

                }
           
        }

        private async void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            string rut = tbox_rut.Text;
            
            if (!string.IsNullOrEmpty(tbox_rut.Text))
            {
                try
                {

                    var message = await this.ShowMessageAsync("Pregunta", "Esta seguro que desea elimirar el usuario " + "*" + rut + "*", MessageDialogStyle.AffirmativeAndNegative);

                    //CONTRAL ESTE ERROR ELIMINA USUSARIO QUE NO EXISTEN EN LA BASE DE DATOS
                    if (message == MessageDialogResult.Affirmative)
                    {
                        u.eliminarUsuario(rut);
                        await this.ShowMessageAsync("Exito!", "El usuario se elimino de forma correcta");
                    }
                  


                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error de Usuario", "No se pudo Eliminar el usuario");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error!!!", "No pueden existir campos vacios");

            }

        }

        private void tbox_rut_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidarRut v = new ValidarRut();
            string rut = tbox_rut.Text;
            tbox_rut.Text = v.formatoRut(rut);
        }

        private void btn_atras_Click(object sender, RoutedEventArgs e)
        {
            MenuAdmin form = new MenuAdmin();
            form.Show();
            this.Hide();
        }
    }
}
