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
using System.Configuration;
using System.IO;

namespace EjemploADO.NET
{
    public partial class Form3 : Form
    {

        private Pokemon pokemon = null;
        private ValidarImagenUrl imagen = new ValidarImagenUrl();
        //Genera una ventana de dialogo que se va a abrir para elegir un 
        //archivo
        private OpenFileDialog archivo = null;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Pokemon pokemonObtenido)
        {
            InitializeComponent();
            //El pokemon obtenido es que se envio desde el Form1 por parametro desde
            //este constructor 
            pokemon = pokemonObtenido;
            Text = "Modificar Pokemon";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementonegocio = new ElementoNegocio();
            try
            {
                //Llamo 2 veces al método listar, porque son dos desplegables
                //diferentes (Uno para el tipo y otro para la Debilidad), por mas
                //que tengan el mismo tipo de datos
                cboTipo.DataSource = elementonegocio.listar();
                //Le digo al Select cual quiero que sea su clave y su value, porque es 
                //como una especie de colección
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementonegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    imagen.CargarImagen(txtUrlImagen.Text, pbPokeUrlImagen);
                    //Tomo los Id de cada elemento seleccionado del Select
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Pokemon poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if (pokemon == null)
                {
                    pokemon = new Pokemon();
                }

                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
                pokemon.UrlImagen = txtUrlImagen.Text;

                if (pokemon.Id != 0)
                {
                    negocio.Modificar(pokemon);
                    MessageBox.Show("Modificado Exitosamente");
                    Close();
                }
                else
                {
                    negocio.Agregar(pokemon);
                    MessageBox.Show("Agregado Exitosamente");
                   
                }
                 //Si archivo es distinto de null, es porque se almacenó una imagen en archivo
                 //y su ruta NO contiene http, guardo la imagen que se levantó localmente
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    //guardo imagen local
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["poke-images"] + archivo.SafeFileName);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {        
            imagen.CargarImagen(txtUrlImagen.Text, pbPokeUrlImagen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instancio el archivo en null, Indico que tipo de archivo permitido para cargar
            //Primero indico el tipo, el pipe y luego la extensión
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg; | png|*.png";
            //Si se seleccionar la carga de un archivo con el formato permitido entra 
            //a la condición
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                //Cargue la ruta completa en la caja de texto UrlImagen
                txtUrlImagen.Text = archivo.FileName;
                imagen.CargarImagen(archivo.FileName, pbPokeUrlImagen);
           
            }

        }
    }
}
