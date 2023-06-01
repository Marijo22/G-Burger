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
    public partial class RegistroUsuario : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";

        public RegistroUsuario(int band)
        {
            InitializeComponent();
            if(band==1)
            {
                linkLabel1.Enabled = false;
                linkLabel1.Visible = false;
                label9.Visible = false;
            }
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion is1 = new IniciarSesion();
            this.Hide();
            is1.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreEmpleado = txtBoxNombreEmpleado.Text;
                string nombreUsuario = txtBoxNombreUsuario.Text;
                string contraUsuario = txtBoxContrasena.Text;
                string direccionEmpleado = txtBoxDireccionEmpleado.Text;
                string curpEmpleado = txtBoxCURPEmpleado.Text;
                string telefonoEmpleado = txtBoxTelefonoEmpleado.Text;
                int telefono = (int)Convert.ToInt64(telefonoEmpleado);

                if (telefonoEmpleado.Length < 10 || curpEmpleado.Length < 18)
                {
                    MessageBox.Show("El telefono o la CURP no estan completos");
                }
                else
                {
                    if (contraUsuario.Length >= 8)
                    {
                        string query = string.Format("INSERT INTO EMPLEADO (CURP_emp, nombre_emp, direccion_emp, telefono_emp, nombre_usuario, Contraseña) " +
                            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                            curpEmpleado, nombreEmpleado, direccionEmpleado, telefonoEmpleado, nombreUsuario, contraUsuario);

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
                            MessageBox.Show("Empleado: '" + nombreEmpleado + "' agregado correctamente");
                        }

                        txtBoxNombreEmpleado.Clear();
                        txtBoxNombreUsuario.Clear();
                        txtBoxContrasena.Clear();
                        txtBoxDireccionEmpleado.Clear();
                        txtBoxCURPEmpleado.Clear();
                        txtBoxTelefonoEmpleado.Clear();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe tener minimo 8 caracteres");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtBoxNombreEmpleado.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //IniciarSesion p = new IniciarSesion();
            this.Close();
            //p.Show();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IniciarSesion is1 = new IniciarSesion();
            this.Hide();
            is1.ShowDialog();
        }
    }
}
