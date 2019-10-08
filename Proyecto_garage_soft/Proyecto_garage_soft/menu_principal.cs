using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_garage_soft
{
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void Pb_menu_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            vehiculos_administrar va = new vehiculos_administrar();
            va.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            vehiculos_administrar va = new vehiculos_administrar();
            va.Show();
            this.Hide();
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void BtnBuscarAuto_Click(object sender, EventArgs e)
        {
            vehiculos_administrar fm = new vehiculos_administrar();
            fm.Show();
            this.Hide();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void BunifuSwitch1_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            historial his = new historial();
            his.Show();
            this.Hide();
        }
    }
}
