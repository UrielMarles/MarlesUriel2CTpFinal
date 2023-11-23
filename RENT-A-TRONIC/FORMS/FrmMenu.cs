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
    public partial class FrmMenu : Form
    {
        private ConexionConTabla conect;
        private UsuarioEntidad usuario;
        private FrmInicioSesion inicioSesion;
        private bool forzarCerrado;
        private bool mostrandoOcultos;


        public FrmMenu(ConexionConTabla conect)
        {
            //throw new ExcepcionConstruyendoEntidad("descomento esto para ver el error");
            this.conect = conect;
            forzarCerrado = false;
            mostrandoOcultos = false;
            InitializeComponent();

        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            inicioSesion = new FrmInicioSesion(conect);
            inicioSesion.alRecibirUsuario += usuario => { this.usuario = usuario; };// expresion lambda
            inicioSesion.alRecibirUsuario += actualizarImagenes;
            inicioSesion.cerrando += forzarCierre;
            this.Hide();
            inicioSesion.ShowDialog();
            this.Show();
            if (!conect.FuncionaConexion)
            {
                throw new Exception("No se pudo conectar con la tabla");
            }
            ActualizarGanancias();
        }
        public void ActualizarGanancias()
        {
            int DineroGanado = 0;
            int AlmasGanadas = 0;
            int nuevasDenuncias = 0;
            int nuevasVentas = 0;
            Random random = new Random();
            List<InterfazEntidades> entidadesActualizar = new List<InterfazEntidades> { };
            ColeccionEntidades<FiestaEntidad> fiestasTotales = new ColeccionEntidades<FiestaEntidad>(conect);
            ColeccionEntidades<AnimatronicoEntidad> animatronicosTotales = new ColeccionEntidades<AnimatronicoEntidad>(conect);
            ColeccionEntidades<AnimatronicoFiestaEntidad> tablaIntermedia = new ColeccionEntidades<AnimatronicoFiestaEntidad>(conect);
            ColeccionEntidades<CantidadEntidad> cantidadesTotales = new ColeccionEntidades<CantidadEntidad>(conect);
            foreach (FiestaEntidad fi in fiestasTotales.ListaT)
            {

                if (fi.Fecha <= DateTime.Now.Date)
                {
                    fi.Activo = false;
                    DineroGanado += fi.Precio;
                    bool denuncia = random.Next(2) == 0;
                    if (denuncia)
                    {
                        nuevasDenuncias++;
                    }
                    entidadesActualizar.Add(fi);
                    ColeccionEntidades<UsuarioEntidad> usuariosTotales = new ColeccionEntidades<UsuarioEntidad>(conect);
                    UsuarioEntidad consiguioVenta = usuariosTotales.ObtenerPorId(fi.AdminFiestaId);
                    consiguioVenta.CantidadVentas += 1;
                    ((InterfazEntidades)consiguioVenta).ActualizarEntradaEnLaTabla(conect);
                    foreach (AnimatronicoFiestaEntidad animFiesta in tablaIntermedia["fiestaId", fi.Id.ToString()])
                    {
                        animFiesta.Activo = false;
                        entidadesActualizar.Add(animFiesta);
                        AnimatronicoEntidad animAsociado = animatronicosTotales.ObtenerPorId(animFiesta.AnimatronicoId);
                        AlmasGanadas += animAsociado.CantidadAlmas;
                    }
                }
            }
            CantidadEntidad dinero = cantidadesTotales["nombre", "dinero"][0];
            CantidadEntidad almas = cantidadesTotales["nombre", "almas"][0];
            CantidadEntidad denuncias = cantidadesTotales["nombre", "cantidad denuncias"][0];
            dinero.Cantidad += DineroGanado;
            almas.Cantidad += AlmasGanadas;
            denuncias.Cantidad += nuevasDenuncias;
            entidadesActualizar.Add(dinero);
            entidadesActualizar.Add(almas);
            entidadesActualizar.Add(denuncias);
            foreach (InterfazEntidades entity in entidadesActualizar)
            {
                entity.ActualizarEntradaEnLaTabla(conect);
            }
        }
        public void forzarCierre()
        {
            forzarCerrado = true;
            Application.Exit();
        }
        public void guardarUsuario(UsuarioEntidad usuario)
        {
            this.usuario = usuario;
        }

        public void actualizarImagenes(UsuarioEntidad usuario)
        {
            this.lblSaludo.Text = $"Bienvenido {usuario.Nombre}";
            this.DisplayError.Text = "";
            if (usuario.EsAdmin)
            {
                adminDance.Visible = true;
                adminDance2.Visible = true;

            }
            else
            {
                adminDance.Visible = false;
                adminDance2.Visible = false;
            }
        }
        /// CICLO DE VIDA

        private void FrmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forzarCerrado)
            {
                FrmConfirmar pregunta = new FrmConfirmar("   Seguro que \nquieres cerrar?");
                DialogResult result = pregunta.ShowDialog();
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
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
            this.Close();
        }


        private void btnAnimatronicos_Click(object sender, EventArgs e)
        {
            btnAnimatronicos.Image = Resources.animatronicos_apretados;
            btnAnimatronicos.Update();
            Thread.Sleep(50);
            btnAnimatronicos.Image = Resources.animatronicos_normal;
            FrmTabla<AnimatronicoEntidad> tablaAni = new FrmTabla<AnimatronicoEntidad>(conect, usuario, mostrandoOcultos);
            this.Hide();
            tablaAni.ShowDialog();
            this.Show();
        }

        private void btnFiestas_Click(object sender, EventArgs e)
        {
            btnFiestas.Image = Resources.fiestas_apretado;
            btnFiestas.Update();
            Thread.Sleep(50);
            btnFiestas.Image = Resources.fiestas_normal;
            FrmTabla<FiestaEntidad> tablaAni = new FrmTabla<FiestaEntidad>(conect, usuario, mostrandoOcultos);
            this.Hide();
            tablaAni.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            btnUsuarios.Image = Resources.usuarios_apretado;
            btnUsuarios.Update();
            Thread.Sleep(50);
            btnUsuarios.Image = Resources.usuarios_normal;
            if (usuario.EsAdmin)
            {
                FrmTabla<UsuarioEntidad> tablaAni = new FrmTabla<UsuarioEntidad>(conect, usuario, mostrandoOcultos);
                this.Hide();
                tablaAni.ShowDialog();
                this.Show();
            }
            else
            {
                DisplayError.Text = "No tienes permiso";
            }

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            FrmOptions opciones = new FrmOptions(usuario, inicioSesion, mostrandoOcultos, conect);
            opciones.cambio += cambiarVisibilidad;
            opciones.ShowDialog();
        }

        private void cambiarVisibilidad(bool visibilidad)
        {
            this.mostrandoOcultos = visibilidad;
        }
    }
}
