namespace PROYECTO.GUI
{
    partial class BOTON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOTON));
            this.ptb_alta = new System.Windows.Forms.PictureBox();
            this.ptb_lupa = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_alta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lupa)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_alta
            // 
            this.ptb_alta.Image = ((System.Drawing.Image)(resources.GetObject("ptb_alta.Image")));
            this.ptb_alta.Location = new System.Drawing.Point(99, 117);
            this.ptb_alta.Name = "ptb_alta";
            this.ptb_alta.Size = new System.Drawing.Size(172, 135);
            this.ptb_alta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_alta.TabIndex = 0;
            this.ptb_alta.TabStop = false;
            // 
            // ptb_lupa
            // 
            this.ptb_lupa.Image = ((System.Drawing.Image)(resources.GetObject("ptb_lupa.Image")));
            this.ptb_lupa.Location = new System.Drawing.Point(363, 117);
            this.ptb_lupa.Name = "ptb_lupa";
            this.ptb_lupa.Size = new System.Drawing.Size(172, 135);
            this.ptb_lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_lupa.TabIndex = 1;
            this.ptb_lupa.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(99, 258);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(172, 59);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(363, 258);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(172, 59);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BOTON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(683, 429);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.ptb_lupa);
            this.Controls.Add(this.ptb_alta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOTON";
            this.Text = "BOTON2";
            this.Load += new System.EventHandler(this.BOTON2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_alta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_alta;
        private System.Windows.Forms.PictureBox ptb_lupa;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_buscar;
    }
}