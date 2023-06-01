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
    public partial class ConfirmacionDePedido : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
           "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int numref = 1;
        float preciototal = 0.00F;

        public ConfirmacionDePedido(int numpedido, float total)
        {
            InitializeComponent();
            numref = numpedido;
            preciototal = total;
        }

        private void ConfirmacionDePedido_Load(object sender, EventArgs e)
        {
            string query = ("SELECT cantidad, nombre_pro, precio" +
                " FROM PRODUCTOS_PEDIDOS LEFT JOIN PRODUCTOS ON " +
                "PRODUCTOS_PEDIDOS.id_producto = PRODUCTOS.id_producto WHERE " +
                "PRODUCTOS_PEDIDOS.num_referencia = " + numref);
            int Fila = 0;
            label6.Text = preciototal.ToString();
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    data.Fill(ds, "PRODUCTOS_CARRITO");

                    foreach (DataRow row in ds.Tables["PRODUCTOS_CARRITO"].Rows)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[Fila].Cells[0].Value = row["cantidad"].ToString();
                        dataGridView1.Rows[Fila].Cells[1].Value = row["nombre_pro"].ToString();
                        dataGridView1.Rows[Fila].Cells[2].Value = row["precio"].ToString();
                        Fila++;
                    }
                }

                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datetimeactual = DateTime.Now;
                string metodo;
                if (radioButtonEfectivo.Checked == true)
                    metodo = "Efectivo";
                else
                    metodo = "Tarjeta";

                string query2 = ("UPDATE PEDIDO SET nombre_cliente = '" + textBox1.Text + "'," +
                        "metodopago = '" + metodo + "', fecha = '"+ datetimeactual.ToString("M-dd-yyyy hh:mm:ss") + "', total = "+
                        preciototal+", confirmado = 1 " +
                        "WHERE num_referencia = "+ numref);
                using (SqlConnection connection2 = new SqlConnection(cadena))
                {
                    connection2.Open();
                    using (SqlCommand command2 = new SqlCommand(query2, connection2))
                    {
                        int rowsAffected = command2.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                    connection2.Close();
                };
                Application.Restart();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que quiere cancelar este pedido? Perderá toda la informacion contenida en el",
                "Eliminar pedido", buttons);
            if (result == DialogResult.Yes)
            {
                string query2 = ("DELETE FROM PEDIDO WHERE num_referencia = " + numref);
                using (SqlConnection connection2 = new SqlConnection(cadena))
                {
                    connection2.Open();
                    using (SqlCommand command2 = new SqlCommand(query2, connection2))
                    {
                        int rowsAffected = command2.ExecuteNonQuery();

                        // Mostrar el número de filas afectadas por la consulta SQL
                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                    connection2.Close();
                };
                MessageBox.Show("Pedido eliminado correctamente");
                this.Close();
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
