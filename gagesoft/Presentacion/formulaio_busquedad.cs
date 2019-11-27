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
    public partial class formulaio_busquedad : Form
    {
        public formulaio_busquedad()
        {
            InitializeComponent();
        }

        private void formulaio_busquedad_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAllcars();

            dgvcarsworks.DataSource = dt;
            dgvcarsworks.Refresh();
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.findcars(txtBusquennoma.text);

            dgvcarsworks.DataSource = dt;
            dgvcarsworks.Refresh();
        }

        private void btnclosewi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
