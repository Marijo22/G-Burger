namespace ConexionSQLServer
{
    partial class IniciarSesion
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxContrasena;
        private System.Windows.Forms.TextBox txtBoxNombreUsuario;
        private System.Windows.Forms.Button btnIniciarSesión;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxContrasena = new System.Windows.Forms.TextBox();
            this.txtBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnIniciarSesión = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Evil Dead", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(286, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "iniciar sesión";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(-5, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 203);
            this.label2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre usuario";
            // 
            // txtBoxContrasena
            // 
            this.txtBoxContrasena.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContrasena.Location = new System.Drawing.Point(320, 278);
            this.txtBoxContrasena.Name = "txtBoxContrasena";
            this.txtBoxContrasena.PasswordChar = '%';
            this.txtBoxContrasena.Size = new System.Drawing.Size(328, 26);
            this.txtBoxContrasena.TabIndex = 2;
            // 
            // txtBoxNombreUsuario
            // 
            this.txtBoxNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreUsuario.Location = new System.Drawing.Point(320, 241);
            this.txtBoxNombreUsuario.Name = "txtBoxNombreUsuario";
            this.txtBoxNombreUsuario.Size = new System.Drawing.Size(328, 26);
            this.txtBoxNombreUsuario.TabIndex = 1;
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesión.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesión.Location = new System.Drawing.Point(320, 339);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Size = new System.Drawing.Size(164, 33);
            this.btnIniciarSesión.TabIndex = 3;
            this.btnIniciarSesión.Text = "iniciar sesión";
            this.btnIniciarSesión.UseVisualStyleBackColor = true;
            this.btnIniciarSesión.Click += new System.EventHandler(this.btnIniciarSesión_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.Image = global::ConexionSQLServer.Properties.Resources.gburgers;
            this.pictureBox1.Location = new System.Drawing.Point(311, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBoxVolver.BackgroundImage = global::ConexionSQLServer.Properties.Resources._140_1400827_arrow_back_outline_comments_flecha_de_regresar_png;
            this.pictureBoxVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVolver.Location = new System.Drawing.Point(41, 35);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(39, 30);
            this.pictureBoxVolver.TabIndex = 26;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(436, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "¿No tienes una cuenta?";
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxVolver);
            this.Controls.Add(this.btnIniciarSesión);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxContrasena);
            this.Controls.Add(this.txtBoxNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
    }
}