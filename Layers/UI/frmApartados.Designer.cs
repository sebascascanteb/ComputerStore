namespace ComputerStore.Layers.UI
{
    partial class frmApartados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApartados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.cmbTipoComponente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dvgComponentes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComputadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRealizarApartado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.UDCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pbSeleccionado = new System.Windows.Forms.PictureBox();
            this.listBoxApartados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbUbi = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listBoxPreApartados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Controls.Add(this.cmbTipoComponente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 105);
            this.panel1.TabIndex = 57;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Plum;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(178, 52);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 33);
            this.btnFiltrar.TabIndex = 55;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Plum;
            this.pbImagen.Image = global::ComputerStore.Properties.Resources.cpu;
            this.pbImagen.Location = new System.Drawing.Point(278, 8);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(50, 50);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 54;
            this.pbImagen.TabStop = false;
            // 
            // cmbTipoComponente
            // 
            this.cmbTipoComponente.BackColor = System.Drawing.Color.Plum;
            this.cmbTipoComponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComponente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoComponente.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComponente.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoComponente.FormattingEnabled = true;
            this.cmbTipoComponente.Location = new System.Drawing.Point(20, 55);
            this.cmbTipoComponente.Name = "cmbTipoComponente";
            this.cmbTipoComponente.Size = new System.Drawing.Size(137, 29);
            this.cmbTipoComponente.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tipo de Componente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Apartado de Componentes";
            // 
            // dvgComponentes
            // 
            this.dvgComponentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dvgComponentes.BackgroundColor = System.Drawing.Color.Plum;
            this.dvgComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.TipoComponente,
            this.TipoComputadora,
            this.Precio,
            this.Cantidad,
            this.Foto});
            this.dvgComponentes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dvgComponentes.Location = new System.Drawing.Point(373, 1);
            this.dvgComponentes.Name = "dvgComponentes";
            this.dvgComponentes.ReadOnly = true;
            this.dvgComponentes.Size = new System.Drawing.Size(868, 362);
            this.dvgComponentes.TabIndex = 58;
            this.dvgComponentes.SelectionChanged += new System.EventHandler(this.dvgComponentes_SelectionChanged);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 42.8952F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // TipoComponente
            // 
            this.TipoComponente.DataPropertyName = "tipoComponente";
            this.TipoComponente.FillWeight = 106.8055F;
            this.TipoComponente.HeaderText = "Tipo de Componente";
            this.TipoComponente.Name = "TipoComponente";
            this.TipoComponente.ReadOnly = true;
            this.TipoComponente.Width = 120;
            // 
            // TipoComputadora
            // 
            this.TipoComputadora.DataPropertyName = "tipoComputadora";
            this.TipoComputadora.FillWeight = 135.6676F;
            this.TipoComputadora.HeaderText = "Tipo de Computadora";
            this.TipoComputadora.Name = "TipoComputadora";
            this.TipoComputadora.ReadOnly = true;
            this.TipoComputadora.Width = 123;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 105.8213F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Imagen";
            this.Foto.FillWeight = 101.4521F;
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto.Width = 53;
            // 
            // btnRealizarApartado
            // 
            this.btnRealizarApartado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRealizarApartado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarApartado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarApartado.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarApartado.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarApartado.Location = new System.Drawing.Point(1035, 481);
            this.btnRealizarApartado.Name = "btnRealizarApartado";
            this.btnRealizarApartado.Size = new System.Drawing.Size(195, 36);
            this.btnRealizarApartado.TabIndex = 59;
            this.btnRealizarApartado.Text = "Realizar Apartado";
            this.btnRealizarApartado.UseVisualStyleBackColor = false;
            this.btnRealizarApartado.Click += new System.EventHandler(this.btnRealizarApartado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Plum;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(188, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 36);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // UDCantidad
            // 
            this.UDCantidad.BackColor = System.Drawing.Color.Plum;
            this.UDCantidad.Enabled = false;
            this.UDCantidad.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDCantidad.ForeColor = System.Drawing.Color.Black;
            this.UDCantidad.Location = new System.Drawing.Point(130, 193);
            this.UDCantidad.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.UDCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDCantidad.Name = "UDCantidad";
            this.UDCantidad.Size = new System.Drawing.Size(91, 28);
            this.UDCantidad.TabIndex = 74;
            this.UDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Plum;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 73;
            this.label9.Text = "Cantidad";
            // 
            // pbSeleccionado
            // 
            this.pbSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.pbSeleccionado.Image = global::ComputerStore.Properties.Resources.cpu;
            this.pbSeleccionado.Location = new System.Drawing.Point(22, 232);
            this.pbSeleccionado.Name = "pbSeleccionado";
            this.pbSeleccionado.Size = new System.Drawing.Size(160, 160);
            this.pbSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSeleccionado.TabIndex = 71;
            this.pbSeleccionado.TabStop = false;
            // 
            // listBoxApartados
            // 
            this.listBoxApartados.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBoxApartados.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxApartados.FormattingEnabled = true;
            this.listBoxApartados.HorizontalScrollbar = true;
            this.listBoxApartados.ItemHeight = 18;
            this.listBoxApartados.Location = new System.Drawing.Point(345, 436);
            this.listBoxApartados.Name = "listBoxApartados";
            this.listBoxApartados.Size = new System.Drawing.Size(644, 238);
            this.listBoxApartados.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(345, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "Seleccionados";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Plum;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(1124, 641);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 33);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbUbi
            // 
            this.cmbUbi.BackColor = System.Drawing.Color.Plum;
            this.cmbUbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUbi.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUbi.ForeColor = System.Drawing.Color.Black;
            this.cmbUbi.FormattingEnabled = true;
            this.cmbUbi.Location = new System.Drawing.Point(1035, 436);
            this.cmbUbi.Name = "cmbUbi";
            this.cmbUbi.Size = new System.Drawing.Size(137, 29);
            this.cmbUbi.TabIndex = 56;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Plum;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(995, 641);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 33);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBoxPreApartados
            // 
            this.listBoxPreApartados.BackColor = System.Drawing.Color.Plum;
            this.listBoxPreApartados.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPreApartados.FormattingEnabled = true;
            this.listBoxPreApartados.HorizontalScrollbar = true;
            this.listBoxPreApartados.ItemHeight = 18;
            this.listBoxPreApartados.Location = new System.Drawing.Point(2, 436);
            this.listBoxPreApartados.Name = "listBoxPreApartados";
            this.listBoxPreApartados.Size = new System.Drawing.Size(337, 238);
            this.listBoxPreApartados.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 79;
            this.label2.Text = "Pre Apartados";
            // 
            // frmApartados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerStore.Properties.Resources._24365372_6898823res;
            this.ClientSize = new System.Drawing.Size(1243, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPreApartados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbUbi);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxApartados);
            this.Controls.Add(this.UDCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbSeleccionado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnRealizarApartado);
            this.Controls.Add(this.dvgComponentes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApartados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmApartados_FormClosing);
            this.Load += new System.EventHandler(this.frmApartados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.ComboBox cmbTipoComponente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvgComponentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComputadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.Button btnRealizarApartado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown UDCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbSeleccionado;
        private System.Windows.Forms.ListBox listBoxApartados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbUbi;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listBoxPreApartados;
        private System.Windows.Forms.Label label2;
    }
}