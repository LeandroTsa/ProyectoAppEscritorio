using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegocioArticulos;
using DatosArtículos;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            busArticulos negocio = new busArticulos();
            try
            {
                dgvLista.DataSource = negocio.Listararticulos();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
         
                Articulos imgarticulos = (Articulos)dgvLista.CurrentRow.DataBoundItem;
            cargarImagen(imgarticulos.imagenURL);   
          
        }
        private void cargarImagen(string URL)
        {

            try
            {
                pbArticulo.Load(URL);
            }
            catch (Exception )
            {

                pbArticulo.Load("https://previews.123rf.com/images/yoginta/yoginta2301/yoginta230100567/196853824-imagen-no-encontrada-ilustraci%C3%B3n-vectorial.jpg");
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PresentacionDos presentacinDos = new PresentacionDos(); 
            presentacinDos.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PresentacionDos presentacionDos = new PresentacionDos();
            presentacionDos.ShowDialog();
        }
    }
}
