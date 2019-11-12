namespace Presentacion
{
    partial class ejemlist
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
            this.dgveje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgveje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgveje
            // 
            this.dgveje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveje.Location = new System.Drawing.Point(31, 25);
            this.dgveje.Name = "dgveje";
            this.dgveje.RowHeadersWidth = 51;
            this.dgveje.RowTemplate.Height = 24;
            this.dgveje.Size = new System.Drawing.Size(744, 404);
            this.dgveje.TabIndex = 0;
            this.dgveje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgveje_CellContentClick);
            // 
            // ejemlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgveje);
            this.Name = "ejemlist";
            this.Text = "ejemlist";
            this.Load += new System.EventHandler(this.ejemlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgveje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgveje;
    }
}