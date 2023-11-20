using System.Drawing;
using System.Windows.Forms;

namespace Al_Soft
{
    internal class PersonalizadorDGV
    {
        public static void Personalizar(DataGridView TablaClientes)
        {
            TablaClientes.BackgroundColor = Color.White;  // Cambia el color de fondo a blanco.
            TablaClientes.DefaultCellStyle.Font = new Font("Arial", 12);  // Cambia el estilo de la fuente.
            TablaClientes.DefaultCellStyle.ForeColor = Color.Black;    // Cambia el color de la fuente a negro.
            TablaClientes.GridColor = Color.FromArgb(255, 182, 193);  // Cambia el color de los bordes de las celdas a rosado pastel.

            TablaClientes.RowTemplate.Height = 50; // Ajusta el ancho del divisor de cada columna.
            foreach (DataGridViewColumn columna in TablaClientes.Columns)
            {
                columna.DividerWidth = 6; // Cambia a '6' el grosor de las líneas de las columnas de la tabla. Puede ser cualquier valor.

                // Ajusta la altura del divisor de cada fila
                foreach (DataGridViewRow fila in TablaClientes.Rows)
                {
                    fila.DividerHeight = 6; // Cambia a '2' el grosor de las líneas de las filas de la tabla. Puede ser cualquier valor. 
                }

                // Asegúrate de que los cambios se apliquen
                TablaClientes.Refresh();
            }

        }

        public static void Personalizar2(DataGridView TablaMateriaP)
        {
            TablaMateriaP.BackgroundColor = Color.White;  // Cambia el color de fondo a blanco.
            TablaMateriaP.DefaultCellStyle.Font = new Font("Arial", 12);  // Cambia el estilo de la fuente.
            TablaMateriaP.DefaultCellStyle.ForeColor = Color.Black;    // Cambia el color de la fuente a negro.
            TablaMateriaP.GridColor = Color.FromArgb(255, 182, 193);  // Cambia el color de los bordes de las celdas a rosado pastel.

            TablaMateriaP.RowTemplate.Height = 50; // Ajusta el ancho del divisor de cada columna.
            foreach (DataGridViewColumn columna in TablaMateriaP.Columns)
            {
                columna.DividerWidth = 6; // Cambia a '6' el grosor de las líneas de las columnas de la tabla. Puede ser cualquier valor.

                // Ajusta la altura del divisor de cada fila
                foreach (DataGridViewRow fila in TablaMateriaP.Rows)
                {
                    fila.DividerHeight = 6; // Cambia a '2' el grosor de las líneas de las filas de la tabla. Puede ser cualquier valor. 
                }

                // Asegúrate de que los cambios se apliquen
                TablaMateriaP.Refresh();
            }

        }
        public static void Personalizado3(DataGridView TablaIngreso)
        {
            TablaIngreso.BackgroundColor = Color.White;  // Cambia el color de fondo a blanco.
            TablaIngreso.DefaultCellStyle.Font = new Font("Arial", 12);  // Cambia el estilo de la fuente.
            TablaIngreso.DefaultCellStyle.ForeColor = Color.Black;    // Cambia el color de la fuente a negro.
            TablaIngreso.GridColor = Color.FromArgb(255, 182, 193);  // Cambia el color de los bordes de las celdas a rosado pastel.

            TablaIngreso.RowTemplate.Height = 50; // Ajusta el ancho del divisor de cada columna.
            foreach (DataGridViewColumn columna in TablaIngreso.Columns)
            {
                columna.DividerWidth = 6; // Cambia a '6' el grosor de las líneas de las columnas de la tabla. Puede ser cualquier valor.

                // Ajusta la altura del divisor de cada fila
                foreach (DataGridViewRow fila in TablaIngreso.Rows)
                {
                    fila.DividerHeight = 6; // Cambia a '2' el grosor de las líneas de las filas de la tabla. Puede ser cualquier valor. 
                }

                // Asegúrate de que los cambios se apliquen
                TablaIngreso.Refresh();
            }
        }
    }
}
