using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using ComputerStore.Layers.Service;
using ComputerStore.Layers.UI.FrmReportes;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI
{
    public partial class frmStoreCustom : Form
    {
        ComponenteDTO componenteV = new ComponenteDTO();
        ComponenteDTO componenteM = new ComponenteDTO();
        ComponenteDTO componenteStock = new ComponenteDTO();
        List<ComponenteDTO> listaComponentesAgregados = new List<ComponenteDTO>();
        List<ComponenteDTO> listaComponentesSotck = new List<ComponenteDTO>();
        List<ComponenteDTO> listaComponentesPreApartados = new List<ComponenteDTO>();
        List<ComponenteDTO> listaComponentesPreApartadosStock = new List<ComponenteDTO>();
        List<ComponenteApartado> ListaComponentesApartadosAgregadosStock = new List<ComponenteApartado>();
        ComputadoraDTO computadora = new ComputadoraDTO();
        BLLComponente bLLComponente = new BLLComponente();
        BLLComponenteApartado bLLComponenteApartado = new BLLComponenteApartado();
        BLLComputadora bLLComputadora = new BLLComputadora();
        BLLFactura bLLFactura = new BLLFactura();
        BLLComputadoraComponente bLLComputadoraComponente = new BLLComputadoraComponente();
        Factura factura = new Factura();
        UsuarioDTO usuario = new UsuarioDTO();
        public static int IdFactura = 0;
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmStoreCustom()
        {
            InitializeComponent();
            usuario = SesionIniciada.UsuarioIn;
            pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
            pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
            btnAgregar.Enabled = false;
            UDCantidad.Enabled = false;
            RefrescarComponentesAgregados();
            RefrescarComponentesPreApartados();
            UDCantidad.Value = 1;
        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            try
            {
                //listBoxAgregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                listaComponentesPreApartados = BLLComponenteApartado.ObtenerComponentesApartadosPorUsuario(usuario.Id);
                listaComponentesPreApartadosStock = BLLComponenteApartado.ObtenerComponentesApartadosPorUsuario(usuario.Id);
                RefrescarComponentes();
                CargarTipoComponentes();
                dgvComponentes.ClearSelection();

                pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
                btnAgregar.Enabled = false;
                UDCantidad.Enabled = false;
                RefrescarComponentesAgregados();
                RefrescarComponentesPreApartados();
                UDCantidad.Value = 1;

                lblIcono1.Text = "₡";
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

        private void RefrescarComponentesPreApartados()
        {
            try
            {
                listaComponentesPreApartados = BLLComponenteApartado.ObtenerComponentesApartadosPorUsuario(usuario.Id);

                listBoxPreApartados.DataSource = listaComponentesPreApartados.FindAll(c => c.Activo == true); ;
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


        private void RefrescarComponentes()
        {
            try
            {
                // Configuracion del DataGridView para que se vea bien la imagen.
                dgvComponentes.AutoGenerateColumns = false;
                dgvComponentes.RowTemplate.Height = 100;
                dgvComponentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dgvComponentes.DataSource = BLLComponente.ObtenerComponentesActivo().FindAll(c => c.IdTipoComputadora == 1);
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

        private void RefrescarComponentesFiltrado(int idTipoComponente)
        {
            try
            {
                // Configuracion del DataGridView para que se vea bien la imagen.
                dgvComponentes.DataSource = null;
                dgvComponentes.AutoGenerateColumns = false;
                dgvComponentes.RowTemplate.Height = 100;
                dgvComponentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvComponentes.DataSource = BLLComponente.ObtenerComponentesActivoPorTipoComponente(idTipoComponente);
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

        private void RefrescarComponentesAgregados()
        {
            listBoxAgregados.DataSource = null;


            listBoxAgregados.DataSource = listaComponentesAgregados;
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoComponente.SelectedIndex > -1)
                {
                    RefrescarComponentesFiltrado((cmbTipoComponente.SelectedItem as TipoComponente).Id);

                    switch ((cmbTipoComponente.SelectedItem as TipoComponente).Id) //es para poner iconos del tipo de computadora al lado del cmbox
                    {
                        case 1:
                            pbImagen.Image = ComputerStore.Properties.Resources._case;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        case 2:
                            pbImagen.Image = ComputerStore.Properties.Resources.cpu;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        case 3:
                            pbImagen.Image = ComputerStore.Properties.Resources.motherboard;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        case 4:
                            pbImagen.Image = ComputerStore.Properties.Resources.ram;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        case 5:
                            pbImagen.Image = ComputerStore.Properties.Resources.gpu;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        case 6:
                            pbImagen.Image = ComputerStore.Properties.Resources.almacenamiento;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        case 7:
                            pbImagen.Image = ComputerStore.Properties.Resources.psu;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                        default:
                            pbImagen.Image = ComputerStore.Properties.Resources.cpu;
                            pbImagen.SizeMode = PictureBoxSizeMode.CenterImage; break;
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar el tipo que desea filtrar");

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
                componenteV.Cantidad = Convert.ToInt32(UDCantidad.Value);
                // Validar si hay un componenteA construido
                if (componenteV != null)
                {
                    // si es así se le hace un add a la lista de agregados
                    bool componenteExiste = listaComponentesAgregados.Exists(c => c.Id == componenteV.Id); //para no agregar el mismo dos veces 

                    bool componenteExistePreApartado = listaComponentesPreApartados.Exists(c => c.Id == componenteV.Id); //para no agregar si ya lo tiene preapartado 

                    bool tipoComponenteExiste = listaComponentesAgregados.Exists(c => c.IdTipoComponente == componenteV.IdTipoComponente && c.IdTipoComponente != 4
                                                                                                            && c.IdTipoComponente != 6);
                    if (!componenteExistePreApartado)
                    {
                        if (!tipoComponenteExiste)
                        {

                            if (componenteExiste) // si existe le cambia la cantidad
                            {
                                if (componenteV.IdTipoComponente == 4 || componenteV.IdTipoComponente == 6)
                                {
                                    foreach (ComponenteDTO componenteEnLista in listaComponentesAgregados)
                                    {
                                        if (componenteEnLista.Id == componenteV.Id)
                                        //validar que sea una ram o un almacenamiento                            
                                        {
                                            if (componenteV.Cantidad <= componenteM.Cantidad) //que no superer la cantidad disponible
                                            {
                                                if (componenteEnLista.Cantidad + componenteV.Cantidad <= 4)
                                                {
                                                    bool componenteExisteEnStock = listaComponentesSotck.Exists(c => c.Id == componenteM.Id); //para no agregar el mismo dos veces 

                                                    if (!componenteExisteEnStock)
                                                    {
                                                        componenteStock = (ComponenteDTO)componenteM.Clone();
                                                        listaComponentesSotck.Add(componenteStock);
                                                    }

                                                    componenteEnLista.Cantidad += componenteV.Cantidad;
                                                    listaComponentesAgregados[count] = componenteEnLista;
                                                    componenteM.Cantidad = componenteM.Cantidad - componenteV.Cantidad;
                                                    if (componenteM.Cantidad == 0)
                                                    {
                                                        componenteM.Activo = false;
                                                        bLLComponente.Guardar(componenteM);
                                                    }
                                                    else
                                                    {
                                                        bLLComponente.Guardar(componenteM);
                                                    }
                                                    pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                                                    pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
                                                    btnAgregar.Enabled = false;
                                                    UDCantidad.Enabled = false;
                                                    RefrescarComponentesAgregados();
                                                    RefrescarComponentes();
                                                    UDCantidad.Value = 1;
                                                    return;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("La cantidad maxima de este componente es de 4");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("La cantidad de este componente es insuficiente");
                                            }
                                        }
                                        count++;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Solos los componentes\nRAM\nAlmacenamiento pueden seleccionarse el mismo\nmás de una vez");
                                }
                            }
                            else
                            {
                                if (componenteV.Cantidad <= componenteM.Cantidad)
                                {
                                    componenteStock = (ComponenteDTO)componenteM.Clone();
                                    listaComponentesSotck.Add(componenteStock);

                                    listaComponentesAgregados.Add(componenteV);
                                    RefrescarComponentesAgregados();

                                    componenteM.Cantidad = componenteM.Cantidad - componenteV.Cantidad;
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
                                    MessageBox.Show("La cantidad de este componente es insuficiente");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Solo puede haber un tipo de componente\npor cada tipo de computadora");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya tienes este componente Pre Apartado\nSeleccionalo desde tus Pre Apartados");
                    }
                }
                listBoxAgregados.ClearSelected();
                pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
                btnAgregar.Enabled = false;
                UDCantidad.Enabled = false;

                RefrescarComponentes();
                UDCantidad.Value = 1;
                txtPrecio.Text = MontosColonesDolar().ToString("#.00");

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

        private void dvgComponentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Validar si hay un fila selecionada
                if (dgvComponentes.SelectedRows.Count > 0)
                {

                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = (ComponenteDTO)dgvComponentes.SelectedRows[0].DataBoundItem;

                    componenteM = new ComponenteDTO();
                    componenteM = (ComponenteDTO)dgvComponentes.SelectedRows[0].DataBoundItem;

                    componenteV = new ComponenteDTO();
                    componenteV.Id = c.Id;
                    componenteV.Nombre = c.Nombre;
                    componenteV.LinkFabricante = c.LinkFabricante;
                    componenteV.Precio = c.Precio;
                    componenteV.IdTipoComponente = c.IdTipoComponente;
                    componenteV.tipoComponente = c.tipoComponente;
                    componenteV.IdTipoComputadora = c.IdTipoComputadora;
                    componenteV.tipoComputadora = c.tipoComputadora;
                    pbSeleccionado.Image = new Bitmap(new MemoryStream(c.Imagen));
                    pbSeleccionado.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbSeleccionado.Tag = c.Imagen;
                    componenteV.Imagen = (byte[])this.pbSeleccionado.Tag;
                    componenteV.FechaIngreso = c.FechaIngreso;
                    componenteV.Activo = c.Activo;
                    btnAgregar.Enabled = true;
                    if (componenteV.IdTipoComponente == 4 || componenteV.IdTipoComponente == 6)
                    {
                        UDCantidad.Enabled = true;
                    }
                    else
                    {
                        UDCantidad.Enabled = false;
                        UDCantidad.Value = 1;
                    }
                    dgvComponentes.ClearSelection();

                    btnAgregar.Enabled = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ComponenteDTO componente in listaComponentesSotck)
                {
                    bLLComponente.Guardar(componente);

                }
                foreach (ComponenteApartado componenteApartado in ListaComponentesApartadosAgregadosStock)
                {
                    bLLComponenteApartado.Guardar(componenteApartado);
                }
                listaComponentesAgregados = new List<ComponenteDTO>();
                RefrescarComponentesAgregados();
                RefrescarComponentes();
                RefrescarComponentesPreApartados();

                txtPrecio.Text = MontosColonesDolar().ToString();

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

        private void frmStoreCustom_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (listaComponentesAgregados.Count > 0)
                {
                    MessageBox.Show("Error\nLa ventana no se puede cerrar\nTienes componentes en la lista de agregados");
                    e.Cancel = true; // Cancelar el cierre de la ventana
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

        private float MontosColonesDolar()
        {
            float monto = 0;

            try
            {
                ServiceBCCR service = new ServiceBCCR();
                Dolar dolar = new Dolar();
                dolar = service.GetCambioDolar(DateTime.Now, DateTime.Now, "v") as Dolar;
                float ValorDolar = float.Parse(dolar.Monto.ToString());
                if (listaComponentesAgregados.Count > 0 || listaComponentesAgregados != null)
                {
                    if (rdbColones.Checked)
                    {
                        foreach (ComponenteDTO componente in listaComponentesAgregados)
                        {
                            monto += componente.Precio * componente.Cantidad;
                        }
                    }
                    if (rdbDolar.Checked)
                    {
                        foreach (ComponenteDTO componente in listaComponentesAgregados)
                        {
                            monto += componente.Precio * componente.Cantidad; ;
                        }
                        monto = monto / ValorDolar;

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
            return monto;
        }

        private float MontoDolar()
        {
            Dolar dolar = new Dolar();

            try
            { 
            ServiceBCCR service = new ServiceBCCR();
            dolar = service.GetCambioDolar(DateTime.Now, DateTime.Now, "v") as Dolar;
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
            return float.Parse(dolar.Monto.ToString());

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaComponentesAgregados.Count < 0)
                {
                    MessageBox.Show("No hay componentes que puedas eliminar");

                    return;
                }

                ComponenteDTO componenteDelete = new ComponenteDTO();
                ComponenteDTO componenteDeleteStock = new ComponenteDTO();

                componenteDelete = listBoxAgregados.SelectedItem as ComponenteDTO;

                bool componenteExistePreApartado = listaComponentesPreApartadosStock.Exists(c => c.Id == componenteDelete.Id); //para validar su existencia en pre apartados stock

                if (componenteDelete != null)
                {
                    if (!componenteExistePreApartado)
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

                        listaComponentesAgregados.Remove(componenteDelete);

                        RefrescarComponentesAgregados();
                        RefrescarComponentes();
                        listBoxAgregados.ClearSelected();

                        txtPrecio.Text = MontosColonesDolar().ToString();
                    }
                    else
                    {
                        ComponenteApartado compA = new ComponenteApartado();
                        ComponenteDTO compoPreAS = listaComponentesPreApartadosStock.FirstOrDefault(c => c.Id == componenteDelete.Id);
                        compA = ListaComponentesApartadosAgregadosStock.FirstOrDefault(c => c.IdUsuario == usuario.Id && c.IdComponente == compoPreAS.Id);

                        foreach (ComponenteDTO componente in listaComponentesPreApartadosStock)
                        {
                            if (componente.Id == componenteDelete.Id)
                            {
                                if (componente.Cantidad == componenteDelete.Cantidad)
                                {
                                    bLLComponenteApartado.Guardar(compA);
                                    componenteDeleteStock = componente;
                                }
                                else
                                {
                                    foreach (ComponenteDTO componenteStock in listaComponentesSotck)
                                    {
                                        if (componente.Id == componenteDelete.Id)
                                        {
                                            bLLComponente.Guardar(componenteStock);
                                            bLLComponenteApartado.Guardar(compA);
                                        }
                                    }
                                    listaComponentesSotck.Remove(componenteDeleteStock);
                                    RefrescarComponentes();
                                }
                            }
                        }
                        //listaComponentesPreApartadosStock.Remove(componenteDeleteStock);

                        listaComponentesAgregados.Remove(componenteDelete);

                        RefrescarComponentesAgregados();
                        RefrescarComponentesPreApartados();
                        listBoxAgregados.ClearSelected();
                    }
                    txtPrecio.Text = MontosColonesDolar().ToString();
                    pbComponenteAgregado.Image = ComputerStore.Properties.Resources.cpu;
                    pbComponenteAgregado.SizeMode = PictureBoxSizeMode.CenterImage;
                }

                else
                {

                    MessageBox.Show("Debe selecionar el componente que desea eliminar");
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


        private void rdbColones_CheckedChanged(object sender, EventArgs e)
        {
            lblIcono1.Text = "₡";
            txtPrecio.Text = MontosColonesDolar().ToString("#.00");
        }

        private void rdbDolar_CheckedChanged(object sender, EventArgs e)
        {
            lblIcono1.Text = "$";
            txtPrecio.Text = MontosColonesDolar().ToString("#.00");
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaComponentesAgregados.Count == 7)
                {
                    computadora = new ComputadoraDTO();
                    computadora.Nombre = "Pc Custom " + usuario.Nombre;
                    computadora.IdTipoComputadora = 1;
                    computadora.Activo = true;

                    bLLComputadora.Guardar(computadora);

                    computadora.Id = BLLComputadora.ObtenerComputadorasActivo().Max(n => n.Id);

                    List<ComputadoraComponente> listComputadoraComponentes = new List<ComputadoraComponente>();

                    if (listaComponentesAgregados.Count > 0 || listaComponentesAgregados != null)  //falta validar que esten todos los tipos 
                    {
                        foreach (ComponenteDTO componente in listaComponentesAgregados)
                        {
                            ComputadoraComponente computadoraComponente = new ComputadoraComponente();
                            computadoraComponente.IdComputadora = computadora.Id;
                            computadoraComponente.IdComponente = componente.Id;
                            computadoraComponente.PrecioComponente = componente.Precio;
                            computadoraComponente.Cantidad = componente.Cantidad;
                            computadoraComponente.Impuesto = 0.13f;
                            computadoraComponente.TotalColones = ((componente.Precio * componente.Cantidad) + ((componente.Precio * componente.Cantidad) * computadoraComponente.Impuesto));
                            computadoraComponente.TotalDolar = (computadoraComponente.TotalColones / MontoDolar());
                            bLLComputadoraComponente.Guardar(computadoraComponente);
                            listComputadoraComponentes.Add(computadoraComponente);
                        }

                        factura = new Factura();
                        factura.IdComputadora = computadora.Id;
                        factura.IdUsuario = usuario.Id;
                        factura.Descripcion = "PC Custom. Personalizada por " + usuario.Nombre + " " + usuario.Apellido1 + " " + usuario.Apellido2;
                        factura.Fecha = DateTime.Today;
                        float TotalColones = 0, TotalDolar = 0;
                        foreach (ComputadoraComponente compcom in listComputadoraComponentes)
                        {
                            TotalColones += compcom.TotalColones;
                            TotalDolar += compcom.TotalDolar;
                        }
                        factura.TotalColones = TotalColones;
                        factura.TotalDolar = TotalDolar;
                        bLLFactura.Guardar(factura);

                        MessageBox.Show("Compra Exitosa");

                        List<Factura> listaBllFactura = BLLFactura.ObtenerFacturas();

                        int countID = listaBllFactura.Max(n => n.Id);

                        IdFactura = countID;
                        FrmReportes.frmReporteParaFacturacion frmReport = new frmReporteParaFacturacion();
                        frmReport.ShowDialog();
                        listaComponentesAgregados = new List<ComponenteDTO>();
                        this.Close();
                        frmStoreCustom frm = new frmStoreCustom();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Debe tener todos los componentes necesarios agregados");

                    }
                }
                else
                {
                    MessageBox.Show("En este apartado de nuestra tienda es necesario ensamblar\n" +
                        "una computadora por completo,\nsi deseas adquirir solo algunos componentes\n" +
                        "te recomendamos ir a nuestra seccion de Apartados");

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

        private void btnPreApartados_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(listaComponentesPreApartados == null) || !(listaComponentesPreApartados.Count < 1))
                {
                    RefrescarComponentesPreApartados();
                    listBoxPreApartados.Visible = true;
                    btnAgregarPreApartado.Visible = true;
                }
                else
                {
                    MessageBox.Show("No tienes computadora Pre Apartados");

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

        private void btnAgregarPreApartado_Click(object sender, EventArgs e)
        {
            int count = 0;

            try
            {
                ComponenteApartado compA = new ComponenteApartado();
                ComponenteApartado compAS = new ComponenteApartado();

                ComponenteDTO componenteA = new ComponenteDTO();
                componenteA = listBoxPreApartados.SelectedItem as ComponenteDTO;


                if (componenteA != null)
                {

                    componenteM = new ComponenteDTO();
                    componenteM = (ComponenteDTO)componenteA.Clone();
                    int posicion = listaComponentesPreApartados.IndexOf(componenteA);

                    compA = BLLComponenteApartado.ObtenerComponentesApartadosPorUsuarioYComponente(usuario.Id, componenteA.Id);
                    compAS = (ComponenteApartado)compA.Clone();


                    // Validar si hay un componenteA construido
                    if (componenteA != null)
                    {
                        // si es así se le hace un add a la lista de agregados
                        bool componenteExiste = listaComponentesAgregados.Exists(c => c.Id == componenteA.Id); //para no agregar el mismo dos veces 

                        bool tipoComponenteExiste = listaComponentesAgregados.Exists(c => c.IdTipoComponente == componenteA.IdTipoComponente && c.IdTipoComponente != 4
                                                                                     && c.IdTipoComponente != 6);
                        if (!tipoComponenteExiste)
                        {

                            if (componenteExiste) // si existe le cambia la cantidad
                            {
                                if (componenteA.IdTipoComponente == 4 || componenteA.IdTipoComponente == 6)
                                {
                                    foreach (ComponenteDTO componenteEnLista in listaComponentesAgregados)
                                    {
                                        if (componenteEnLista.Id == componenteA.Id)
                                        //validar que sea una ram o un almacenamiento                            
                                        {
                                            if (componenteA.Cantidad <= componenteM.Cantidad) //que no superer la cantidad disponible
                                            {
                                                if (componenteEnLista.Cantidad + componenteA.Cantidad <= 4)
                                                {
                                                    componenteEnLista.Cantidad += componenteA.Cantidad;
                                                    listaComponentesAgregados[count] = componenteEnLista;
                                                    componenteM.Cantidad = componenteM.Cantidad - componenteA.Cantidad;
                                                    compA.Cantidad = componenteM.Cantidad;
                                                    if (componenteM.Cantidad == 0)
                                                    {
                                                        componenteM.Activo = false;
                                                        compA.Activo = componenteM.Activo;

                                                        listaComponentesPreApartados[posicion] = componenteM;
                                                        bLLComponenteApartado.Guardar(compA);
                                                        ListaComponentesApartadosAgregadosStock.Add(compAS);
                                                    }
                                                    else
                                                    {
                                                        bLLComponenteApartado.Guardar(compA);
                                                        listaComponentesPreApartados[posicion] = componenteM;
                                                        ListaComponentesApartadosAgregadosStock.Add(compAS);
                                                    }
                                                    pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                                                    pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
                                                    btnAgregar.Enabled = false;
                                                    UDCantidad.Enabled = false;
                                                    RefrescarComponentesAgregados();
                                                    RefrescarComponentesPreApartados();
                                                    UDCantidad.Value = 1;
                                                    return;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("La cantidad maxima de este componente es de 4");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("La cantidad de este componente es insuficiente");
                                            }
                                        }


                                        count++;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Solos los componentes\nRAM\nAlmacenamiento pueden seleccionarse el mismo\nmás de una vez");
                                }
                            }
                            else
                            {
                                if (componenteA.Cantidad <= componenteM.Cantidad)
                                {
                                    //componenteStock = (ComponenteDTO)componenteM.Clone();
                                    //listaComponentesSotck.Add(componenteStock);

                                    listaComponentesAgregados.Add(componenteA);
                                    RefrescarComponentesAgregados();

                                    componenteM.Cantidad = componenteM.Cantidad - componenteA.Cantidad;
                                    compA.Cantidad = componenteM.Cantidad;

                                    if (componenteM.Cantidad == 0)
                                    {
                                        componenteM.Activo = false;
                                        compA.Activo = componenteM.Activo;

                                        bLLComponenteApartado.Guardar(compA);
                                        listaComponentesPreApartados[posicion] = componenteM;
                                        ListaComponentesApartadosAgregadosStock.Add(compAS);

                                    }
                                    else
                                    {
                                        bLLComponenteApartado.Guardar(compA);
                                        listaComponentesPreApartados[posicion] = componenteM;
                                        ListaComponentesApartadosAgregadosStock.Add(compAS);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La cantidad de este componente es insuficiente");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Solo puede haber un componente\npor cada tipo de componente");
                        }
                    }

                    listBoxAgregados.ClearSelected();
                    pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                    pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
                    btnAgregar.Enabled = false;
                    UDCantidad.Enabled = false;

                    RefrescarComponentesPreApartados();
                    UDCantidad.Value = 1;
                    txtPrecio.Text = MontosColonesDolar().ToString();
                }
                else
                {
                    MessageBox.Show("Debe selecionar el componente que desea Agregar");
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

        private void listBoxAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (listBoxAgregados.SelectedIndex > -1)
                {
                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = listBoxAgregados.SelectedItem as ComponenteDTO;
                    pbComponenteAgregado.Image = new Bitmap(new MemoryStream(c.Imagen));
                    pbComponenteAgregado.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbComponenteAgregado.Tag = c.Imagen;
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

        private void btnCancelarFiltro_Click(object sender, EventArgs e)
        {
            RefrescarComponentes();
        }
    }
}
