namespace Presentacion
{
    partial class formularios_carros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularios_carros));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescrip = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtplacasa = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregisauto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPropietario = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtcomcar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Registre un Auto";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescrip.BackgroundImage")));
            this.txtDescrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtDescrip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDescrip.Icon = ((System.Drawing.Image)(resources.GetObject("txtDescrip.Icon")));
            this.txtDescrip.Location = new System.Drawing.Point(567, 216);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(400, 59);
            this.txtDescrip.TabIndex = 25;
            this.txtDescrip.text = "Descripcion";
            // 
            // txtplacasa
            // 
            this.txtplacasa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtplacasa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtplacasa.BackgroundImage")));
            this.txtplacasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtplacasa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtplacasa.Icon = ((System.Drawing.Image)(resources.GetObject("txtplacasa.Icon")));
            this.txtplacasa.Location = new System.Drawing.Point(567, 135);
            this.txtplacasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtplacasa.Name = "txtplacasa";
            this.txtplacasa.Size = new System.Drawing.Size(400, 59);
            this.txtplacasa.TabIndex = 23;
            this.txtplacasa.text = "Placa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 594);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = " En este formulario podra registrar un auto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnregisauto
            // 
            this.btnregisauto.ActiveBorderThickness = 1;
            this.btnregisauto.ActiveCornerRadius = 20;
            this.btnregisauto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnregisauto.ActiveForecolor = System.Drawing.Color.White;
            this.btnregisauto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnregisauto.BackColor = System.Drawing.SystemColors.Control;
            this.btnregisauto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregisauto.BackgroundImage")));
            this.btnregisauto.ButtonText = "Registrar auto";
            this.btnregisauto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregisauto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisauto.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnregisauto.IdleBorderThickness = 1;
            this.btnregisauto.IdleCornerRadius = 20;
            this.btnregisauto.IdleFillColor = System.Drawing.Color.White;
            this.btnregisauto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnregisauto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnregisauto.Location = new System.Drawing.Point(639, 465);
            this.btnregisauto.Margin = new System.Windows.Forms.Padding(5);
            this.btnregisauto.Name = "btnregisauto";
            this.btnregisauto.Size = new System.Drawing.Size(262, 73);
            this.btnregisauto.TabIndex = 32;
            this.btnregisauto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnregisauto.Click += new System.EventHandler(this.btnregisauto_Click);
            // 
            // txtPropietario
            // 
            this.txtPropietario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPropietario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPropietario.BackgroundImage")));
            this.txtPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPropietario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPropietario.Icon = ((System.Drawing.Image)(resources.GetObject("txtPropietario.Icon")));
            this.txtPropietario.Location = new System.Drawing.Point(567, 301);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(400, 59);
            this.txtPropietario.TabIndex = 33;
            this.txtPropietario.text = "Propietario";
            // 
            // txtcomcar
            // 
            this.txtcomcar.FormattingEnabled = true;
            this.txtcomcar.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.txtcomcar.Location = new System.Drawing.Point(567, 403);
            this.txtcomcar.Name = "txtcomcar";
            this.txtcomcar.Size = new System.Drawing.Size(400, 24);
            this.txtcomcar.TabIndex = 34;
            // 
            // formularios_carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 594);
            this.Controls.Add(this.txtcomcar);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.btnregisauto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtplacasa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularios_carros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formularios_carros";
            this.Load += new System.EventHandler(this.formularios_carros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTextbox txtDescrip;
        private Bunifu.Framework.UI.BunifuTextbox txtplacasa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnregisauto;
        private Bunifu.Framework.UI.BunifuTextbox txtPropietario;
        private System.Windows.Forms.ComboBox txtcomcar;
    }
}