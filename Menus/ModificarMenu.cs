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

namespace ConexionSQLServer.Menus
{
    public partial class ModificarMenu : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";

        public ModificarMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ModificarMenu_Load(object sender, EventArgs e)
        {
            string query2 = ("SELECT * FROM MENUIMAGENES WHERE id = 1");
            DataTable dt = new DataTable();
            using (SqlConnection connection2 = new SqlConnection(cadena))
            {
                connection2.Open();
                using (SqlCommand command2 = new SqlCommand(query2, connection2))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command2);
                    adapter.Fill(dt);
                }
                connection2.Close();
            };
            DataRow dr = dt.Rows[0];
            pictureBox2.Image = Image.FromFile(dr["Imagen"].ToString());
            textBoxImagen.Text = dr["Imagen"].ToString();
            comboBoxCatego.SelectedItem= dr["categoria"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    string comando = string.Format("UPDATE MENUIMAGENES SET" +
                        " Imagen = '{0}', categoria='{1}' WHERE id = 1",
                        textBoxImagen.Text, comboBoxCatego.SelectedItem.ToString());
                    SqlCommand command = new SqlCommand(comando, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Menu actualizado...");
            }
            catch (Exception ee)
            {
                MessageBox.Show("El sistema mando el siguiente error: " + ee);
            }
        }
    }
}
