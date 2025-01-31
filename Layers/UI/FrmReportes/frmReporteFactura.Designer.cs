
namespace ComputerStore.Layers.UI.FrmReportes
{
    partial class frmReporteFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteFactura));
            this.PA_ReporteFacturaFiltradoFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteFactura = new ComputerStore.Layers.UI.FrmReportes.DataSetReporteFactura();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_ReporteFacturaFiltradoFechasTableAdapter = new ComputerStore.Layers.UI.FrmReportes.DataSetReporteFacturaTableAdapters.PA_ReporteFacturaFiltradoFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteFacturaFiltradoFechasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_ReporteFacturaFiltradoFechasBindingSource
            // 
            this.PA_ReporteFacturaFiltradoFechasBindingSource.DataMember = "PA_ReporteFacturaFiltradoFechas";
            this.PA_ReporteFacturaFiltradoFechasBindingSource.DataSource = this.DataSetReporteFactura;
            // 
            // DataSetReporteFactura
            // 
            this.DataSetReporteFactura.DataSetName = "DataSetReporteFactura";
            this.DataSetReporteFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(508, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Fecha Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("8-bit Operator+", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dtpInicio.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dtpInicio.Location = new System.Drawing.Point(508, 31);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(227, 20);
            this.dtpInicio.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(750, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Fecha Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("8-bit Operator+", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFin.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dtpFin.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dtpFin.Location = new System.Drawing.Point(750, 31);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(227, 20);
            this.dtpFin.TabIndex = 69;
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFoto.Location = new System.Drawing.Point(993, 16);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(152, 33);
            this.btnAgregarFoto.TabIndex = 68;
            this.btnAgregarFoto.Text = "Filtrar";
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.PA_ReporteFacturaFiltradoFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComputerStore.Layers.UI.FrmReportes.ReportFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1132, 524);
            this.reportViewer1.TabIndex = 73;
            // 
            // PA_ReporteFacturaFiltradoFechasTableAdapter
            // 
            this.PA_ReporteFacturaFiltradoFechasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerStore.Properties.Resources._24365372_6898823res;
            this.ClientSize = new System.Drawing.Size(1156, 593);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.btnAgregarFoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteFactura";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteFacturaFiltradoFechasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnAgregarFoto;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_ReporteFacturaFiltradoFechasBindingSource;
        private DataSetReporteFactura DataSetReporteFactura;
        private DataSetReporteFacturaTableAdapters.PA_ReporteFacturaFiltradoFechasTableAdapter PA_ReporteFacturaFiltradoFechasTableAdapter;
    }
}