using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using ComputerStore.Layers.Service;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI
{
    public partial class frmApartados : Form
    {
        UsuarioDTO usuario = new UsuarioDTO();

        List<ComponenteDTO> listaComponentesApartados = new List<ComponenteDTO>();
        List<ComponenteDTO> listaComponentesPreApartados = new List<ComponenteDTO>();

        List<ComponenteDTO> listaComponentesSotck = new List<ComponenteDTO>();

        ComponenteDTO componenteA = new ComponenteDTO();
        ComponenteDTO componenteM = new ComponenteDTO();

        ComponenteDTO componenteStock = new ComponenteDTO();
        BLLComponente bLLComponente = new BLLComponente();
        BLLComponenteApartado bLLComponenteApartado = new BLLComponenteApartado();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmApartados()
        {
            InitializeComponent();
            usuario = SesionIniciada.UsuarioIn;
        }

        private void frmApartados_Load(object sender, EventArgs e)
        {
            RefrescarComponentes();
            RefrescarComponentesApartados();
            CargarTipoComponentes();
            llenarComboUbi();
            RefrescarCompoenntesPreApartados();
            dvgComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBoxPreApartados.ClearSelected();
        }

        private void RefrescarCompoenntesPreApartados()
        {
            try
            {
                listaComponentesPreApartados = BLLComponenteApartado.ObtenerComponentesApartadosPorUsuario(usuario.Id);
                listBoxPreApartados.DataSource = listaComponentesPreApartados;
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


        private void RefrescarComponentesFiltrado(int idTipoComponente)
        {
            try
            {
                // Configuracion del DataGridView para que se vea bien la imagen.
                dvgComponentes.DataSource = null;
                dvgComponentes.AutoGenerateColumns = false;
                dvgComponentes.RowTemplate.Height = 100;
                dvgComponentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dvgComponentes.DataSource = BLLComponente.ObtenerComponentesActivoPorTipoComponente(idTipoComponente);
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

        private void RefrescarComponentes()
        {
            try { 
            // Configuracion del DataGridView para que se vea bien la imagen.
            dvgComponentes.DataSource = null;
            dvgComponentes.AutoGenerateColumns = false;
            dvgComponentes.RowTemplate.Height = 100;
            dvgComponentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dvgComponentes.DataSource = BLLComponente.ObtenerComponentesActivo().FindAll(c => c.IdTipoComputadora == 1);
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
            listBoxApartados.DataSource = null;
            listBoxApartados.DataSource = listaComponentesApartados;
            listBoxApartados.DisplayMember = listaComponentesApartados.ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                RefrescarComponentesFiltrado((cmbTipoComponente.SelectedItem as TipoComponente).Id);

                switch ((cmbTipoComponente.SelectedItem as TipoComponente).Id)
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
                if (dvgComponentes.SelectedRows.Count > 0)
                {

                    // DataBoundItem retorna el objeto seleccionado en el grid
                    var c = (ComponenteDTO)dvgComponentes.SelectedRows[0].DataBoundItem;

                    componenteM = new ComponenteDTO();
                    componenteM = (ComponenteDTO)dvgComponentes.SelectedRows[0].DataBoundItem;


                    componenteA = new ComponenteDTO();
                    componenteA.Id = c.Id;
                    componenteA.Nombre = c.Nombre;
                    componenteA.LinkFabricante = c.LinkFabricante;
                    componenteA.Precio = c.Precio;
                    componenteA.IdTipoComponente = c.IdTipoComponente;
                    componenteA.tipoComponente = c.tipoComponente;
                    componenteA.IdTipoComputadora = c.IdTipoComputadora;
                    componenteA.tipoComputadora = c.tipoComputadora;
                    pbSeleccionado.Image = new Bitmap(new MemoryStream(c.Imagen));
                    pbSeleccionado.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbSeleccionado.Tag = c.Imagen;
                    componenteA.Imagen = (byte[])this.pbSeleccionado.Tag;
                    componenteA.FechaIngreso = c.FechaIngreso;
                    componenteA.Activo = c.Activo;
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
                    dvgComponentes.ClearSelection();
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

                    bool componenteExistePre = listaComponentesPreApartados.Exists(c => c.Id == componenteA.Id && c.Activo == true);
                    //&& ((c.IdTipoComponente == 4 || c.IdTipoComponente == 6)&& c.Cantidad < 4)); //para no agregar el mismo dos veces 

                    if (!componenteExistePre)
                    {
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
                                                pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                                                pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
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
                                MessageBox.Show("Solos los componentes\nRAM\nAlmacenamiento\n pueden seleccionarse el mismo más de una vez");
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
                    else
                    {
                        MessageBox.Show("Este computadora ya se encuentra en tus Pre Apartados");

                    }
                }
                pbSeleccionado.Image = ComputerStore.Properties.Resources.cpu;
                pbSeleccionado.SizeMode = PictureBoxSizeMode.CenterImage;
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

        private void checkListBoxAgregados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRealizarApartado_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaComponentesApartados.Count < 1)
                {
                    MessageBox.Show("Debe elejir como minimo un componente para realizar el apartado");
                    return;

                }

                if (cmbUbi.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir la ubicacion de la sucursal de apartado");
                    cmbUbi.Focus();
                    return;
                }

                DialogResult result = MessageBox.Show("¿Quieres Realizar el Apartado?\nUna vez confirmado no se podran realizar cambios.\nDe lo contrario será necesario contactar con un administrador", "Confirmación", MessageBoxButtons.OKCancel);

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
                        CompApart.IdUsuario = usuario.Id;
                        CompApart.IdComponente = componentes.Id;
                        CompApart.Cantidad = componentes.Cantidad;
                        CompApart.ProvinciaApartado = (cmbUbi.SelectedItem as ProvinciaJson).nombre;
                        CompApart.Activo = true;

                        bLLComponenteApartado.Guardar(CompApart);

                    }
                    listaBllCompApart = BLLComponenteApartado.ObtenerComponentesApartadosActivo();


                    MessageBox.Show("Se ha realizado con exito el apartado\nPuedes retirarlo de nuestra tienda fisica dentro de 24h\nTambien podras ingresar con tu usuario" +
                        "\nal apartado de Pc Custom y utilizar los componentes apartados");

                    //btnCancelar_Click(sender, e);    tengo que limpiar las cosas en esta parte 
                    listaComponentesApartados = new List<ComponenteDTO>();
                    listaComponentesSotck = new List<ComponenteDTO>();
                    RefrescarCompoenntesPreApartados();
                    RefrescarComponentesApartados();
                    RefrescarComponentes();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ComponenteDTO componente in listaComponentesSotck)
                {
                    bLLComponente.Guardar(componente);

                }
                listaComponentesApartados = new List<ComponenteDTO>();
                listaComponentesSotck = new List<ComponenteDTO>();
                RefrescarComponentesApartados();
                RefrescarComponentes();
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

        private void frmApartados_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (listaComponentesApartados.Count > 0)
                {
                    MessageBox.Show("Error\nLa ventana no se puede cerrar\nTienes componentes en la lista de apartados");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ComponenteDTO componenteDelete = new ComponenteDTO();
                ComponenteDTO componenteDeleteStock = new ComponenteDTO();

                componenteDelete = listBoxApartados.SelectedItem as ComponenteDTO;

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
                    MessageBox.Show("Se equivocó en 3 ocasiones, el Sistema se Cerrará por seguridad","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
