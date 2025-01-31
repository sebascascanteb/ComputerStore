using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using log4net;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace ComputerStore.Layers.UI
{
    public partial class frmMantenimientoComponente : Form
    {
        ErrorProvider error = new ErrorProvider();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmMantenimientoComponente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CargarTipoComponentes()
        {
            try
            {
                cmbTipoComponente.DataSource = BLLTipoComponente.ObtenerTipoComponentes();
                cmbTipoComponente.DisplayMember = "Descripcion";
                cmbTipoComponente.ValueMember = "Id";
                cmbTipoComponente.SelectedIndex = -1;
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
        private void frmMantenimientoComponente_Load(object sender, EventArgs e)
        {
            RefrescarComponentes();
            CargarTipoComponentes();
            CargarTipoComputadoras();
            dtpFecha.Value = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, 0, 0, 0);


        }

        private void RefrescarComponentes()
        {
            try
            {
                // Configuracion del DataGridView para que se vea bien la imagen.
                dvgComponentes.AutoGenerateColumns = false;
                dvgComponentes.RowTemplate.Height = 100;
                dvgComponentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dvgComponentes.DataSource = BLLComponente.ObtenerComponentes();
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
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {

                    //ruta = opt.FileName.Trim();
                    this.pbImagen.ImageLocation = opt.FileName;
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbImagen.Tag = (byte[])cadenaBytes;

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
            txtNombre.Clear();
            txtLink.Clear();
            txtPrecio.Clear();
            dtpFecha.Value = DateTime.Today;
            cmbTipoComponente.SelectedIndex = -1;
            cmbTipoComputadora.SelectedIndex = -1;
            pbImagen.Image = ComputerStore.Properties.Resources.hardwareicon;
            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            UDCantidad.Value = 0;
            chkBox.Checked = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            btnCrear.Enabled = true;
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
                if (string.IsNullOrEmpty(txtLink.Text))
                {
                    error.SetError(txtLink, "Error, el link es requerido");
                    txtLink.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    error.SetError(txtPrecio, "Error, el precio es requerido");
                    txtPrecio.Focus();
                    return;
                }
                if (!float.TryParse(txtPrecio.Text, out float resutlt))
                {
                    error.SetError(txtPrecio, "Error, el precio debe ser numerico");
                    txtPrecio.Focus();
                    return;
                }
                if (dtpFecha.Value == null)
                {
                    error.SetError(dtpFecha, "Error, la fecha es necesaria");
                    dtpFecha.Focus();
                    return;
                }
                if (cmbTipoComponente.SelectedIndex == -1)
                {
                    error.SetError(cmbTipoComponente, "Error, debe seleccionar un tipo de Componente");
                    cmbTipoComponente.Focus();
                    return;
                }
                if (cmbTipoComputadora.SelectedIndex == -1)
                {
                    error.SetError(cmbTipoComputadora, "Error, debe seleccionar un tipo de Computadora");
                    cmbTipoComputadora.Focus();
                    return;
                }
                if (!(UDCantidad.Value > 0))
                {
                    error.SetError(UDCantidad, "Error, debe agregar minimo 1");
                    UDCantidad.Focus();
                    return;
                }
                if (pbImagen.Tag == null)
                {
                    error.SetError(pbImagen, "Error, debe agregar una Foto");
                    btnAgregarFoto.Focus();
                    return;
                }



                BLLComponente bLLComponente = new BLLComponente();
                ComponenteDTO c = new ComponenteDTO();


                c.IdTipoComputadora = (cmbTipoComputadora.SelectedItem as TipoComputadora).Id;
                c.IdTipoComponente = (cmbTipoComponente.SelectedItem as TipoComponente).Id;
                c.Nombre = txtNombre.Text;
                c.Imagen = (byte[])this.pbImagen.Tag;
                c.LinkFabricante = txtLink.Text;
                c.FechaIngreso = dtpFecha.Value;
                c.Precio = float.Parse(txtPrecio.Text);
                c.Cantidad = Convert.ToInt32(UDCantidad.Value);
                c.Activo = chkBox.Checked;
                bLLComponente.Guardar(c);

                MessageBox.Show("Guardado", "✔", MessageBoxButtons.OK);


                error = new ErrorProvider();
                error.Clear();

                RefrescarComponentes();
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
                if (string.IsNullOrEmpty(txtLink.Text))
                {
                    error.SetError(txtLink, "Error, el link es requerido");
                    txtLink.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    error.SetError(txtPrecio, "Error, el precio es requerido");
                    txtPrecio.Focus();
                    return;
                }
                if (!float.TryParse(txtPrecio.Text, out float resutlt))
                {
                    error.SetError(txtPrecio, "Error, el precio debe ser numerico");
                    txtPrecio.Focus();
                    return;
                }
                if (dtpFecha.Value == null)
                {
                    error.SetError(dtpFecha, "Error, la fecha es necesaria");
                    dtpFecha.Focus();
                    return;
                }
                if (cmbTipoComponente.SelectedIndex == -1)
                {
                    error.SetError(cmbTipoComponente, "Error, debe seleccionar un tipo de Componente");
                    cmbTipoComponente.Focus();
                    return;
                }
                if (cmbTipoComputadora.SelectedIndex == -1)
                {
                    error.SetError(cmbTipoComputadora, "Error, debe seleccionar un tipo de Computadora");
                    cmbTipoComputadora.Focus();
                    return;
                }
                if (pbImagen.Tag == null)
                {
                    error.SetError(pbImagen, "Error, debe agregar una Foto");
                    btnAgregarFoto.Focus();
                    return;
                }


                BLLComponente bLLComponente = new BLLComponente();
                ComponenteDTO c = new ComponenteDTO();

                c.Id = int.Parse(txtId.Text);
                c.IdTipoComputadora = (cmbTipoComputadora.SelectedItem as TipoComputadora).Id;
                c.IdTipoComponente = (cmbTipoComponente.SelectedItem as TipoComponente).Id;
                c.Nombre = txtNombre.Text;
                c.Imagen = (byte[])this.pbImagen.Tag;
                c.LinkFabricante = txtLink.Text;
                c.FechaIngreso = dtpFecha.Value;
                c.Precio = float.Parse(txtPrecio.Text);
                c.Cantidad = Convert.ToInt32(UDCantidad.Value);
                c.Activo = chkBox.Checked;
                if (UDCantidad.Value < 1)
                {
                    c.Activo = false;
                }
                bLLComponente.Guardar(c);

                MessageBox.Show("Actualizado", "✔", MessageBoxButtons.OK);

                btnCrear.Enabled = true;
                error = new ErrorProvider();
                error.Clear();

                RefrescarComponentes();
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

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarTodo();
            btnCrear.Enabled = true;
        }

        private void dvgComponentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                // Validar si hay un fila selecionada
                if (dvgComponentes.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = (ComponenteDTO)dvgComponentes.SelectedRows[0].DataBoundItem;
                    txtId.Text = c.Id.ToString();
                    txtNombre.Text = c.Nombre;
                    txtLink.Text = c.LinkFabricante;
                    txtPrecio.Text = c.Precio.ToString();
                    cmbTipoComponente.SelectedValue = c.IdTipoComponente;
                    cmbTipoComputadora.SelectedValue = c.IdTipoComputadora;
                    pbImagen.Image = new Bitmap(new MemoryStream(c.Imagen));
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbImagen.Tag = c.Imagen;
                    dtpFecha.Value = c.FechaIngreso;
                    txtId.Enabled = false;
                    UDCantidad.Value = c.Cantidad;
                    chkBox.Checked = c.Activo;
                    //btnCrear.Enabled = false;
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

        private void dvgComponentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgComponentes.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                string enlace = dvgComponentes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // Abrir el enlace en una pestaña de navegador
                try
                {
                    System.Diagnostics.Process.Start(enlace);
                }
                catch
                {
                    MessageBox.Show("Link no funcional ❌ \nNecesitas Cambiarlo");
                }

            }
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
                    BLLComponente logica = new BLLComponente();

                    int id = int.Parse(txtId.Text);

                    logica.Desactivar(id);

                    MessageBox.Show("Desactivado", "✔🧺", MessageBoxButtons.OK);
                    txtId.Enabled = true;
                    btnCrear.Enabled = true;

                    RefrescarComponentes();
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
    }
}
