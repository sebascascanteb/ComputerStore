
namespace ComputerStore.Layers.UI.FrmReportes
{
    partial class frmReporteParaFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteParaFacturacion));
            this.PA_ReporteFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetParaFacturacion = new ComputerStore.Layers.UI.FrmReportes.DataSetParaFacturacion();
            this.PA_ReporteFacturacionTableAdapter = new ComputerStore.Layers.UI.FrmReportes.DataSetParaFacturacionTableAdapters.PA_ReporteFacturacionTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParaFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // PA_ReporteFacturacionBindingSource
            // 
            this.PA_ReporteFacturacionBindingSource.DataMember = "PA_ReporteFacturacion";
            this.PA_ReporteFacturacionBindingSource.DataSource = this.DataSetParaFacturacion;
            // 
            // DataSetParaFacturacion
            // 
            this.DataSetParaFacturacion.DataSetName = "DataSetParaFacturacion";
            this.DataSetParaFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteFacturacionTableAdapter
            // 
            this.PA_ReporteFacturacionTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFacturacion";
            reportDataSource1.Value = this.PA_ReporteFacturacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComputerStore.Layers.UI.FrmReportes.ReportParaFacturacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(699, 641);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteParaFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComputerStore.Properties.Resources._24365372_6898823res;
            this.ClientSize = new System.Drawing.Size(723, 665);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteParaFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteParaFacturacion";
            this.Load += new System.EventHandler(this.frmReporteParaFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetParaFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PA_ReporteFacturacionBindingSource;
        private DataSetParaFacturacion DataSetParaFacturacion;
        private DataSetParaFacturacionTableAdapters.PA_ReporteFacturacionTableAdapter PA_ReporteFacturacionTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}