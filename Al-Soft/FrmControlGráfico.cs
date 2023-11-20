using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Al_Soft
{
    public partial class FrmControlGráfico : Form
    {
        public FrmControlGráfico()
        {
            InitializeComponent();
            CargarGraficoIngresos();
            CargarGraficoEgresos();
            CargarGraficoGanancias();
        }

        private void CargarGraficoIngresos()
        {
            List<DataPoint> datosIngresos = ObtenerDatosDesdeBaseDeDatosPorFecha("Ingreso", "FechaHoy_I", "Total_I");
            ConfigurarGrafico(chartIngresos, "Puntos de Ingresos", "Línea de Ingresos", datosIngresos);
        }

        private void CargarGraficoEgresos()
        {
            List<DataPoint> datosEgresos = ObtenerDatosDesdeBaseDeDatosPorFecha("Egreso", "FechaHoy_E", "Total_E");
            ConfigurarGrafico(chartEgresos, "Puntos de Egresos", "Línea de Egresos", datosEgresos);
        }

        private void CargarGraficoGanancias()
        {
            List<DataPoint> datosGanancias = ObtenerDatosDesdeBaseDeDatosPorFecha("R_Mensual", "Fecha_Saldo", "Saldo");
            ConfigurarGrafico(chartGanancias, "Puntos de Ganancias", "Línea de Ganancias", datosGanancias);
        }

        private List<DataPoint> ObtenerDatosDesdeBaseDeDatosPorFecha(string tabla, string columnaFecha, string columna)
        {
            List<DataPoint> datos = new List<DataPoint>();

            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                string consulta = $"SELECT {columnaFecha}, {columna} FROM {tabla}";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conex))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[columnaFecha] != DBNull.Value && reader[columna] != DBNull.Value)
                            {
                                DateTime fecha = Convert.ToDateTime(reader[columnaFecha]);
                                int valor = Convert.ToInt32(reader[columna]);

                                Console.WriteLine($"Fecha obtenida: {fecha.ToString("dd/MM/yyyy")}");

                                DataPoint dataPoint = new DataPoint(fecha.ToOADate(), valor);
                                datos.Add(dataPoint);
                            }
                        }
                    }
                }
                conex.Close();
            }

            return datos;
        }

        private void ConfigurarGrafico(Chart chart, string nombreSeriePuntos, string nombreSerieLineas, List<DataPoint> datos)
        {
            chart.Series.Clear();

            var seriePuntos = chart.Series.Add(nombreSeriePuntos);
            foreach (var dataPoint in datos)
            {
                seriePuntos.Points.Add(dataPoint);
            }
            seriePuntos.ChartType = SeriesChartType.Point;
            seriePuntos.XValueType = ChartValueType.DateTime;
            seriePuntos.MarkerStyle = MarkerStyle.Circle;

            var serieLineas = chart.Series.Add(nombreSerieLineas);
            foreach (var dataPoint in datos)
            {
                serieLineas.Points.Add(dataPoint);
            }
            serieLineas.ChartType = SeriesChartType.Line;

            chart.Titles.Add("Gráfico");
            chart.ChartAreas[0].AxisX.Title = "Fecha";
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chart.ChartAreas[0].AxisY.Title = "Cantidad";
        }
    }
}
