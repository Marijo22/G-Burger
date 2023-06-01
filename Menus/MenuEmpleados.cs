using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionSQLServer.Menus
{
    public partial class MenuEmpleados : Form
    {
        string nombreusuario = "";
        public MenuEmpleados(string nombreus)
        {
            InitializeComponent();
            nombreusuario = nombreus;
            labelUsuario.Text = nombreusuario;
            if(nombreus != "Admin")
            {
                button3.Enabled = false;
            }
        }

        private void MenuEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuABC menuabc = new MenuABC("PRODUCTOS");
            this.Hide();
            menuabc.ShowDialog();
            this.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MenuABC menuabc = new MenuABC("PEDIDO");
            this.Hide();
            menuabc.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MenuABC menuabc = new MenuABC("COMBO_PRODUCTOS");
            this.Hide();
            menuabc.ShowDialog();
            this.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Pedido.AutorizacionDePedido aut1 = new Pedido.AutorizacionDePedido(nombreusuario);
            this.Hide();
            aut1.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MenuABC menuabc = new MenuABC("EMPLEADO");
            this.Hide();
            menuabc.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Seguro que quiere cerrar la sesión?",
                "Cerrar sesión", buttons);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menus.ModificarMenu mm = new Menus.ModificarMenu();
            this.Hide();
            mm.ShowDialog();
            this.Show();
        }
    }
}
