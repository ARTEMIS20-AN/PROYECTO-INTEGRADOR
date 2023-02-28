namespace Interface
{
    partial class LOGIN
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_usu = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.txt_usuari = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_acceder = new System.Windows.Forms.Button();
            this.lkl_olvide = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(578, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usu.ForeColor = System.Drawing.Color.White;
            this.lbl_usu.Location = new System.Drawing.Point(269, 253);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(112, 27);
            this.lbl_usu.TabIndex = 3;
            this.lbl_usu.Text = "USUARIO";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_contraseña.Location = new System.Drawing.Point(242, 392);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(167, 27);
            this.lbl_contraseña.TabIndex = 4;
            this.lbl_contraseña.Text = "CONTRASEÑA";
            // 
            // ptb_logo
            // 
            this.ptb_logo.Image = ((System.Drawing.Image)(resources.GetObject("ptb_logo.Image")));
            this.ptb_logo.Location = new System.Drawing.Point(238, 49);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(181, 126);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_logo.TabIndex = 5;
            this.ptb_logo.TabStop = false;
            // 
            // txt_usuari
            // 
            this.txt_usuari.Location = new System.Drawing.Point(216, 303);
            this.txt_usuari.Multiline = true;
            this.txt_usuari.Name = "txt_usuari";
            this.txt_usuari.Size = new System.Drawing.Size(228, 37);
            this.txt_usuari.TabIndex = 6;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(216, 450);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(228, 37);
            this.txt_contraseña.TabIndex = 7;
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registrar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(335, 562);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(192, 44);
            this.btn_registrar.TabIndex = 9;
            this.btn_registrar.Text = "REGISTAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_acceder
            // 
            this.btn_acceder.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_acceder.FlatAppearance.BorderSize = 0;
            this.btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_acceder.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceder.ForeColor = System.Drawing.Color.White;
            this.btn_acceder.Location = new System.Drawing.Point(128, 562);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(192, 44);
            this.btn_acceder.TabIndex = 10;
            this.btn_acceder.Text = "ACCEDER";
            this.btn_acceder.UseVisualStyleBackColor = true;
            this.btn_acceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lkl_olvide
            // 
            this.lkl_olvide.AutoSize = true;
            this.lkl_olvide.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl_olvide.LinkColor = System.Drawing.Color.White;
            this.lkl_olvide.Location = new System.Drawing.Point(234, 643);
            this.lkl_olvide.Name = "lkl_olvide";
            this.lkl_olvide.Size = new System.Drawing.Size(185, 21);
            this.lkl_olvide.TabIndex = 11;
            this.lkl_olvide.TabStop = true;
            this.lkl_olvide.Text = "olvide mi contraseña";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(644, 697);
            this.Controls.Add(this.lkl_olvide);
            this.Controls.Add(this.btn_acceder);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuari);
            this.Controls.Add(this.ptb_logo);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_usu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_usu;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.TextBox txt_usuari;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_acceder;
        private System.Windows.Forms.LinkLabel lkl_olvide;
    }
}

