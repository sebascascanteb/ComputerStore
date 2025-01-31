using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using ComputerStore.Layers.Persistencia;
using ComputerStore.Layers.UI;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class frmLogin : Form
    {
        public static string nombreUsuario = "";
        public static int idTipoUsuario = 0;
        public static string tipoUsuario = "";
        ErrorProvider error = new ErrorProvider();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            error = new ErrorProvider();

            try
            {
                if (string.IsNullOrEmpty(txtUsuarioIn.Text))
                {
                    error.SetError(txtUsuarioIn, "Error, la identificacion es requerida");
                    txtUsuarioIn.Focus();
                    return;
                }
                if (!int.TryParse(txtUsuarioIn.Text, out int resutlt))
                {
                    error.SetError(txtUsuarioIn, "Error, la identificacion debe ser numerica");
                    txtUsuarioIn.Focus();
                    return;
                }
                if (txtUsuarioIn.Text.Length != 9)
                {
                    error.SetError(txtUsuarioIn, "Error, la identificacion debe ser de 9 digitos");
                    txtUsuarioIn.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPasswordIn.Text))
                {
                    error.SetError(txtPasswordIn, "Error, la contraseña es requerida");
                    txtPasswordIn.Focus();
                    return;
                }

                List<UsuarioDTO> listaUsuarios;

                listaUsuarios = BLLUsuario.ObtenerUsuariosDes();

                bool iniciado = false;

                foreach (UsuarioDTO usuario in listaUsuarios)
                {
                    if (usuario.Id == int.Parse(txtUsuarioIn.Text) && usuario.Contrasena.Equals(txtPasswordIn.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        if (usuario.Activo == true)
                        {
                            SesionIniciada.UsuarioIn = usuario;
                            nombreUsuario = usuario.Nombre;
                            idTipoUsuario = usuario.IdTipoUsuario;
                            tipoUsuario = usuario.tipoUsuario.ToString();
                            iniciado = true;
                        }
                        else
                        {
                            MessageBox.Show("Error\nUsuario inactivo");
                            return;
                        }

                    }
                }

                if (iniciado)
                {
                    limpiar();
                    var frm = new frmHome();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error\nUsuario inexistente");
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            limpiar();
            var frm = new frmRegister();
            frm.ShowDialog();
        }


        public void limpiar()
        {
            txtPasswordIn.Clear();
            txtUsuarioIn.Clear();
        }

       

        private void txtUsuarioIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPasswordIn.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPasswordIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
