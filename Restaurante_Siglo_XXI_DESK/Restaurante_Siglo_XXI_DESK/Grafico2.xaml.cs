using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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
using ControlzEx.Theming;
using System.Windows.Threading;
using MahApps.Metro.Controls.Dialogs;

namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para Grafico2.xaml
    /// </summary>
    public partial class Grafico2
    {
        /*public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }
        //private double _trend;
        private double[] temp = { 1, 3, 2, 4, -3, 5, 2, 1 };*/
        public Grafico2()
        {
            InitializeComponent();
            ThemeManager.Current.ChangeTheme(this, "Light.Blue");
            GraficoLineal("01/2020", "06/2021");
            Fecha();
        }
        private void Fecha()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += (s, e) => { txt_fecha.Text = DateTime.Now.ToString(); };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        public void GraficoLineal(string inicio, string fin)
        {

            BoletaBN b = new BoletaBN();
            var t = b.RePCLIENTEMENSUAL(inicio,fin);
            
            gf_lineal.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Meses",
                Labels = new [] { "en","febr", "mzo","abr","my","jun","jul","ag","sept","oct","nov" ,"dic" }
                });
            gf_lineal.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "Clientes", LabelFormatter = value => value.ToString("C").Remove(0,1) });

            SeriesCollection series = new SeriesCollection();
            string meses = "";
            int clientes = 0;
            List<double> values = new List<double>();
            
            foreach (DataRow row in t.Rows)
            {
                

                foreach (DataColumn column in t.Columns)
                {
                   
                        if (column.ToString().Equals("MES"))
                        {
                            meses = row[column].ToString();
                        
                        }
                    
                    

                    if (column.ToString().Equals("CLIENTES"))
                    {
                        clientes = Convert.ToInt32(row[column]);
                        values.Add(clientes);

                    }
                    
                }



                

            }
            
            for (int i = 0; i <= meses.Count(); i++)
            {
                
                series.Add(new LineSeries() { Title = meses, Values = new ChartValues<double>(values) });
                
            }
            

            gf_lineal.Series = series;
        }

        private async void Buscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime fechai = Convert.ToDateTime(dp_inicio.Text);
                DateTime fechaf = Convert.ToDateTime(dp_fin.Text);
                string fechaInicio = "0" + fechai.Month.ToString() + "/" + fechai.Year.ToString();
                string fechaFin = "0" + fechaf.Month.ToString() + "/" + fechaf.Year.ToString();
                if (fechai <= fechaf)
                {
                    gf_lineal.Series.Clear();
                    gf_lineal.AxisX.Clear();
                    gf_lineal.AxisY.Clear();

                    GraficoLineal(fechaInicio, fechaFin);
                    if (gf_lineal.ActualSeries.Count() != 0)
                    {
                        await this.ShowMessageAsync("Grafico Lineal", "Se genero correctamente");

                    }
                    else
                    {

                        await this.ShowMessageAsync("Sorry", "No se encontraron datos");
                    }
                }
                else
                {
                    await this.ShowMessageAsync("Error", "fechas inicio debe ser menor a la fecha termino");
                }

            }
            catch (Exception)
            {
                await this.ShowMessageAsync("Error", "Ingrese los datos correctamente");
            }
        }
        private void btn_reporte_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printd = new PrintDialog();

            if (printd.ShowDialog() == true)
            {

                printd.PrintVisual(grid_graf, "Doc");
            }
        }
        private void btn_atras_Click(object sender, RoutedEventArgs e)
        {
            VentanaReportes form = new VentanaReportes();
            form.Show();
            this.Hide();
        }
    }
}
