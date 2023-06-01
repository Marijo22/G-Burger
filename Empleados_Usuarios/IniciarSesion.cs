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
    public partial class IniciarSesion : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistroUsuario p = new RegistroUsuario(0);
            this.Hide();
            p.ShowDialog();
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtBoxNombreUsuario.Text;
                string contraUsuario = txtBoxContrasena.Text;

                string query = "SELECT COUNT(*) FROM EMPLEADO WHERE nombre_usuario='"+nombreUsuario+
                    "' AND Contraseña='"+contraUsuario+"'";

                // establecer los valores de los parámetros de la consulta SQL
               

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
            
                    int count = (int)command.ExecuteScalar();
                    // verificar el resultado y mostrar un mensaje apropiado
                    if (count > 0)
                    {
                        MessageBox.Show("BIENVENIDO "+nombreUsuario);
                        Menus.MenuEmpleados p = new Menus.MenuEmpleados(nombreUsuario);
                        this.Hide();
                        p.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no se encuentra en la base de datos.");
                    }

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtBoxNombreUsuario.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario p = new RegistroUsuario(0);
            this.Hide();
            p.ShowDialog();
        }
    }
}
