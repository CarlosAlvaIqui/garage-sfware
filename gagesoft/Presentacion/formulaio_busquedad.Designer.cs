namespace Presentacion
{
    partial class formulaio_busquedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulaio_busquedad));
            this.txtBusquennoma = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnbusqueda = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnlistarmecars = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvcarsworks = new System.Windows.Forms.DataGridView();
            this.btnclosewi = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarsworks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusquennoma
            // 
            this.txtBusquennoma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusquennoma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBusquennoma.BackgroundImage")));
            this.txtBusquennoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBusquennoma.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBusquennoma.Icon = ((System.Drawing.Image)(resources.GetObject("txtBusquennoma.Icon")));
            this.txtBusquennoma.Location = new System.Drawing.Point(33, 56);
            this.txtBusquennoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusquennoma.Name = "txtBusquennoma";
            this.txtBusquennoma.Size = new System.Drawing.Size(707, 59);
            this.txtBusquennoma.TabIndex = 24;
            this.txtBusquennoma.text = "Placa";
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.ActiveBorderThickness = 1;
            this.btnbusqueda.ActiveCornerRadius = 20;
            this.btnbusqueda.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnbusqueda.ActiveForecolor = System.Drawing.Color.White;
            this.btnbusqueda.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnbusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.btnbusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbusqueda.BackgroundImage")));
            this.btnbusqueda.ButtonText = "Buscar";
            this.btnbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusqueda.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnbusqueda.IdleBorderThickness = 1;
            this.btnbusqueda.IdleCornerRadius = 20;
            this.btnbusqueda.IdleFillColor = System.Drawing.Color.White;
            this.btnbusqueda.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnbusqueda.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnbusqueda.Location = new System.Drawing.Point(780, 14);
            this.btnbusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(262, 73);
            this.btnbusqueda.TabIndex = 33;
            this.btnbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // btnlistarmecars
            // 
            this.btnlistarmecars.ActiveBorderThickness = 1;
            this.btnlistarmecars.ActiveCornerRadius = 20;
            this.btnlistarmecars.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnlistarmecars.ActiveForecolor = System.Drawing.Color.White;
            this.btnlistarmecars.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnlistarmecars.BackColor = System.Drawing.SystemColors.Control;
            this.btnlistarmecars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlistarmecars.BackgroundImage")));
            this.btnlistarmecars.ButtonText = "Listar";
            this.btnlistarmecars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistarmecars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistarmecars.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnlistarmecars.IdleBorderThickness = 1;
            this.btnlistarmecars.IdleCornerRadius = 20;
            this.btnlistarmecars.IdleFillColor = System.Drawing.Color.White;
            this.btnlistarmecars.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnlistarmecars.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnlistarmecars.Location = new System.Drawing.Point(780, 83);
            this.btnlistarmecars.Margin = new System.Windows.Forms.Padding(5);
            this.btnlistarmecars.Name = "btnlistarmecars";
            this.btnlistarmecars.Size = new System.Drawing.Size(262, 73);
            this.btnlistarmecars.TabIndex = 34;
            this.btnlistarmecars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvcarsworks
            // 
            this.dgvcarsworks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarsworks.Location = new System.Drawing.Point(33, 232);
            this.dgvcarsworks.Name = "dgvcarsworks";
            this.dgvcarsworks.RowHeadersWidth = 51;
            this.dgvcarsworks.RowTemplate.Height = 24;
            this.dgvcarsworks.Size = new System.Drawing.Size(1009, 423);
            this.dgvcarsworks.TabIndex = 35;
            // 
            // btnclosewi
            // 
            this.btnclosewi.ActiveBorderThickness = 1;
            this.btnclosewi.ActiveCornerRadius = 20;
            this.btnclosewi.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnclosewi.ActiveForecolor = System.Drawing.Color.White;
            this.btnclosewi.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnclosewi.BackColor = System.Drawing.SystemColors.Control;
            this.btnclosewi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclosewi.BackgroundImage")));
            this.btnclosewi.ButtonText = "Cerrrar";
            this.btnclosewi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclosewi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosewi.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnclosewi.IdleBorderThickness = 1;
            this.btnclosewi.IdleCornerRadius = 20;
            this.btnclosewi.IdleFillColor = System.Drawing.Color.White;
            this.btnclosewi.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnclosewi.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnclosewi.Location = new System.Drawing.Point(780, 151);
            this.btnclosewi.Margin = new System.Windows.Forms.Padding(5);
            this.btnclosewi.Name = "btnclosewi";
            this.btnclosewi.Size = new System.Drawing.Size(262, 73);
            this.btnclosewi.TabIndex = 36;
            this.btnclosewi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclosewi.Click += new System.EventHandler(this.btnclosewi_Click);
            // 
            // formulaio_busquedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 681);
            this.Controls.Add(this.btnclosewi);
            this.Controls.Add(this.dgvcarsworks);
            this.Controls.Add(this.btnlistarmecars);
            this.Controls.Add(this.btnbusqueda);
            this.Controls.Add(this.txtBusquennoma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulaio_busquedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulaio_busquedad";
            this.Load += new System.EventHandler(this.formulaio_busquedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarsworks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtBusquennoma;
        private Bunifu.Framework.UI.BunifuThinButton2 btnbusqueda;
        private Bunifu.Framework.UI.BunifuThinButton2 btnlistarmecars;
        private System.Windows.Forms.DataGridView dgvcarsworks;
        private Bunifu.Framework.UI.BunifuThinButton2 btnclosewi;
    }
}