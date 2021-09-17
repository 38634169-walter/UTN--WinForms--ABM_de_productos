using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using modelo;
using negocio;

namespace ventanaArticulos
{

    public partial class FrmNuevoArticulo : Form
    {
        public Articulo art;
        
        public FrmNuevoArticulo()
        {
            InitializeComponent();
        }
        public FrmNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.art=articulo;
            labelTitulo.Text = "Editar Articulo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (art == null) art = new Articulo();

                art.codigo = textBoxImagen.Text;
                art.nombre = textBoxNombre.Text;
                art.imagenUrl = textBoxImagen.Text;
                art.descripcion = textBoxDescripcion.Text;
                art.marca = (Marca)comboBoxMarca.SelectedItem;
                art.categoria = (Categoria)comboBoxCategoria.SelectedItem;
                if(art.id != 0)
                {
                    negocio.modificar(art);
                    MessageBox.Show("Se modifico correctamente");
                }
                else
                {
                    negocio.agregar(art);
                    MessageBox.Show("Articulo Agregado");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmNuevoArticulo_Load(object sender, EventArgs e)
        {
            pictureBoxVerImagen.Load("https://st4.depositphotos.com/17828278/24401/v/600/depositphotos_244011872-stock-illustration-no-image-vector-symbol-missing.jpg");
            Marca mar = new Marca();
            Categoria cat = new Categoria();
            
            //comboBoxMarca.DataSource = mar.listar();
            //comboBoxMarca.ValueMember = "Id";
            //comboBoxMarca.DisplayMember = "Descripcion";
            //comboBoxCategoria.DataSource = cat.listar();
            //comboBoxCategoria.ValueMember = "Id";
            //comboBoxCategoria.DisplayMember = "Descripcion";

            if(art != null)
            {
                textBoxCodigo.Text = art.codigo;
                textBoxNombre.Text = art.nombre;
                textBoxImagen.Text = art.imagenUrl;
                textBoxDescripcion.Text = art.descripcion;
                cargar_imagen(art.imagenUrl);
                comboBoxMarca.SelectedItem = art.marca.id;
                comboBoxCategoria.SelectedItem = art.categoria.id;
            }
        }
        public void cargar_imagen(string imagen)
        {
            try
            {
                pictureBoxVerImagen.Load(imagen);
            }
            catch(Exception)
            {
                pictureBoxVerImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTv1v1-D5ZqOD0pAOpt62RBInPWx9XC5JGgS48pY4SASh_1yNOCTOWSiUHQDA4paJnOLY8&usqp=CAU");
                
            }
        }

        private void textBoxImagen_Leave(object sender, EventArgs e)
        {
            cargar_imagen(textBoxImagen.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
