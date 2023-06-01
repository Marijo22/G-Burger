namespace ConexionSQLServer.Empleados_Usuarios
{
    partial class Bajas_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gru_Panel = new System.Windows.Forms.GroupBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_Emp = new System.Windows.Forms.TextBox();
            this.txt_Curp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Usuario = new System.Windows.Forms.ComboBox();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gru_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Evil Dead", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "EMPLEADOS Y USUARIOS";
            // 
            // gru_Panel
            // 
            this.gru_Panel.BackColor = System.Drawing.Color.Transparent;
            this.gru_Panel.Controls.Add(this.txtBoxDireccion);
            this.gru_Panel.Controls.Add(this.label7);
            this.gru_Panel.Controls.Add(this.txt_Contra);
            this.gru_Panel.Controls.Add(this.label6);
            this.gru_Panel.Controls.Add(this.txt_nombre_Emp);
            this.gru_Panel.Controls.Add(this.txt_Curp);
            this.gru_Panel.Controls.Add(this.label2);
            this.gru_Panel.Controls.Add(this.txt_tele);
            this.gru_Panel.Controls.Add(this.txt_Nombre);
            this.gru_Panel.Controls.Add(this.label5);
            this.gru_Panel.Controls.Add(this.label4);
            this.gru_Panel.Controls.Add(this.label3);
            this.gru_Panel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gru_Panel.ForeColor = System.Drawing.Color.Black;
            this.gru_Panel.Location = new System.Drawing.Point(95, 107);
            this.gru_Panel.Name = "gru_Panel";
            this.gru_Panel.Size = new System.Drawing.Size(610, 315);
            this.gru_Panel.TabIndex = 24;
            this.gru_Panel.TabStop = false;
            this.gru_Panel.Text = "Bajas";
            this.gru_Panel.Enter += new System.EventHandler(this.gru_Panel_Enter);
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Enabled = false;
            this.txtBoxDireccion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDireccion.Location = new System.Drawing.Point(128, 189);
            this.txtBoxDireccion.MaxLength = 200;
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(328, 26);
            this.txtBoxDireccion.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Direccion:";
            // 
            // txt_Contra
            // 
            this.txt_Contra.Enabled = false;
            this.txt_Contra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contra.Location = new System.Drawing.Point(128, 136);
            this.txt_Contra.MaxLength = 30;
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.PasswordChar = '%';
            this.txt_Contra.Size = new System.Drawing.Size(198, 26);
            this.txt_Contra.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contraseña:";
            // 
            // txt_nombre_Emp
            // 
            this.txt_nombre_Emp.Enabled = false;
            this.txt_nombre_Emp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_Emp.Location = new System.Drawing.Point(128, 55);
            this.txt_nombre_Emp.MaxLength = 70;
            this.txt_nombre_Emp.Name = "txt_nombre_Emp";
            this.txt_nombre_Emp.Size = new System.Drawing.Size(252, 27);
            this.txt_nombre_Emp.TabIndex = 2;
            // 
            // txt_Curp
            // 
            this.txt_Curp.Enabled = false;
            this.txt_Curp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Curp.Location = new System.Drawing.Point(128, 265);
            this.txt_Curp.MaxLength = 18;
            this.txt_Curp.Name = "txt_Curp";
            this.txt_Curp.Size = new System.Drawing.Size(240, 27);
            this.txt_Curp.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Empleado:";
            // 
            // txt_tele
            // 
            this.txt_tele.Enabled = false;
            this.txt_tele.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(128, 226);
            this.txt_tele.MaxLength = 10;
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(198, 26);
            this.txt_tele.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(128, 98);
            this.txt_Nombre.MaxLength = 20;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(252, 27);
            this.txt_Nombre.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "CURP:";
            // 
            // cbb_Usuario
            // 
            this.cbb_Usuario.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Usuario.FormattingEnabled = true;
            this.cbb_Usuario.Location = new System.Drawing.Point(116, 74);
            this.cbb_Usuario.Name = "cbb_Usuario";
            this.cbb_Usuario.Size = new System.Drawing.Size(409, 27);
            this.cbb_Usuario.TabIndex = 1;
            this.cbb_Usuario.SelectedIndexChanged += new System.EventHandler(this.cbb_Usuario_SelectedIndexChanged);
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVolver.BackgroundImage = global::ConexionSQLServer.Properties.Resources._140_1400827_arrow_back_outline_comments_flecha_de_regresar_png;
            this.pictureBoxVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVolver.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(39, 30);
            this.pictureBoxVolver.TabIndex = 26;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(153, 447);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(222, 33);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR EMPLEADO";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Bajas_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexionSQLServer.Properties.Resources.KF;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBoxVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gru_Panel);
            this.Controls.Add(this.cbb_Usuario);
            this.Name = "Bajas_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bajas_Usuarios";
            this.Load += new System.EventHandler(this.Bajas_Usuarios_Load);
            this.gru_Panel.ResumeLayout(false);
            this.gru_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gru_Panel;
        private System.Windows.Forms.TextBox txt_nombre_Emp;
        private System.Windows.Forms.TextBox txt_Curp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_Usuario;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDireccion;
    }
}