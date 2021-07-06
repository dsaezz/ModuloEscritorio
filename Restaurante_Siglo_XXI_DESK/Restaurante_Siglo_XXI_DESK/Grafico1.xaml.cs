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
//using GRAFICOS
using LiveCharts;
using LiveCharts.Wpf;
using CapaNegocio;
using System.Data;
using ControlzEx.Theming;
using System.Windows.Threading;
using MahApps.Metro.Controls.Dialogs;

namespace Restaurante_Siglo_XXI_DESK
{
    /// <summary>
    /// Lógica de interacción para Grafico1.xaml
    /// </summary>
    public partial class Grafico1 
    {
        public Func<ChartPoint, string> PointLabel { get; set; }
        public Grafico1()
        {
            InitializeComponent();
            ThemeManager.Current.ChangeTheme(this, "Light.Blue");

            PointLabel = chartPoint => string.Format("{0}({1:p})", chartPoint.Y, chartPoint.Participation);
            GraficoPie("01/2021", "08/2021");
            Fecha();
        }
        
        private void Fecha()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += (s, e) => { txt_fecha.Text = DateTime.Now.ToString(); };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        public void GraficoPie(string inicio, string fin)
        {
            PlatoBN p = new PlatoBN();
            string fechai = Convert.ToString(dp_inicio.Text);
            var t = p.REPplato(inicio,fin);

            string plato = "";
            int cant = 0;
            foreach (DataRow row in t.Rows)
            {
                PieSeries pie = new PieSeries();

                foreach (DataColumn column in t.Columns)
                {

                    if (column.ToString().Equals("PLATO"))
                    {
                        plato = row[column].ToString();

                    }
                    if (column.ToString().Equals("TOTAL_CONSUMIDO"))
                    {
                        cant = Convert.ToInt32(row[column]);
                        pie.Values = new ChartValues<int> { cant };
                    }

                    pie.Title = plato;
                    pie.DataLabels = true;
                    pie.LabelPoint = PointLabel;


                    //pipChart.Series.Add(new PieSeries { Title = "Uno", DataLabels = true, LabelPoint = PointLabel, Values = new ChartValues<int> { 5 } });
                    //MessageBox.Show(row[column].ToString() + " " + column);
                }

                pipChart.Series.Add(pie);
                // pie.Title = row[column].ToString();
            }





            DataContext = this;
        }
            private void pipChart_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;


            //clear selected slice
            foreach (PieSeries series in chart.Series)
            {
                series.PushOut = 0;

                var selectedSeries = (PieSeries)chartPoint.SeriesView;
                selectedSeries.PushOut = 8;
            }
        }

        private async void Buscar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                DateTime fechai = Convert.ToDateTime(dp_inicio.Text);
                DateTime fechaf = Convert.ToDateTime(dp_fin.Text);
                string fechaInicio = "0" + fechai.Month.ToString() + "/" + fechai.Year.ToString();
                string fechaFin = "0" + fechaf.Month.ToString() + "/" + fechaf.Year.ToString();
                if (fechai<= fechaf)
                {
                    pipChart.Series.Clear();

                    GraficoPie(fechaInicio, fechaFin);
                    if (pipChart.ActualSeries.Count() != 0)
                    {
                        await this.ShowMessageAsync("Grafico de Torta", "Se genero correctamente");

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
            catch(Exception)
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

