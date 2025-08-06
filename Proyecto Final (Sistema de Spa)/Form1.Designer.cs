namespace Proyecto_Final__Sistema_de_Spa_
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportarCSV = new Guna.UI2.WinForms.Guna2Button();
            this.BtnElimninar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMostrar = new Guna.UI2.WinForms.Guna2Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnExportarCSV);
            this.panel1.Controls.Add(this.BtnElimninar);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.BtnAgendar);
            this.panel1.Controls.Add(this.BtnMostrar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 747);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.BorderColor = System.Drawing.Color.White;
            this.btnSalir.BorderRadius = 10;
            this.btnSalir.BorderThickness = 4;
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalir.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSalir.Location = new System.Drawing.Point(42, 646);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(219, 72);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.BorderColor = System.Drawing.Color.White;
            this.btnExportarCSV.BorderRadius = 10;
            this.btnExportarCSV.BorderThickness = 4;
            this.btnExportarCSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarCSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarCSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportarCSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportarCSV.FillColor = System.Drawing.Color.Black;
            this.btnExportarCSV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportarCSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExportarCSV.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources._5099674;
            this.btnExportarCSV.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportarCSV.Location = new System.Drawing.Point(42, 506);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(219, 74);
            this.btnExportarCSV.TabIndex = 5;
            this.btnExportarCSV.Text = "Exportar ";
            this.btnExportarCSV.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // BtnElimninar
            // 
            this.BtnElimninar.BorderColor = System.Drawing.Color.White;
            this.BtnElimninar.BorderRadius = 10;
            this.BtnElimninar.BorderThickness = 4;
            this.BtnElimninar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimninar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimninar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElimninar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnElimninar.FillColor = System.Drawing.Color.Black;
            this.BtnElimninar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimninar.ForeColor = System.Drawing.Color.White;
            this.BtnElimninar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnElimninar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_eliminar_100;
            this.BtnElimninar.ImageSize = new System.Drawing.Size(55, 45);
            this.BtnElimninar.Location = new System.Drawing.Point(42, 379);
            this.BtnElimninar.Name = "BtnElimninar";
            this.BtnElimninar.Size = new System.Drawing.Size(219, 71);
            this.BtnElimninar.TabIndex = 4;
            this.BtnElimninar.Text = "Eliminar";
            this.BtnElimninar.Click += new System.EventHandler(this.BtnElimninar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BorderColor = System.Drawing.Color.White;
            this.BtnActualizar.BorderRadius = 10;
            this.BtnActualizar.BorderThickness = 4;
            this.BtnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnActualizar.FillColor = System.Drawing.Color.Black;
            this.BtnActualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources._5099674;
            this.BtnActualizar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnActualizar.Location = new System.Drawing.Point(42, 266);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(219, 69);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgendar
            // 
            this.BtnAgendar.BorderColor = System.Drawing.Color.White;
            this.BtnAgendar.BorderRadius = 10;
            this.BtnAgendar.BorderThickness = 4;
            this.BtnAgendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAgendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAgendar.FillColor = System.Drawing.Color.Black;
            this.BtnAgendar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendar.ForeColor = System.Drawing.Color.White;
            this.BtnAgendar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAgendar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_spa_64;
            this.BtnAgendar.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnAgendar.Location = new System.Drawing.Point(42, 35);
            this.BtnAgendar.Name = "BtnAgendar";
            this.BtnAgendar.Size = new System.Drawing.Size(219, 71);
            this.BtnAgendar.TabIndex = 2;
            this.BtnAgendar.Text = "Agendar";
            this.BtnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BorderColor = System.Drawing.Color.White;
            this.BtnMostrar.BorderRadius = 10;
            this.BtnMostrar.BorderThickness = 4;
            this.BtnMostrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMostrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMostrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMostrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMostrar.FillColor = System.Drawing.Color.Black;
            this.BtnMostrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnMostrar.HoverState.BorderColor = System.Drawing.Color.White;
            this.BtnMostrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnMostrar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources._5099674;
            this.BtnMostrar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMostrar.Location = new System.Drawing.Point(42, 140);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(219, 77);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBoxBanner);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(318, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1183, 747);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.Pink;
            this.pictureBoxBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBanner.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(1183, 747);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 0;
            this.pictureBoxBanner.TabStop = false;
            this.pictureBoxBanner.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerBanner
            // 
            this.timerBanner.Enabled = true;
            this.timerBanner.Interval = 3000;
            this.timerBanner.Tick += new System.EventHandler(this.timerBanner_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1501, 747);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmHome";
            this.Text = "M&P System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnElimninar;
        private Guna.UI2.WinForms.Guna2Button BtnActualizar;
        private Guna.UI2.WinForms.Guna2Button BtnAgendar;
        private Guna.UI2.WinForms.Guna2Button BtnMostrar;
        private Guna.UI2.WinForms.Guna2Button btnExportarCSV;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private System.Windows.Forms.Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Timer timerBanner;
    }
}

