using Al_Soft.Sistema_Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Al_Soft
{
    public partial class FrmMateriaP : Form
    {
        public FrmMateriaP()
        {
            InitializeComponent();
            PersonalizadorDGV.Personalizar2(TablaMatPrima);
            MySqlConnection conex = Conexión.GetConnection();
            string consulta = "SELECT * FROM Materia_prima";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaMatPrima.DataSource = LlenarTabla;
            TablaMatPrima.Columns["IDMateriaP"].Visible = false;
            conex.Close();
        }

        public void ActualizarTablaMatPrima()
        {
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string abrirconsulta = "SELECT*FROM Materia_Prima";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(abrirconsulta, conex);
            DataTable LlenarTabla = new DataTable();
            adaptador.Fill(LlenarTabla);
            TablaMatPrima.DataSource = LlenarTabla;
            conex.Close();
        }

        public void LimpiarCamposMP()
        {
            txbIDMatP.Clear();
            txbNomMP.Clear();
            txbDescripción.Clear();
            nudCant.Value = 0;
            txbCostoXUni.Clear();
        }

        private void btnAgregarMP_Click(object sender, EventArgs e)
        {
            string NomMP = txbNomMP.Text;
            string Descrip = txbDescripción.Text;
            int Cant = (int)nudCant.Value;
            double Costo;

            if (string.IsNullOrEmpty(NomMP) || string.IsNullOrEmpty(Descrip) || Cant == 0 || !double.TryParse(txbCostoXUni.Text, out Costo))
            {
                MessageBox.Show("Uno o más campos de texto están vacíos", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cant = Cant + 0;
            int Cantidad = Cant;

            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();
            string consulta = "INSERT INTO Materia_prima(Nombre, Descripción, Cantidad, Costo, Costo_Total) " +
                              $"VALUES(@NomMP, @Descrip, @Cantidad, @Costo, @Costo_Total)";

            try
            {
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@NomMP", NomMP);
                comando.Parameters.AddWithValue("@Descrip", Descrip);
                comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                comando.Parameters.AddWithValue("@Costo", Costo);
                double CostoTotal = Costo * Cant;
                comando.Parameters.AddWithValue("@Costo_Total", CostoTotal);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarTablaMatPrima();
                LimpiarCamposMP();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("El Producto no pudo ser ingresado. " + ex.Message, "Error");
            }
            finally
            {
                conex.Close();
            }
        }

        private void btnModifMP_Click(object sender, EventArgs e)
        {
            string NomMP = txbNomMP.Text;
            string Descrip = txbDescripción.Text;
            int Cant = (int)nudCant.Value;
            double Costo;

            if (string.IsNullOrEmpty(NomMP) || string.IsNullOrEmpty(Descrip) || Cant == 0 || !double.TryParse(txbCostoXUni.Text, out Costo))
            {
                MessageBox.Show("Uno o más campos de texto están vacíos", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cant = Cant + 0;
            int Cantidad = Cant;

            int IDProducto;
            if (!int.TryParse(TablaMatPrima.CurrentRow.Cells["IDMateriaP"].Value.ToString(), out IDProducto))
            {
                MessageBox.Show("Producto no seleccionado", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult condición = MessageBox.Show("¿Desea Modificar Producto?", "Confirmar Modificación:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (condición == DialogResult.Yes)
            {
                MySqlConnection conex = Conexión.GetConnection();
                conex.Open();
                try
                {
                    string consulta = "UPDATE Materia_prima SET Nombre = @Nom, Descripción = @Desc, Cantidad = @Cant, Costo = @Costo, Costo_Total = @Costo_Total WHERE IDMateriaP = @IDProd";
                    MySqlCommand comando = new MySqlCommand(consulta, conex);
                    comando.Parameters.AddWithValue("@IDProd", IDProducto);
                    comando.Parameters.AddWithValue("@Nom", NomMP);
                    comando.Parameters.AddWithValue("@Desc", Descrip);
                    comando.Parameters.AddWithValue("@Cant", Cantidad);
                    comando.Parameters.AddWithValue("@Costo", Costo);
                    double CostoTotal = Costo * Cant;
                    comando.Parameters.AddWithValue("@Costo_Total", CostoTotal);
                    int rowsAffected = comando.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Producto no encontrado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    ActualizarTablaMatPrima();
                    LimpiarCamposMP();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al modificar el producto: " + ex.Message);
                }
                finally
                {
                    conex.Close();
                }
            }
        }

        private void btnBorrarMP_Click(object sender, EventArgs e)
        {
            if (TablaMatPrima.CurrentRow == null)
            {
                MessageBox.Show("No se seleccionó ningún producto", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int IDProducto;
            if (!int.TryParse(TablaMatPrima.CurrentRow.Cells["IDMateriaP"].Value.ToString(), out IDProducto))
            {
                MessageBox.Show("Producto no seleccionado", "Advertencia:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            DialogResult condición = MessageBox.Show("¿Eliminar Producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (condición == DialogResult.Yes)
            {
                string consulta = "DELETE FROM Materia_prima WHERE IDMateriaP = @IDProd";
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                comando.Parameters.AddWithValue("@IDProd", IDProducto);

                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Producto no encontrado", "Información:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Producto Eliminado.");
                ActualizarTablaMatPrima();
                LimpiarCamposMP();
                conex.Close();
            }
        }

        private void TablaMatPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TablaMatPrima.Rows[e.RowIndex];
                txbIDMatP.Text = row.Cells[0].Value.ToString();
                txbNomMP.Text = row.Cells[1].Value.ToString();
                txbDescripción.Text = row.Cells[2].Value.ToString();
                nudCant.Text = row.Cells[3].Value.ToString();
                txbCostoXUni.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
