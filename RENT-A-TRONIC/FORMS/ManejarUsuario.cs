using BACK;
using BACK.Entidades;
using RENT_A_TRONIC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENT_A_TRONIC.FORMS
{
    public partial class frmManejoUsuario : Form
    {
        private ConexionConTabla cnct;
        private UsuarioEntidad? user;
        private bool esAdmin;
        public frmManejoUsuario(ConexionConTabla cnct)
        {
            InitializeComponent();
            this.cnct = cnct;
            InstanciarTextos();
        }
        public frmManejoUsuario(ConexionConTabla cnct, UsuarioEntidad user)
        {
            InitializeComponent();
            this.cnct = cnct;
            this.user = user;
            InstanciarTextos();
        }

        private void InstanciarTextos()
        {
            esAdmin = false;
            if (!(this.user is null))
            {
                textBoxNombre.Text = user.Nombre;
                telefono.Text = user.Telefono;
                contraseña1.Text = user.Contrasenia;
                contraseña2.Text = user.Contrasenia;
                esAdmin = user.EsAdmin;

            }
        }

        private void EnviarInformacion()
        {

            if (textBoxNombre.Text == "" || textBoxNombre.Text.Length > 50 || contraseña1.Text == "" || contraseña1.Text.Length > 50 || contraseña2.Text != contraseña1.Text || telefono.Text == "" || telefono.Text.Length > 50 )
            {
                DisplayError.Text = "Falta completar algun campo";
                if (contraseña1.Text == "" || contraseña1.Text.Length > 50 || contraseña2.Text != contraseña1.Text)
                {
                    DisplayError.Text = "Verificar contraseña";
                }

            }
            else
            {
                bool actualizando = true;
                if (this.user is null)
                {
                    actualizando = false;
                    user = new UsuarioEntidad(-1, textBoxNombre.Text, contraseña1.Text, esAdmin, true, telefono.Text, 0);
                }
                else
                {
                    user.Nombre = textBoxNombre.Text;
                    user.Contrasenia = contraseña1.Text;
                    user.EsAdmin = esAdmin;
                    user.Telefono = telefono.Text;
                }
                FrmConfirmar pregunta = new FrmConfirmar("Confirmar?");
                DialogResult result = pregunta.ShowDialog();
                pregunta.Dispose();
                if (result == DialogResult.Yes)
                {
                    if (actualizando)
                    {
                        ((InterfazEntidades)user).ActualizarEntradaEnLaTabla(cnct);
                    }
                    else
                    {
                        ((InterfazEntidades)user).CrearEntradaEnLaTabla(cnct);
                    }
                }
                this.Close();
            }

        }

        /// ACEPTAR
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            btn_aceptar.Image = Resources.aceptar_apretado;
            btn_aceptar.Update();
            Thread.Sleep(50);
            EnviarInformacion();
            btn_aceptar.Image = Resources.aceptar_hover;

        }

        private void btn_aceptar_MouseEnter(object sender, EventArgs e)
        {
            btn_aceptar.Image = Resources.aceptar_hover;
        }

        private void btn_aceptar_MouseLeave(object sender, EventArgs e)
        {
            btn_aceptar.Image = Resources.aceptar_normal;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_cancelar.Image = Resources.cancelar_apretado;
            FrmConfirmar pregunta = new FrmConfirmar("Cancelar?");
            DialogResult result = pregunta.ShowDialog();
            pregunta.Dispose();
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btn_cancelar_MouseEnter(object sender, EventArgs e)
        {
            btn_cancelar.Image = Resources.cancelar_hover;
        }

        private void btn_cancelar_MouseLeave(object sender, EventArgs e)
        {
            btn_cancelar.Image = Resources.cancelar_normal;
        }

        private void btnEsAdmin_Click(object sender, EventArgs e)
        {
            if (esAdmin)
            {
                btnEsAdmin.Image = Resources.no_normal;
                esAdmin = false;
            }
            else
            {
                btnEsAdmin.Image = Resources.si_normal;
                esAdmin = true;
            }
        }
    }
}
