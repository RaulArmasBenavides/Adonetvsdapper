using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAdo07.View
{
    public partial class Formulario : Form
    {
        private int idusuario = 0;
        public Formulario(int id)
        {
            idusuario = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistraVentas fr = new frmRegistraVentas(idusuario);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmRegistraVentas);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistrarCompras fr = new frmRegistrarCompras();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmRegistrarCompras);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }
            fr.Show();
        }
    }
}
