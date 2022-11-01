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
    public partial class Form1 : Form
    {
        //Creamos un atributo privado para guardar los datos que extraemos de la BD para poder
        //manipular esos datos
        private List<Pokemon> ListaPokemon;

        ValidarImagenUrl Imagen = new ValidarImagenUrl();

        MetodoNumero objNumero = new MetodoNumero();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            //Capturamos el elemento seleccionado de la grilla. El currentRow toma la fila actual seleccionada.
            //Entonces decimos practicamente de la grilla mencionada, con este registro seleccionado devolveme el objeto enlazado a ese evento
            //***Con un casteo explicito estamos diciendo que queremos convertir de manera explicita a tipo Pokemon (porque se que es un Pokemon)
            //y lo almacenamos en la variable "seleccionado"***

            if (dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                //CargarImagen(seleccionado.UrlImagen);
                Imagen.CargarImagen(seleccionado.UrlImagen, pbPokemon);
            }

        }

        //Metodo privado para capturar, en los dos eventos, el error de cuando un registro no tiene una imagen almacenada,
        //que recibe por parámetro la url imagen.Sino encuentra la url, carga una por defecto.
        //private void CargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbPokemon.Load(imagen);
        //    }
        //    catch (Exception e)
        //    {

        //        pbPokemon.Load("https://media.istockphoto.com/vectors/thumbnail-image-vector-graphic-vector-id1147544807?k=20&m=1147544807&s=612x612&w=0&h=pBhz1dkwsCMq37Udtp9sfxbjaMl27JUapoyYpQm0anc=");
        //    }
        //}

        private void TlsElementos_Click(object sender, EventArgs e)
        {
            Form2 ventanaElementos = new Form2();
            ventanaElementos.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form3 alta = new Form3();
            alta.ShowDialog();
            Actualizar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            //Al Pokemon "seleccionado" se lo voy a pasar por parametro con el
            //constructor de la clase que le creamos al Form3
            Form3 modificar = new Form3(seleccionado);
            modificar.ShowDialog();
            Actualizar();
        }

        private void btnEliminarF_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> ListaFiltrada;
            string Filtro = txtFiltro.Text;

            if (Filtro.Length >= 3)
            {
                //Usamos la expresión Lambda
                ListaFiltrada = ListaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(Filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(Filtro.ToUpper()));

            }
            else
            {
                ListaFiltrada = ListaPokemon;
            }
            //Limpiamos el dgv de la lista anterior para luego cargarla con los datos
            //que contiene la Lista Filtrada
            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = ListaFiltrada;
            OcultarColumnas();

        }
        
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMensajeCampo.Text = "";
            lblMensajeCriterio.Text = "";
            lblMensajeFiltro.Text = "";

            string opcion = cboCampo.SelectedItem.ToString();


            if (opcion == "Número")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Mayor a");

            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comience con");
                cboCriterio.Items.Add("Contiene ");
                cboCriterio.Items.Add("Termine con");
            }

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cboCriterio.SelectedIndex < 0))
            {
                lblMensajeCampo.Text = "";
                lblMensajeCriterio.Text = "";
                lblMensajeFiltro.Text = "";
            }
        }

        private void txtFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {
            lblMensajeFiltro.Text = "";
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negociofiltro = new PokemonNegocio();
            try
            {
                lblMensajeCampo.Text = "";
                lblMensajeCriterio.Text = "";
                lblMensajeFiltro.Text = "";

                if (validarfiltro())
                {
                    return;
                } 

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvPokemon.DataSource = negociofiltro.Filtrar(campo, criterio, filtro);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    

        //****MÉTODOS****

        //Método para Actualizar la grilla 
        private void Actualizar()
        {
            //Accedemos a los datos
            PokemonNegocio negocio = new PokemonNegocio();
            //A la grilla de datos, le agrego a negocio el metodo lista para que me devuelva datos de la DB
            //dgvPokemon.DataSource = negocio.Listar(); --> De esta manera no podemos manuipular datos, solo mostrarlos

            ListaPokemon = negocio.Listar();
            dgvPokemon.DataSource = ListaPokemon;
            OcultarColumnas();

            //Cuando se abra la ventana voy a cargar por defecto la imagen del pokemon de la posicion 0,
            ////llamando al metodo CargarImagen(método local)
            //CargarImagen(ListaPokemon[0].UrlImagen);

            Imagen.CargarImagen(ListaPokemon[0].UrlImagen, pbPokemon);
        }

        //Método para ocultar columnas de Id y UrlImagen
        private void OcultarColumnas()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["Id"].Visible = false;
        }

        //Método para validar Filtro
        private bool validarfiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                lblMensajeCampo.Text = "Por favor, seleccione un campo";
                lblMensajeCampo.ForeColor = Color.Red;
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                lblMensajeCriterio.Text ="Por favor, seleccione un criterio";
                lblMensajeCriterio.ForeColor = Color.Red;
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Número")
            {
                string Cadena = txtFiltroAvanzado.Text;
                if (!(objNumero.EsNumero(Cadena)) || Cadena == "")
                {
                    lblMensajeFiltro.Text = "Por favor, ingrese un nùmero";
                    lblMensajeFiltro.ForeColor = Color.Red;
                    return true;
                }

            }
            return false;
        }

        //Método para eliminar registros, ya sea fisica o de forma lógica
        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;

            try
            {
                //Guardo el valor de tipo Dialog Result que devuelve el MessageBox en una variable
                //del mismo tipo para evaluar la respuesta y ejecutar el método Eliminar
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el siguiente Pokemon?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        negocio.EliminarLogico(seleccionado.Id);
                    }
                    else
                    {
                        negocio.Eliminar(seleccionado.Id);
                    }

                    Actualizar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
