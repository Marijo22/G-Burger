using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexionSQLServer
{
    public partial class AltaProducto : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";

        public AltaProducto()
        {
            InitializeComponent();
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos los datos de los campos
                string nombreProducto = textBoxNombreP.Text;
                string descripcionProducto = richTextBoxDesc.Text;
                float precioProducto = float.Parse(textBoxPrecio.Text);

                //Se define una imagen predeterminada en caso de que no se haya examinado una
                string direccionImagen = "C:/G_Burgers_1/Imagenes/noimage.png";

                //Se verifica si se examino una imagen para obtener su direccion y almancenarla
                if (textBoxImagen.Text != "")
                {
                    direccionImagen = textBoxImagen.Text;
                }
                string categoriaProducto = comboBoxCatego.SelectedItem.ToString();

                //Instruccion sql
                string query = string.Format("INSERT INTO PRODUCTOS (nombre_pro, descripcion, precio, " +
                    "imagen, categoria) VALUES ('{0}', '{1}', {2}, '{3}', '{4}')",
                    nombreProducto, descripcionProducto, precioProducto,
                    direccionImagen, categoriaProducto);

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar la consulta SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                    connection.Close();
                    MessageBox.Show(nombreProducto+" agregado correctamente");
                }

                //Limpiamos las cajas de texto
                textBoxNombreP.Clear();
                richTextBoxDesc.Clear();
                textBoxPrecio.Clear();
                textBoxImagen.Clear();
                pictureBox2.Image = null;
                comboBoxCatego.SelectedIndex = -1;

                //En caso de ser un combo abrimos la ventana para registrar qué productos abarca
                if(categoriaProducto=="Combos")
                {
                    MessageBox.Show("Agregue productos al combo");
                    ProductosCombo altaPC = new ProductosCombo();
                    altaPC.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxNombreP.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG|*.png|JPG|*.jpg" } )
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                    textBoxImagen.Text = ofd.FileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
