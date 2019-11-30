﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_ntc_Click(object sender, EventArgs e)
        {
            form_usuario ejl = new form_usuario();
            ejl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsNegPerson np = new clsNegPerson();
            var user = txtUser.Text;
            var contraseña = txtPassword.Text;
            // np.IniciarSesion(user,contraseña);
            if (np.IniciarSesion(user, contraseña))
            {

                var mensaje = string.Format("Bienvenido {0}", txtUser.Text);
                dashboard dhb = new dashboard();
                dhb.Show();
                MessageBox.Show("Entrastes usuario : " + mensaje);
            }
            else {
                MessageBox.Show("No entrastes x gil");
            }


           
        }

        private void lb_ntc_Click_1(object sender, EventArgs e)
        {
            formulario_empleado ejl = new formulario_empleado();
            ejl.Show();
        }
    }
}
