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
    public partial class formulario_empleado : Form
    {
        public formulario_empleado()
        {
            InitializeComponent();
        }

        private void formulario_empleado_Load(object sender, EventArgs e)
        {

        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {


           /* clsNegPerson np = new clsNegPerson();

            var userr = txtchagetext.text;
            var contraseña = txtContra.text;
            var ubi = txtUbicacion.text;
            var nomesta = txtNombreesta.text;
            var nom = txtNomb.text;
            var dni = Int32.Parse(txrDni.text);
            var cel = Int32.Parse(txtcel.text);
            var tip = txttipo.text;
            var cobrohora = float.Parse(txtcobro.text);


            MessageBox.Show("Se guardo correctamente" + userr);
            np.insertSOMETHING(userr,contraseña,ubi,nomesta,nom,dni,cel,tip, cobrohora);
           */
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
