using RENT_A_TRONIC.FORMS;
using RENT_A_TRONIC.Properties;
using BACK;
using BACK.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BACK.Scripts;

namespace RENT_A_TRONIC
{
    public partial class FrmInicioSesion : Form
    {
        public delegate void eventoUsuarioObtenido(UsuarioEntidad entidad); // define la estructura de las funciones que se
        // pueden subscribir al evento
        public delegate void eventoCerrando();

        public event eventoCerrando cerrando;
        public event eventoUsuarioObtenido alRecibirUsuario;

        private ConexionConTabla conect;
        private UsuarioEntidad usuario;
        public FrmInicioSesion(ConexionConTabla conect)
        {
            InitializeComponent();
            this.conect = conect;
            //throw new ExcepcionNoManejada();
            if (!conect.FuncionaConexion)
            {
                throw new Exception("No se pudo conectar con la tabla");
            }
        }
        /// FUNCIONES PROPIAS

        private void IntentarIngresoUsuario()
        {
            try
            {
                ColeccionEntidades<UsuarioEntidad> tablaEnteraUsers = new ColeccionEntidades<UsuarioEntidad>(conect);
                List<UsuarioEntidad> listaUsers = tablaEnteraUsers["nombre", IngresoNombre.Text];
                if (listaUsers.Count == 0)
                {
                    throw new ErrorAccediendoUsuario("No existe un usuario con ese nombre");
                }
                UsuarioEntidad usuarioConNombre = listaUsers[0];
                if (usuarioConNombre.Contrasenia != IngresoContrasenia.Text)
                {
                    throw new ErrorAccediendoUsuario("   La contrasenia es incorrecta");
                }
                this.usuario = usuarioConNombre;
                this.DialogResult = DialogResult.OK;
                alRecibirUsuario.Invoke(usuarioConNombre);
                DisplayError.Text = "";
                IngresoNombre.Text = "";
                IngresoContrasenia.Text = "";
                this.Close();

            }
            catch (ErrorAccediendoUsuario ex)
            {
                DisplayError.Text = ex.Message;
            }
        }

        /// BOTON ENTRAR

        private void EntrarBtn_MouseEnter(object sender, EventArgs e)
        {
            EntrarBtn.Image = Resources.entrar_hover;
        }

        private void EntrarBtn_MouseLeave(object sender, EventArgs e)
        {
            EntrarBtn.Image = Resources.entrar_normal;
        }

        private void EntrarBtn_MouseClick(object sender, MouseEventArgs e)
        {
            EntrarBtn.Image = Resources.entrar_apretado;
            EntrarBtn.Update();
            IntentarIngresoUsuario();
            Thread.Sleep(50);
            EntrarBtn.Image = Resources.entrar_hover;
        }
        /// BOTON CERRAR
        private void BotonCerrar_MouseEnter(object sender, EventArgs e)
        {
            BotonCerrar.Image = Resources.cerrar_hover;
        }
        private void BotonCerrar_MouseLeave(object sender, EventArgs e)
        {
            BotonCerrar.Image = Resources.cerrar_normal;
        }
        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            BotonCerrar.Image = Resources.cerrar_apretado;
            BotonCerrar.Update();
            Thread.Sleep(100);
            FrmConfirmar pregunta = new FrmConfirmar("   Seguro que \nquieres cerrar?");
            DialogResult result = pregunta.ShowDialog();
            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                this.Close();
                cerrando.Invoke();
            }
            
        }

    }
}
