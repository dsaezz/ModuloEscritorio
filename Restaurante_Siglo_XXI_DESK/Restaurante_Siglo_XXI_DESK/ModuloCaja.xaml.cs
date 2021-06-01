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
using System.Drawing;
using MahApps.Metro.Controls;
using CapaNegocio;
using System.Data;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Threading;

namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para ModuloCaja.xaml
    /// </summary>
    public partial class ModuloCaja 
    {
        private void fecha()
        { 
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += (s, e) => { lbl_fecha.Content = DateTime.Now.ToString(); };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
       
        public ModuloCaja()
        {
            InitializeComponent();
            BotonMesas();
            fecha();

            MetodoPagoBN m = new MetodoPagoBN();
            cbox_tipo_pago.ItemsSource = m.obtenerMetodo();

            cbox_tipo_pago.DisplayMemberPath = "tipo_pago";
            cbox_tipo_pago.SelectedValuePath = "nro_pago";
            cbox_tipo_pago.SelectedIndex = 0;

        }
        ServiceReference1.ServiciosClient servicios = new ServiceReference1.ServiciosClient();
        MesaBN m = new MesaBN();
        int idpedido = 0;
        int idmesa = 0;
        public void BotonMesas()
        {

            var list = servicios.ListaMesaWS();
            
            foreach (var item in list)
            {
                
                
                Button b = new Button();
                Grid g = new Grid();
                b.Content = "Mesa " + item.id.ToString();
                b.Name = "Button" + item.id.ToString();
                
                b.Height = 100;
                b.Width = 100;
                b.HorizontalAlignment = HorizontalAlignment.Left;
                b.VerticalAlignment = VerticalAlignment.Stretch;
                b.Margin = new Thickness(5);
                          
                wp_mesas.Orientation = Orientation.Horizontal;
                wp_mesas.Children.Add(b);
                //Programar evento CLICK de cada boton
                

                //estado DISPONIBLE el numero es representado como D (Disponible)
                if (item.estado.Equals(68))
                {
                    b.Background = Brushes.Green;
                }
                else
                {
                    b.Background = Brushes.Red;
                    b.Click += (s, e) => {
                        idmesa = item.id;

                        dg_orden.ItemsSource = m.detalleOrden(item.id).DefaultView;
                        
                        var t = m.detalleOrden(item.id);
                        int precio_cant_p, precio_cant_b;
                        int cantidad_p = 0;
                        int total_p = 0;
                        int precio_p = 0;
                        int precio_b = 0;
                        int cantidad_B = 0;
                        int total_b = 0;
                        int total = 0;
                        foreach (DataRow row in t.Rows)
                        {
                            
                            foreach (DataColumn column in t.Columns)
                            {

                                if (column.ToString().Equals("PRECIO_PLATO"))
                                {

                                    precio_p = Convert.ToInt32(row[column]);

                                }
                                if (column.ToString().Equals("CANTIDAD_PLATO"))
                                {
                                    cantidad_p = Convert.ToInt32(row[column]);
                                    //platos
                                    precio_cant_p = cantidad_p * precio_p;
                                    total_p = total_p + precio_cant_p;

                                }
                                if (column.ToString().Equals("PRECIO_BEBESTIBLE"))
                                {
                                    precio_b = Convert.ToInt32(row[column]);
                                }

                                if (column.ToString().Equals("CANTIDAD_BEBESTIBLE"))
                                {
                                    cantidad_B = Convert.ToInt32(row[column]);
                                    //bebidas
                                    precio_cant_b = precio_b * cantidad_B;
                                    total_b = total_b + precio_cant_b;
                                }
                                if (column.ToString().Equals("NRO_PEDIDO"))
                                {
                                    idpedido = Convert.ToInt32(row[column]);
                                }
                                
                            }
                        }
                        total = total_b + total_p;
                        lbl_dinero.Content = total;

                        tbox_monto_i.IsEnabled = true;
                        
                        
                    };

                }

            }                    
        }

        private async void btn_pagar_Click(object sender, RoutedEventArgs e)
        {
            BoletaBN b = new BoletaBN();
            try
            {
                int dinero = Convert.ToInt32(lbl_dinero.Content);
                int pagado = Convert.ToInt32(tbox_monto_i.Text);
                DateTime fecha = Convert.ToDateTime(lbl_fecha.Content);
                int vuelto = Convert.ToInt32(lbl_vuelto.Content);
                int nropago = Convert.ToInt32(cbox_tipo_pago.SelectedValue);
                b.agregarBoleta(dinero, pagado, fecha, vuelto, idpedido, idmesa, nropago);

                await this.ShowMessageAsync("Exito!", "La boleta se agrego correctamente al sistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private async void tbox_monto_i_LostFocus(object sender, RoutedEventArgs e)
        {
            
            

            if (string.IsNullOrEmpty(tbox_monto_i.Text))
            {
                tbox_monto_i.Text = "0";
                
            }
            else
            {
                var pago = Convert.ToInt32(tbox_monto_i.Text);
                var tot = Convert.ToInt32(lbl_dinero.Content);
                if (pago >= tot)
                {
                    lbl_vuelto.Content = (pago - tot).ToString();
                    btn_pagar.IsEnabled = true;
                }
                else
                {
                    await this.ShowMessageAsync("Error", "El pago ingresado debe ser igual o mayor al costo total");
                }
               


            }
            
        }

        private void btn_boleta_Click(object sender, RoutedEventArgs e)
        {
            BoletaInforme form = new BoletaInforme();
            form.Show();
            this.Hide();
        }
    }
}
