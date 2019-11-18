using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            autos_form af = new autos_form();
            af.Show();
            this.Close();
        }

        private void btnBusquedasss_Click(object sender, EventArgs e)
        {
            /*busqueda_autos ba = new busqueda_autos();
            ba.Show();*/
            formulario_empleado fe = new formulario_empleado();
            fe.Show();
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
        }

        private void btncreateus_Click(object sender, EventArgs e)
        {
            formulario_empleado fe = new formulario_empleado();
            fe.Show();
        }
    }
}
