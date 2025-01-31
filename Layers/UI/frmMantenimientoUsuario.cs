using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using log4net;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI
{
    public partial class frmMantenimientoUsuario : Form
    {
        ErrorProvider error = new ErrorProvider();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmMantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void frmMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            RefrescarUsuarios();
            CargarTipoUsuarios();
        }
        private void RefrescarUsuarios()
        {
            try { 
            // Configuracion del DataGridView para que se vea bien la imagen.
            dvgUsuarios.AutoGenerateColumns = false;
            dvgUsuarios.RowTemplate.Height = 100;
            dvgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dvgUsuarios.DataSource = BLLUsuario.ObtenerUsuarios();
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



        private void CargarTipoUsuarios()
        {
            try { 
            cmbTipoUsuario.DataSource = BLLTipoUsuario.ObtenerTipoUsuarios();
            cmbTipoUsuario.DisplayMember = "Descripcion";
            cmbTipoUsuario.ValueMember = "Id";
            cmbTipoUsuario.SelectedIndex = -1;
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


        private void dvgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                // Validar si hay un fila selecionada
                if (dvgUsuarios.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var us = (UsuarioDTO)dvgUsuarios.SelectedRows[0].DataBoundItem;
                    txtId.Text = us.Id.ToString();
                    txtNombre.Text = us.Nombre;
                    txtApellido1.Text = us.Apellido1;
                    txtApellido2.Text = us.Apellido2;
                    txtEmail.Text = us.Email;
                    txtPassword.Text = null;
                    cmbTipoUsuario.SelectedValue = us.IdTipoUsuario;
                    pbImagen.Image = new Bitmap(new MemoryStream(us.Foto));
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbImagen.Tag = us.Foto;
                    chkBox.Checked = us.Activo;

                    txtId.Enabled = false;
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
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    error.SetError(txtId, "Error, la identificacion es requerida");
                    txtId.Focus();
                    return;
                }
                if (!int.TryParse(txtId.Text, out int resutlt))
                {
                    error.SetError(txtId, "Error, la identificacion debe ser numerica");
                    txtId.Focus();
                    return;
                }
                if (txtId.Text.Length != 9)
                {
                    error.SetError(txtId, "Error, la identificacion debe ser de 9 digitos");
                    txtId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    error.SetError(txtNombre, "Error, el nombre es requerido");
                    txtNombre.Focus();
                    return;
                }
                if (!txtNombre.Text.All(char.IsLetter))
                {
                    error.SetError(txtNombre, "Error, el nombre debe contener solo letras");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido1.Text))
                {
                    error.SetError(txtApellido1, "Error, el apellido1 es requerido");
                    txtApellido1.Focus();
                    return;
                }
                if (!txtApellido1.Text.All(char.IsLetter))
                {
                    error.SetError(txtApellido1, "Error, el apellido debe contener solo letras");
                    txtApellido1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido2.Text))
                {
                    error.SetError(txtApellido2, "Error, el apellido2 es requerido");
                    txtApellido2.Focus();
                    return;
                }
                if (!txtApellido2.Text.All(char.IsLetter))
                {
                    error.SetError(txtApellido2, "Error, el apellido debe contener solo letras");
                    txtApellido2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    error.SetError(txtEmail, "Error, el Email es requerido");
                    txtEmail.Focus();
                    return;
                }
                if (!txtEmail.Text.EndsWith("@", StringComparison.OrdinalIgnoreCase) && !txtEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    error.SetError(txtEmail, "Error, el Email debe tener el formato correcto\n@gmail.com");
                    txtEmail.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    error.SetError(txtPassword, "Error, la contraseña es requerida");
                    txtPassword.Focus();
                    return;
                }
                if (cmbTipoUsuario.SelectedIndex == -1)
                {
                    error.SetError(txtPassword, "Error, debe seleccionar un tipo de usuario");
                    cmbTipoUsuario.Focus();
                    return;
                }
                if (pbImagen.Tag == null)
                {
                    error.SetError(pbImagen, "Error, debe agregar una Foto");
                    btnAgregarFoto.Focus();
                    return;
                }
                


                BLLUsuario bLLUsuario = new BLLUsuario();
                UsuarioDTO us = new UsuarioDTO();


                us.Id = int.Parse(txtId.Text);
                us.IdTipoUsuario = (cmbTipoUsuario.SelectedItem as TipoUsuario).Id;
                us.Nombre = txtNombre.Text;
                us.Apellido1 = txtApellido1.Text;
                us.Apellido2 = txtApellido2.Text;
                us.Email = txtEmail.Text;
                us.Contrasena = txtPassword.Text;
                us.Foto = (byte[])this.pbImagen.Tag;
                us.Activo = chkBox.Checked;
                bLLUsuario.Guardar(us);

                MessageBox.Show("Guardado", "✔", MessageBoxButtons.OK);


                error = new ErrorProvider();
                error.Clear();

                RefrescarUsuarios();
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

        private void limpiarTodo()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
            chkBox.Checked = true;
            pbImagen.Image = ComputerStore.Properties.Resources.userIcon;
            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            error = new ErrorProvider();

            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    error.SetError(txtId, "Error, la identificacion es requerida");
                    txtId.Focus();
                    return;
                }
                if (!int.TryParse(txtId.Text, out int resutlt))
                {
                    error.SetError(txtId, "Error, la identificacion debe ser numerica");
                    txtId.Focus();
                    return;
                }
                if (txtId.Text.Length != 9)
                {
                    error.SetError(txtId, "Error, la identificacion debe ser de 9 digitos");
                    txtId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    error.SetError(txtNombre, "Error, el nombre es requerido");
                    txtNombre.Focus();
                    return;
                }
                if (!txtNombre.Text.All(char.IsLetter))
                {
                    error.SetError(txtNombre, "Error, el nombre debe contener solo letras");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido1.Text))
                {
                    error.SetError(txtApellido1, "Error, el apellido1 es requerido");
                    txtApellido1.Focus();
                    return;
                }
                if (!txtApellido1.Text.All(char.IsLetter))
                {
                    error.SetError(txtApellido1, "Error, el apellido debe contener solo letras");
                    txtApellido1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellido2.Text))
                {
                    error.SetError(txtApellido2, "Error, el apellido2 es requerido");
                    txtApellido2.Focus();
                    return;
                }
                if (!txtApellido2.Text.All(char.IsLetter))
                {
                    error.SetError(txtApellido2, "Error, el apellido debe contener solo letras");
                    txtApellido2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    error.SetError(txtEmail, "Error, el Email es requerido");
                    txtEmail.Focus();
                    return;
                }
                if (!txtEmail.Text.EndsWith("@", StringComparison.OrdinalIgnoreCase) && !txtEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                {
                    error.SetError(txtEmail, "Error, el Email debe tener el formato correcto\n@gmail.com");
                    txtEmail.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    error.SetError(txtPassword, "Error, la contraseña es requerida");
                    txtPassword.Focus();
                    return;
                }
                if (cmbTipoUsuario.SelectedIndex == -1)
                {
                    error.SetError(txtPassword, "Error, debe seleccionar un tipo de usuario");
                    cmbTipoUsuario.Focus();
                    return;
                }
                if (pbImagen.Tag == null)
                {
                    error.SetError(pbImagen, "Error, debe agregar una Foto");
                    btnAgregarFoto.Focus();
                    return;
                }


                BLLUsuario bLLUsuario = new BLLUsuario();
                UsuarioDTO us = new UsuarioDTO();


                us.Id = int.Parse(txtId.Text);
                us.IdTipoUsuario = (cmbTipoUsuario.SelectedItem as TipoUsuario).Id;
                us.Nombre = txtNombre.Text;
                us.Apellido1 = txtApellido1.Text;
                us.Apellido2 = txtApellido2.Text;
                us.Email = txtEmail.Text;
                us.Contrasena = txtPassword.Text;
                us.Foto = (byte[])this.pbImagen.Tag;
                us.Activo = chkBox.Checked;
                bLLUsuario.Guardar(us);

                btnCrear.Enabled = true;
                txtId.Enabled = true;
                MessageBox.Show("Actualizado", "✔", MessageBoxButtons.OK);


                RefrescarUsuarios();
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


        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            btnCrear.Enabled = true;
            txtId.Enabled = true;

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            error = new ErrorProvider();

            try
            {

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    error.SetError(txtId, "Error, la identificacion es requerida");
                    txtId.Focus();
                    return;
                }

                if (!int.TryParse(txtId.Text, out int resutlt))
                {
                    error.SetError(txtId, "Error, la identificacion debe ser numerica");
                    txtId.Focus();
                    return;
                }
                if (txtId.Text.Length != 9)
                {
                    error.SetError(txtId, "Error, la identificacion debe ser de 9 digitos");
                    txtId.Focus();
                    return;
                }

                var resultado = MessageBox.Show("¿Esta seguro?", "Pregunta",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    BLLUsuario logica = new BLLUsuario();

                    int id = int.Parse(txtId.Text);

                    logica.Desactivar(id);

                    MessageBox.Show("Desactivado", "✔🧺", MessageBoxButtons.OK);
                    txtId.Enabled = true;
                    btnCrear.Enabled = true;

                    RefrescarUsuarios();
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
