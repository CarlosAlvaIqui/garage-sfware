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
    }
}
