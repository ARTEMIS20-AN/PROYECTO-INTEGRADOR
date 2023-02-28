
namespace PROYECTO
{
    partial class NuevoReporte_GUI
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
            this.lblNuevoReporte = new System.Windows.Forms.Label();
            this.grbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtTipoDeIncidente = new System.Windows.Forms.TextBox();
            this.lblTipoDeIncidente = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbDescripcion = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbEmpleado.SuspendLayout();
            this.grbDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNuevoReporte
            // 
            this.lblNuevoReporte.AutoSize = true;
            this.lblNuevoReporte.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblNuevoReporte.ForeColor = System.Drawing.Color.White;
            this.lblNuevoReporte.Location = new System.Drawing.Point(219, 22);
            this.lblNuevoReporte.Name = "lblNuevoReporte";
            this.lblNuevoReporte.Size = new System.Drawing.Size(386, 33);
            this.lblNuevoReporte.TabIndex = 0;
            this.lblNuevoReporte.Text = "Nuevo reporte de incidente";
            this.lblNuevoReporte.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbEmpleado
            // 
            this.grbEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.grbEmpleado.Controls.Add(this.txtTipoDeIncidente);
            this.grbEmpleado.Controls.Add(this.lblTipoDeIncidente);
            this.grbEmpleado.Controls.Add(this.txtApellido);
            this.grbEmpleado.Controls.Add(this.dtpFechaHora);
            this.grbEmpleado.Controls.Add(this.txtDepartamento);
            this.grbEmpleado.Controls.Add(this.txtNombre);
            this.grbEmpleado.Controls.Add(this.lblFecha);
            this.grbEmpleado.Controls.Add(this.lblApellido);
            this.grbEmpleado.Controls.Add(this.lblDepartamento);
            this.grbEmpleado.Controls.Add(this.lblNombre);
            this.grbEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.grbEmpleado.ForeColor = System.Drawing.Color.White;
            this.grbEmpleado.Location = new System.Drawing.Point(27, 72);
            this.grbEmpleado.Name = "grbEmpleado";
            this.grbEmpleado.Size = new System.Drawing.Size(830, 210);
            this.grbEmpleado.TabIndex = 1;
            this.grbEmpleado.TabStop = false;
            this.grbEmpleado.Text = "Empleado";
            // 
            // txtTipoDeIncidente
            // 
            this.txtTipoDeIncidente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTipoDeIncidente.Location = new System.Drawing.Point(602, 31);
            this.txtTipoDeIncidente.Name = "txtTipoDeIncidente";
            this.txtTipoDeIncidente.Size = new System.Drawing.Size(196, 28);
            this.txtTipoDeIncidente.TabIndex = 9;
            // 
            // lblTipoDeIncidente
            // 
            this.lblTipoDeIncidente.AutoSize = true;
            this.lblTipoDeIncidente.Location = new System.Drawing.Point(396, 41);
            this.lblTipoDeIncidente.Name = "lblTipoDeIncidente";
            this.lblTipoDeIncidente.Size = new System.Drawing.Size(182, 23);
            this.lblTipoDeIncidente.TabIndex = 8;
            this.lblTipoDeIncidente.Text = "Tipo de incidente:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtApellido.Location = new System.Drawing.Point(116, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 28);
            this.txtApellido.TabIndex = 7;
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dtpFechaHora.Location = new System.Drawing.Point(159, 154);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(207, 28);
            this.dtpFechaHora.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDepartamento.Location = new System.Drawing.Point(585, 110);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(213, 28);
            this.txtDepartamento.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNombre.Location = new System.Drawing.Point(116, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 28);
            this.txtNombre.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 159);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(147, 23);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha y Hora:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(4, 98);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(97, 23);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(396, 115);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(162, 23);
            this.lblDepartamento.TabIndex = 1;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // grbDescripcion
            // 
            this.grbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.grbDescripcion.Controls.Add(this.txtDescripcion);
            this.grbDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.grbDescripcion.ForeColor = System.Drawing.Color.White;
            this.grbDescripcion.Location = new System.Drawing.Point(27, 310);
            this.grbDescripcion.Name = "grbDescripcion";
            this.grbDescripcion.Size = new System.Drawing.Size(830, 78);
            this.grbDescripcion.TabIndex = 10;
            this.grbDescripcion.TabStop = false;
            this.grbDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescripcion.Location = new System.Drawing.Point(10, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(804, 32);
            this.txtDescripcion.TabIndex = 10;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(27, 394);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(86, 33);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(119, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 33);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // NuevoReporte_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(883, 433);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.grbDescripcion);
            this.Controls.Add(this.grbEmpleado);
            this.Controls.Add(this.lblNuevoReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoReporte_GUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NuevoReporte_GUI_Load);
            this.grbEmpleado.ResumeLayout(false);
            this.grbEmpleado.PerformLayout();
            this.grbDescripcion.ResumeLayout(false);
            this.grbDescripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoReporte;
        private System.Windows.Forms.GroupBox grbEmpleado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTipoDeIncidente;
        private System.Windows.Forms.Label lblTipoDeIncidente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

