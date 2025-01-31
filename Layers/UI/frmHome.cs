using ComputerStore.Layers.Entities;
using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI
{
    public partial class frmHome : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        UsuarioDTO usuario = new UsuarioDTO();
        public frmHome()
        {
            InitializeComponent();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                MnuMantenimientos.Visible = false;
                MnuReportes.Visible = false;
                usuario = SesionIniciada.UsuarioIn;
                MnuUsuario.Text = usuario.Nombre.ToString() + " " + usuario.Apellido1.ToString() + " " + usuario.Apellido2.ToString();
                MnuTipoUsuario.Text = usuario.tipoUsuario.ToString();

                if (usuario.IdTipoUsuario == 1)
                {
                    MnuMantenimientos.Visible = true;
                    MnuReportes.Visible = true;
                    MnuApartado.Visible = false;
                    MnuStore.Visible = false;
                }
                if (usuario.IdTipoUsuario == 2)
                {
                    MnuMantenimientos.Visible = false;
                    MnuReportes.Visible = true;
                    MnuApartado.Visible = false;
                    MnuStore.Visible = false;
                }
                if (usuario.IdTipoUsuario == 3)
                {
                    MnuMantenimientos.Visible = false;
                    MnuReportes.Visible = false;
                    MnuApartado.Visible = true;
                    MnuStore.Visible = true;
                }
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

        private void MnuMantenimientos_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMantenimientoUsuario();
            frm.ShowDialog();
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMantenimientoComponente();
            frm.ShowDialog();
        }

        private void munStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void MnuApartado_Click(object sender, EventArgs e)
        {
            var frm = new frmApartados();
            frm.ShowDialog();
        }

        private void MnuMantenimientoComputadoras_Click(object sender, EventArgs e)
        {
            var frm = new frmMantenimientoComputadora();
            frm.ShowDialog();
        }

        private void MnuPcPreensambladas_Click(object sender, EventArgs e)
        {
            var frm = new frmStore();
            frm.ShowDialog();
        }

        private void MnuPcCustom_Click(object sender, EventArgs e)
        {
            var frm = new frmStoreCustom();
            frm.ShowDialog();
        }

        private void MnuMantenimientoApartado_Click(object sender, EventArgs e)
        {

            var frm = new frmMantenimientoApartado();
            frm.ShowDialog();
        }

        private void MnuReporteFactura_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportes.frmReporteFactura();
            frm.ShowDialog();
        }

        private void MnuReporteUsuarios_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportes.frmReporteUsuario();
            frm.ShowDialog();
        }

        private void MnuComponentes_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportes.frmReporteComponentes();
            frm.ShowDialog();
        }
    }
}
