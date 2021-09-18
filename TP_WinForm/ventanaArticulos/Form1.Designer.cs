
namespace ventanaArticulos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.labelDatosArticulo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.buttonEliminar = new FontAwesome.Sharp.IconButton();
            this.buttonModificar = new FontAwesome.Sharp.IconButton();
            this.buttonAgregar = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconoLupa = new System.Windows.Forms.PictureBox();
            this.buscador = new System.Windows.Forms.TextBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.tituloVentana = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(59, 62);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(133, 115);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 0;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulos.Location = new System.Drawing.Point(30, 191);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.ShowEditingIcon = false;
            this.dgvArticulos.Size = new System.Drawing.Size(469, 215);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // labelDatosArticulo
            // 
            this.labelDatosArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosArticulo.ForeColor = System.Drawing.Color.White;
            this.labelDatosArticulo.Location = new System.Drawing.Point(244, 62);
            this.labelDatosArticulo.Name = "labelDatosArticulo";
            this.labelDatosArticulo.Size = new System.Drawing.Size(212, 115);
            this.labelDatosArticulo.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Location = new System.Drawing.Point(0, 26);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(151, 442);
            this.panelMenu.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panelBotones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 341);
            this.panel2.TabIndex = 3;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.buttonEliminar);
            this.panelBotones.Controls.Add(this.buttonModificar);
            this.panelBotones.Controls.Add(this.buttonAgregar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 184);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(151, 157);
            this.panelBotones.TabIndex = 4;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttonEliminar.IconColor = System.Drawing.Color.White;
            this.buttonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEliminar.IconSize = 40;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(0, 102);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(151, 51);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.MouseLeave += new System.EventHandler(this.buttonEliminar_MouseLeave);
            this.buttonEliminar.MouseHover += new System.EventHandler(this.buttonEliminar_MouseHover);
            // 
            // buttonModificar
            // 
            this.buttonModificar.AutoSize = true;
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonModificar.IconColor = System.Drawing.Color.White;
            this.buttonModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonModificar.IconSize = 40;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(0, 51);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(151, 51);
            this.buttonModificar.TabIndex = 6;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click_1);
            this.buttonModificar.MouseLeave += new System.EventHandler(this.buttonModificar_MouseLeave);
            this.buttonModificar.MouseHover += new System.EventHandler(this.buttonModificar_MouseHover);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.AutoSize = true;
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.buttonAgregar.IconColor = System.Drawing.Color.White;
            this.buttonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAgregar.IconSize = 40;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.Location = new System.Drawing.Point(0, 0);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(151, 51);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click_1);
            this.buttonAgregar.MouseLeave += new System.EventHandler(this.buttonAgregar_MouseLeave);
            this.buttonAgregar.MouseHover += new System.EventHandler(this.buttonAgregar_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.iconoLupa);
            this.panel5.Controls.Add(this.buscador);
            this.panel5.Controls.Add(this.pictureBoxArticulo);
            this.panel5.Controls.Add(this.dgvArticulos);
            this.panel5.Controls.Add(this.labelDatosArticulo);
            this.panel5.Location = new System.Drawing.Point(147, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 442);
            this.panel5.TabIndex = 6;
            // 
            // iconoLupa
            // 
            this.iconoLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoLupa.Image = ((System.Drawing.Image)(resources.GetObject("iconoLupa.Image")));
            this.iconoLupa.Location = new System.Drawing.Point(455, 14);
            this.iconoLupa.Name = "iconoLupa";
            this.iconoLupa.Size = new System.Drawing.Size(25, 27);
            this.iconoLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoLupa.TabIndex = 5;
            this.iconoLupa.TabStop = false;
            this.iconoLupa.Click += new System.EventHandler(this.iconoLupa_Click);
            // 
            // buscador
            // 
            this.buscador.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buscador.Location = new System.Drawing.Point(59, 17);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(390, 20);
            this.buscador.TabIndex = 4;
            this.buscador.Text = "Ingresar nombre de articulo";
            this.buscador.Click += new System.EventHandler(this.buscador_Click);
            this.buscador.Leave += new System.EventHandler(this.buscador_Leave);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(660, 0);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(26, 27);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerrar.TabIndex = 4;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.pictureBoxMinimizar);
            this.panel4.Controls.Add(this.tituloVentana);
            this.panel4.Controls.Add(this.pictureBoxCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 27);
            this.panel4.TabIndex = 7;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(637, 0);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(27, 29);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizar.TabIndex = 4;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // tituloVentana
            // 
            this.tituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVentana.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tituloVentana.Location = new System.Drawing.Point(275, 2);
            this.tituloVentana.Name = "tituloVentana";
            this.tituloVentana.Size = new System.Drawing.Size(137, 23);
            this.tituloVentana.TabIndex = 7;
            this.tituloVentana.Text = "Casa Hogar S.A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 467);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasaHogar S.A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label labelDatosArticulo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tituloVentana;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox iconoLupa;
        private System.Windows.Forms.TextBox buscador;
        private FontAwesome.Sharp.IconButton buttonEliminar;
        private FontAwesome.Sharp.IconButton buttonAgregar;
        private FontAwesome.Sharp.IconButton buttonModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

