using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI.FrmReportes
{
    public partial class frmReporteFactura : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmReporteFactura()
        {
            InitializeComponent();
            
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'DataSetReporteFactura.PA_ReporteFacturaFiltradoFechas' table. You can move, or remove it, as needed.
                this.PA_ReporteFacturaFiltradoFechasTableAdapter.Fill(this.DataSetReporteFactura.PA_ReporteFacturaFiltradoFechas, dtpInicio.Value, dtpFin.Value);

                this.reportViewer1.RefreshReport();

            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Si el contador es 3 cierre la aplicación
                if (contador == 3)
                {
                    // se devuelve Cancel
                    MessageBox.Show("Se equivocó en 3 ocasiones, el Sistema se Cerrará por seguridad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    Application.Exit();
                }
            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            frmReporteFactura_Load(sender, e);
        }
    }
}
