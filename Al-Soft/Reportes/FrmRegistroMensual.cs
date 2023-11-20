using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Al_Soft.Sistema_Usuarios
{
    public partial class FrmRegistroMensual : Form
    {
        private ConfiguracionApp configuracionApp;

        public FrmRegistroMensual()
        {
            InitializeComponent();
            configuracionApp = new ConfiguracionApp();
            CargarDatosEnDataGridView();
            VerificarGenerarYPDFYLimpiarTabla();
        }

        public void ActualizarTablaRMensualEnFrmRegistroMensual(int nuevoIDRDiario, decimal totalIngresos, decimal totalEgresos, DateTime FechaSaldo, decimal saldoTotal)
        {
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                int ultimoIDRMensual = ObtenerUltimoIDRMensual();
                string actualizarConsulta = "INSERT INTO R_Mensual (IDR_Mensual, IDR_Diario, Total_Ingreso, Total_Egreso, Fecha_Saldo, Saldo) " +
                                            "VALUES (@IDRMensual, @IDRDiario, @TotalIngreso, @TotalEgreso, @FechaSaldo, @Saldo)";

                using (MySqlCommand cmd = new MySqlCommand(actualizarConsulta, conex))
                {
                    cmd.Parameters.AddWithValue("@IDRMensual", ultimoIDRMensual + 1);
                    cmd.Parameters.AddWithValue("@IDRDiario", nuevoIDRDiario);
                    cmd.Parameters.AddWithValue("@TotalIngreso", totalIngresos);
                    cmd.Parameters.AddWithValue("@FechaSaldo", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TotalEgreso", totalEgresos);
                    cmd.Parameters.AddWithValue("@Saldo", saldoTotal);
                    cmd.ExecuteNonQuery();
                }
                conex.Close();
            }
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                string consulta = "SELECT * FROM R_Mensual";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conex))
                {
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                    {
                        DataTable tablaMensual = new DataTable();
                        adaptador.Fill(tablaMensual);
                        TablaMensual.DataSource = tablaMensual;
                        TablaMensual.Columns["IDR_Mensual"].Visible = false;
                        TablaMensual.Columns["IDR_Diario"].Visible = false;

                    }
                }
                conex.Close();
            }
        }

        private int ObtenerUltimoIDRMensual()
        {
            int ultimoIDRMensual = 0;
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                string consulta = "SELECT MAX(IDR_Mensual) FROM R_Mensual";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conex))
                {
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        ultimoIDRMensual = Convert.ToInt32(resultado);
                    }
                }
                conex.Close();
            }
            return ultimoIDRMensual;
        }

        private DateTime ultimaGeneracionPDF = DateTime.MinValue;
        private void VerificarGenerarYPDFYLimpiarTabla()
        {
            DateTime ultimaGeneracionPDFGuardada = configuracionApp.UltimaGeneracionPDF;

            if (ultimaGeneracionPDFGuardada == DateTime.MinValue || DateTime.Now > ultimaGeneracionPDFGuardada.AddMonths(1))
            {
                GenerarPDF();
                LimpiarTabla();
                ultimaGeneracionPDF = DateTime.Now;
                configuracionApp.UltimaGeneracionPDF = ultimaGeneracionPDF;
                configuracionApp.Save();
            }
        }

        private void LimpiarTabla()
        {
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                string borrarDatosConsulta = "DELETE FROM R_Mensual";
                using (MySqlCommand cmd = new MySqlCommand(borrarDatosConsulta, conex))
                {
                    cmd.ExecuteNonQuery();
                }
                conex.Close();
            }

            CargarDatosEnDataGridView();
        }

        private void GenerarPDF()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaRegistroMensual = Path.Combine(rutaDocumentos, "RegistroMensual");

            if (!Directory.Exists(rutaRegistroMensual))
            {
                Directory.CreateDirectory(rutaRegistroMensual);
            }

            string nombreArchivo = $"InformeMensual_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string rutaPDF = Path.Combine(rutaRegistroMensual, nombreArchivo);

            DataTable datos = ObtenerDatosParaPDF();
            try
            {
                using (FileStream fs = new FileStream(rutaPDF, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                    pdfDoc.Open();

                    PdfPTable table = new PdfPTable(datos.Columns.Count);
                    foreach (DataColumn col in datos.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName));
                        table.AddCell(cell);
                    }

                    foreach (DataRow row in datos.Rows)
                    {
                        foreach (DataColumn col in datos.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(row[col.ColumnName].ToString()));
                            table.AddCell(cell);
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }

                MessageBox.Show("Cierre de registro mensual. Generando Informe en un PDF");
                System.Diagnostics.Process.Start(rutaPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}");
            }
        }

        private DataTable ObtenerDatosParaPDF()
        {
            DataTable datos = (DataTable)TablaMensual.DataSource;
            return datos;
        }

        private void btnHoy_Click_1(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now.Date;
            FiltrarTablasPorFecha(hoy, "Hoy");
        }

        private void btnU7D_Click(object sender, EventArgs e)
        {
            DateTime haceUnaSemana = DateTime.Now.Date.AddDays(-7);
            FiltrarTablasPorFecha(haceUnaSemana, "Hace 1 semana");
        }

        private void btnU30D_Click(object sender, EventArgs e)
        {
            DateTime hace30Dias = DateTime.Now.Date.AddDays(-30);
            FiltrarTablasPorFecha(hace30Dias, "últimos 30 días");
        }

        private void FiltrarTablasPorFecha(DateTime fechaFiltro, string descripcionFiltro)
        {
            try
            {
                using (MySqlConnection conex = Conexión.GetConnection())
                {
                    conex.Open();
                    string fechaFormateada = fechaFiltro.ToString("yyyy-MM-dd");
                    string consulta = "SELECT * FROM R_Mensual WHERE Fecha_Saldo >= @FechaFiltro";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conex))
                    {
                        cmd.Parameters.AddWithValue("@FechaFiltro", fechaFormateada);
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd))
                        {
                            DataTable tablaMensual = new DataTable();
                            adaptador.Fill(tablaMensual);
                            TablaMensual.DataSource = tablaMensual;
                        }
                    }
                    conex.Close();
                }
                MessageBox.Show($"Datos filtrados para: {descripcionFiltro}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
