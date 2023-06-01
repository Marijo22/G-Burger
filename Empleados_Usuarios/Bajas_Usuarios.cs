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

namespace ConexionSQLServer.Empleados_Usuarios
{
    public partial class Bajas_Usuarios : Form
    {
        string connectionString = "Data Source = DESKTOP-B7R68LI\\SQLEXPRESS;" +
           "initial catalog=G_Burgers; user id=sa; password=KendrickLamar";
        int act = 0;

        public Bajas_Usuarios(int acti)
        {
            InitializeComponent();
            act = acti;
            if(act==1)
            {
                gru_Panel.Text = "Actualizaciones";
                btnEliminar.Text = "Actualizar Empleado";

                txt_nombre_Emp.Enabled = true;
                txt_Nombre.Enabled = true;
                txt_tele.Enabled = true;
                txt_Curp.Enabled = true;
                txt_Contra.Enabled = true;
                txtBoxDireccion.Enabled = true;
            }
        }

        private void PonerDatosEnElCombo()
        {
            string query = "SELECT CURP_emp,nombre_emp FROM EMPLEADO";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
            cbb_Usuario.DataSource = dt;
            cbb_Usuario.ValueMember = "CURP_emp";
            cbb_Usuario.DisplayMember = "nombre_emp";
            cbb_Usuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_Usuario.SelectedIndex = -1;
        }

        private void LimpiarVariablesTrabajo()
        {
            PonerDatosEnElCombo();
            txt_nombre_Emp.Text = "";
            txt_Nombre.Text = "";
            txt_tele.Text = "";
            txt_Curp.Text = "";
            txt_Contra.Text = "";
            txtBoxDireccion.Text = "";
            cbb_Usuario.SelectedIndex = -1;
        }

        private void BorrarUsuario()
        {
            try
            {
                //Obtenemos la clave de usuario
                string Clave = cbb_Usuario.SelectedValue.ToString();

                //Se hace la conexion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string comando = string.Format("DELETE FROM EMPLEADO WHERE CURP_emp = '{0}'", Clave);
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

        private void ActualizarUsuario()
        {
            try
            {
                int telefono = (int)Convert.ToInt64(txt_tele.Text);
                if (txt_tele.Text.Length < 10 || txt_Curp.Text.Length < 18 || txt_Contra.Text.Length < 8)
                {
                    MessageBox.Show("Uno o mas datos pueden estar incompletos (Telefono, CURP o contraseña)");
                }
                else
                {
                    string Clave = cbb_Usuario.SelectedValue.ToString();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string comando = string.Format("UPDATE EMPLEADO SET CURP_emp = '{0}'" +
                            ", nombre_emp = '{1}', direccion_emp='{2}', telefono_emp = '{3}'," +
                            " nombre_usuario = '{4}', Contraseña = '{5}' WHERE CURP_emp  = '{0}'",
                            Clave, txt_nombre_Emp.Text, txtBoxDireccion.Text, txt_tele.Text, txt_Nombre.Text,
                            txt_Contra.Text);
                        SqlCommand command = new SqlCommand(comando, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show(Clave + " Actualizado correctamente... ");
                    LimpiarVariablesTrabajo();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("El sistema mando el siguiente error: " + ee);
            }
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_Usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Usuario.SelectedValue != null)
            {
                string Clave = cbb_Usuario.SelectedValue.ToString();
                string query = string.Format("SELECT * FROM EMPLEADO WHERE CURP_emp = '{0}'", Clave);
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

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txt_nombre_Emp.Text = dr["nombre_emp"].ToString();
                    txt_Nombre.Text = dr["nombre_usuario"].ToString();
                    txt_tele.Text = dr["telefono_emp"].ToString();
                    txt_Curp.Text = dr["CURP_emp"].ToString();
                    txt_Contra.Text = dr["Contraseña"].ToString();
                    txtBoxDireccion.Text = dr["direccion_emp"].ToString();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbb_Usuario.SelectedIndex < 0)
            {
                MessageBox.Show(" Error! No hay ningun producto seleccionado... ");
            }
            else
            {
                string mensajecaja = "";
                if(act==0)
                    mensajecaja="¿Esta seguro de borrarlo?";
                if (act==1)
                    mensajecaja = "¿Seguro de su actualizacion?";
                DialogResult respuesta;
                respuesta = MessageBox.Show(mensajecaja, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    if(act==0)
                        BorrarUsuario();
                    if (act == 1)
                        ActualizarUsuario();
                }
                else
                {
                    MessageBox.Show(" Operacion cancelada. No se ha modificado el registro... ");
                    LimpiarVariablesTrabajo();
                }
            }
        }

        private void Bajas_Usuarios_Load(object sender, EventArgs e)
        {
            PonerDatosEnElCombo();
            LimpiarVariablesTrabajo();
        }

        private void gru_Panel_Enter(object sender, EventArgs e)
        {

        }
    }
}
