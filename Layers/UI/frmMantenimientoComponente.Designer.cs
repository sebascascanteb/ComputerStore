namespace ComputerStore.Layers.UI
{
    partial class frmMantenimientoComponente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoComponente));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoComponente = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgComponentes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoComputadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkFabricante = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoComputadora = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UDCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(1531, 848);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 36);
            this.btnLimpiar.TabIndex = 59;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.Plum;
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.Color.Black;
            this.btnDesactivar.Location = new System.Drawing.Point(1714, 911);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(133, 36);
            this.btnDesactivar.TabIndex = 58;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(1546, 911);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen.Image = global::ComputerStore.Properties.Resources.hardwareicon;
            this.pbImagen.Location = new System.Drawing.Point(1381, 452);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(466, 371);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 56;
            this.pbImagen.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Plum;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(1366, 911);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(124, 36);
            this.btnCrear.TabIndex = 55;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "Componentes";
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.BackColor = System.Drawing.Color.Plum;
            this.btnAgregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFoto.Location = new System.Drawing.Point(1381, 410);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(152, 33);
            this.btnAgregarFoto.TabIndex = 53;
            this.btnAgregarFoto.Text = "Agregar Foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Plum;
            this.txtPrecio.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(1541, 201);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(227, 28);
            this.txtPrecio.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Plum;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1351, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Precio";
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.Plum;
            this.txtLink.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.ForeColor = System.Drawing.Color.Black;
            this.txtLink.Location = new System.Drawing.Point(1541, 101);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(227, 28);
            this.txtLink.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1351, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Link Fabricante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1351, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 24);
            this.label5.TabIndex = 48;
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
            this.cmbTipoComponente.Location = new System.Drawing.Point(1592, 258);
            this.cmbTipoComponente.Name = "cmbTipoComponente";
            this.cmbTipoComponente.Size = new System.Drawing.Size(137, 29);
            this.cmbTipoComponente.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Plum;
            this.txtNombre.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(1541, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 28);
            this.txtNombre.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1351, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Componente";
            // 
            // dvgComponentes
            // 
            this.dvgComponentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dvgComponentes.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dvgComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComponentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.TipoComponente,
            this.TipoComputadora,
            this.LinkFabricante,
            this.FechaIngreso,
            this.Precio,
            this.Cantidad,
            this.Foto,
            this.Activo});
            this.dvgComponentes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dvgComponentes.Location = new System.Drawing.Point(0, 217);
            this.dvgComponentes.Name = "dvgComponentes";
            this.dvgComponentes.ReadOnly = true;
            this.dvgComponentes.Size = new System.Drawing.Size(1169, 622);
            this.dvgComponentes.TabIndex = 39;
            this.dvgComponentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgComponentes_CellContentClick);
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
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1351, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tipo de Computadora";
            // 
            // cmbTipoComputadora
            // 
            this.cmbTipoComputadora.BackColor = System.Drawing.Color.Plum;
            this.cmbTipoComputadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoComputadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoComputadora.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoComputadora.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoComputadora.FormattingEnabled = true;
            this.cmbTipoComputadora.Location = new System.Drawing.Point(1592, 317);
            this.cmbTipoComputadora.Name = "cmbTipoComputadora";
            this.cmbTipoComputadora.Size = new System.Drawing.Size(137, 29);
            this.cmbTipoComputadora.TabIndex = 60;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("8-bit Operator+", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dtpFecha.CustomFormat = "yyyy/MM/dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(1541, 152);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(227, 20);
            this.dtpFecha.TabIndex = 62;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1351, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fecha Ingreso";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.txtId.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.PapayaWhip;
            this.txtId.Location = new System.Drawing.Point(0, 890);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(113, 28);
            this.txtId.TabIndex = 64;
            this.txtId.Visible = false;
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.BackColor = System.Drawing.Color.Plum;
            this.chkBox.Checked = true;
            this.chkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBox.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold);
            this.chkBox.Location = new System.Drawing.Point(1440, 370);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(13, 12);
            this.chkBox.TabIndex = 66;
            this.chkBox.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Plum;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1351, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Activo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Plum;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1487, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 67;
            this.label9.Text = "Cantidad";
            // 
            // UDCantidad
            // 
            this.UDCantidad.BackColor = System.Drawing.Color.Plum;
            this.UDCantidad.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDCantidad.ForeColor = System.Drawing.Color.Black;
            this.UDCantidad.Location = new System.Drawing.Point(1592, 363);
            this.UDCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UDCantidad.Name = "UDCantidad";
            this.UDCantidad.Size = new System.Drawing.Size(91, 28);
            this.UDCantidad.TabIndex = 68;
            // 
            // frmMantenimientoComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ComputerStore.Properties.Resources.fComponentesResized;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.UDCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoComputadora);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregarFoto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoComponente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgComponentes);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoComponente";
            this.Text = "Mantenimiento Componentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMantenimientoComponente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarFoto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoComponente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgComponentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoComputadora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown UDCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComputadora;
        private System.Windows.Forms.DataGridViewLinkColumn LinkFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}