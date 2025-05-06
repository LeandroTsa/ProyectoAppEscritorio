using DatosArtículos;
using NegocioArticulos;
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
    public partial class PresentacionDos : Form
    {
        public PresentacionDos()
        {
            InitializeComponent();
        }

        private void PresentacionDos_Load(object sender, EventArgs e)
        {
            busArticulos busArticulos = new busArticulos();

            try
            {
                cbxMarca.DataSource = busArticulos.Listararticulos();
                cbxCategoria.DataSource = busArticulos.Listararticulos();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
