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
    public partial class Carrito : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int leftco = 155;
        int topco = 50;
        int numref = 1;
        float preciototal = 0.00F;

        public Carrito(int idpedido)
        {
            InitializeComponent();
            numref = idpedido;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            try
            {
                labelPrecioTotal.Text = "0.00";
                preciototal = 0.00F;
                leftco = 155;
                topco = 50;
                panel1.Controls.Clear();

                Label labelPro = new Label();
                labelPro.Left = leftco - 127;
                labelPro.Top = topco - 40;
                labelPro.AutoSize = true;
                labelPro.Text = "Producto";
                labelPro.Font = new Font("Arial", 12, FontStyle.Regular);
                panel1.Controls.Add(labelPro);

                Label labelDes = new Label();
                labelDes.Left = leftco;
                labelDes.Top = topco - 40;
                labelDes.AutoSize = true;
                labelDes.Text = "Descripcion";
                labelDes.Font = new Font("Arial", 12, FontStyle.Regular);
                panel1.Controls.Add(labelDes);

                Label labelPre = new Label();
                labelPre.Left = leftco + 229;
                labelPre.Top = topco - 40;
                labelPre.AutoSize = true;
                labelPre.Text = "Precio";
                labelPre.Font = new Font("Arial", 12, FontStyle.Regular);
                panel1.Controls.Add(labelPre);

                Label labelCan = new Label();
                labelCan.Left = leftco + 345;
                labelCan.Top = topco - 40;
                labelCan.AutoSize = true;
                labelCan.Text = "Cantidad";
                labelCan.Font = new Font("Arial", 12, FontStyle.Regular);
                panel1.Controls.Add(labelCan);

                Label labelOps = new Label();
                labelOps.Left = leftco + 345;
                labelOps.Top = topco - 40;
                labelOps.AutoSize = true;
                labelOps.Text = "Opciones";
                labelOps.Font = new Font("Arial", 12, FontStyle.Regular);
                panel1.Controls.Add(labelOps);

                string query = ("SELECT * FROM PRODUCTOS_PEDIDOS LEFT JOIN PRODUCTOS ON " +
                    "PRODUCTOS_PEDIDOS.id_producto = PRODUCTOS.id_producto WHERE " +
                    "PRODUCTOS_PEDIDOS.num_referencia = " + numref);

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();
                    DataSet ds = new DataSet();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        data.Fill(ds, "PRODUCTOS_CARRITO");

                        foreach (DataRow row in ds.Tables["PRODUCTOS_CARRITO"].Rows)
                        {
                            PictureBox pb = new PictureBox();
                            pb.Left = leftco - 140;
                            pb.Top = topco - 20;
                            String direccionImagen = row["imagen"].ToString();
                            Console.WriteLine(direccionImagen);
                            pb.Size = new Size(120, 72);
                            pb.SizeMode = PictureBoxSizeMode.Zoom;
                            if (direccionImagen != "null")
                                pb.Image = Image.FromFile(direccionImagen);
                            panel1.Controls.Add(pb);

                            Label lb2 = new Label();
                            lb2.Left = leftco;
                            lb2.Top = topco;
                            lb2.AutoSize = true;
                            lb2.Text = row["nombre_pro"].ToString();
                            lb2.Font = new Font("Arial", 12, FontStyle.Bold);
                            panel1.Controls.Add(lb2);

                            Label lbl = new Label();
                            lbl.Left = leftco;
                            lbl.Top = topco + 20;
                            lbl.AutoSize = true;
                            lbl.Text = row["descripcion"].ToString();
                            panel1.Controls.Add(lbl);

                            Label lbpesos = new Label();
                            lbpesos.Left = leftco + 200;
                            lbpesos.Top = topco;
                            lbpesos.AutoSize = true;
                            lbpesos.Text = "$";
                            panel1.Controls.Add(lbpesos);

                            Label lbprecio = new Label();
                            lbprecio.Left = leftco + 210;
                            lbprecio.Top = topco;
                            lbprecio.AutoSize = true;
                            String textoprecioproducto = row["precio"].ToString();
                            float precioproducto = (float)Convert.ToDouble(textoprecioproducto);
                            lbprecio.Text = textoprecioproducto;
                            panel1.Controls.Add(lbprecio);

                            NumericUpDown nud1 = new NumericUpDown();
                            nud1.Left = leftco + 340;
                            nud1.Size = new Size(66, 22);
                            nud1.Top = topco;
                            int cantidadproducto = Int32.Parse(row["Cantidad"].ToString());
                            nud1.Value = cantidadproducto;
                            nud1.Maximum = 100;
                            nud1.Minimum = 1;
                            panel1.Controls.Add(nud1);

                            nud1.ValueChanged += (s, e2) =>
                            {
                                string query2 = ("UPDATE PRODUCTOS_PEDIDOS SET Cantidad = " + nud1.Value + " WHERE " +
                                "num_referencia = " + numref + "AND id_producto = " + row["id_producto"].ToString());
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
                                Carrito_Load(s, e);
                            };

                            LinkLabel linkL1 = new LinkLabel();
                            linkL1.Left = leftco + 430;
                            linkL1.Top = topco;
                            linkL1.Text = "Eliminar";
                            panel1.Controls.Add(linkL1);

                            linkL1.LinkClicked += (s, e2) =>
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show("¿Seguro que quiere borrar este producto?",
                                    "Eliminar producto", buttons);
                                if (result == DialogResult.Yes)
                                {
                                    string query2 = ("DELETE FROM PRODUCTOS_PEDIDOS WHERE num_referencia = " + numref +
                                "AND id_producto = " + row["id_producto"].ToString());
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
                                    MessageBox.Show("Producto eliminado correctamente");
                                    Carrito_Load(s, e2);
                                }
                            };

                            LinkLabel linkL2 = new LinkLabel();
                            linkL2.Left = leftco + 430;
                            linkL2.Top = topco + 25;
                            linkL2.AutoSize = true;
                            linkL2.Text = "Ver mas opciones de " + row["categoria"].ToString();
                            panel1.Controls.Add(linkL2);

                            linkL2.LinkClicked += (s, e2) =>
                            {
                                MenuOtros mo1 = new MenuOtros(numref, row["categoria"].ToString());
                                mo1.Show();
                            };

                            preciototal += precioproducto * cantidadproducto;
                            labelPrecioTotal.Text = preciototal.ToString("#.##");
                            topco += 100;
                        }
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(preciototal>0.0)
            {
                ConfirmacionDePedido confirmar = new ConfirmacionDePedido(numref, preciototal);
                this.Hide();
                confirmar.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Aun no ha pedido nada");
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
