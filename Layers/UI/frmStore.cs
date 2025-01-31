using ComputerStore.Layers.BLL;
using ComputerStore.Layers.Entities;
using ComputerStore.Layers.Service;
using ComputerStore.Layers.UI.FrmReportes;
using ComputerStore.Layers.Util;
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
    public partial class frmStore : Form
    {

        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;


        List<ComputadoraComponente> ListaCompuComponentes = new List<ComputadoraComponente>();
        List<ComputadoraComponente> ListaCompuComponentesSeleccionada = new List<ComputadoraComponente>();
        UsuarioDTO usuario = new UsuarioDTO();

        List<ComputadoraDTO> ListaMostrarComputadoras = new List<ComputadoraDTO>();
        ComputadoraDTO computadora = new ComputadoraDTO();

        List<ComponenteDTO> ListaComponentesCase = new List<ComponenteDTO>();
        BLLFactura bLLFactura = new BLLFactura();
        int countF = 0;
        public static int IdFactura = 0;

        public frmStore()
        {
            InitializeComponent();
            usuario = SesionIniciada.UsuarioIn;

        }

        private void frmStore_Load(object sender, EventArgs e)
        {
            CargarTipoComputadoras();
            MostrarPc();
        }

        private void CargarTipoComputadoras()
        {
            cmbTipoComputadora.DataSource = BLLTipoComputadora.ObtenerTipoComputadoras();
            cmbTipoComputadora.DisplayMember = "Descripcion";
            cmbTipoComputadora.ValueMember = "Id";
            cmbTipoComputadora.SelectedIndex = 1;
        }

        private void MostrarPc()
        {
            try
            {
                if ((cmbTipoComputadora.SelectedItem as TipoComputadora).Id == 2)
                {
                    ListaMostrarComputadoras = new List<ComputadoraDTO>();

                    //computadoras segun el combobox
                    ListaCompuComponentes = BLLComputadoraComponente.ObtenerComputadoraComponentes();

                    ListaMostrarComputadoras = BLLComputadora.ObtenerComputadorasActivo().FindAll(c => c.IdTipoComputadora == (cmbTipoComputadora.SelectedItem as TipoComputadora).Id);

                    ListaComponentesCase = BLLComponente.ObtenerComponentesActivo().FindAll(c => c.IdTipoComputadora == (cmbTipoComputadora.SelectedItem as TipoComputadora).Id
                                                                                            && c.IdTipoComponente == 1);
                    countF = 1;

                    foreach (ComputadoraComponente computadoraComponente in ListaCompuComponentes)
                    {
                        foreach (ComputadoraDTO com in ListaMostrarComputadoras)
                        {
                            foreach (ComponenteDTO compo in ListaComponentesCase)
                            {
                                if ((computadoraComponente.IdComputadora == com.Id) && (computadoraComponente.IdComponente == compo.Id))
                                {
                                    switch (countF)
                                    {
                                        case 1:
                                            pb1.Image = new Bitmap(new MemoryStream(compo.Imagen)); //tomar las imagenes de db
                                            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                                            pb1.Tag = compo.Imagen;
                                            countF++;
                                            break;
                                        case 2:
                                            pb2.Image = new Bitmap(new MemoryStream(compo.Imagen)); //tomar las imagenes de db
                                            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                                            pb2.Tag = compo.Imagen;
                                            countF++;
                                            break;
                                        case 3:
                                            pb3.Image = new Bitmap(new MemoryStream(compo.Imagen)); //tomar las imagenes de db
                                            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                                            pb3.Tag = compo.Imagen;
                                            countF++;
                                            break;
                                        case 4:
                                            pb4.Image = new Bitmap(new MemoryStream(compo.Imagen)); //tomar las imagenes de db
                                            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                                            pb4.Tag = compo.Imagen;
                                            countF++;
                                            break;
                                        case 5:
                                            pb5.Image = new Bitmap(new MemoryStream(compo.Imagen)); //tomar las imagenes de db
                                            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                                            pb5.Tag = compo.Imagen;
                                            countF++;
                                            break;
                                        default:
                                            //pb1.Image = pb2.Image = pb3.Image = pb5.Image = pb6.Image = (pb1.Image = null);
                                            //pb1.SizeMode = pb2.SizeMode = pb3.SizeMode = pb5.SizeMode = pb6.SizeMode = (pb1.SizeMode = PictureBoxSizeMode.CenterImage);
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    frmStoreCustom frm = new frmStoreCustom();
                    frm.ShowDialog();
                    this.Close();
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

        private void pb1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 1;
                computadora = BLLComputadora.ObtenerComputadorasActivo().FirstOrDefault(c => c.Id == num);
                Bitmap qrCodeImage = QRGenerator.GenerateQRCode(computadora.Nombre);
                pbQr.Image = qrCodeImage;
                LLenarListaComponentes();
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

        private void pb2_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 2;
                computadora = BLLComputadora.ObtenerComputadorasActivo().FirstOrDefault(c => c.Id == num);
                Bitmap qrCodeImage = QRGenerator.GenerateQRCode(computadora.Nombre);
                pbQr.Image = qrCodeImage;
                LLenarListaComponentes();
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

        private void pb3_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 3;
                computadora = BLLComputadora.ObtenerComputadorasActivo().FirstOrDefault(c => c.Id == num);
                Bitmap qrCodeImage = QRGenerator.GenerateQRCode(computadora.Nombre);
                pbQr.Image = qrCodeImage;
                LLenarListaComponentes();
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

        private void pb4_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 4;
                computadora = BLLComputadora.ObtenerComputadorasActivo().FirstOrDefault(c => c.Id == num);
                Bitmap qrCodeImage = QRGenerator.GenerateQRCode(computadora.Nombre);
                pbQr.Image = qrCodeImage;
                LLenarListaComponentes();
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

        private void pb5_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 5;
                computadora = BLLComputadora.ObtenerComputadorasActivo().FirstOrDefault(c => c.Id == num);
                Bitmap qrCodeImage = QRGenerator.GenerateQRCode(computadora.Nombre);
                pbQr.Image = qrCodeImage;
                LLenarListaComponentes();
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
                MostrarPc();
          
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                Factura factura = new Factura();
                factura.IdComputadora = computadora.Id;
                factura.IdUsuario = usuario.Id;
                factura.Descripcion = computadora.Nombre;
                factura.Fecha = DateTime.Today;
                float TotalColones = 0, TotalDolar = 0;
                foreach (ComputadoraComponente compcom in ListaCompuComponentesSeleccionada)
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
                this.Close();
                frmStore frm = new frmStore();
                frm.ShowDialog();

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

        private void LLenarListaComponentes()
        {
            try
            {
                ListaCompuComponentesSeleccionada = BLLComputadoraComponente.ObtenerComputadoraComponentesPorIdComputadora(computadora.Id);
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

        private float MontosColonesDolar()
        {
            float monto = 0;

            try
            {
                ServiceBCCR service = new ServiceBCCR();
                Dolar dolar = new Dolar();
                dolar = service.GetCambioDolar(DateTime.Now, DateTime.Now, "v") as Dolar;
                float ValorDolar = float.Parse(dolar.Monto.ToString());
                if (ListaCompuComponentesSeleccionada.Count > 0 || ListaCompuComponentesSeleccionada != null)
                {
                    if (rdbColones.Checked)
                    {
                        foreach (ComputadoraComponente componente in ListaCompuComponentesSeleccionada)
                        {
                            monto += componente.PrecioComponente * componente.Cantidad;
                        }
                    }
                    if (rdbDolar.Checked)
                    {
                        foreach (ComputadoraComponente componente in ListaCompuComponentesSeleccionada)
                        {
                            monto += componente.PrecioComponente * componente.Cantidad; ;
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

            ServiceBCCR service = new ServiceBCCR();
            Dolar dolar = new Dolar();
            dolar = service.GetCambioDolar(DateTime.Now, DateTime.Now, "v") as Dolar;
            return float.Parse(dolar.Monto.ToString());
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
    }

}
