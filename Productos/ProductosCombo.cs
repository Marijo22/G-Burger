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
    public partial class ProductosCombo : Form
    {
        string cadena = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
            "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int leftco = 155;
        int topco = 50;
        int numref;
        int[,] prods_combo;
        int contador;

        public ProductosCombo()
        {
            InitializeComponent();
        }

        private void PonerDatosEnElCombo()
        {
            string query = "SELECT id_producto,nombre_pro FROM PRODUCTOS WHERE categoria = 'Combos'";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(cadena))
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
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "id_producto";
            comboBox1.DisplayMember = "nombre_pro";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = -1;
        }

        private void LimpiarVariablesTrabajo()
        {
            PonerDatosEnElCombo();
            comboBox1.SelectedIndex = -1;
        }

        private void ProductosCombo_Load(object sender, EventArgs e)
        {
            PonerDatosEnElCombo();
            LimpiarVariablesTrabajo();
            try
            {
                string query = ("SELECT * FROM PRODUCTOS WHERE categoria NOT LIKE 'Combos'");

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    // Abrir la conexión a la base de datos
                    connection.Open();
                    DataSet ds = new DataSet();
                    DataTable dt2 = new DataTable();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(command);
                        data.Fill(ds, "PRODUCTOS");
                        data.Fill(dt2);

                        int filasdt = dt2.Rows.Count;
                        prods_combo  = new int[filasdt,2];
                        contador = 0;

                        foreach (DataRow row in ds.Tables["PRODUCTOS"].Rows)
                        {
                            prods_combo[contador, 0] = Int32.Parse(row["id_producto"].ToString());
                            prods_combo[contador, 1] = 0;

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

                            Label lbl = new Label();
                            lbl.Left = leftco;
                            lbl.Top = topco;
                            lbl.AutoSize = true;
                            lbl.Text = "Categoria: " + row["categoria"].ToString();
                            panel1.Controls.Add(lbl);

                            Label lb2 = new Label();
                            lb2.Left = leftco;
                            lb2.Top = topco + 20;
                            lb2.AutoSize = true;
                            lb2.Text = row["nombre_pro"].ToString();
                            lb2.Font = new Font("Arial", 12, FontStyle.Bold);
                            panel1.Controls.Add(lb2);

                            Label lbpesos = new Label();
                            lbpesos.Left = leftco + 200;
                            lbpesos.Top = topco;
                            lbpesos.AutoSize = true;
                            lbpesos.Text = "$" + row["precio"].ToString();
                            panel1.Controls.Add(lbpesos);

                            CheckBox cb1 = new CheckBox();
                            cb1.Left = leftco + 345;
                            cb1.Top = topco;
                            cb1.Checked = false;
                            panel1.Controls.Add(cb1);

                            

                            NumericUpDown nud1 = new NumericUpDown();
                            nud1.Left = leftco + 470;
                            nud1.Size = new Size(66, 22);
                            nud1.Top = topco;
                            nud1.Value = 1;
                            nud1.Maximum = 10;
                            nud1.Minimum = 1;
                            panel1.Controls.Add(nud1);

                            int x = contador;

                            nud1.ValueChanged += (s, e2) =>
                            {
                                if(cb1.Checked==true)
                                prods_combo[x, 1] = Int32.Parse(nud1.Value.ToString());
                            };

                            cb1.CheckedChanged += (s, e2) =>
                            {
                                if (cb1.Checked == true)
                                    prods_combo[x, 1] = Int32.Parse(nud1.Value.ToString());
                                else
                                    prods_combo[x, 1] = 0;
                            };

                            topco += 100;
                            contador++;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensajecaja = "¿Seguro de que desea sobreescribir/registrar los productos en el combo?";
            DialogResult respuesta;
            respuesta = MessageBox.Show(mensajecaja, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                numref = Int32.Parse(comboBox1.SelectedValue.ToString());
                string query = ("DELETE FROM COMBO_PRODUCTOS WHERE id_combo = " + numref);
                
                using (SqlConnection connection2 = new SqlConnection(cadena))
                {
                    connection2.Open();
                     using (SqlCommand command = new SqlCommand(query, connection2))
                     {
                              int rowsAffected = command.ExecuteNonQuery();
                              Console.WriteLine("Rows affected: " + rowsAffected);
                     }
                     for(int i=0; i<contador; i++)
                     {
                        if (prods_combo[i, 1] > 0)
                        {
                            query = ("INSERT INTO COMBO_PRODUCTOS (id_combo,id_producto,Cantidad) " +
                                "VALUES (" + numref + "," + prods_combo[i, 0] + "," + prods_combo[i, 1] + ")");
                            using (SqlCommand command = new SqlCommand(query, connection2))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                Console.WriteLine("Rows affected: " + rowsAffected);
                            }
                        }
                     }
                    MessageBox.Show(" Operacion completada... ");
                    connection2.Close();
                };
                panel1.Controls.Clear();
                topco = 50;
                ProductosCombo_Load(sender, e);
            }
            else
            {
                MessageBox.Show(" Operacion cancelada... ");
                LimpiarVariablesTrabajo();
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
