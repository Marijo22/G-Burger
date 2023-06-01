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
    public partial class MenuOtros : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int leftco = 20;
        int topco = 10;
        int numref = 1;
        int cantidadreg = 0;
        string tabla = "";

        public MenuOtros(int idpedido, string tablaabuscar)
        {
            InitializeComponent();
            numref = idpedido;
            tabla = tablaabuscar;
            label2.Text = tabla.ToUpper();
        }

        private void pictureBoxCarrito_Click(object sender, EventArgs e)
        {
            Carrito cr1 = new Carrito(numref);
            this.Hide();
            cr1.ShowDialog();
            string confirmado = "";
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = ("SELECT confirmado FROM PEDIDO WHERE num_referencia = " + numref);
                // Abrir la conexión a la base de datos
                connection.Open();
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    data.Fill(ds, "RESULTADOS");
                    foreach (DataRow row in ds.Tables["RESULTADOS"].Rows)
                        confirmado = row["confirmado"].ToString();
                }
            }
            this.Show();
            if (confirmado == "True")
                this.Close();
        }

        private void MenuOtros_Load(object sender, EventArgs e)
        {
            try
            {
                string query = ("SELECT * FROM PRODUCTOS WHERE CATEGORIA = '" + tabla + "'");
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    connection.Open();
                    DataSet ds = new DataSet();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        data.Fill(ds, "PRODUCTOS");

                        foreach (DataRow row in ds.Tables["PRODUCTOS"].Rows)
                        {
                            PictureBox pb = new PictureBox();
                            pb.Left = leftco;
                            pb.Top = topco;
                            String direccionImagen = row["imagen"].ToString();
                            pb.Size = new Size(356, 233);
                            pb.SizeMode = PictureBoxSizeMode.Zoom;
                            if (direccionImagen != "null")
                                pb.Image = Image.FromFile(direccionImagen);
                            panel1.Controls.Add(pb);

                            Label lbl = new Label();
                            lbl.Left = leftco + 5;
                            lbl.Top = topco + 235;
                            lbl.AutoSize = true;
                            lbl.Font = new Font("Arial", 18, FontStyle.Bold);
                            lbl.Text = row["nombre_pro"].ToString();
                            panel1.Controls.Add(lbl);

                            Label lbprecio = new Label();
                            lbprecio.Left = leftco + 270;
                            lbprecio.Top = topco + 235;
                            lbprecio.AutoSize = true;
                            lbprecio.Font = new Font("Arial", 18, FontStyle.Bold);
                            lbprecio.Text = "$" + row["precio"].ToString();
                            panel1.Controls.Add(lbprecio);

                            Button botonañadir = new Button();
                            botonañadir.Size = new Size(334, 31);
                            botonañadir.BackColor = Color.FromArgb(255, 168, 19);
                            botonañadir.Text = "Agregar al carrito";
                            botonañadir.Font = new Font("Evil Dead", 10, FontStyle.Regular);
                            botonañadir.Left = leftco + 10;
                            botonañadir.Top = topco + 270;
                            botonañadir.Cursor = Cursors.Hand;

                            botonañadir.Click += (s, e2) =>
                            {
                                string query2 = ("SELECT COUNT(*) AS [contador] FROM PRODUCTOS_PEDIDOS " +
                                "WHERE num_referencia=" + numref + " AND id_producto = " + row["id_producto"].ToString());

                                using (SqlConnection connection2 = new SqlConnection(cadena))
                                {
                                    connection2.Open();
                                    using (SqlCommand command2 = new SqlCommand(query2, connection2))
                                    {
                                        cantidadreg = (int)command2.ExecuteScalar();
                                    }
                                    connection2.Close();
                                };

                                if (cantidadreg == 0)
                                {
                                    query2 = ("INSERT INTO PRODUCTOS_PEDIDOS (num_referencia,id_producto,Cantidad)" +
                                  " VALUES (" + numref + "," + row["id_producto"].ToString() + ",1)");
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
                                    MessageBox.Show("Producto añadido");
                                }
                                else
                                {
                                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                    DialogResult result = MessageBox.Show("Este producto ya está registrado en tu pedido" +
                                        " una o mas veces, ¿desde añadir una unidad mas?", "Registrar producto", buttons);
                                    if (result == DialogResult.Yes)
                                    {
                                        string query3 = ("UPDATE PRODUCTOS_PEDIDOS SET Cantidad = Cantidad+1 WHERE " +
                                        "num_referencia = " + numref + "AND id_producto = " + row["id_producto"].ToString());
                                        using (SqlConnection connection2 = new SqlConnection(cadena))
                                        {
                                            connection2.Open();
                                            using (SqlCommand command2 = new SqlCommand(query3, connection2))
                                            {
                                                int rowsAffected = command2.ExecuteNonQuery();

                                            // Mostrar el número de filas afectadas por la consulta SQL
                                            Console.WriteLine("Rows affected: " + rowsAffected);
                                            }
                                            connection2.Close();
                                        };
                                    }
                                }
                            };
                            panel1.Controls.Add(botonañadir);

                            leftco += 400;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pedido.Buscador cr1 = new Pedido.Buscador(numref, tabla);
            this.Hide();
            cr1.ShowDialog();
            string confirmado = "";
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = ("SELECT confirmado FROM PEDIDO WHERE num_referencia = " + numref);
                // Abrir la conexión a la base de datos
                connection.Open();
                DataSet ds = new DataSet();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter data = new SqlDataAdapter(command);
                    data.Fill(ds, "RESULTADOS");
                    foreach (DataRow row in ds.Tables["RESULTADOS"].Rows)
                        confirmado = row["confirmado"].ToString();
                }
            }
            this.Show();
            if (confirmado == "True")
                this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
