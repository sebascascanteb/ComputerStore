namespace ComputerStore.Layers.UI
{
    partial class frmStoreCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreCustom));
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComputadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkFabricante = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoComponente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbSeleccionado = new System.Windows.Forms.PictureBox();
            this.UDCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIcono1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbColones = new System.Windows.Forms.RadioButton();
            this.btnPreApartados = new System.Windows.Forms.Button();
            this.listBoxPreApartados = new System.Windows.Forms.ListBox();
            this.btnAgregarPreApartado = new System.Windows.Forms.Button();
            this.listBoxAgregados = new System.Windows.Forms.ListBox();
            this.pbComponenteAgregado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComponenteAgregado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvComponentes.BackgroundColor = System.Drawing.Color.Plum;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.TipoComponente,
            this.TipoComputadora,
            this.LinkFabricante,
            this.FechaIngreso,
            this.Precio,
            this.Cantidad,
            this.Foto});
            this.dgvComponentes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvComponentes.Location = new System.Drawing.Point(0, 241);
            this.dgvComponentes.MultiSelect = false;
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.Size = new System.Drawing.Size(894, 620);
            this.dgvComponentes.TabIndex = 40;
            this.dgvComponentes.SelectionChanged += new System.EventHandler(this.dvgComponentes_SelectionChanged);
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
            // LinkFabricante
            // 
            this.LinkFabricante.DataPropertyName = "LinkFabricante";
            this.LinkFabricante.FillWeight = 66.47623F;
            this.LinkFabricante.HeaderText = "Link";
            this.LinkFabricante.Name = "LinkFabricante";
            this.LinkFabricante.ReadOnly = true;
            this.LinkFabricante.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LinkFabricante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LinkFabricante.Width = 52;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.FillWeight = 140.8818F;
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 92;
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
            // cmbTipoComponente
            // 
            this.cmbTipoComponente.BackColor = System.Drawing.Color.Plum;
            this.cmbTipoComponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComponente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoComponente.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComponente.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoComponente.FormattingEnabled = true;
            this.cmbTipoComponente.Location = new System.Drawing.Point(20, 69);
            this.cmbTipoComponente.Name = "cmbTipoComponente";
            this.cmbTipoComponente.Size = new System.Drawing.Size(137, 29);
            this.cmbTipoComponente.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(770, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1023, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Agregados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "PC Escritorio Custom";
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pbImagen.Image = global::ComputerStore.Properties.Resources.cpu;
            this.pbImagen.Location = new System.Drawing.Point(278, 8);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(50, 50);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 54;
            this.pbImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnCancelarFiltro);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Controls.Add(this.cmbTipoComponente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 876);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 105);
            this.panel1.TabIndex = 55;
            // 
            // btnCancelarFiltro
            // 
            this.btnCancelarFiltro.BackColor = System.Drawing.Color.Plum;
            this.btnCancelarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFiltro.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFiltro.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarFiltro.Location = new System.Drawing.Point(278, 66);
            this.btnCancelarFiltro.Name = "btnCancelarFiltro";
            this.btnCancelarFiltro.Size = new System.Drawing.Size(33, 33);
            this.btnCancelarFiltro.TabIndex = 56;
            this.btnCancelarFiltro.Text = "X";
            this.btnCancelarFiltro.UseVisualStyleBackColor = false;
            this.btnCancelarFiltro.Click += new System.EventHandler(this.btnCancelarFiltro_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Plum;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(178, 66);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(91, 33);
            this.btnFiltrar.TabIndex = 55;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Plum;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(698, 939);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 36);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.Text = " Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbSeleccionado
            // 
            this.pbSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.pbSeleccionado.Image = global::ComputerStore.Properties.Resources.cpu;
            this.pbSeleccionado.Location = new System.Drawing.Point(523, 874);
            this.pbSeleccionado.Name = "pbSeleccionado";
            this.pbSeleccionado.Size = new System.Drawing.Size(160, 160);
            this.pbSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSeleccionado.TabIndex = 56;
            this.pbSeleccionado.TabStop = false;
            // 
            // UDCantidad
            // 
            this.UDCantidad.BackColor = System.Drawing.Color.Plum;
            this.UDCantidad.Enabled = false;
            this.UDCantidad.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDCantidad.ForeColor = System.Drawing.Color.Black;
            this.UDCantidad.Location = new System.Drawing.Point(803, 889);
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
            this.UDCantidad.TabIndex = 70;
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
            this.label9.Location = new System.Drawing.Point(698, 890);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 69;
            this.label9.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(1023, 939);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 36);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(1023, 889);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 36);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(1707, 996);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(185, 36);
            this.btnFinalizarCompra.TabIndex = 73;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(1688, 890);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(204, 28);
            this.txtPrecio.TabIndex = 74;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1568, 892);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 24);
            this.lblTotal.TabIndex = 76;
            this.lblTotal.Text = "SubTotal:";
            // 
            // lblIcono1
            // 
            this.lblIcono1.AutoSize = true;
            this.lblIcono1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblIcono1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIcono1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcono1.ForeColor = System.Drawing.Color.Black;
            this.lblIcono1.Location = new System.Drawing.Point(1663, 892);
            this.lblIcono1.Name = "lblIcono1";
            this.lblIcono1.Size = new System.Drawing.Size(26, 24);
            this.lblIcono1.TabIndex = 77;
            this.lblIcono1.Text = "*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.rdbDolar);
            this.panel2.Controls.Add(this.rdbColones);
            this.panel2.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1795, 924);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 39);
            this.panel2.TabIndex = 81;
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Font = new System.Drawing.Font("8-bit Operator+", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDolar.Location = new System.Drawing.Point(53, 2);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(46, 33);
            this.rdbDolar.TabIndex = 1;
            this.rdbDolar.Text = "$";
            this.rdbDolar.UseVisualStyleBackColor = true;
            this.rdbDolar.CheckedChanged += new System.EventHandler(this.rdbDolar_CheckedChanged);
            // 
            // rdbColones
            // 
            this.rdbColones.AutoSize = true;
            this.rdbColones.Checked = true;
            this.rdbColones.Font = new System.Drawing.Font("8-bit Operator+", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbColones.Location = new System.Drawing.Point(5, 2);
            this.rdbColones.Name = "rdbColones";
            this.rdbColones.Size = new System.Drawing.Size(49, 33);
            this.rdbColones.TabIndex = 0;
            this.rdbColones.TabStop = true;
            this.rdbColones.Text = "₡";
            this.rdbColones.UseVisualStyleBackColor = true;
            this.rdbColones.CheckedChanged += new System.EventHandler(this.rdbColones_CheckedChanged);
            // 
            // btnPreApartados
            // 
            this.btnPreApartados.BackColor = System.Drawing.Color.Plum;
            this.btnPreApartados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreApartados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreApartados.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreApartados.ForeColor = System.Drawing.Color.Black;
            this.btnPreApartados.Location = new System.Drawing.Point(568, 202);
            this.btnPreApartados.Name = "btnPreApartados";
            this.btnPreApartados.Size = new System.Drawing.Size(157, 38);
            this.btnPreApartados.TabIndex = 56;
            this.btnPreApartados.Text = "Pre Apartados";
            this.btnPreApartados.UseVisualStyleBackColor = false;
            this.btnPreApartados.Click += new System.EventHandler(this.btnPreApartados_Click);
            // 
            // listBoxPreApartados
            // 
            this.listBoxPreApartados.BackColor = System.Drawing.Color.Plum;
            this.listBoxPreApartados.Font = new System.Drawing.Font("8-bit Operator+", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPreApartados.FormattingEnabled = true;
            this.listBoxPreApartados.ItemHeight = 17;
            this.listBoxPreApartados.Location = new System.Drawing.Point(0, 64);
            this.listBoxPreApartados.Name = "listBoxPreApartados";
            this.listBoxPreApartados.Size = new System.Drawing.Size(562, 174);
            this.listBoxPreApartados.TabIndex = 82;
            this.listBoxPreApartados.Visible = false;
            // 
            // btnAgregarPreApartado
            // 
            this.btnAgregarPreApartado.BackColor = System.Drawing.Color.Plum;
            this.btnAgregarPreApartado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPreApartado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPreApartado.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPreApartado.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPreApartado.Location = new System.Drawing.Point(568, 163);
            this.btnAgregarPreApartado.Name = "btnAgregarPreApartado";
            this.btnAgregarPreApartado.Size = new System.Drawing.Size(107, 38);
            this.btnAgregarPreApartado.TabIndex = 83;
            this.btnAgregarPreApartado.Text = "Agregar";
            this.btnAgregarPreApartado.UseVisualStyleBackColor = false;
            this.btnAgregarPreApartado.Visible = false;
            this.btnAgregarPreApartado.Click += new System.EventHandler(this.btnAgregarPreApartado_Click);
            // 
            // listBoxAgregados
            // 
            this.listBoxAgregados.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBoxAgregados.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAgregados.FormattingEnabled = true;
            this.listBoxAgregados.HorizontalScrollbar = true;
            this.listBoxAgregados.ItemHeight = 22;
            this.listBoxAgregados.Location = new System.Drawing.Point(1023, 241);
            this.listBoxAgregados.Name = "listBoxAgregados";
            this.listBoxAgregados.Size = new System.Drawing.Size(690, 620);
            this.listBoxAgregados.TabIndex = 85;
            this.listBoxAgregados.SelectedIndexChanged += new System.EventHandler(this.listBoxAgregados_SelectedIndexChanged);
            // 
            // pbComponenteAgregado
            // 
            this.pbComponenteAgregado.BackColor = System.Drawing.Color.Transparent;
            this.pbComponenteAgregado.Image = global::ComputerStore.Properties.Resources.cpu;
            this.pbComponenteAgregado.Location = new System.Drawing.Point(1727, 241);
            this.pbComponenteAgregado.Name = "pbComponenteAgregado";
            this.pbComponenteAgregado.Size = new System.Drawing.Size(165, 165);
            this.pbComponenteAgregado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComponenteAgregado.TabIndex = 86;
            this.pbComponenteAgregado.TabStop = false;
            // 
            // frmStoreCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::ComputerStore.Properties.Resources.fComponentesResized;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pbComponenteAgregado);
            this.Controls.Add(this.listBoxAgregados);
            this.Controls.Add(this.btnAgregarPreApartado);
            this.Controls.Add(this.listBoxPreApartados);
            this.Controls.Add(this.btnPreApartados);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblIcono1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.UDCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbSeleccionado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComponentes);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStoreCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreCustom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStoreCustom_FormClosing);
            this.Load += new System.EventHandler(this.frmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbComponenteAgregado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoComponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComputadora;
        private System.Windows.Forms.DataGridViewLinkColumn LinkFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbSeleccionado;
        private System.Windows.Forms.NumericUpDown UDCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIcono1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.RadioButton rdbColones;
        private System.Windows.Forms.Button btnPreApartados;
        private System.Windows.Forms.ListBox listBoxPreApartados;
        private System.Windows.Forms.Button btnAgregarPreApartado;
        private System.Windows.Forms.ListBox listBoxAgregados;
        private System.Windows.Forms.PictureBox pbComponenteAgregado;
        private System.Windows.Forms.Button btnCancelarFiltro;
    }
}