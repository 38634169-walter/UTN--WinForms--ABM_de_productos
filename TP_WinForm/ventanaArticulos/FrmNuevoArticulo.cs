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

            bool validar = true;
            foreach (Control v in (this.Controls))
            {
                if (v is TextBox)
                {
                    if (v.Text == "")
                    {
                        validar = false;
                        v.ForeColor = Color.White;
                        v.BackColor = Color.Red;
                    }
                    else
                    {
                        v.ForeColor = Color.Black;
                        v.BackColor = System.Drawing.SystemColors.Control;
                    }
                }
            }
            if (validar == true) {
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    if (art == null)
                    {
                        art = new Articulo();
                    }

                    art.codigo = textBoxCodigo.Text;
                    art.nombre = textBoxNombre.Text;
                    art.imagenUrl = textBoxImagen.Text;
                    art.descripcion = textBoxDescripcion.Text;
                    art.precio = Convert.ToDouble(textBoxPrecio.Text);
                    art.marca = (Marca)comboBoxMarca.SelectedItem;
                    art.categoria = (Categoria)comboBoxCategoria.SelectedItem;
                    if (art.id != 0)
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
        }

        private void FrmNuevoArticulo_Load(object sender, EventArgs e)
        {
            pictureBoxVerImagen.Load("https://st4.depositphotos.com/17828278/24401/v/600/depositphotos_244011872-stock-illustration-no-image-vector-symbol-missing.jpg");
            MarcaNegocio mar = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();
            
            comboBoxMarca.DataSource = mar.listar();
            comboBoxMarca.ValueMember = "id";
            comboBoxMarca.DisplayMember = "descripcion";
            comboBoxCategoria.DataSource = cat.listar();
            comboBoxCategoria.ValueMember = "id";
            comboBoxCategoria.DisplayMember = "descripcion";

            if(art != null)
            {
                textBoxCodigo.Text = art.codigo;
                textBoxNombre.Text = art.nombre;
                textBoxImagen.Text = art.imagenUrl;
                textBoxDescripcion.Text = art.descripcion;
                cargar_imagen(art.imagenUrl);
                textBoxPrecio.Text = art.precio.ToString();
                comboBoxMarca.SelectedValue = art.marca.id;
                comboBoxCategoria.SelectedValue = art.categoria.id;
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

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

    }
}
