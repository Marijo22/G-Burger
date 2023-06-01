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
    public partial class MenuPrincipal : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int idpedido = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            /*DateTime datetimeactual = DateTime.Now;
            string query = ("INSERT INTO PEDIDO (nombre_cliente,fecha,total,metodopago,confirmado,pagado) " +
                "VALUES ('Nombre del cliente','" + datetimeactual.ToString() + "',0,'Efectivo',0,0)");

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    // Mostrar el número de filas afectadas por la consulta SQL
                    Console.WriteLine("Rows affected: " + rowsAffected);
                }

                query = ("SELECT  TOP 1 *  FROM PEDIDO ORDER BY num_referencia DESC");
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    idpedido = (int)command.ExecuteScalar();
                    MessageBox.Show("ID: " + idpedido);
                }

                connection.Close();
            };

            Menu mn1 = new Menu(idpedido);
            this.Hide();
            mn1.ShowDialog();
            this.Show();*/
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datetimeactual = DateTime.Now;
                //MessageBox.Show(datetimeactual.ToString());
                string query = ("INSERT INTO PEDIDO (nombre_cliente,fecha,total,metodopago,confirmado,pagado,autorizo) " +
                    "VALUES ('Nombre del cliente','" + datetimeactual.ToString("M-dd-yyyy hh:mm:ss") + "',0,'Efectivo',0,0,NULL)");

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }

                    query = ("SELECT  TOP 1 *  FROM PEDIDO ORDER BY num_referencia DESC");
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        idpedido = (int)command.ExecuteScalar();
                        MessageBox.Show("ID: " + idpedido);
                    }

                    connection.Close();
                };

                Menu mn1 = new Menu(idpedido);
                this.Hide();
                mn1.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion form2 = new IniciarSesion();
            this.Hide();
            form2.ShowDialog();
            //this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroUsuario reg1 = new RegistroUsuario(0);
            this.Hide();
            reg1.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductosCombo altaPC = new ProductosCombo();
            this.Hide();
            altaPC.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que quiere salir del sistema?",
                "Salir", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
