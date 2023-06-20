using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjHiperShop
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            Intentos = 0;
        }
        private int i = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 8)
            {
                i = 1;
            }
            string f = @"C:\Users\Mikel Parrales\source\repos\Minisuper\pjHiperShop\bin\Debug\Images\" + i.ToString() + ".png";
            Carrusel.Image = Image.FromFile(f);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("En verdad desea salir de la aplicacion", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();

            }
            else
            {

                MessageBox.Show("Cancelado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private string constring;
        private int contador = 0;
        private int Intentos = 3;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           
 

        }


        private void login()
        {


        }
    }
}

