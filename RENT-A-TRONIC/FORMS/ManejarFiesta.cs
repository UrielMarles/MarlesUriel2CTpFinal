using BACK;
using BACK.Entidades;
using BACK.Scripts;
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
    public partial class frmManejoFiesta : Form
    {
        private ConexionConTabla cnct;
        private UsuarioEntidad user;
        private ColeccionEntidades<AnimatronicoEntidad> animatronicosTotales;
        private ColeccionEntidades<AnimatronicoFiestaEntidad> AnimatronicosFiestasTotales;
        private ColeccionEntidades<FiestaEntidad> FiestasTotales;
        private List<AnimatronicoFiestaEntidad> animatronicosFiestasViejos;
        private AnimatronicoEntidad objAnim1;
        private AnimatronicoEntidad objAnim2;
        private AnimatronicoEntidad objAnim3;
        private FiestaEntidad? fiesta;
        private bool actualizando;
        private int precioActual;
        public frmManejoFiesta(ConexionConTabla cnct, UsuarioEntidad user)
        {
            InitializeComponent();
            this.cnct = cnct;
            this.user = user;
            this.precioActual = 0;
            actualizando = false;
            ActualizarTotales();
            InstanciarTextos();
            ActualizarTextosAnims();
        }
        public frmManejoFiesta(ConexionConTabla cnct, UsuarioEntidad user, FiestaEntidad fiesta)
        {
            InitializeComponent();
            this.fiesta = fiesta;
            this.cnct = cnct;
            this.user = user;
            actualizando = true;
            this.precioActual = 0;
            ActualizarTotales();
            InstanciarTextos();
            ActualizarTextosAnims();
        }

        private void ActualizarTotales()
        {
            fechaElegida.MinDate = DateTime.Now.Date.AddDays(1);
            this.animatronicosTotales = new ColeccionEntidades<AnimatronicoEntidad>(cnct);
            this.AnimatronicosFiestasTotales = new ColeccionEntidades<AnimatronicoFiestaEntidad>(cnct);
            this.FiestasTotales = new ColeccionEntidades<FiestaEntidad>(cnct);
        }
        private void ActualizarTextosAnims()
        {
            precioActual = 0;
            List<string> nombres = new List<string>();
            foreach (AnimatronicoEntidad animaTotal in animatronicosTotales.ListaT)
            {
                List<AnimatronicoFiestaEntidad> fiestasDelAnim = AnimatronicosFiestasTotales.EntidadesConValorEnLLave("animatronicoId", animaTotal.Id.ToString());
                bool estaLibre = true;
                foreach (AnimatronicoFiestaEntidad rela in fiestasDelAnim)
                {
                    if (FiestasTotales.ObtenerPorId(rela.FiestaId).Fecha == fechaElegida.SelectionStart)
                    {
                        estaLibre = false;
                    }
                }
                if (estaLibre)
                {
                    nombres.Add(animaTotal.Nombre);
                }
            }
            if (!(objAnim1 is null))
            {
                precioActual += 500;
                anim1.Text = objAnim1.Nombre;
                nombres.Remove(objAnim1.Nombre);
            }
            else
            {
                anim1.Text = "";
            }
            if (!(objAnim2 is null))
            {
                precioActual += 500;
                anim2.Text = objAnim2.Nombre;
                nombres.Remove(objAnim2.Nombre);
            }
            else
            {
                anim2.Text = "";
            }
            if (!(objAnim3 is null))
            {
                precioActual += 500;
                anim3.Text = objAnim3.Nombre;
                nombres.Remove(objAnim3.Nombre);
            }
            else
            {
                anim3.Text = "";
            }
            precioTxT.Text = precioActual.ToString();
            opcionesAnims.DataSource = nombres;
            opcionesAnims.SelectedIndex = -1    ;
            opcionesAnims.Update();

        }
        private void InstanciarTextos()
        {
            fechaElegida.SelectionStart = DateTime.Now.Date.AddDays(1);
            if (!(this.fiesta is null))
            {
                animatronicosFiestasViejos = AnimatronicosFiestasTotales.EntidadesConValorEnLLave("fiestaId", fiesta.Id.ToString());
                int cantidad = animatronicosFiestasViejos.Count;
                if (cantidad > 0)
                {
                    objAnim1 = animatronicosTotales.ObtenerPorId(animatronicosFiestasViejos[0].Id);
                    anim1.Text = objAnim1.Nombre;

                }
                if (cantidad > 1)
                {
                    objAnim2 = animatronicosTotales.ObtenerPorId(animatronicosFiestasViejos[1].Id);
                    anim2.Text = objAnim2.Nombre;
                }
                if (cantidad > 2)
                {
                    objAnim3 = animatronicosTotales.ObtenerPorId(animatronicosFiestasViejos[2].Id);
                    anim3.Text = objAnim3.Nombre;
                }
                nombreTxT.Text = fiesta.NombreCliente;
                telefonoTxT.Text = fiesta.TelefonoCliente;
                CorreoTxT.Text = fiesta.CorreoCliente;
                fechaElegida.SelectionStart = fiesta.Fecha;
                lugarTxt.Text = fiesta.Lugar;
            }
        }

        private void EnviarInformacion()
        {

            if (nombreTxT.Text == "" || telefonoTxT.Text == "" || CorreoTxT.Text == "" || lugarTxt.Text == "" || precioActual == 0)
            {
                DisplayError.Text = "Falta completar algun campo";
            }
            else
            {
                bool actualizando = true;
                if (this.fiesta is null)
                {
                    actualizando = false;
                    fiesta = new FiestaEntidad(lugarTxt.Text, -1, true, int.Parse(precioTxT.Text), nombreTxT.Text, telefonoTxT.Text, CorreoTxT.Text, fechaElegida.SelectionStart, user.Id);

                }
                else
                {
                    fiesta.Lugar = lugarTxt.Text;
                    fiesta.NombreCliente = nombreTxT.Text;
                    fiesta.Fecha = fechaElegida.SelectionStart;
                    fiesta.AdminFiestaId = user.Id;
                    fiesta.Precio = int.Parse(precioTxT.Text);
                    fiesta.TelefonoCliente = telefonoTxT.Text;
                }
                FrmConfirmar pregunta = new FrmConfirmar("Confirmar?");
                DialogResult result = pregunta.ShowDialog();
                pregunta.Dispose();
                if (result == DialogResult.Yes)
                {
                    if (actualizando)
                    {
                        ((InterfazEntidades)fiesta).ActualizarEntradaEnLaTabla(cnct);
                    }
                    else
                    {
                        ((InterfazEntidades)fiesta).CrearEntradaEnLaTabla(cnct);
                    }
                    ActualizarTotales();
                    fiesta = FiestasTotales["nombre", nombreTxT.Text][0];
                    List<AnimatronicoFiestaEntidad> nuevos = new List<AnimatronicoFiestaEntidad>();
                    if (objAnim1 != null)
                    {
                        nuevos.Add(new AnimatronicoFiestaEntidad(-1, true, fiesta.Id, objAnim1.Id));
                    }
                    if (objAnim2 != null)
                    {
                        nuevos.Add(new AnimatronicoFiestaEntidad(-1, true, fiesta.Id, objAnim2.Id));
                    }
                    if (objAnim3 != null)
                    {
                        nuevos.Add(new AnimatronicoFiestaEntidad(-1, true, fiesta.Id, objAnim3.Id));
                    }
                    foreach (AnimatronicoFiestaEntidad animFiest in animatronicosFiestasViejos)
                    {
                        animFiest.Activo = false;
                        ((InterfazEntidades)animFiest).ActualizarEntradaEnLaTabla(cnct);
                    }
                    foreach (AnimatronicoFiestaEntidad animFiest in nuevos)
                    {
                        ((InterfazEntidades)animFiest).CrearEntradaEnLaTabla(cnct);
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

        private void sumarBtn_Click(object sender, EventArgs e)
        {
            if(!(opcionesAnims.SelectedItem.ToString() is null))
            {
                string nombreAnim = opcionesAnims.SelectedItem.ToString();
                AnimatronicoEntidad seleccionado = animatronicosTotales.EntidadesConValorEnLLave("nombre", nombreAnim)[0];
                if (objAnim1 is null)
                {
                    objAnim1 = seleccionado;
                }
                else if (objAnim2 is null)
                {
                    objAnim2 = seleccionado;
                }
                else if (objAnim3 is null)
                {
                    objAnim3 = seleccionado;
                }
                opcionesAnims.SelectedItem = null;
                ActualizarTextosAnims();
            }

        }

        private void borrarAnims_Click(object sender, EventArgs e)
        {
            objAnim1 = null;
            objAnim2 = null;
            objAnim3 = null;
            ActualizarTextosAnims();
        }

        private void fechaElegida_DateChanged(object sender, DateRangeEventArgs e)
        {
            objAnim1 = null;
            objAnim2 = null;
            objAnim3 = null;
            ActualizarTextosAnims();
        }
    }
}
