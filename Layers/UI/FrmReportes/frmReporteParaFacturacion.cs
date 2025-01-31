using ComputerStore.Layers.Entities;
using log4net;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ComputerStore.Layers.UI.FrmReportes
{
    public partial class frmReporteParaFacturacion : Form
    {
        UsuarioDTO usuario = new UsuarioDTO();
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;
        public frmReporteParaFacturacion()
        {
            InitializeComponent();
            usuario = SesionIniciada.UsuarioIn;

        }

        private void frmReporteParaFacturacion_Load(object sender, EventArgs e)
        {
            try { 
            int FacturaId = frmStoreCustom.IdFactura;
            if (FacturaId == 0)
            {
                FacturaId = frmStore.IdFactura;
            }
            // TODO: This line of code loads data into the 'DataSetParaFacturacion.PA_ReporteFacturacion' table. You can move, or remove it, as needed.
            this.PA_ReporteFacturacionTableAdapter.Fill(this.DataSetParaFacturacion.PA_ReporteFacturacion, FacturaId);

            this.reportViewer1.RefreshReport();


            string ruta = @"c:\temp\Factura"+FacturaId.ToString()+".pdf";
            
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                //Process.Start(ruta);

                String CuentaCorreoElectronico = "computerstoresebas@gmail.com";
                String ContrasenaGeneradaGmail = "cxezlxuytvzljson";
                MailMessage mensaje = new MailMessage();
                mensaje.IsBodyHtml = true;
                mensaje.Subject = "ComputerStore";
                mensaje.Body = "Factura";
                mensaje.From = new MailAddress(CuentaCorreoElectronico);
                mensaje.To.Add(usuario.Email); //Correo del destinatario
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(CuentaCorreoElectronico,
                ContrasenaGeneradaGmail);
                smtp.EnableSsl = true;
                Attachment attachment = new Attachment(@"c:\temp\Factura" + FacturaId.ToString() +".pdf");
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
                MessageBox.Show("Correo Enviado");


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