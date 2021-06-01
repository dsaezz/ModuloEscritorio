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
//INTERFAZ
using MahApps.Metro.Controls;
using CapaNegocio;
using MahApps.Metro.Controls.Dialogs;
namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para CrudProveedor.xaml
    /// </summary>
    public partial class CrudProveedor
    {
        public CrudProveedor()
        {
            InitializeComponent();
            dg_proveedor.ItemsSource = p.listarProveedor().DefaultView;
        }
        public void Limpiar()
        {
            tbox_idProveedor.Text = string.Empty;
            tbox_nombre.Text = string.Empty;
            tbox_tipoProveedor.Text = string.Empty;
        }
        ProveedorBN p = new ProveedorBN();
            private async void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_idProveedor.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idProveedor.Text);
                    var message = await this.ShowMessageAsync("Pregunta", "Esta seguro que desea elimirar el proveedor Numero " + "*" + id + "*", MessageDialogStyle.AffirmativeAndNegative);


                    if (message == MessageDialogResult.Affirmative)
                    {
                        p.eliminarProveedor(id);
                        await this.ShowMessageAsync("Exito!", "El proveedor se elimino de forma correcta");
                    }

                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error", "No se pudo Eliminar el Proveedor");
                }

            }
            else
            {
                await this.ShowMessageAsync("Error!!!", "No pueden existir campos vacios");

            }
        }

        private async void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_idProveedor.Text) && !string.IsNullOrEmpty(tbox_nombre.Text) &&
               !string.IsNullOrEmpty(tbox_tipoProveedor.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idProveedor.Text);
                    string nombre = tbox_nombre.Text;
                    string tipoProveedor = tbox_tipoProveedor.Text;

                    //p.modificarProveedor(id, tipoProveedor, nombre);
                    await this.ShowMessageAsync("Exito!", "El proveedor se Modifico correctamente");
                    Limpiar();
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error!", "No se pudo modificar el Proveedor");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe rellenar todos los campos");
            }
        }

        private async void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_idProveedor.Text) && !string.IsNullOrEmpty(tbox_nombre.Text) &&
                !string.IsNullOrEmpty(tbox_tipoProveedor.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idProveedor.Text);
                    string nombre = tbox_nombre.Text;
                    string tipoProveedor = tbox_tipoProveedor.Text;

                    //p.agregarProveedor(id,tipoProveedor,nombre);
                    await this.ShowMessageAsync("Exito!", "El proveedor se agrego correctamente");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    await this.ShowMessageAsync("Error", "No se pudo agregar el Proveedor " + ex.Message);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe rellenar todos los campos");
            }
        }

        private void btn_atras_Click(object sender, RoutedEventArgs e)
        {
            MenuAdmin form = new MenuAdmin();
            form.Show();
            this.Hide();
        }
    }
    }

