using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI.FrmReportes
{
    public partial class frmReporteUsuario : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmReporteUsuario()
        {
            InitializeComponent();
        }

        private void frmReporteUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    txtId.Focus();
                    return;
                }
                if (!int.TryParse(txtId.Text, out int resutlt))
                {
                    txtId.Focus();
                    return;
                }
                if (txtId.Text.Length != 9)
                {
                    txtId.Focus();
                    return;
                }
                // TODO: This line of code loads data into the 'DataSetReporteUsuario.PA_ReporteUsuariosFiltradoId' table. You can move, or remove it, as needed.
                this.PA_ReporteUsuariosFiltradoIdTableAdapter.Fill(this.DataSetReporteUsuario.PA_ReporteUsuariosFiltradoId, int.Parse(txtId.Text.ToString()));

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

            frmReporteUsuario_Load(sender, e);
        }
    }
}
