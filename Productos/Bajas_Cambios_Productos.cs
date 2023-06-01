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

namespace ConexionSQLServer.Productos
{
    public partial class Bajas_Cambios_Productos : Form
    {
        string connectionString = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
          "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int act = 0;

        public Bajas_Cambios_Productos(int acti)
        {
            InitializeComponent();
            act = acti;
            if(act==1)
            {
                button2.Text = "ACTUALIZAR";
            }
            else
            {
                textBoxNombreP.Enabled = false;
                richTextBoxDesc.Enabled = false;
                textBoxPrecio.Enabled = false;
                comboBoxCatego.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void PonerDatosEnElCombo()
        {
            string query = "SELECT id_producto,nombre_pro FROM PRODUCTOS";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            cbb_Prods.DataSource = dt;
            cbb_Prods.ValueMember = "id_producto";
            cbb_Prods.DisplayMember = "nombre_pro";
            cbb_Prods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_Prods.SelectedIndex = -1;
        }

        private void LimpiarVariablesTrabajo()
        {
            PonerDatosEnElCombo();
            textBoxNombreP.Text = "";
            richTextBoxDesc.Text = "";
            textBoxPrecio.Text = "";
            textBoxImagen.Text = "";
            comboBoxCatego.SelectedIndex = -1;
            pictureBox2.Image = null;
        }


        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bajas_Cambios_Productos_Load(object sender, EventArgs e)
        {
            PonerDatosEnElCombo();
            LimpiarVariablesTrabajo();
        }

        private void cbb_Prods_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbb_Prods.SelectedValue != null)
            {
                string Clave = cbb_Prods.SelectedValue.ToString();
                string query = string.Format("SELECT * FROM PRODUCTOS WHERE id_producto = {0}", Clave);
                DataTable dt2 = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    try
                    {
                        connection.Open();
                        adapter.Fill(dt2);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

                if (dt2.Rows.Count > 0)
                {
                    DataRow dr = dt2.Rows[0];
                    textBoxNombreP.Text = dr["nombre_pro"].ToString();
                    richTextBoxDesc.Text = dr["descripcion"].ToString();
                    textBoxPrecio.Text = dr["precio"].ToString();
                    comboBoxCatego.SelectedItem = dr["categoria"].ToString();
                    String direccionImagen = dr["imagen"].ToString();
                    if (direccionImagen != "null")
                        pictureBox2.Image = Image.FromFile(direccionImagen);
                    textBoxImagen.Text = direccionImagen;
                }
            }
        }

        private void BorrarProducto()
        {
            try
            {
                //Obtenemos la clave de usuario
                string Clave = cbb_Prods.SelectedValue.ToString();

                //Se hace la conexion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string comando = string.Format("DELETE FROM PRODUCTOS WHERE id_producto = {0}", Clave);
                    SqlCommand command = new SqlCommand(comando, connection);

                    //Se ejecuta el comando
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show(Clave + " Operacion terminada... ");

                //Llamamos la funcion para limpiar las cajas de texto
                LimpiarVariablesTrabajo();
            }
            catch (Exception ee)
            {
                MessageBox.Show("El sistema mando el siguiente error: " + ee);
            }
        }

        private void ActualizarProducto()
        {
            try
            {
                string Clave = cbb_Prods.SelectedValue.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string comando = string.Format("UPDATE PRODUCTOS SET" +
                        " nombre_pro = '{1}', descripcion='{2}', precio = {3}," +
                        " imagen = '{4}' WHERE id_producto = {0}",
                        Clave, textBoxNombreP.Text, richTextBoxDesc.Text, textBoxPrecio.Text, textBoxImagen.Text);
                    SqlCommand command = new SqlCommand(comando, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show(Clave + "Producto actualizado...");
                LimpiarVariablesTrabajo();
            }
            catch (Exception ee)
            {
                MessageBox.Show("El sistema mando el siguiente error: " + ee);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbb_Prods.SelectedIndex < 0)
            {
                MessageBox.Show(" Error! No hay ningun producto seleccionado... ");
            }
            else
            {
                string mensajecaja = "";
                if (act == 0)
                    mensajecaja = "¿Esta seguro de borrarlo?";
                if (act == 1)
                    mensajecaja = "¿Seguro de su actualizacion?";
                DialogResult respuesta;
                respuesta = MessageBox.Show(mensajecaja, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if (act == 0)
                        BorrarProducto();
                    if (act == 1)
                        ActualizarProducto();
                }
                else
                {
                    MessageBox.Show(" Operacion cancelada. No se ha modificado el registro... ");
                    LimpiarVariablesTrabajo();
                }
            }
        }

        private void cbb_Prods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG|*.png|JPG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                    textBoxImagen.Text = ofd.FileName;
                }
            }
        }

        private void textBoxImagen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
