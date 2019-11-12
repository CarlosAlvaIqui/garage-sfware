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
    public partial class busqueda_autos : Form
    {
        public busqueda_autos()
        {
            InitializeComponent();
        }

        private void btnSalirc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
