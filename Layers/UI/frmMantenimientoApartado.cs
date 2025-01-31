using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using ComputerStore.Layers.Service;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI
{
    public partial class frmMantenimientoApartado : Form
    {
        ErrorProvider error = new ErrorProvider();

        UsuarioDTO usuario = new UsuarioDTO();

        List<ComponenteDTO> listaComponentesSotck = new List<ComponenteDTO>();
        List<ComponenteDTO> listaComponentes = new List<ComponenteDTO>();
        List<ComponenteDTO> listaComponentesApartados = new List<ComponenteDTO>();
        ComponenteDTO componenteA = new ComponenteDTO();
        ComponenteDTO componentePreA = new ComponenteDTO();

        ComponenteDTO componenteM = new ComponenteDTO();
        List<ComponenteApartado> listaApartados = new List<ComponenteApartado>();
        ComponenteDTO componenteStock = new ComponenteDTO();
        BLLComponenteApartado bLLComponenteApartado = new BLLComponenteApartado();

        List<UsuarioDTO> listaUsuarios = new List<UsuarioDTO>();
        BLLComponente bLLComponente = new BLLComponente();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmMantenimientoApartado()
        {
            InitializeComponent();
            usuario = SesionIniciada.UsuarioIn;
        }

        private void frmMantenimientoApartado_Load(object sender, EventArgs e)
        {
            llenarComboUbi();
            RefrescarComponentes();
            RefrescarUsuarios();
            RefrescarApartados();
        }

        private void RefrescarComponentes()
        {
            try
            {
                listaComponentes = BLLComponente.ObtenerComponentesActivo().FindAll(c => c.IdTipoComputadora == 2);
                listBoxComponentes.DataSource = listaComponentes;
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

        private void RefrescarComponentesApartados()
        {
            try
            {
                listBoxSeleccionados.DataSource = null;
                listBoxSeleccionados.DataSource = listaComponentesApartados;
                listBoxSeleccionados.DisplayMember = listaComponentesApartados.ToString();
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
        private void RefrescarApartados()
        {
            try
            {
                listaApartados = BLLComponenteApartado.ObtenerComponentesApartados();
                dgvApartados.DataSource = listaApartados;
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
        private void RefrescarUsuarios()
        {
            try
            {
                listaUsuarios = BLLUsuario.ObtenerUsuariosPorTipo(3);
                listBoxUsuarios.DataSource = listaUsuarios;
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




        private async Task llenarComboUbi()
        {
            var provincias = await ServiceUbicaciones.GetProvincias();
            foreach (var provincia in provincias)
            {
                cmbUbi.Items.Add(provincia);
            }
            cmbUbi.DisplayMember = "nombre";
            cmbUbi.ValueMember = "numero";
            cmbUbi.SelectedIndex = -1;
        }



        private void listBoxComponentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (listBoxComponentes.SelectedIndex > -1)
                {

                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = listBoxComponentes.SelectedItem as ComponenteDTO;

                    componenteM = new ComponenteDTO();
                    componenteM = listBoxComponentes.SelectedItem as ComponenteDTO;


                    componenteA = new ComponenteDTO();
                    componenteA.Id = c.Id;
                    componenteA.Nombre = c.Nombre;
                    componenteA.LinkFabricante = c.LinkFabricante;
                    componenteA.Precio = c.Precio;
                    componenteA.IdTipoComponente = c.IdTipoComponente;
                    componenteA.tipoComponente = c.tipoComponente;
                    componenteA.IdTipoComputadora = c.IdTipoComputadora;
                    componenteA.tipoComputadora = c.tipoComputadora;
                    componenteA.Imagen = c.Imagen;
                    componenteA.FechaIngreso = c.FechaIngreso;
                    componenteA.Activo = c.Activo;
                    txtIdComponente.Text = c.Id.ToString();
                    btnAgregar.Enabled = true;
                    if (componenteA.IdTipoComponente == 4 || componenteA.IdTipoComponente == 6)
                    {
                        UDCantidad.Enabled = true;
                    }
                    else
                    {
                        UDCantidad.Enabled = false;
                        UDCantidad.Value = 1;
                    }
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

        private void listBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUsuarios.SelectedIndex > -1)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = listBoxUsuarios.SelectedItem as UsuarioDTO;
                    txtIdUsuario.Text = c.Id.ToString();
                }
                else
                {
                    MessageBox.Show("No hay Componentes");
                    return;
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
            txtId.Clear();
            txtIdApartado.Clear();
            txtIdComponente.Clear();
            txtIdUsuario.Clear();
            cmbUbi.SelectedIndex = -1;
            UDCantidad.Value = 0;
            chkBox.Checked = true;
            btnActualizar.Enabled = false;
            chkBox.Enabled = false;
            btnDesactivar.Enabled = false;
        }

        private void dvgComponentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //llenar computadora anterior
                componentePreA = new ComponenteDTO();
                // Validar si hay un fila selecionada
                if (dgvApartados.SelectedRows.Count > 0)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = (ComponenteApartado)dgvApartados.SelectedRows[0].DataBoundItem;
                    if (c != null)
                    {
                        txtId.Text = c.Id.ToString();
                        txtIdApartado.Text = c.Id.ToString();
                        txtIdComponente.Text = c.IdComponente.ToString();
                        componentePreA = BLLComponente.ObtenerComponentes().FirstOrDefault(com => com.Id == c.IdComponente);
                        componentePreA.Cantidad = c.Cantidad;
                        txtIdUsuario.Text = c.IdUsuario.ToString();
                        cmbUbi.SelectedValue = c.ProvinciaApartado;
                        UDCantidad.Value = c.Cantidad;
                        chkBox.Checked = c.Activo;
                        btnCrear.Enabled = false;
                        btnAgregar.Enabled = false;
                        listBoxUsuarios.Enabled = false;
                        btnActualizar.Enabled = true;
                        UDCantidad.Enabled = true;
                        chkBox.Enabled = true;
                        btnDesactivar.Enabled = true;
                    }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            btnCrear.Enabled = true;
            btnAgregar.Enabled = true;
            listBoxUsuarios.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //se le debe actualizar la ubicacion a los que tengan el mismo id de apartado
            try
            {

                if (cmbUbi.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir la ubicacion de la sucursal de apartado");
                    cmbUbi.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Debe elegir el usuario al que se le va a realizar el apartado");
                    listBoxUsuarios.Focus();
                    return;
                }

                DialogResult result = MessageBox.Show("¿Modificar el Apartado?", "Confirmación", MessageBoxButtons.OKCancel);

                // Comprobar qué botón se ha pulsado
                if (result == DialogResult.OK)
                {
                    ComponenteApartado CompApart = new ComponenteApartado();
                    ComponenteDTO componenteAct = new ComponenteDTO();
                    List<ComponenteApartado> listaBllCompApart = new List<ComponenteApartado>();
                    listaBllCompApart = BLLComponenteApartado.ObtenerComponentesApartadosActivo();

                    componenteAct = BLLComponente.ObtenerComponentes().FirstOrDefault(com => com.Id == int.Parse(txtIdComponente.Text.ToString()));
                    int countID = int.Parse(txtIdApartado.Text);

                    if (!(componentePreA.Id == componenteAct.Id))
                    {
                        bool Duplicada = listaApartados.Exists(x => x.IdComponente == componenteAct.Id && x.Id == countID);
                        if (!Duplicada)
                        {
                            //restablece el que estaba apartado
                            componentePreA.Cantidad +=
                            (BLLComponente.ObtenerComponentes().FirstOrDefault(com => com.Id == componentePreA.Id)).Cantidad;
                            bLLComponente.Guardar(componentePreA);
                            //ingresa el nuevo, pero modifica el stock de el mismo
                            componenteAct.Cantidad = int.Parse(UDCantidad.Value.ToString());
                            componenteAct.Cantidad =
                            (BLLComponente.ObtenerComponentes().FirstOrDefault(com => com.Id == componenteAct.Id)).Cantidad
                            - componenteAct.Cantidad;
                            bLLComponente.Guardar(componenteAct);

                            foreach (ComponenteApartado componenteApartado in listaApartados)
                            {
                                if (componenteApartado.Id == countID)
                                {
                                    if (componentePreA.Id == componenteApartado.IdComponente)
                                    {
                                        //CompApart = new ComponenteApartado();
                                        componenteApartado.Id = countID;
                                        componenteApartado.IdUsuario = int.Parse(txtIdUsuario.Text.ToString());
                                        if (componenteApartado.IdComponente == componentePreA.Id)
                                        {
                                            componenteApartado.IdComponente = componenteAct.Id;
                                            componenteAct.Cantidad = int.Parse(UDCantidad.Value.ToString());
                                            componenteApartado.Cantidad = componenteAct.Cantidad;
                                        }
                                        componenteApartado.ProvinciaApartado = (cmbUbi.SelectedItem as ProvinciaJson).nombre;
                                        componenteApartado.Activo = chkBox.Checked;

                                        bLLComponenteApartado.ActualizarComponenteApartadoReemplazarComponente(componenteApartado, componentePreA.Id);
                                    }
                                    else
                                    {

                                        if (componenteApartado.Id == countID)
                                        {
                                            //CompApart = new ComponenteApartado();
                                            componenteApartado.Id = countID;
                                            componenteApartado.IdUsuario = int.Parse(txtIdUsuario.Text.ToString());
                                            if (componenteApartado.IdComponente == componentePreA.Id)
                                            {
                                                componenteApartado.IdComponente = componenteAct.Id;
                                                componenteAct.Cantidad = int.Parse(UDCantidad.Value.ToString());
                                                componenteApartado.Cantidad = componenteAct.Cantidad;
                                            }
                                            componenteApartado.ProvinciaApartado = (cmbUbi.SelectedItem as ProvinciaJson).nombre;
                                            componenteApartado.Activo = chkBox.Checked;

                                            bLLComponenteApartado.Guardar(componenteApartado);
                                        }

                                    }
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Este computadora ya está asignado dentro de este numero de apartado");
                            return;
                        }
                    }
                    else
                    {
                        // lo restablece 
                        componentePreA.Cantidad +=
                        (BLLComponente.ObtenerComponentes().FirstOrDefault(com => com.Id == componentePreA.Id)).Cantidad;
                        bLLComponente.Guardar(componentePreA);
                        //lo modifica
                        componentePreA.Cantidad = int.Parse(UDCantidad.Value.ToString());
                        componentePreA.Cantidad =
                        (BLLComponente.ObtenerComponentes().FirstOrDefault(com => com.Id == componentePreA.Id)).Cantidad
                        - componentePreA.Cantidad;
                        bLLComponente.Guardar(componentePreA);

                        foreach (ComponenteApartado componenteApartado in listaApartados)
                        {
                            if (componenteApartado.Id == countID)
                            {
                                //CompApart = new ComponenteApartado();
                                componenteApartado.Id = countID;
                                componenteApartado.IdUsuario = int.Parse(txtIdUsuario.Text.ToString());
                                if (componenteApartado.IdComponente == componentePreA.Id)
                                {
                                    componenteApartado.IdComponente = componenteAct.Id;
                                    componenteAct.Cantidad = int.Parse(UDCantidad.Value.ToString());
                                    componenteApartado.Cantidad = componenteAct.Cantidad;
                                }
                                componenteApartado.ProvinciaApartado = (cmbUbi.SelectedItem as ProvinciaJson).nombre;
                                componenteApartado.Activo = chkBox.Checked;

                                bLLComponenteApartado.Guardar(componenteApartado);
                            }
                        }
                    }



                    listaBllCompApart = BLLComponenteApartado.ObtenerComponentesApartadosActivo();


                    MessageBox.Show("Se ha modificado con exito el apartado");

                    //btnCancelar_Click(sender, e);    tengo que limpiar las cosas en esta parte 
                    listaComponentesApartados = new List<ComponenteDTO>();
                    listaComponentesSotck = new List<ComponenteDTO>();
                    RefrescarApartados();
                    RefrescarComponentesApartados();
                    RefrescarComponentes();
                    limpiarTodo();

                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Has cancelado el editado del Apartado");
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

        private void listBoxSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaComponentesApartados.Count < 1)
                {
                    MessageBox.Show("Debe elejir como minimo un computadora para realizar el apartado");
                    return;

                }

                if (cmbUbi.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir la ubicacion de la sucursal de apartado");
                    cmbUbi.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(txtIdUsuario.Text))
                {
                    MessageBox.Show("Debe elegir el usuario al que se le va a realizar el apartado");
                    listBoxUsuarios.Focus();
                    return;
                }

                DialogResult result = MessageBox.Show("¿Realizar el Apartado?", "Confirmación", MessageBoxButtons.OKCancel);

                // Comprobar qué botón se ha pulsado
                if (result == DialogResult.OK)
                {
                    ComponenteApartado CompApart = new ComponenteApartado();
                    List<ComponenteApartado> listaBllCompApart = new List<ComponenteApartado>();
                    listaBllCompApart = BLLComponenteApartado.ObtenerComponentesApartadosActivo();

                    int countID = listaBllCompApart.Max(n => n.Id) + 1;


                    foreach (ComponenteDTO componentes in listaComponentesApartados)
                    {

                        CompApart = new ComponenteApartado();
                        CompApart.Id = countID;
                        CompApart.IdUsuario = int.Parse(txtIdUsuario.Text.ToString());
                        CompApart.IdComponente = componentes.Id;
                        CompApart.Cantidad = componentes.Cantidad;
                        CompApart.ProvinciaApartado = (cmbUbi.SelectedItem as ProvinciaJson).nombre;
                        CompApart.Activo = true;

                        bLLComponenteApartado.Guardar(CompApart);

                    }
                    listaBllCompApart = BLLComponenteApartado.ObtenerComponentesApartadosActivo();


                    MessageBox.Show("Se ha realizado con exito el apartado");

                    //btnCancelar_Click(sender, e);    tengo que limpiar las cosas en esta parte 
                    listaComponentesApartados = new List<ComponenteDTO>();
                    listaComponentesSotck = new List<ComponenteDTO>();
                    RefrescarApartados();
                    RefrescarComponentesApartados();
                    RefrescarComponentes();
                    limpiarTodo();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Has cancelado el Apartado");
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

        private void btnDesactivar_Click(object sender, EventArgs e) //falta
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
                    BLLComponenteApartado logica = new BLLComponenteApartado();

                    int id = int.Parse(txtId.Text);

                    logica.DesactivarPorId(id);

                    MessageBox.Show("Se desactivaron todos los elementos del apartado Num: " + id, "✔🧺", MessageBoxButtons.OK);
                    txtId.Enabled = true;
                    btnCrear.Enabled = true;
                    btnAgregar.Enabled = true;
                    limpiarTodo();

                    RefrescarApartados();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                ComponenteDTO componenteDelete = new ComponenteDTO();
                ComponenteDTO componenteDeleteStock = new ComponenteDTO();

                componenteDelete = listBoxSeleccionados.SelectedItem as ComponenteDTO;

                if (componenteDelete != null)
                {

                    foreach (ComponenteDTO componente in listaComponentesSotck)
                    {
                        if (componente.Id == componenteDelete.Id)
                        {
                            bLLComponente.Guardar(componente);
                            componenteDeleteStock = componente;
                        }
                    }

                    listaComponentesSotck.Remove(componenteDeleteStock);

                    listaComponentesApartados.Remove(componenteDelete);

                    RefrescarComponentesApartados();
                    RefrescarComponentes();

                }
                else
                {
                    MessageBox.Show("Debe selecionar el computadora que desea eliminar");

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int count = 0;

            try
            {
                componenteA.Cantidad = Convert.ToInt32(UDCantidad.Value);
                // Validar si hay un componenteA construido
                if (componenteA != null)
                {
                    // si es así se le hace un add a la lista de agregados
                    bool componenteExiste = listaComponentesApartados.Exists(c => c.Id == componenteA.Id && c.Activo == true); //para no agregar el mismo dos veces 

                    //bool componenteExistePre = listaComponentesPreApartados.Exists(c => c.Id == componenteA.Id && c.Activo == true);
                    //&& ((c.IdTipoComponente == 4 || c.IdTipoComponente == 6)&& c.Cantidad < 4)); //para no agregar el mismo dos veces 

                    //if (!componenteExistePre)
                    //{
                    if (componenteExiste) // si existe le cambia la cantidad
                    {
                        if (componenteA.IdTipoComponente == 4 || componenteA.IdTipoComponente == 6)
                        {
                            foreach (ComponenteDTO componenteEnLista in listaComponentesApartados)
                            {
                                if (componenteEnLista.Id == componenteA.Id)
                                //validar que sea una ram o un almacenamiento                            
                                {
                                    if (componenteA.Cantidad <= componenteM.Cantidad) //que no superer la cantidad disponible
                                    {
                                        if (componenteEnLista.Cantidad + componenteA.Cantidad <= 4)
                                        {
                                            bool componenteExisteEnStock = listaComponentesSotck.Exists(c => c.Id == componenteM.Id); //para no agregar el mismo dos veces 

                                            if (!componenteExisteEnStock)
                                            {
                                                componenteStock = (ComponenteDTO)componenteM.Clone();
                                                listaComponentesSotck.Add(componenteStock);
                                            }

                                            componenteEnLista.Cantidad += componenteA.Cantidad;
                                            listaComponentesApartados[count] = componenteEnLista;
                                            componenteM.Cantidad = componenteM.Cantidad - componenteA.Cantidad;
                                            if (componenteM.Cantidad == 0)
                                            {
                                                componenteM.Activo = false;
                                                bLLComponente.Guardar(componenteM);

                                            }
                                            else
                                            {
                                                bLLComponente.Guardar(componenteM);

                                            }
                                            //pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                                            //pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
                                            btnAgregar.Enabled = false;
                                            UDCantidad.Enabled = false;
                                            RefrescarComponentesApartados();
                                            RefrescarComponentes();
                                            UDCantidad.Value = 1;
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("La cantidad maxima de este computadora es de 4");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("La cantidad de este computadora es insuficiente");
                                    }
                                }
                                count++;



                            }
                        }
                        else
                        {
                            MessageBox.Show("Solos los componentes\nRAM\nAlmacenamiento\npueden seleccionarse el mismo más de una vez");
                        }
                    }
                    else
                    {
                        if (componenteA.Cantidad <= componenteM.Cantidad)
                        {

                            componenteStock = (ComponenteDTO)componenteM.Clone();
                            listaComponentesSotck.Add(componenteStock);

                            listaComponentesApartados.Add(componenteA);

                            RefrescarComponentesApartados();

                            componenteM.Cantidad = componenteM.Cantidad - componenteA.Cantidad;
                            if (componenteM.Cantidad == 0)
                            {
                                componenteM.Activo = false;
                                bLLComponente.Guardar(componenteM);

                            }
                            else
                            {
                                bLLComponente.Guardar(componenteM);

                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad de este computadora es insuficiente");
                        }
                    }

                }

                btnAgregar.Enabled = false;
                UDCantidad.Enabled = false;
                RefrescarComponentes();
                UDCantidad.Value = 1;
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
