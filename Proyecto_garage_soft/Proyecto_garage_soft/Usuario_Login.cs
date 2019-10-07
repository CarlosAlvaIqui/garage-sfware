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
    public partial class Usuario_Login : Form
    {
        public Usuario_Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Login_Load(object sender, EventArgs e)
        {

        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            menu_principal fm = new menu_principal();
            fm.Show();
            this.Hide();
        }
    }
}
