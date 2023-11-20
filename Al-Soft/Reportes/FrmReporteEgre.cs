using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmReporteEgre : Form
    {
        public FrmReporteEgre()
        {
            InitializeComponent();
        }

        private void FrmReporteEgre_Load(object sender, EventArgs e)
        {
            PersonalizadorDGV.Personalizado3(TablaEgr);
            ActualizarTablas();
            OcultarColumnas();
            VerificarFechaEgreso();
        }

        public void ActualizarTablas()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT * FROM egreso WHERE Ocultar = false";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaEgr.DataSource = LlenarTabla;
            conex.Close();
            OcultarColumnas();
        }

        private void btnAgregarEgr_Click(object sender, EventArgs e)
        {
            if (ValidarCamposEgreso())
            {
                InsertarRegistroEgreso();
            }
        }

        private void btnModifEgr_Click(object sender, EventArgs e)
        {
            if (ValidarCamposEgreso())
            {
                ModificarRegistroEgreso();
            }
        }

        private void btnBorrarEgr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbIDEgreso.Text))
            {
                EliminarRegistroEgreso();
            }
            else
            {
                MessageBox.Show("Campo de texto vacío", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarCamposEgreso()
        {
            string descripcion = txbDescripciónE.Text;
            string valor = txbCostoEgr.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show("¡Por favor, completa todos los campos!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(valor, out _))
            {
                MessageBox.Show("¡Por favor, ingresa un valor válido!", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void InsertarRegistroEgreso()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            string consulta = "INSERT INTO Egreso (FechaHoy_E, Descripcion, Costo, Total_E) VALUES (@fechaHoy, @descripcion, @costo, @total)";
            MySqlCommand comando = new MySqlCommand(consulta, conex);
            comando.Parameters.AddWithValue("@fechaHoy", DateTime.Now);
            comando.Parameters.AddWithValue("@descripcion", txbDescripciónE.Text);

            if (int.TryParse(txbCostoEgr.Text, out int costoEgreso))
            {
                comando.Parameters.AddWithValue("@costo", costoEgreso);
                comando.Parameters.AddWithValue("@total", costoEgreso);

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Exitoso!", "Confirmar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTablas();
                    LimpiarCamposEgreso();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de Registro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, ingresa un valor válido para el costo!", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conex.Close();

            VerificarFechaEgreso();
        }

        private void ModificarRegistroEgreso()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            string consulta = "UPDATE Egreso SET Descripcion = @descripcion, Costo = @costo, Total_E = @total WHERE IDEgreso = @IDEgreso";
            MySqlCommand comando = new MySqlCommand(consulta, conex);
            comando.Parameters.AddWithValue("@descripcion", txbDescripciónE.Text);

            if (int.TryParse(txbCostoEgr.Text, out int costoEgreso))
            {
                comando.Parameters.AddWithValue("@costo", costoEgreso);
                comando.Parameters.AddWithValue("@total", costoEgreso);
                comando.Parameters.AddWithValue("@IDEgreso", int.Parse(txbIDEgreso.Text));

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado!", "Confirmar Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTablas();
                    LimpiarCamposEgreso();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de Modificación: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("¡Por favor, ingresa un valor válido para el costo!", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conex.Close();

            VerificarFechaEgreso();
        }

        private void EliminarRegistroEgreso()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string consulta = "DELETE FROM Egreso WHERE IDEgreso = @IDEgreso";
            MySqlCommand comando = new MySqlCommand(consulta, conex);
            comando.Parameters.AddWithValue("@IDEgreso", int.Parse(txbIDEgreso.Text));

            int rowsAffected = comando.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                MessageBox.Show("Registro no encontrado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Registro Eliminado.");
            ActualizarTablas();
            LimpiarCamposEgreso();
            conex.Close();

            VerificarFechaEgreso();
        }

        private void LimpiarCamposEgreso()
        {
            txbIDEgreso.Clear();
            txbCostoEgr.Clear();
            txbDescripciónE.Clear();
        }

        private void TablaEgr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TablaEgr.Rows.Count)
            {
                DataGridViewRow row = TablaEgr.Rows[e.RowIndex];
                txbIDEgreso.Text = row.Cells[0].Value.ToString();
                txbDescripciónE.Text = row.Cells[2].Value.ToString();
                txbCostoEgr.Text = row.Cells[3].Value.ToString();
            }
        }

        private void VerificarFechaEgreso()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT IDEgreso, FechaHoy_E, Ocultar FROM egreso";
            MySqlCommand comando = new MySqlCommand(abrirconsulta, conex);

            List<int> filasAOcultar = new List<int>();
            List<int> filasAMostrar = new List<int>();

            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    int IDEgreso = reader.GetInt32("IDEgreso");
                    DateTime fechaHoyEgreso = Convert.ToDateTime(reader["FechaHoy_E"]);
                    bool ocultarEgreso = reader.GetBoolean("Ocultar");

                    if (DateTime.Now > fechaHoyEgreso.AddDays(1))
                    {
                        if (!ocultarEgreso)
                        {
                            filasAOcultar.Add(IDEgreso);
                        }
                    }
                    else
                    {
                        if (ocultarEgreso)
                        {
                            filasAMostrar.Add(IDEgreso);
                        }
                    }
                }
            }

            using (MySqlTransaction transEgreso = conex.BeginTransaction())
            {
                try
                {
                    foreach (int idEgreso in filasAOcultar)
                    {
                        string updateQuery = "UPDATE egreso SET Ocultar = true WHERE IDEgreso = @IDEgreso";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conex))
                        {
                            updateCommand.Parameters.AddWithValue("@IDEgreso", idEgreso);
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    transEgreso.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la transacción de ocultar egresos: " + ex.Message);
                    transEgreso.Rollback();
                }
            }

            using (MySqlTransaction transMostrarEgreso = conex.BeginTransaction())
            {
                try
                {
                    foreach (int idEgreso in filasAMostrar)
                    {
                        string updateQuery = "UPDATE egreso SET Ocultar = false WHERE IDEgreso = @IDEgreso";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conex))
                        {
                            updateCommand.Parameters.AddWithValue("@IDEgreso", idEgreso);
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    transMostrarEgreso.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la transacción de mostrar egresos: " + ex.Message);
                    transMostrarEgreso.Rollback();
                }
            }

            ActualizarTablas();
            conex.Close();
        }

        private void OcultarColumnas()
        {
            TablaEgr.Columns["IDEgreso"].Visible = false;
            TablaEgr.Columns["Total_E"].Visible = false;
            TablaEgr.Columns["Ocultar"].Visible = false;
            TablaEgr.Columns["Cierre_E"].Visible = false;
        }
    }
}
