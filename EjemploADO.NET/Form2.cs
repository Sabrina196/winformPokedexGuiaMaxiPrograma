using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Negocio;

namespace EjemploADO.NET
{
    public partial class Form2 : Form
    {
        private List<Elemento> ListaElementos;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ActualizarElementos();

        }

        //MÉTODO PARA ACTUALIZAR GRILLA
        public void ActualizarElementos()
        {
            ElementoNegocio NegocioE = new ElementoNegocio();

            ListaElementos = NegocioE.listar();
            dgvElemento.DataSource = ListaElementos;
        }

        private void btnCargarElemento_Click(object sender, EventArgs e)
        {
            Form4 CargaElement = new Form4();
            CargaElement.ShowDialog();
            ActualizarElementos();
        }
    }
}
