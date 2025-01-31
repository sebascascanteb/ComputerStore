namespace ComputerStore.Layers.UI
{
    partial class frmMantenimientoApartado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoApartado));
            this.UDCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUbi = new System.Windows.Forms.ComboBox();
            this.txtIdApartado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvApartados = new System.Windows.Forms.DataGridView();
            this.NumApartado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinciaApartado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdComponente = new System.Windows.Forms.TextBox();
            this.listBoxComponentes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxSeleccionados = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartados)).BeginInit();
            this.SuspendLayout();
            // 
            // UDCantidad
            // 
            this.UDCantidad.BackColor = System.Drawing.Color.Plum;
            this.UDCantidad.Enabled = false;
            this.UDCantidad.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDCantidad.ForeColor = System.Drawing.Color.Black;
            this.UDCantidad.Location = new System.Drawing.Point(1681, 382);
            this.UDCantidad.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.UDCantidad.Name = "UDCantidad";
            this.UDCantidad.Size = new System.Drawing.Size(91, 28);
            this.UDCantidad.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Plum;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1576, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 24);
            this.label9.TabIndex = 92;
            this.label9.Text = "Cantidad";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.BackColor = System.Drawing.Color.Plum;
            this.chkBox.Checked = true;
            this.chkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox.Enabled = false;
            this.chkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBox.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold);
            this.chkBox.Location = new System.Drawing.Point(1529, 389);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(13, 12);
            this.chkBox.TabIndex = 91;
            this.chkBox.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Plum;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1440, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 90;
            this.label7.Text = "Activo";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.txtId.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.PapayaWhip;
            this.txtId.Location = new System.Drawing.Point(-2, -2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(113, 28);
            this.txtId.TabIndex = 89;
            this.txtId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Plum;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1440, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "Num Componente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Plum;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(1576, 458);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 36);
            this.btnLimpiar.TabIndex = 84;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.Plum;
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivar.Enabled = false;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.Color.Black;
            this.btnDesactivar.Location = new System.Drawing.Point(1762, 521);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(133, 36);
            this.btnDesactivar.TabIndex = 83;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Plum;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Enabled = false;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(1589, 521);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 36);
            this.btnActualizar.TabIndex = 82;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Plum;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(1411, 521);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(124, 36);
            this.btnCrear.TabIndex = 80;
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
            this.label8.Location = new System.Drawing.Point(1, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 79;
            this.label8.Text = "Apartados";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BackColor = System.Drawing.Color.Plum;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtIdUsuario.Location = new System.Drawing.Point(1630, 237);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(227, 28);
            this.txtIdUsuario.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Plum;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1440, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1440, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Provincia Apartado";
            // 
            // cmbUbi
            // 
            this.cmbUbi.BackColor = System.Drawing.Color.Plum;
            this.cmbUbi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUbi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUbi.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUbi.ForeColor = System.Drawing.Color.Black;
            this.cmbUbi.FormattingEnabled = true;
            this.cmbUbi.Location = new System.Drawing.Point(1662, 330);
            this.cmbUbi.Name = "cmbUbi";
            this.cmbUbi.Size = new System.Drawing.Size(156, 29);
            this.cmbUbi.TabIndex = 72;
            // 
            // txtIdApartado
            // 
            this.txtIdApartado.BackColor = System.Drawing.Color.Plum;
            this.txtIdApartado.Enabled = false;
            this.txtIdApartado.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdApartado.ForeColor = System.Drawing.Color.Black;
            this.txtIdApartado.Location = new System.Drawing.Point(1630, 184);
            this.txtIdApartado.Name = "txtIdApartado";
            this.txtIdApartado.Size = new System.Drawing.Size(227, 28);
            this.txtIdApartado.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1440, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Num Apartado";
            // 
            // dgvApartados
            // 
            this.dgvApartados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvApartados.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumApartado,
            this.IdUsuario,
            this.NumComponente,
            this.Cantidad,
            this.ProvinciaApartado,
            this.Activo});
            this.dgvApartados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvApartados.Location = new System.Drawing.Point(0, 186);
            this.dgvApartados.MultiSelect = false;
            this.dgvApartados.Name = "dgvApartados";
            this.dgvApartados.ReadOnly = true;
            this.dgvApartados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApartados.Size = new System.Drawing.Size(742, 828);
            this.dgvApartados.TabIndex = 69;
            this.dgvApartados.SelectionChanged += new System.EventHandler(this.dvgComponentes_SelectionChanged);
            // 
            // NumApartado
            // 
            this.NumApartado.DataPropertyName = "Id";
            this.NumApartado.FillWeight = 42.8952F;
            this.NumApartado.HeaderText = "Num Apartado";
            this.NumApartado.Name = "NumApartado";
            this.NumApartado.ReadOnly = true;
            this.NumApartado.Width = 92;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.FillWeight = 106.8055F;
            this.IdUsuario.HeaderText = "Usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Width = 68;
            // 
            // NumComponente
            // 
            this.NumComponente.DataPropertyName = "IdComponente";
            this.NumComponente.FillWeight = 135.6676F;
            this.NumComponente.HeaderText = "Num Componente";
            this.NumComponente.Name = "NumComponente";
            this.NumComponente.ReadOnly = true;
            this.NumComponente.Width = 107;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // ProvinciaApartado
            // 
            this.ProvinciaApartado.DataPropertyName = "ProvinciaApartado";
            this.ProvinciaApartado.FillWeight = 105.8213F;
            this.ProvinciaApartado.HeaderText = "Provincia de Apartado";
            this.ProvinciaApartado.Name = "ProvinciaApartado";
            this.ProvinciaApartado.ReadOnly = true;
            this.ProvinciaApartado.Width = 125;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 62;
            // 
            // txtIdComponente
            // 
            this.txtIdComponente.BackColor = System.Drawing.Color.Plum;
            this.txtIdComponente.Enabled = false;
            this.txtIdComponente.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdComponente.ForeColor = System.Drawing.Color.Black;
            this.txtIdComponente.Location = new System.Drawing.Point(1630, 283);
            this.txtIdComponente.Name = "txtIdComponente";
            this.txtIdComponente.Size = new System.Drawing.Size(227, 28);
            this.txtIdComponente.TabIndex = 94;
            // 
            // listBoxComponentes
            // 
            this.listBoxComponentes.BackColor = System.Drawing.Color.Plum;
            this.listBoxComponentes.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComponentes.FormattingEnabled = true;
            this.listBoxComponentes.HorizontalScrollbar = true;
            this.listBoxComponentes.ItemHeight = 18;
            this.listBoxComponentes.Location = new System.Drawing.Point(748, 186);
            this.listBoxComponentes.Name = "listBoxComponentes";
            this.listBoxComponentes.Size = new System.Drawing.Size(649, 310);
            this.listBoxComponentes.TabIndex = 95;
            this.listBoxComponentes.SelectedIndexChanged += new System.EventHandler(this.listBoxComponentes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(748, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 96;
            this.label1.Text = "Componentes";
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.BackColor = System.Drawing.Color.Plum;
            this.listBoxUsuarios.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.HorizontalScrollbar = true;
            this.listBoxUsuarios.ItemHeight = 18;
            this.listBoxUsuarios.Location = new System.Drawing.Point(748, 758);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(649, 256);
            this.listBoxUsuarios.TabIndex = 97;
            this.listBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.listBoxUsuarios_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Plum;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(748, 731);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 98;
            this.label6.Text = "Usuarios";
            // 
            // listBoxSeleccionados
            // 
            this.listBoxSeleccionados.BackColor = System.Drawing.Color.Plum;
            this.listBoxSeleccionados.Font = new System.Drawing.Font("8-bit Operator+", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSeleccionados.FormattingEnabled = true;
            this.listBoxSeleccionados.HorizontalScrollbar = true;
            this.listBoxSeleccionados.ItemHeight = 18;
            this.listBoxSeleccionados.Location = new System.Drawing.Point(748, 524);
            this.listBoxSeleccionados.Name = "listBoxSeleccionados";
            this.listBoxSeleccionados.Size = new System.Drawing.Size(649, 202);
            this.listBoxSeleccionados.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Plum;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(748, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 24);
            this.label10.TabIndex = 100;
            this.label10.Text = "Seleccionados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Plum;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(1273, 478);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 34);
            this.btnAgregar.TabIndex = 101;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Plum;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(1273, 705);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 34);
            this.btnEliminar.TabIndex = 102;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMantenimientoApartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerStore.Properties.Resources.fComponentesResized;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxSeleccionados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxComponentes);
            this.Controls.Add(this.txtIdComponente);
            this.Controls.Add(this.UDCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbUbi);
            this.Controls.Add(this.txtIdApartado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvApartados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoApartado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoApartado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMantenimientoApartado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UDCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUbi;
        private System.Windows.Forms.TextBox txtIdApartado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvApartados;
        private System.Windows.Forms.TextBox txtIdComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumApartado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinciaApartado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.ListBox listBoxComponentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxSeleccionados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}