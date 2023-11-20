using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            PersonalizadorDGV.Personalizar(TablaClientes);
            MySqlConnection conex = Conexión.GetConnection();
            string abrirconsulta = "SELECT * FROM Clientes";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaClientes.DataSource = LlenarTabla;
            TablaClientes.Columns["IDCliente"].Visible = false;
            conex.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cmbxBuscar.Items.Add("Todos los campos");
            cmbxBuscar.Items.Add("Nombre");
            cmbxBuscar.Items.Add("Apellido");
            cmbxBuscar.Items.Add("Dirección");
            cmbxBuscar.Items.Add("Teléfono");
            cmbxBuscar.SelectedItem = "Todos los campos";
            cmbxBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ActualizarTablas()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT * FROM Clientes";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaClientes.DataSource = LlenarTabla;
            conex.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nomC = txbNomCli.Text;
            string apeC = txbApeCli.Text;
            string ciCli = txbCedula.Text;
            string dir = txbDir.Text;
            string tel = txbTel.Text;

            if (string.IsNullOrWhiteSpace(nomC) || string.IsNullOrWhiteSpace(apeC) || string.IsNullOrWhiteSpace(ciCli) || string.IsNullOrWhiteSpace(dir) || string.IsNullOrWhiteSpace(tel))
            {
                MessageBox.Show("¡Por favor, completa todos los campos!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conex = Conexión.GetConnection();
                conex.Open();
                string consulta = "INSERT INTO Clientes(Nombre, Apellido, Dirección, Cédula_Cli, Teléfono) VALUES ('" + nomC + "','" + apeC + "','" + dir + "'," +
                    "'" + ciCli + "','" + tel + "');";
                try
                {
                    MySqlCommand comando = new MySqlCommand(consulta, conex);
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            string nomC = txbNomCli.Text;
            string apeC = txbApeCli.Text;
            string ciCli = txbCedula.Text;
            string dir = txbDir.Text;
            string tel = txbTel.Text;

            int IDCli;
            if (!int.TryParse(txbIDCliente.Text, out IDCli))
            {
                MessageBox.Show("Campo de texto vacío o no es un número válido", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Modificar Registro?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MySqlConnection conex = Conexión.GetConnection();
                conex.Open();
                try
                {
                    string consulta = "UPDATE Clientes SET Nombre= @Nom, Apellido= @Apell, Dirección= @Dir, Cédula_Cli= @ci, Teléfono= @Tel WHERE IDCliente= @IDCli";
                    MySqlCommand comando = new MySqlCommand(consulta, conex);
                    comando.Parameters.AddWithValue("@IDCli", IDCli);
                    comando.Parameters.AddWithValue("@Nom", nomC);
                    comando.Parameters.AddWithValue("@Apell", apeC);
                    comando.Parameters.AddWithValue("@Dir", dir);
                    comando.Parameters.AddWithValue("@ci", ciCli);
                    comando.Parameters.AddWithValue("@Tel", tel);

                    int rowsAffected = comando.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Usuario no encontrado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    ActualizarTablas();
                    LimpiarCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message);
                    conex.Close();
                }
            }
        }

        public void LimpiarCampos()
        {
            txbIDCliente.Clear();
            txbNomCli.Clear();
            txbApeCli.Clear();
            txbDir.Clear();
            txbCedula.Clear();
            txbTel.Clear();
            txbBuscarCli.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarPor = cmbxBuscar.SelectedItem.ToString();
            string valorBuscado = txbBuscarCli.Text;

            if (string.IsNullOrEmpty(valorBuscado))
            {
                MessageBox.Show("Campo de texto vacío", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            string consulta;
            if (buscarPor == "Todos los campos")
            {
                consulta = "SELECT * FROM Clientes WHERE Nombre LIKE '%" + valorBuscado + "%' OR Apellido LIKE '%" + valorBuscado + "%' OR Dirección LIKE '%" + valorBuscado + "%' OR Cédula_Cli LIKE '%" + valorBuscado + "%' OR Teléfono LIKE '%" + valorBuscado + "%'";
            }
            else
            {
                consulta = "SELECT * FROM Clientes WHERE " + buscarPor + " LIKE '%" + valorBuscado + "%'";
            }

            using (MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conex))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron Resultados", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TablaClientes.DataSource = TablaClientes;
                    DataTable LlenarTabla = new DataTable();
                    adaptador.Fill(LlenarTabla);
                    TablaClientes.DataSource = LlenarTabla;
                    TablaClientes.Columns["IDCliente"].Visible = false;
                    conex.Close();
                    ActualizarTablas();
                }
                else
                {
                    TablaClientes.DataSource = tabla;
                }
            }
            LimpiarCampos();
        }

        private void TablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TablaClientes.Rows[e.RowIndex];
                txbIDCliente.Text = row.Cells[0].Value.ToString();
                txbNomCli.Text = row.Cells[1].Value.ToString();
                txbApeCli.Text = row.Cells[2].Value.ToString();
                txbDir.Text = row.Cells[3].Value.ToString();
                txbCedula.Text = row.Cells[4].Value.ToString();
                txbTel.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IDCli = txbIDCliente.Text;

            if (string.IsNullOrEmpty(txbIDCliente.Text) || string.IsNullOrEmpty(txbNomCli.Text) || string.IsNullOrEmpty(txbApeCli.Text) || string.IsNullOrEmpty(txbDir.Text) || string.IsNullOrEmpty(txbTel.Text))
            {
                MessageBox.Show("Uno o más campos de texto están vacíos", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            DialogResult condición = MessageBox.Show("¿Eliminar Registro?", "Confirmar Eliminacón", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (condición == DialogResult.Yes)
            {
                string consulta = "DELETE FROM Clientes WHERE IDCliente = @IDCli";
                MySqlCommand comando = new MySqlCommand(consulta, conex);

                comando.Parameters.AddWithValue("@IDCli", IDCli);

                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Usuario no encontrado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ActualizarTablas();
                LimpiarCampos();
                conex.Close();
            }
        }
    }
}
