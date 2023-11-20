using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Al_Soft.Sistema_Usuarios
{
    public partial class FrmReporteDiario : Form
    {
        public FrmReporteDiario()
        {
            InitializeComponent();
            CargarDatosIngreso();
            CargarDatosEgreso();
        }

        private void CargarDatosIngreso()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT IDIngreso, FechaHoy_I, Total_I FROM Ingreso WHERE Cierre_I = 0";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaIngr.DataSource = LlenarTabla;
            TablaIngr.Columns["IDIngreso"].Visible = false;
            conex.Close();
        }

        private void CargarDatosEgreso()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT IDEgreso, FechaHoy_E, Total_E FROM Egreso WHERE Cierre_E = 0";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaEgr.DataSource = LlenarTabla;
            TablaEgr.Columns["IDEgreso"].Visible = false;
            conex.Close();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realizar cierre de caja?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int nuevoIDRDiario = ObtenerNuevoIDRDiario();
                txbIDCierreCaja.Text = nuevoIDRDiario.ToString();

                if (TablaIngr.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos en la tabla Ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalIngresos = 0;
                foreach (DataGridViewRow fila in TablaIngr.Rows)
                {
                    if (fila.Cells["Total_I"].Value != null)
                    {
                        totalIngresos += Convert.ToDecimal(fila.Cells["Total_I"].Value);
                    }
                }
                txbIngresos.Text = totalIngresos.ToString();

                if (TablaEgr.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos en la tabla Egreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalEgresos = 0;
                foreach (DataGridViewRow fila in TablaEgr.Rows)
                {
                    if (fila.Cells["Total_E"].Value != null)
                    {
                        totalEgresos += Convert.ToDecimal(fila.Cells["Total_E"].Value);
                    }
                }
                txbEgresos.Text = totalEgresos.ToString();

                decimal saldoTotal = totalIngresos - totalEgresos;
                txbSaldoTotal.Text = saldoTotal.ToString();

                GuardarEnTablaRDiario(nuevoIDRDiario, totalIngresos, totalEgresos, DateTime.Now, saldoTotal);

                ActualizarTablasCerradas();
                CargarDatosIngreso();
                CargarDatosEgreso();
                FrmRegistroMensual frmRegistroMensual = new FrmRegistroMensual();
                frmRegistroMensual.ActualizarTablaRMensualEnFrmRegistroMensual(nuevoIDRDiario, totalIngresos, totalEgresos, DateTime.Now, saldoTotal);
            }
            else
            {
                return;
            }
        }

        private void ActualizarTablasCerradas()
        {
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();

                string actualizarIngresoConsulta = "UPDATE Ingreso SET Cierre_I = 1";

                using (MySqlCommand cmd = new MySqlCommand(actualizarIngresoConsulta, conex))
                {
                    cmd.ExecuteNonQuery();
                }

                string actualizarEgresoConsulta = "UPDATE Egreso SET Cierre_E = 1";

                using (MySqlCommand cmd = new MySqlCommand(actualizarEgresoConsulta, conex))
                {
                    cmd.ExecuteNonQuery();
                }

                conex.Close();
            }
        }

        private int ObtenerNuevoIDRDiario()
        {
            int nuevoIDRDiario = 0;
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                string consulta = "SELECT MAX(IDR_Diario) FROM R_Diario";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conex))
                {
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        nuevoIDRDiario = Convert.ToInt32(resultado) + 1;
                    }
                }
                conex.Close();
            }
            return nuevoIDRDiario;
        }

        private void GuardarEnTablaRDiario(int nuevoIDRDiario, decimal totalIngresos, decimal totalEgresos, DateTime FechaSaldo, decimal saldoTotal)
        {
            using (MySqlConnection conex = Conexión.GetConnection())
            {
                conex.Open();
                using (MySqlTransaction transaccion = conex.BeginTransaction())
                {
                    try
                    {
                        string actualizarConsulta = "INSERT INTO R_Diario (IDR_Diario, Total_Ingreso, Total_Egreso, Fecha_Saldo, Saldo) " +
                                                    "VALUES (@IDRDiario, @TotalIngreso, @TotalEgreso, @FechaSaldo, @Saldo)";

                        using (MySqlCommand cmd = new MySqlCommand(actualizarConsulta, conex, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@IDRDiario", nuevoIDRDiario);
                            cmd.Parameters.AddWithValue("@TotalIngreso", totalIngresos);
                            cmd.Parameters.AddWithValue("@TotalEgreso", totalEgresos);
                            cmd.Parameters.AddWithValue("@FechaSaldo", FechaSaldo);
                            cmd.Parameters.AddWithValue("@Saldo", saldoTotal);

                            cmd.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.ToString());
                        transaccion.Rollback();
                    }
                }
            }
        }
    }
}
