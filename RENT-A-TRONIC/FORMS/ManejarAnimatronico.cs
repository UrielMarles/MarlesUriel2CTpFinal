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
    public partial class frmManejoAnimatronico : Form
    {
        private ConexionConTabla cnct;
        private UsuarioEntidad user;
        private AnimatronicoEntidad? animatronico;
        private int cantidadAlmas;
        public frmManejoAnimatronico(ConexionConTabla cnct, UsuarioEntidad user)
        {
            InitializeComponent();
            this.cnct = cnct;
            this.user = user;
            InstanciarTextos();
        }
        public frmManejoAnimatronico(ConexionConTabla cnct, UsuarioEntidad user, AnimatronicoEntidad animatronico)
        {
            InitializeComponent();
            this.animatronico = animatronico;
            this.cnct = cnct;
            this.user = user;
            InstanciarTextos();
        }

        private void InstanciarTextos()
        {
            cantidadAlmas = 2;
            if (!(this.animatronico is null))
            {
                textBoxNombre.Text = animatronico.Nombre;
                textBoxDescripcion.Text = animatronico.Descripcion;
                cantidadAlmas = animatronico.CantidadAlmas;  
            }
            actualizarAlmas();

        }

        private void EnviarInformacion()
        {
            if (textBoxNombre.Text == "" || textBoxNombre.Text.Length > 50 || textBoxDescripcion.Text == "" || textBoxNombre.Text.Length > 200)
            {
                DisplayError.Text = "Falta completar algun campo";
            }
            else
            {
                bool actualizando = true;
                if (this.animatronico is null)
                {
                    actualizando = false;
                    animatronico = new AnimatronicoEntidad(-1, textBoxNombre.Text, textBoxDescripcion.Text, true, cantidadAlmas, user.Id);
                }
                else
                {
                    animatronico.Nombre = textBoxNombre.Text;
                    animatronico.Descripcion = textBoxDescripcion.Text;
                    animatronico.CantidadAlmas = cantidadAlmas;

                }
                FrmConfirmar pregunta = new FrmConfirmar("Confirmar?");
                DialogResult result = pregunta.ShowDialog();
                pregunta.Dispose();
                if (result == DialogResult.Yes)
                {
                    if (actualizando)
                    {
                        ((InterfazEntidades)animatronico).ActualizarEntradaEnLaTabla(cnct);
                    }
                    else
                    {
                        ((InterfazEntidades)animatronico).CrearEntradaEnLaTabla(cnct);
                    }
                }
                this.Close();
            }

        }
        private void actualizarAlmas()
        {
            switch (cantidadAlmas)
            {
                case 0:
                    alma1.Visible = false;
                    alma2.Visible = false;
                    alma3.Visible = false;
                    break;
                case 1:
                    alma1.Visible = true;
                    alma2.Visible = false;
                    alma3.Visible = false;
                    break;
                case 2:
                    alma1.Visible = true;
                    alma2.Visible = true;
                    alma3.Visible = false;
                    break;
                case 3:
                    alma1.Visible = true;
                    alma2.Visible = true;
                    alma3.Visible = true;
                    break;
            }
        }
        private void botonMas_Click(object sender, EventArgs e)
        {
            botonMas.Image = Resources.nuevo_apretado;
            botonMas.Update();
            Thread.Sleep(5);
            botonMas.Image = Resources.nuevo_horver;
            if (cantidadAlmas < 3)
            {
                cantidadAlmas += 1;
            }
            actualizarAlmas();
        }

        private void botonMenos_Click(object sender, EventArgs e)
        {
            botonMenos.Image = Resources.menos_apretado;
            botonMenos.Update();
            Thread.Sleep(5);
            botonMenos.Image = Resources.menos_hover;
            if (cantidadAlmas > 0)
            {
                cantidadAlmas -= 1;
            }
            actualizarAlmas();
        }

        private void botonMenos_MouseEnter(object sender, EventArgs e)
        {
            botonMenos.Image = Resources.menos_hover;
        }

        private void botonMenos_MouseLeave(object sender, EventArgs e)
        {
            botonMenos.Image = Resources.menos_normal;
        }

        private void botonMas_MouseEnter(object sender, EventArgs e)
        {
            botonMas.Image = Resources.nuevo_horver;
        }

        private void botonMas_MouseLeave(object sender, EventArgs e)
        {
            botonMas.Image = Resources.nuevo_normal;
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
    }
}
