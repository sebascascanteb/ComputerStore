
namespace ComputerStore.Layers.UI.FrmReportes
{
    partial class frmReporteUsuario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteUsuario));
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_ReporteUsuariosFiltradoIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteUsuario = new ComputerStore.Layers.UI.FrmReportes.DataSetReporteUsuario();
            this.PA_ReporteUsuariosFiltradoIdTableAdapter = new ComputerStore.Layers.UI.FrmReportes.DataSetReporteUsuarioTableAdapters.PA_ReporteUsuariosFiltradoIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteUsuariosFiltradoIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtId.Font = new System.Drawing.Font("8-bit Operator+", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(1049, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(227, 28);
            this.txtId.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(881, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Identificación";
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFoto.Location = new System.Drawing.Point(1282, 12);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(152, 33);
            this.btnAgregarFoto.TabIndex = 69;
            this.btnAgregarFoto.Text = "Filtrar";
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetUsuario";
            reportDataSource1.Value = this.PA_ReporteUsuariosFiltradoIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComputerStore.Layers.UI.FrmReportes.ReportUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1422, 591);
            this.reportViewer1.TabIndex = 70;
            // 
            // PA_ReporteUsuariosFiltradoIdBindingSource
            // 
            this.PA_ReporteUsuariosFiltradoIdBindingSource.DataMember = "PA_ReporteUsuariosFiltradoId";
            this.PA_ReporteUsuariosFiltradoIdBindingSource.DataSource = this.DataSetReporteUsuario;
            // 
            // DataSetReporteUsuario
            // 
            this.DataSetReporteUsuario.DataSetName = "DataSetReporteUsuario";
            this.DataSetReporteUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteUsuariosFiltradoIdTableAdapter
            // 
            this.PA_ReporteUsuariosFiltradoIdTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerStore.Properties.Resources._24365372_6898823res;
            this.ClientSize = new System.Drawing.Size(1446, 654);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnAgregarFoto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReporteUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteUsuario";
            this.Load += new System.EventHandler(this.frmReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteUsuariosFiltradoIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarFoto;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_ReporteUsuariosFiltradoIdBindingSource;
        private DataSetReporteUsuario DataSetReporteUsuario;
        private DataSetReporteUsuarioTableAdapters.PA_ReporteUsuariosFiltradoIdTableAdapter PA_ReporteUsuariosFiltradoIdTableAdapter;
    }
}