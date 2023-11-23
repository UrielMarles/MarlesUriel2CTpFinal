using BACK;
using BACK.Entidades;
using BACK.Herramientas;
using BACK.Scripts;
using RENT_A_TRONIC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENT_A_TRONIC.FORMS
{
    public partial class FrmOptions : Form
    {
        private UsuarioEntidad user;
        private FrmInicioSesion inicioSesion;
        private bool mostrandoOcultos;
        private ConexionConTabla conec;

        public delegate void cambioOculto(bool cambio);
        public event cambioOculto cambio;
        public FrmOptions(UsuarioEntidad user, FrmInicioSesion inicioSesion, bool mostrandoOcultos, ConexionConTabla conec)
        {
            InitializeComponent();
            this.user = user;
            this.mostrandoOcultos = mostrandoOcultos;
            this.inicioSesion = inicioSesion;
            this.conec = conec;
        }

        private void FrmConfirmar_Load(object sender, EventArgs e)
        {
            if (mostrandoOcultos)
            {
                borrados.Text = "Ocultar borrados";
            }
            else
            {
                borrados.Text = "Mostrar borrados";
            }
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            FrmConfirmar pregunta = new FrmConfirmar(" cerrar sesion?");
            DialogResult result = pregunta.ShowDialog();
            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                inicioSesion.ShowDialog();
                this.Close();
            }

        }
        private void cambiarVisibilidad(object sender, EventArgs e)
        {
            
            mostrandoOcultos = mostrandoOcultos ? false : true;
            if (mostrandoOcultos)
            {
                borrados.Text = "Ocultar borrados";
            }
            else
            {
                borrados.Text = "Mostrar borrados";
            }
            cambio.Invoke(mostrandoOcultos);

        }

        private void ResetearTabla_Click(object sender, EventArgs e)
        {
            if (user.EsAdmin)
            {
                FrmConfirmar pregunta = new FrmConfirmar("Resetear Tabla?");
                DialogResult result = pregunta.ShowDialog();
                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    ConexionConTabla conec = new ConexionConTabla("Data Source=DESKTOP-FT8QR65\\NEWSERVER; Initial Catalog=RENT-A-TRONICDB;Integrated Security=True");

                    // Act
                    FilesManager.ResetearTablas(conec);
                    FilesManager.CargarInformacionBase(conec, new List<InterfazEntidades>()
                {
                    new UsuarioEntidad(),
                    new AnimatronicoEntidad(),
                    new FiestaEntidad(),
                    new CantidadEntidad(),
                    new AnimatronicoFiestaEntidad()
                });
                }
            }
            else
            {
                DisplayError.Text = "No tienes permisos";
            }

        }

        private void crearBackup_Click(object sender, EventArgs e)
        {
            if (user.EsAdmin)
            {
                FrmConfirmar pregunta = new FrmConfirmar("Crear Backup?");
                DialogResult result = pregunta.ShowDialog();
                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    List<string> listaNombres = new List<string> { "animatronicos", "animatronicosFiestas", "cantidades", "fiestas", "usuarios" };
                    List<List<Dictionary<string, string>>> listaTablas = new List<List<Dictionary<string, string>>>();
                    List<Dictionary<string, string>> listaUnaTabla;
                    listaUnaTabla = new List<Dictionary<string, string>>();
                    foreach (AnimatronicoEntidad user in new ColeccionEntidades<AnimatronicoEntidad>(conec).ListaT)
                    {
                        listaUnaTabla.Add(user.DevolverInfoEnDict());
                    }
                    listaTablas.Add(listaUnaTabla);
                    listaUnaTabla = new List<Dictionary<string, string>>();
                    foreach (AnimatronicoFiestaEntidad user in new ColeccionEntidades<AnimatronicoFiestaEntidad>(conec).ListaT)
                    {
                        listaUnaTabla.Add(user.DevolverInfoEnDict());
                    }
                    listaTablas.Add(listaUnaTabla);
                    listaUnaTabla = new List<Dictionary<string, string>>();
                    foreach (CantidadEntidad user in new ColeccionEntidades<CantidadEntidad>(conec).ListaT)
                    {
                        listaUnaTabla.Add(user.DevolverInfoEnDict());
                    }
                    listaTablas.Add(listaUnaTabla);
                    listaUnaTabla = new List<Dictionary<string, string>>();
                    foreach (FiestaEntidad user in new ColeccionEntidades<FiestaEntidad>(conec).ListaT)
                    {
                        listaUnaTabla.Add(user.DevolverInfoEnDict());
                    }
                    listaTablas.Add(listaUnaTabla);
                    listaUnaTabla = new List<Dictionary<string, string>>();
                    foreach (UsuarioEntidad user in new ColeccionEntidades<UsuarioEntidad>(conec).ListaT)
                    {
                        listaUnaTabla.Add(user.DevolverInfoEnDict());
                    }
                    listaTablas.Add(listaUnaTabla);
                    FilesManager.GuardarUnBackup(listaTablas, listaNombres);
                    MessageBox.Show("BACKUP REALIZADO!!!!!!!!!");
                }
            }
            else
            {
                DisplayError.Text = "No tienes permisos";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
