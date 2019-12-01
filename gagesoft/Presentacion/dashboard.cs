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
            formularios_carros af = new formularios_carros();
            af.Show();
        }

        private void btnBusquedasss_Click(object sender, EventArgs e)
        {
            /*busqueda_autos ba = new busqueda_autos();
            ba.Show();*/
            formulaio_busquedad fb = new formulaio_busquedad();
            fb.Show();  
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
        }

        private void btncreateus_Click(object sender, EventArgs e)
        {
            formulario_empleado fe = new formulario_empleado();
            fe.Show();
        }

        private void btnsitios_Click(object sender, EventArgs e)
        {
            formulario_empleado fe = new formulario_empleado();
            fe.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEstacionamiento_Click(object sender, EventArgs e)
        {
            formulario_estacionamiento fe = new formulario_estacionamiento();
            fe.Show();
        }
    }
}
