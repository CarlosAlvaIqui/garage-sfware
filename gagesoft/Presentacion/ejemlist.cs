using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ejemlist : Form
    {
        public ejemlist()
        {
            InitializeComponent();
        }

        private void ejemlist_Load(object sender, EventArgs e)
        {
            /*DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgveje.DataSource = dt;
            dgveje.Refresh();*/
        }

        private void dgveje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
