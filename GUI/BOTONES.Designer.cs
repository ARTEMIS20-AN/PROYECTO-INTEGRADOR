namespace PROYECTO.GUI
{
    partial class BOTONES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOTONES));
            this.ptb_lupa = new System.Windows.Forms.PictureBox();
            this.lbl_usu = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.ptb_usu = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_usu)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_lupa
            // 
            this.ptb_lupa.Image = ((System.Drawing.Image)(resources.GetObject("ptb_lupa.Image")));
            this.ptb_lupa.Location = new System.Drawing.Point(424, 145);
            this.ptb_lupa.Name = "ptb_lupa";
            this.ptb_lupa.Size = new System.Drawing.Size(245, 158);
            this.ptb_lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_lupa.TabIndex = 1;
            this.ptb_lupa.TabStop = false;
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usu.ForeColor = System.Drawing.Color.White;
            this.lbl_usu.Location = new System.Drawing.Point(291, 62);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(145, 34);
            this.lbl_usu.TabIndex = 4;
            this.lbl_usu.Text = "USUARIOS";
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(118, 309);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(245, 68);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptb_usu
            // 
            this.ptb_usu.Image = ((System.Drawing.Image)(resources.GetObject("ptb_usu.Image")));
            this.ptb_usu.Location = new System.Drawing.Point(118, 145);
            this.ptb_usu.Name = "ptb_usu";
            this.ptb_usu.Size = new System.Drawing.Size(245, 158);
            this.ptb_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_usu.TabIndex = 6;
            this.ptb_usu.TabStop = false;
            this.ptb_usu.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(424, 309);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(245, 68);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BOTONES
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(777, 452);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.ptb_usu);
            this.Controls.Add(this.lbl_usu);
            this.Controls.Add(this.ptb_lupa);
            this.Controls.Add(this.btn_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOTONES";
            this.Text = "BOTONES";
            this.Load += new System.EventHandler(this.BOTONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_usu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_lupa;
        private System.Windows.Forms.Label lbl_usu;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox ptb_usu;
        private System.Windows.Forms.Button btn_buscar;
    }
}