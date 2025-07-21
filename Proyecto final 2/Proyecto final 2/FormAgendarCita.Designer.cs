namespace Proyecto_final_2
{
    partial class FormAgendarCita
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.lbServicio = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.lbTerapeuta = new System.Windows.Forms.Label();
            this.txtTerapeuta = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(51, 53);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(56, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(54, 100);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(88, 16);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha y Hora";
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Location = new System.Drawing.Point(149, 100);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHora.TabIndex = 3;
            // 
            // lbServicio
            // 
            this.lbServicio.AutoSize = true;
            this.lbServicio.Location = new System.Drawing.Point(57, 155);
            this.lbServicio.Name = "lbServicio";
            this.lbServicio.Size = new System.Drawing.Size(56, 16);
            this.lbServicio.TabIndex = 4;
            this.lbServicio.Text = "Servicio";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Items.AddRange(new object[] {
            "Masaje",
            "Facial",
            "Manicura"});
            this.cmbServicio.Location = new System.Drawing.Point(120, 155);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 24);
            this.cmbServicio.TabIndex = 5;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // lbTerapeuta
            // 
            this.lbTerapeuta.AutoSize = true;
            this.lbTerapeuta.Location = new System.Drawing.Point(60, 200);
            this.lbTerapeuta.Name = "lbTerapeuta";
            this.lbTerapeuta.Size = new System.Drawing.Size(70, 16);
            this.lbTerapeuta.TabIndex = 6;
            this.lbTerapeuta.Text = "Terapeuta";
            // 
            // txtTerapeuta
            // 
            this.txtTerapeuta.Location = new System.Drawing.Point(137, 200);
            this.txtTerapeuta.Name = "txtTerapeuta";
            this.txtTerapeuta.Size = new System.Drawing.Size(100, 22);
            this.txtTerapeuta.TabIndex = 7;
            this.txtTerapeuta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTerapeuta_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(54, 286);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(594, 58);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(481, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 12;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(281, 162);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(0, 16);
            this.lblDuracion.TabIndex = 13;
            // 
            // FormAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTerapeuta);
            this.Controls.Add(this.lbTerapeuta);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.lbServicio);
            this.Controls.Add(this.dtpFechaHora);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Name = "FormAgendarCita";
            this.Text = "FormAgendarCita";
            this.Load += new System.EventHandler(this.FormAgendarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.Label lbServicio;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label lbTerapeuta;
        private System.Windows.Forms.TextBox txtTerapeuta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDuracion;
    }
}