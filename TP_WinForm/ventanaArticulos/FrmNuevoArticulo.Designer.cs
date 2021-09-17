
namespace ventanaArticulos
{
    partial class FrmNuevoArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxVerImagen = new System.Windows.Forms.PictureBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerImagen)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(48, 71);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(48, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // lblNombre
            // 
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(44, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 147);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(68, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxImagen.Location = new System.Drawing.Point(99, 120);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(100, 20);
            this.textBoxImagen.TabIndex = 3;
            this.textBoxImagen.Leave += new System.EventHandler(this.textBoxImagen_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.Location = new System.Drawing.Point(99, 94);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDescripcion.Location = new System.Drawing.Point(99, 147);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(0, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(208, 38);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(277, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxVerImagen);
            this.panel2.Controls.Add(this.comboBoxCategoria);
            this.panel2.Controls.Add(this.comboBoxMarca);
            this.panel2.Controls.Add(this.textBoxCodigo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textBoxDescripcion);
            this.panel2.Controls.Add(this.textBoxImagen);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.textBoxNombre);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 238);
            this.panel2.TabIndex = 8;
            // 
            // pictureBoxVerImagen
            // 
            this.pictureBoxVerImagen.Location = new System.Drawing.Point(261, 59);
            this.pictureBoxVerImagen.Name = "pictureBoxVerImagen";
            this.pictureBoxVerImagen.Size = new System.Drawing.Size(157, 165);
            this.pictureBoxVerImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVerImagen.TabIndex = 15;
            this.pictureBoxVerImagen.TabStop = false;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(99, 201);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategoria.TabIndex = 14;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(99, 173);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 13;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCodigo.Location = new System.Drawing.Point(99, 68);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Url Imagen: ";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria: ";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca: ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelTitulo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(485, 53);
            this.panel5.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Snow;
            this.labelTitulo.ImageKey = "(ninguno)";
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(485, 53);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Agregar articulo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 54);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 38);
            this.panel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAceptar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(277, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 38);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 38);
            this.panel4.TabIndex = 0;
            // 
            // FrmNuevoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(485, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "FrmNuevoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casa Hogar S.A";
            this.Load += new System.EventHandler(this.FrmNuevoArticulo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerImagen)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBoxVerImagen;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}