namespace Presentacion
{
    partial class formulario_estacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario_estacionamiento));
            this.txtLugares = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarifa = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtUbicacion = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtNombrelocal = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncreateparkinglot = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLugares
            // 
            this.txtLugares.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLugares.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLugares.BackgroundImage")));
            this.txtLugares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtLugares.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtLugares.Icon = ((System.Drawing.Image)(resources.GetObject("txtLugares.Icon")));
            this.txtLugares.Location = new System.Drawing.Point(551, 334);
            this.txtLugares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLugares.Name = "txtLugares";
            this.txtLugares.Size = new System.Drawing.Size(400, 59);
            this.txtLugares.TabIndex = 35;
            this.txtLugares.text = "Lugares";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Crear Estacionamiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTarifa
            // 
            this.txtTarifa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTarifa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTarifa.BackgroundImage")));
            this.txtTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTarifa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTarifa.Icon = ((System.Drawing.Image)(resources.GetObject("txtTarifa.Icon")));
            this.txtTarifa.Location = new System.Drawing.Point(551, 257);
            this.txtTarifa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(400, 59);
            this.txtTarifa.TabIndex = 30;
            this.txtTarifa.text = "Tarifa";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUbicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUbicacion.BackgroundImage")));
            this.txtUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtUbicacion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtUbicacion.Icon = ((System.Drawing.Image)(resources.GetObject("txtUbicacion.Icon")));
            this.txtUbicacion.Location = new System.Drawing.Point(551, 177);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(400, 59);
            this.txtUbicacion.TabIndex = 29;
            this.txtUbicacion.text = "Ubicacion";
            // 
            // txtNombrelocal
            // 
            this.txtNombrelocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombrelocal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombrelocal.BackgroundImage")));
            this.txtNombrelocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtNombrelocal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtNombrelocal.Icon = ((System.Drawing.Image)(resources.GetObject("txtNombrelocal.Icon")));
            this.txtNombrelocal.Location = new System.Drawing.Point(551, 96);
            this.txtNombrelocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrelocal.Name = "txtNombrelocal";
            this.txtNombrelocal.Size = new System.Drawing.Size(400, 59);
            this.txtNombrelocal.TabIndex = 28;
            this.txtNombrelocal.text = "Nombre Local";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 499);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Registre su Estacionamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido ";
            // 
            // btncreateparkinglot
            // 
            this.btncreateparkinglot.ActiveBorderThickness = 1;
            this.btncreateparkinglot.ActiveCornerRadius = 20;
            this.btncreateparkinglot.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btncreateparkinglot.ActiveForecolor = System.Drawing.Color.White;
            this.btncreateparkinglot.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btncreateparkinglot.BackColor = System.Drawing.SystemColors.Control;
            this.btncreateparkinglot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncreateparkinglot.BackgroundImage")));
            this.btncreateparkinglot.ButtonText = "Crear Estacionamiento";
            this.btncreateparkinglot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncreateparkinglot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateparkinglot.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btncreateparkinglot.IdleBorderThickness = 1;
            this.btncreateparkinglot.IdleCornerRadius = 20;
            this.btncreateparkinglot.IdleFillColor = System.Drawing.Color.White;
            this.btncreateparkinglot.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btncreateparkinglot.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btncreateparkinglot.Location = new System.Drawing.Point(617, 409);
            this.btncreateparkinglot.Margin = new System.Windows.Forms.Padding(5);
            this.btncreateparkinglot.Name = "btncreateparkinglot";
            this.btncreateparkinglot.Size = new System.Drawing.Size(262, 73);
            this.btncreateparkinglot.TabIndex = 36;
            this.btncreateparkinglot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncreateparkinglot.Click += new System.EventHandler(this.btncreateparkinglot_Click);
            // 
            // formulario_estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 499);
            this.Controls.Add(this.btncreateparkinglot);
            this.Controls.Add(this.txtLugares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombrelocal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulario_estacionamiento";
            this.Text = "formulario_estacionamiento";
            this.Load += new System.EventHandler(this.formulario_estacionamiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtLugares;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox txtTarifa;
        private Bunifu.Framework.UI.BunifuTextbox txtUbicacion;
        private Bunifu.Framework.UI.BunifuTextbox txtNombrelocal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btncreateparkinglot;
    }
}