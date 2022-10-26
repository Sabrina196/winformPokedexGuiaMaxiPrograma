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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void btnCancelarEleNuevo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarEleNuevo_Click(object sender, EventArgs e)
        {
            Elemento Element = new Elemento();
            ElementoNegocio negocioE = new ElementoNegocio();

            try
            {
                Element.Descripcion = txtElementoNuevo.Text;
                negocioE.agregar(Element);               
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
