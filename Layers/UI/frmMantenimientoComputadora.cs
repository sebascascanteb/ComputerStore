using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using log4net;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI
{
    public partial class frmMantenimientoComputadora : Form
    {
        ErrorProvider error = new ErrorProvider();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmMantenimientoComputadora()
        {
            InitializeComponent();
        }

        private void frmMantenimientoComputadora_Load(object sender, EventArgs e)
        {
            RefrescarComputadoras();
            CargarTipoComputadoras();
        }

        private void CargarTipoComputadoras()
        {
            try
            {
                cmbTipoComputadora.DataSource = BLLTipoComputadora.ObtenerTipoComputadoras();
                cmbTipoComputadora.DisplayMember = "Descripcion";
                cmbTipoComputadora.ValueMember = "Id";
                cmbTipoComputadora.SelectedIndex = -1;
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
        private void RefrescarComputadoras()
        {
            try
            {
                // Configuracion del DataGridView para que se vea bien la imagen.
                dgvComputadoras.AutoGenerateColumns = false;
                dgvComputadoras.RowTemplate.Height = 100;
                dgvComputadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dgvComputadoras.DataSource = BLLComputadora.ObtenerComputadoras();
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

        private void dgvComputadoras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                // Validar si hay un fila selecionada
                if (dgvComputadoras.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = (ComputadoraDTO)dgvComputadoras.SelectedRows[0].DataBoundItem;
                    txtId.Text = c.Id.ToString();
                    txtNombre.Text = c.Nombre;
                    cmbTipoComputadora.SelectedValue = c.IdTipoComputadora;
                    txtId.Enabled = false;
                    chkBox.Checked = c.Activo;
                    btnCrear.Enabled = false;
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            error = new ErrorProvider();

            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    error.SetError(txtNombre, "Error, el nombre es requerido");
                    txtNombre.Focus();
                    return;
                }


                if (cmbTipoComputadora.SelectedIndex == -1)
                {
                    error.SetError(cmbTipoComputadora, "Error, debe seleccionar un tipo de Computadora");
                    cmbTipoComputadora.Focus();
                    return;
                }



                BLLComputadora bLLComputadora = new BLLComputadora();
                ComputadoraDTO c = new ComputadoraDTO();


                c.IdTipoComputadora = (cmbTipoComputadora.SelectedItem as TipoComputadora).Id;
                c.Nombre = txtNombre.Text;
                c.Activo = chkBox.Checked;
                bLLComputadora.Guardar(c);

                MessageBox.Show("Guardado", "✔", MessageBoxButtons.OK);


                error = new ErrorProvider();
                error.Clear();

                RefrescarComputadoras();
                limpiarTodo();

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            btnCrear.Enabled = true;
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            error = new ErrorProvider();

            try
            {

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    error.SetError(txtId, "Error,el id es requerido");
                    txtId.Focus();
                    return;
                }
                if (!int.TryParse(txtId.Text, out int resutlt))
                {
                    error.SetError(txtId, "Error, el id debe ser numerico");
                    txtId.Focus();
                    return;
                }


                var resultado = MessageBox.Show("¿Esta seguro?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    BLLComputadora logica = new BLLComputadora();

                    int id = int.Parse(txtId.Text);

                    logica.Desactivar(id);

                    MessageBox.Show("Desactivado", "✔🧺", MessageBoxButtons.OK);
                    txtId.Enabled = true;
                    btnCrear.Enabled = true;

                    RefrescarComputadoras();
                    limpiarTodo();
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

        private void limpiarTodo()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            cmbTipoComputadora.SelectedIndex = -1;
            chkBox.Checked = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            error = new ErrorProvider();

            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    error.SetError(txtNombre, "Error, el nombre es requerido");
                    txtNombre.Focus();
                    return;
                }


                if (cmbTipoComputadora.SelectedIndex == -1)
                {
                    error.SetError(cmbTipoComputadora, "Error, debe seleccionar un tipo de Computadora");
                    cmbTipoComputadora.Focus();
                    return;
                }


                BLLComputadora bLLComputadora = new BLLComputadora();
                ComputadoraDTO c = new ComputadoraDTO();

                c.Id = int.Parse(txtId.Text);
                c.IdTipoComputadora = (cmbTipoComputadora.SelectedItem as TipoComputadora).Id;
                c.Nombre = txtNombre.Text;
                c.Activo = chkBox.Checked;
                bLLComputadora.Guardar(c);

                MessageBox.Show("Actualizado", "✔", MessageBoxButtons.OK);

                btnCrear.Enabled = true;

                error = new ErrorProvider();
                error.Clear();

                RefrescarComputadoras();
                limpiarTodo();
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
    }
}
