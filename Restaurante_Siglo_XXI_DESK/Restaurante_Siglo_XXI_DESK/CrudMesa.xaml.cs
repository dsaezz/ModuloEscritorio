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
    /// Lógica de interacción para CrudMesa.xaml
    /// </summary>
    public partial class CrudMesa
    {
        public CrudMesa()
        {
            InitializeComponent();
            dg_mesa.ItemsSource = u.listarMesa().DefaultView;
        }
        public void Limpiar()
        {
            
            tbox_idMesa.Text = string.Empty;
            tbox_numAsientos.Text = string.Empty;

        }
        MesaBN u = new MesaBN();
        private async void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbox_numAsientos.Text) &&
                !string.IsNullOrEmpty(tbox_idMesa.Text)){
                try
                {
                    int id = Convert.ToInt32(tbox_idMesa.Text);
                    int numAsientos = Convert.ToInt32(tbox_numAsientos.Text);

                    if (cb_estado.SelectedIndex.Equals(0)) {
                        u.agregarMesa(numAsientos,"1");
                        await this.ShowMessageAsync("Exito!", "La mesa se agrego correctamente");
                        Limpiar();
                    }
                    else
                    {
                        u.agregarMesa(numAsientos,"0");
                        await this.ShowMessageAsync("Exito!", "La mesa se agrego correctamente");
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    await this.ShowMessageAsync("Error", "No se pudo agregar la mesa " + ex.Message);
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe rellenar todos los campos");
            }
        }
        ///arreglar modificar hacer aparecer los atributos rut y asignar el rol
        private async void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_numAsientos.Text) &&
                !string.IsNullOrEmpty(tbox_idMesa.Text))
            {
                try
                {
                    int id = Convert.ToInt32(tbox_idMesa.Text);
                    int numAsientos = Convert.ToInt32(tbox_numAsientos.Text);
                    

                    
                    //u.modificarMesa(id, numAsientos,);
                    await this.ShowMessageAsync("Exito!", "La mesa se Modifico correctamente");
                    Limpiar();
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error!", "No se pudo modificar la mesa");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "Debe rellenar todos los campos");
            }
        }

        private async void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbox_idMesa.Text)) {
                try
                {
                    int id = Convert.ToInt32(tbox_idMesa.Text);
                    var message = await this.ShowMessageAsync("Pregunta", "Esta seguro que desea elimirar la mesa Numero " + "*" + id + "*", MessageDialogStyle.AffirmativeAndNegative);

                    
                    if (message == MessageDialogResult.Affirmative)
                    {
                        u.eliminarMesa(id);
                        await this.ShowMessageAsync("Exito!", "La mesa se elimino de forma correcta");
                    }

                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Error", "No se pudo Eliminar la Mesa");
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
