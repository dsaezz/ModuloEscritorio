using ControlzEx.Theming;
using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Threading;
using CapaNegocio;
namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para Grafico3.xaml
    /// </summary>
    public partial class Grafico3
    {
        public Grafico3()
        {
            InitializeComponent();
            ThemeManager.Current.ChangeTheme(this, "Light.Blue");
            Fecha();
            Graficobarra();
        }
        private void Fecha()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += (s, e) => { txt_fecha.Text = DateTime.Now.ToString(); };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        public void Graficobarra()
        {
            BoletaBN b = new BoletaBN();
            gf_lineal.AxisX.Add(new LiveCharts.Wpf.Axis { Title = "Ingresos  Egresos", Labels = new List<string> { "" } }); 
            gf_lineal.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "Pesos", LabelFormatter = value => value.ToString("C")});
            SeriesCollection series = new SeriesCollection();


            
            var t = b.RPINGRESO();
            List<double> values = new List<double>();
            List<double> values2 = new List<double>();
            int ingreso = 0;
            int egreso = 0;
            foreach (DataRow row in t.Rows)
            {


                foreach (DataColumn column in t.Columns)
                {

                    if (column.ToString().Equals("INGRESOS"))
                    {
                        ingreso = Convert.ToInt32(row[column]);
                        values.Add(ingreso);

                        
                    }

                }
                series.Add(new ColumnSeries() {Values = new ChartValues<double>(values) });
            }


            var t2 = b.RPENGRESO();

            foreach (DataRow row in t2.Rows)
            {


                foreach (DataColumn column in t2.Columns)
                {

                    if (column.ToString().Equals("EGRESOS"))
                    {
                        egreso = Convert.ToInt32(row[column]);
                        values2.Add(egreso);


                    }

                }
                series.Add(new ColumnSeries() { Values = new ChartValues<double>(values2) });
            }


            gf_lineal.Series = series;

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
