using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmReporteIngr : Form
    {
        private DateTime fechaCargada;

        public FrmReporteIngr()
        {
            InitializeComponent();
        }

        private void FrmReporteIngr_Load(object sender, EventArgs e)
        {
            PersonalizadorDGV.Personalizado3(TablaIngreso);
            fechaCargada = DateTime.Now;
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT * FROM ingreso WHERE Ocultar = false";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaIngreso.DataSource = LlenarTabla;
            conex.Close();
            VerificarFecha();
            OcultarColumnas();
        }

        public void ActualizarTablas()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT * FROM ingreso WHERE Ocultar = false";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaIngreso.DataSource = LlenarTabla;
            conex.Close();
            OcultarColumnas();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            string descripcion = txbDescripción.Text;
            DateTime fechaRetiro = dtpFechaRetiro.Value;
            string cantPrendas = txbCantidad.Text;
            string valorPrendas = txbCostoXUnid.Text;
            string horas = txbHoras.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(cantPrendas) || string.IsNullOrWhiteSpace(valorPrendas) || string.IsNullOrWhiteSpace(horas))
            {
                MessageBox.Show("¡Por favor, completa todos los campos!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double numCantPrendas, numValorPrendas;
                if (!double.TryParse(cantPrendas, out numCantPrendas) || !double.TryParse(valorPrendas, out numValorPrendas))
                {
                    MessageBox.Show("¡Por favor, ingresa números válidos para la cantidad de prendas y el valor de las prendas!", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlConnection conex = Conexión.GetConnection();
                conex.Open();
                string consulta = "INSERT INTO ingreso (FechaHoy_I, Descripcion, Fecha_Retiro, Cant_Prendas, Valor_Prendas, Horas, Total, Total_I) VALUES (CURDATE(), @descripcion, @fechaRetiro, @cantPrendas, @valorPrendas, @horas, @total, @total)";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@fechaRetiro", fechaRetiro);
                comando.Parameters.AddWithValue("@cantPrendas", cantPrendas);
                comando.Parameters.AddWithValue("@valorPrendas", valorPrendas);
                comando.Parameters.AddWithValue("@horas", horas);
                double total = numCantPrendas * numValorPrendas;
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@total_i", total);

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Exitoso!", "Confirmar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTablas();
                    LimpiarCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de Registro: " + ex.Message);
                }
                conex.Close();
            }
        }

        private void btnModifProd_Click(object sender, EventArgs e)
        {
            string descripcion = txbDescripción.Text;
            DateTime fechaRetiro = dtpFechaRetiro.Value;
            string cantPrendas = txbCantidad.Text;
            string valorPrendas = txbCostoXUnid.Text;
            string horas = txbHoras.Text;

            if (string.IsNullOrWhiteSpace(descripcion) || string.IsNullOrWhiteSpace(cantPrendas) || string.IsNullOrWhiteSpace(valorPrendas) || string.IsNullOrWhiteSpace(horas))
            {
                MessageBox.Show("¡Por favor, completa todos los campos!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double numCantPrendas, numValorPrendas;
                if (!double.TryParse(cantPrendas, out numCantPrendas) || !double.TryParse(valorPrendas, out numValorPrendas))
                {
                    MessageBox.Show("¡Por favor, ingresa números válidos para la cantidad de prendas y el valor de las prendas!", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlConnection conex = Conexión.GetConnection();
                conex.Open();
                string consulta = "UPDATE ingreso SET Descripcion = @descripcion, Fecha_Retiro = @fechaRetiro, Cant_Prendas = @cantPrendas, Valor_Prendas = @valorPrendas, Horas = @horas, Total = @total, Total_I = @total WHERE IDIngreso = @IDIngreso";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@fechaRetiro", fechaRetiro);
                comando.Parameters.AddWithValue("@cantPrendas", cantPrendas);
                comando.Parameters.AddWithValue("@valorPrendas", valorPrendas);
                comando.Parameters.AddWithValue("@horas", horas);
                double total = numCantPrendas * numValorPrendas;
                comando.Parameters.AddWithValue("@total", total);
                comando.Parameters.AddWithValue("@total_i", total);
                comando.Parameters.AddWithValue("@IDIngreso", int.Parse(txbIDIngreso.Text));

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado!", "Confirmar Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarTablas();
                    LimpiarCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de Modificación: " + ex.Message);
                }
                conex.Close();
            }
        }

        public void LimpiarCampos()
        {
            txbHoras.Clear();
            txbIDIngreso.Clear();
            txbCostoXUnid.Clear();
            txbCantidad.Clear();
            txbDescripción.Clear();
        }

        private void btnBorrarProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIDIngreso.Text))
            {
                MessageBox.Show("Campo de texto vacío", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int IDIng = int.Parse(txbIDIngreso.Text);
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            DialogResult condición = MessageBox.Show("¿Eliminar Registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (condición == DialogResult.Yes)
            {
                string consulta = "DELETE FROM ingreso WHERE IDIngreso = @IDIng";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@IDIng", IDIng);

                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Registro no encontrado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Registro Eliminado.");
                ActualizarTablas();
                LimpiarCampos();
                conex.Close();
            }
        }

        private void TablaIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = TablaIngreso.Rows[e.RowIndex];
                txbIDIngreso.Text = row.Cells[0].Value.ToString();
                txbDescripción.Text = row.Cells[2].Value.ToString();
                dtpFechaRetiro.Text = row.Cells[3].Value.ToString();
                txbCantidad.Text = row.Cells[4].Value.ToString();
                txbCostoXUnid.Text = row.Cells[5].Value.ToString();
                txbHoras.Text = row.Cells[6].Value.ToString();
            }
        }

        private void VerificarFecha()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT IDIngreso, FechaHoy_I, Ocultar FROM ingreso";
            MySqlCommand comando = new MySqlCommand(abrirconsulta, conex);

            List<int> filasAOcultar = new List<int>();
            List<int> filasAMostrar = new List<int>();

            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    int IDIngreso = reader.GetInt32("IDIngreso");
                    DateTime fechaHoy = Convert.ToDateTime(reader["FechaHoy_I"]);
                    bool ocultar = reader.GetBoolean("Ocultar");

                    if (DateTime.Now > fechaHoy.AddDays(1))
                    {
                        if (!ocultar)
                        {
                            filasAOcultar.Add(IDIngreso);
                        }
                    }
                    else
                    {
                        if (ocultar)
                        {
                            filasAMostrar.Add(IDIngreso);
                        }
                    }
                }
            }

            using (MySqlTransaction trans = conex.BeginTransaction())
            {
                try
                {
                    foreach (int idIngreso in filasAOcultar)
                    {
                        string updateQuery = "UPDATE ingreso SET Ocultar = true WHERE IDIngreso = @IDIngreso";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conex))
                        {
                            updateCommand.Parameters.AddWithValue("@IDIngreso", idIngreso);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la transacción de ocultar: " + ex.Message);
                    trans.Rollback();
                }
            }

            using (MySqlTransaction transMostrar = conex.BeginTransaction())
            {
                try
                {
                    foreach (int idIngreso in filasAMostrar)
                    {
                        string updateQuery = "UPDATE ingreso SET Ocultar = false WHERE IDIngreso = @IDIngreso";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conex))
                        {
                            updateCommand.Parameters.AddWithValue("@IDIngreso", idIngreso);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    transMostrar.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la transacción de mostrar: " + ex.Message);
                    transMostrar.Rollback();
                }
            }

            ActualizarTablas();
            conex.Close();
        }

        private void OcultarColumnas()
        {
            TablaIngreso.Columns["IDIngreso"].Visible = false;
            TablaIngreso.Columns["Total_I"].Visible = false;
            TablaIngreso.Columns["Ocultar"].Visible = false;
            TablaIngreso.Columns["Cierre_I"].Visible = false;
        }
    }
}
