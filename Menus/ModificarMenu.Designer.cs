namespace ConexionSQLServer.Menus
{
    partial class ModificarMenu
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
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxCatego = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Evil Dead", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "MODIFICAR MENU";
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVolver.BackgroundImage = global::ConexionSQLServer.Properties.Resources._140_1400827_arrow_back_outline_comments_flecha_de_regresar_png;
            this.pictureBoxVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVolver.Location = new System.Drawing.Point(29, 29);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(39, 30);
            this.pictureBoxVolver.TabIndex = 34;
            this.pictureBoxVolver.TabStop = false;
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Enabled = false;
            this.textBoxImagen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImagen.Location = new System.Drawing.Point(357, 277);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.ReadOnly = true;
            this.textBoxImagen.Size = new System.Drawing.Size(297, 26);
            this.textBoxImagen.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Examinar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxCatego
            // 
            this.comboBoxCatego.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCatego.FormattingEnabled = true;
            this.comboBoxCatego.Items.AddRange(new object[] {
            "Hamburguesas",
            "Bebidas",
            "Combos",
            "Otros"});
            this.comboBoxCatego.Location = new System.Drawing.Point(251, 236);
            this.comboBoxCatego.MaxLength = 20;
            this.comboBoxCatego.Name = "comboBoxCatego";
            this.comboBoxCatego.Size = new System.Drawing.Size(403, 28);
            this.comboBoxCatego.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Imagen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Categoria Hipervinculo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(240, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Evil Dead", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(240, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 34);
            this.button2.TabIndex = 42;
            this.button2.Text = "ACTUALIZAR IMAGEN DE MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModificarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCatego);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxVolver);
            this.Name = "ModificarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarMenu";
            this.Load += new System.EventHandler(this.ModificarMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxCatego;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}