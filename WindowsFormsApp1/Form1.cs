using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarAuto()
        {
            Persona p = new Persona();
            Auto auto = new Auto(p);

            p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;

            string mensaje = auto.CargarAuto(int.Parse(txtPotencia.Text));
            MessageBox.Show(mensaje);
        }
        private void BtnCargar_Click(object sender, EventArgs e)
        {
            CargarAuto();
        }
    }
}
