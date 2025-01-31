namespace ComputerStore.Layers.UI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.munStrip = new System.Windows.Forms.MenuStrip();
            this.MnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMantenimientoApartado = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMantenimientoComputadoras = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReporteFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStore = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuComputadoras = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPcCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuApartado = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTipoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MnuComponentes = new System.Windows.Forms.ToolStripMenuItem();
            this.munStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // munStrip
            // 
            this.munStrip.BackColor = System.Drawing.Color.Black;
            this.munStrip.BackgroundImage = global::ComputerStore.Properties.Resources._24365372_6898823res;
            this.munStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMantenimientos,
            this.MnuReportes,
            this.MnuStore,
            this.MnuApartado,
            this.MnuTipoUsuario,
            this.MnuUsuario});
            this.munStrip.Location = new System.Drawing.Point(0, 0);
            this.munStrip.Name = "munStrip";
            this.munStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.munStrip.Size = new System.Drawing.Size(1904, 40);
            this.munStrip.TabIndex = 0;
            this.munStrip.Text = "mnuReportes";
            this.munStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.munStrip_ItemClicked);
            // 
            // MnuMantenimientos
            // 
            this.MnuMantenimientos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.componentesToolStripMenuItem,
            this.MnuMantenimientoApartado,
            this.MnuMantenimientoComputadoras});
            this.MnuMantenimientos.Font = new System.Drawing.Font("8-bit Operator+", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuMantenimientos.Image = global::ComputerStore.Properties.Resources.config;
            this.MnuMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuMantenimientos.Name = "MnuMantenimientos";
            this.MnuMantenimientos.Size = new System.Drawing.Size(235, 36);
            this.MnuMantenimientos.Text = "Mantenimientos";
            this.MnuMantenimientos.Click += new System.EventHandler(this.MnuMantenimientos_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.componentesToolStripMenuItem.Text = "Componentes";
            this.componentesToolStripMenuItem.Click += new System.EventHandler(this.componentesToolStripMenuItem_Click);
            // 
            // MnuMantenimientoApartado
            // 
            this.MnuMantenimientoApartado.Name = "MnuMantenimientoApartado";
            this.MnuMantenimientoApartado.Size = new System.Drawing.Size(242, 30);
            this.MnuMantenimientoApartado.Text = "Apartados";
            this.MnuMantenimientoApartado.Click += new System.EventHandler(this.MnuMantenimientoApartado_Click);
            // 
            // MnuMantenimientoComputadoras
            // 
            this.MnuMantenimientoComputadoras.Name = "MnuMantenimientoComputadoras";
            this.MnuMantenimientoComputadoras.Size = new System.Drawing.Size(242, 30);
            this.MnuMantenimientoComputadoras.Text = "Computadoras";
            this.MnuMantenimientoComputadoras.Click += new System.EventHandler(this.MnuMantenimientoComputadoras_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.BackColor = System.Drawing.Color.Plum;
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuReporteFactura,
            this.MnuReporteUsuarios,
            this.MnuComponentes});
            this.MnuReportes.Font = new System.Drawing.Font("8-bit Operator+", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuReportes.Image = global::ComputerStore.Properties.Resources.report;
            this.MnuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(159, 36);
            this.MnuReportes.Text = "Reportes";
            // 
            // MnuReporteFactura
            // 
            this.MnuReporteFactura.Name = "MnuReporteFactura";
            this.MnuReporteFactura.Size = new System.Drawing.Size(229, 30);
            this.MnuReporteFactura.Text = "Facturas";
            this.MnuReporteFactura.Click += new System.EventHandler(this.MnuReporteFactura_Click);
            // 
            // MnuReporteUsuarios
            // 
            this.MnuReporteUsuarios.Name = "MnuReporteUsuarios";
            this.MnuReporteUsuarios.Size = new System.Drawing.Size(229, 30);
            this.MnuReporteUsuarios.Text = "Usuarios";
            this.MnuReporteUsuarios.Click += new System.EventHandler(this.MnuReporteUsuarios_Click);
            // 
            // MnuStore
            // 
            this.MnuStore.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MnuStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuComputadoras,
            this.MnuPcCustom});
            this.MnuStore.Font = new System.Drawing.Font("8-bit Operator+", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuStore.Image = global::ComputerStore.Properties.Resources.store;
            this.MnuStore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuStore.Name = "MnuStore";
            this.MnuStore.Size = new System.Drawing.Size(120, 36);
            this.MnuStore.Text = "Store";
            // 
            // MnuComputadoras
            // 
            this.MnuComputadoras.Name = "MnuComputadoras";
            this.MnuComputadoras.Size = new System.Drawing.Size(242, 30);
            this.MnuComputadoras.Text = "Computadoras";
            this.MnuComputadoras.Click += new System.EventHandler(this.MnuPcPreensambladas_Click);
            // 
            // MnuPcCustom
            // 
            this.MnuPcCustom.Name = "MnuPcCustom";
            this.MnuPcCustom.Size = new System.Drawing.Size(242, 30);
            this.MnuPcCustom.Text = "Pc Custom";
            this.MnuPcCustom.Click += new System.EventHandler(this.MnuPcCustom_Click);
            // 
            // MnuApartado
            // 
            this.MnuApartado.BackColor = System.Drawing.Color.Plum;
            this.MnuApartado.Font = new System.Drawing.Font("8-bit Operator+", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuApartado.Image = global::ComputerStore.Properties.Resources.reloj;
            this.MnuApartado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuApartado.Name = "MnuApartado";
            this.MnuApartado.Size = new System.Drawing.Size(159, 36);
            this.MnuApartado.Text = "Apartado";
            this.MnuApartado.Click += new System.EventHandler(this.MnuApartado_Click);
            // 
            // MnuTipoUsuario
            // 
            this.MnuTipoUsuario.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MnuTipoUsuario.Enabled = false;
            this.MnuTipoUsuario.Font = new System.Drawing.Font("8-bit Operator+", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuTipoUsuario.Image = global::ComputerStore.Properties.Resources.user32;
            this.MnuTipoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuTipoUsuario.Name = "MnuTipoUsuario";
            this.MnuTipoUsuario.Size = new System.Drawing.Size(104, 36);
            this.MnuTipoUsuario.Text = "***";
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.BackColor = System.Drawing.Color.Plum;
            this.MnuUsuario.Enabled = false;
            this.MnuUsuario.Font = new System.Drawing.Font("8-bit Operator+", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(72, 36);
            this.MnuUsuario.Text = "***";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(763, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 350);
            this.panel2.TabIndex = 2;
            // 
            // MnuComponentes
            // 
            this.MnuComponentes.Name = "MnuComponentes";
            this.MnuComponentes.Size = new System.Drawing.Size(229, 30);
            this.MnuComponentes.Text = "Componentes";
            this.MnuComponentes.Click += new System.EventHandler(this.MnuComponentes_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.munStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.munStrip;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.munStrip.ResumeLayout(false);
            this.munStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip munStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem MnuStore;
        private System.Windows.Forms.ToolStripMenuItem MnuApartado;
        private System.Windows.Forms.ToolStripMenuItem MnuTipoUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimientoComputadoras;
        private System.Windows.Forms.ToolStripMenuItem MnuComputadoras;
        private System.Windows.Forms.ToolStripMenuItem MnuPcCustom;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimientoApartado;
        private System.Windows.Forms.ToolStripMenuItem MnuReporteFactura;
        private System.Windows.Forms.ToolStripMenuItem MnuReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MnuComponentes;
    }
}