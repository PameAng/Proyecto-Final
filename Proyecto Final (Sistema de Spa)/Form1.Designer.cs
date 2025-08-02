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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timerSlideshow = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxSlideshow = new System.Windows.Forms.PictureBox();
            this.btnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnExportarCSV = new Guna.UI2.WinForms.Guna2Button();
            this.BtnElimninar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMostrar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideshow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnExportarCSV);
            this.panel1.Controls.Add(this.BtnElimninar);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.BtnAgendar);
            this.panel1.Controls.Add(this.BtnMostrar);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 934);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBoxSlideshow);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(292, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1397, 934);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // timerSlideshow
            // 
            this.timerSlideshow.Interval = 60;
            this.timerSlideshow.Tick += new System.EventHandler(this.timerSlideshow_Tick);
            // 
            // pictureBoxSlideshow
            // 
            this.pictureBoxSlideshow.BackColor = System.Drawing.Color.Teal;
            this.pictureBoxSlideshow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSlideshow.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSlideshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxSlideshow.Name = "pictureBoxSlideshow";
            this.pictureBoxSlideshow.Size = new System.Drawing.Size(1397, 934);
            this.pictureBoxSlideshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSlideshow.TabIndex = 0;
            this.pictureBoxSlideshow.TabStop = false;
            this.pictureBoxSlideshow.Click += new System.EventHandler(this.pictureBoxSlideshow_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalir.FillColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSalir.Location = new System.Drawing.Point(-6, 855);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(292, 78);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarCSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportarCSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportarCSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportarCSV.FillColor = System.Drawing.Color.Black;
            this.btnExportarCSV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportarCSV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExportarCSV.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_exportar_50;
            this.btnExportarCSV.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportarCSV.Location = new System.Drawing.Point(-9, 622);
            this.btnExportarCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(313, 78);
            this.btnExportarCSV.TabIndex = 5;
            this.btnExportarCSV.Text = "Exportar ";
            this.btnExportarCSV.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // BtnElimninar
            // 
            this.BtnElimninar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimninar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimninar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElimninar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnElimninar.FillColor = System.Drawing.Color.Black;
            this.BtnElimninar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimninar.ForeColor = System.Drawing.Color.White;
            this.BtnElimninar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnElimninar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_eliminar_50;
            this.BtnElimninar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnElimninar.Location = new System.Drawing.Point(-1, 504);
            this.BtnElimninar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnElimninar.Name = "BtnElimninar";
            this.BtnElimninar.Size = new System.Drawing.Size(292, 78);
            this.BtnElimninar.TabIndex = 4;
            this.BtnElimninar.Text = "Eliminar";
            this.BtnElimninar.Click += new System.EventHandler(this.BtnElimninar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnActualizar.FillColor = System.Drawing.Color.Black;
            this.BtnActualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnActualizar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_actualizar_carpeta_48;
            this.BtnActualizar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnActualizar.Location = new System.Drawing.Point(-1, 399);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(292, 78);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgendar
            // 
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
            this.BtnAgendar.Location = new System.Drawing.Point(-1, 294);
            this.BtnAgendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAgendar.Name = "BtnAgendar";
            this.BtnAgendar.Size = new System.Drawing.Size(292, 78);
            this.BtnAgendar.TabIndex = 2;
            this.BtnAgendar.Text = "Agendar";
            this.BtnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMostrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMostrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMostrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMostrar.FillColor = System.Drawing.Color.Black;
            this.BtnMostrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.ForeColor = System.Drawing.Color.White;
            this.BtnMostrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnMostrar.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources.icons8_visible_48__1_;
            this.BtnMostrar.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMostrar.Location = new System.Drawing.Point(-9, 180);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(313, 78);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnHome.FillColor = System.Drawing.Color.Black;
            this.BtnHome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnHome.Image = global::Proyecto_Final__Sistema_de_Spa_.Properties.Resources._5099674;
            this.BtnHome.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnHome.Location = new System.Drawing.Point(-21, 62);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(325, 78);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1689, 934);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHome";
            this.Text = "M&P System ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnHome;
        private Guna.UI2.WinForms.Guna2Button BtnElimninar;
        private Guna.UI2.WinForms.Guna2Button BtnActualizar;
        private Guna.UI2.WinForms.Guna2Button BtnAgendar;
        private Guna.UI2.WinForms.Guna2Button BtnMostrar;
        private Guna.UI2.WinForms.Guna2Button btnExportarCSV;
        private Guna.UI2.WinForms.Guna2Button btnSalir;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBoxSlideshow;
        private System.Windows.Forms.Timer timerSlideshow;
    }
}

