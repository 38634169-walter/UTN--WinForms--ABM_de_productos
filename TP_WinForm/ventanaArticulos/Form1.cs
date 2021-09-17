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
            ArticuloNegocio articuloNeg = new ArticuloNegocio();
            listaArticulos = articuloNeg.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["imagenUrl"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = false;
            dgvArticulos.Columns["marca"].Visible = false;
            dgvArticulos.Columns["categoria"].Visible = false;
            dgvArticulos.Columns["precio"].Visible = false;
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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevoArticulo alta = new FrmNuevoArticulo();
            alta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo art =(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmNuevoArticulo ventana = new FrmNuevoArticulo(art);
            ventana.ShowDialog();       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
