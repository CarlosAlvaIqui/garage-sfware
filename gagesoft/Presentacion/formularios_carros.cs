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
    public partial class formularios_carros : Form
    {
        public formularios_carros()
        {
            InitializeComponent();
        }

        private void formularios_carros_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnregisauto_Click(object sender, EventArgs e)
        {
            clsNegPerson np = new clsNegPerson();
         
            var placa = txtplacasa.text;
            var descripcion = txtDescrip.text;
            var propietario = txtPropietario.text;
            var tipoauto = 0;
            var horini = DateTime.Now;
            GlobalVariablesform.horaini = horini;
            if (txtcomcar.Text == "Carro") {
                tipoauto = 1;
            } else if (txtcomcar.Text == "Moto") {
                tipoauto = 2;
            }
            else {
                tipoauto = 3;
            }




            MessageBox.Show("Se guardo correctamente" + placa);
            np.insertcars(placa, descripcion,propietario,tipoauto);
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
