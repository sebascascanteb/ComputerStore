
namespace ComputerStore.Layers.UI.FrmReportes
{
    partial class frmReporteComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteComponentes));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReporteComponente = new ComputerStore.Layers.UI.FrmReportes.DataSetReporteComponente();
            this.PA_ReporteComponentesFiltradoFechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_ReporteComponentesFiltradoFechasTableAdapter = new ComputerStore.Layers.UI.FrmReportes.DataSetReporteComponenteTableAdapters.PA_ReporteComponentesFiltradoFechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteComponente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteComponentesFiltradoFechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(592, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 77;
            this.label1.Text = "Fecha Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("8-bit Operator+", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dtpInicio.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dtpInicio.Location = new System.Drawing.Point(592, 27);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(227, 20);
            this.dtpInicio.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(834, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 75;
            this.label5.Text = "Fecha Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("8-bit Operator+", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFin.CalendarMonthBackground = System.Drawing.Color.Plum;
            this.dtpFin.CalendarTrailingForeColor = System.Drawing.Color.Plum;
            this.dtpFin.Location = new System.Drawing.Point(834, 27);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(227, 20);
            this.dtpFin.TabIndex = 74;
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAgregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("8-bit Operator+", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarFoto.Location = new System.Drawing.Point(1077, 12);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(152, 33);
            this.btnAgregarFoto.TabIndex = 73;
            this.btnAgregarFoto.Text = "Filtrar";
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetComponente";
            reportDataSource1.Value = this.PA_ReporteComponentesFiltradoFechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComputerStore.Layers.UI.FrmReportes.ReportComponente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1217, 541);
            this.reportViewer1.TabIndex = 78;
            // 
            // DataSetReporteComponente
            // 
            this.DataSetReporteComponente.DataSetName = "DataSetReporteComponente";
            this.DataSetReporteComponente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteComponentesFiltradoFechasBindingSource
            // 
            this.PA_ReporteComponentesFiltradoFechasBindingSource.DataMember = "PA_ReporteComponentesFiltradoFechas";
            this.PA_ReporteComponentesFiltradoFechasBindingSource.DataSource = this.DataSetReporteComponente;
            // 
            // PA_ReporteComponentesFiltradoFechasTableAdapter
            // 
            this.PA_ReporteComponentesFiltradoFechasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerStore.Properties.Resources._24365372_6898823res;
            this.ClientSize = new System.Drawing.Size(1241, 606);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.btnAgregarFoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteComponentes";
            this.Load += new System.EventHandler(this.frmReporteComponentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteComponente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteComponentesFiltradoFechasBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource PA_ReporteComponentesFiltradoFechasBindingSource;
        private DataSetReporteComponente DataSetReporteComponente;
        private DataSetReporteComponenteTableAdapters.PA_ReporteComponentesFiltradoFechasTableAdapter PA_ReporteComponentesFiltradoFechasTableAdapter;
    }
}