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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar_form();
        }

        public void cargar_form()
        {
            ArticuloNegocio articuloNeg = new ArticuloNegocio();
            listaArticulos = articuloNeg.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["imagenUrl"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = false;
            dgvArticulos.Columns["marca"].Visible = false;
            dgvArticulos.Columns["categoria"].Visible = false;
            dgvArticulos.Columns["precio"].Visible = false;
            dgvArticulos.Columns["id"].Visible = false;
            mostrar_datos_articulo(listaArticulos[0].imagenUrl,listaArticulos[0].descripcion,listaArticulos[0].precio,listaArticulos[0].marca.descripcion,listaArticulos[0].categoria.descripcion);
        }

        public void mostrar_datos_articulo(string imagen,string descripcion,double precio,string marca,string categoria)
        {
            labelDatosArticulo.Text = "Precio: $" + precio + "\r\n" +
                "Descripcion: " + descripcion + "\r\n" +
                "Marca: " + marca + "\r\n" +
                "Categoria: " + categoria;
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTv1v1-D5ZqOD0pAOpt62RBInPWx9XC5JGgS48pY4SASh_1yNOCTOWSiUHQDA4paJnOLY8&usqp=CAU");
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            mostrar_datos_articulo(art.imagenUrl,art.descripcion,art.precio,art.marca.descripcion,art.categoria.descripcion);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buscador_Click(object sender, EventArgs e)
        {
            buscador.Text = "";
            buscador.ForeColor = Color.Black;
        }

        private void buscador_Leave(object sender, EventArgs e)
        {
            if(buscador.Text == "")
            {
                buscador.Text = "Ingresar nombre de articulo";
            }
            else
            {
                buscar();
            }
        }

        private void iconoLupa_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            string palabra=buscador.Text;
            ArticuloNegocio artNego = new ArticuloNegocio();
            listaArticulos = artNego.buscar(palabra);
            dgvArticulos.DataSource = listaArticulos;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmNuevoArticulo ventana = new FrmNuevoArticulo(art);
                ventana.ShowDialog();
                cargar_form();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAgregar_Click_1(object sender, EventArgs e)
        {
            FrmNuevoArticulo alta = new FrmNuevoArticulo();
            alta.ShowDialog();
            cargar_form();
        }
    }
}

