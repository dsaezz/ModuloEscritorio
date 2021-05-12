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
    /// Lógica de interacción para CrudStock.xaml
    /// </summary>
    public partial class CrudStock
    {
        public CrudStock()
        {
            InitializeComponent();
            dg_stock.ItemsSource = s.listarStock().DefaultView;
        }
        public void Limpiar()
        {
            tbox_idPoducto.Text = string.Empty;
            tbox_idUnidadMedida.Text = string.Empty;
            tbox_stock.Text = string.Empty;
            tbox_tipoProduc.Text = string.Empty;

        }
        StockBN s = new StockBN();
        private async void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_idPoducto.Text) && !string.IsNullOrEmpty(tbox_idUnidadMedida.Text) &&
                !string.IsNullOrEmpty(tbox_stock.Text) && !string.IsNullOrEmpty(tbox_tipoProduc.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idPoducto.Text);
                    int stock = Convert.ToInt32(tbox_stock.Text);
                    int idUnidad = Convert.ToInt32(tbox_idUnidadMedida.Text);
                    string tipoProduc = tbox_tipoProduc.Text;

                    s.agregarStock(id, stock, tipoProduc, idUnidad);
                    await this.ShowMessageAsync("Exito!", "El Producto se agrego correctamente");
                    Limpiar();
                }
                catch (Exception ex)
                {
                    await this.ShowMessageAsync("Error", "No se pudo agregar el Producto " + ex.Message);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe rellenar todos los campos");
            }
        }

        private async void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_idPoducto.Text) && !string.IsNullOrEmpty(tbox_idUnidadMedida.Text) &&
                !string.IsNullOrEmpty(tbox_stock.Text) && !string.IsNullOrEmpty(tbox_tipoProduc.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idPoducto.Text);
                    int stock = Convert.ToInt32(tbox_stock.Text);
                    int idUnidad = Convert.ToInt32(tbox_idUnidadMedida.Text);
                    string tipoProduc = tbox_tipoProduc.Text;

                    s.modificarStock(id, stock, tipoProduc, idUnidad);
                    await this.ShowMessageAsync("Exito!", "El producto se Modifico correctamente");
                    Limpiar();
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error!", "No se pudo Modificar el Producto");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe rellenar todos los campos");
            }

        }

        private async void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_idPoducto.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idPoducto.Text);
                    var message = await this.ShowMessageAsync("Pregunta", "Esta seguro que desea elimirar el producto Numero " + "*" + id + "*", MessageDialogStyle.AffirmativeAndNegative);


                    if (message == MessageDialogResult.Affirmative)
                    {
                        s.eliminarStock(id);
                        await this.ShowMessageAsync("Exito!", "El producto se elimino de forma correcta");
                    }

                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error", "No se pudo Eliminar el producto");
                }

            }
            else
            {
                await this.ShowMessageAsync("Error!!!", "No pueden existir campos vacios");

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
