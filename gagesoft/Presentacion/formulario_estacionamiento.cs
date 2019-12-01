using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace Presentacion
{
    public partial class formulario_estacionamiento : Form
    {
        public formulario_estacionamiento()
        {
            InitializeComponent();
        }

        private void formulario_estacionamiento_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncreateparkinglot_Click(object sender, EventArgs e)
        {
            clsNegPerson np = new clsNegPerson();

            var nombrelocal = txtNombrelocal.text;
            var ubicacion = txtUbicacion.text;
            var cobroxhora = float.Parse(txtTarifa.text);
            var lugares = Int32.Parse(txtLugares.text);
            float saldo = 0;
            int coche_actuales = 0;
            var iduser = Presentacion.GlobalVariablesform.usuario_id;

            np.insertParkings(iduser,nombrelocal, ubicacion, cobroxhora, lugares, saldo, coche_actuales);


        }
    }
}
