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
    public enum EtipoTabla { Animatronicos, Fiestas, Usuarios }
    public partial class FrmTabla<T> : Form where T : InterfazEntidades, new() 
    {
        private ConexionConTabla conect;
        private ColeccionEntidades<T> colecEntidades;
        private UsuarioEntidad user;
        private EtipoTabla tipo;
        private string stringFiltro;
        private bool mostrarOcultos;

        public FrmTabla(ConexionConTabla conect, UsuarioEntidad user,bool mostrarOcultos)
        {
            InitializeComponent();
            this.conect = conect;
            this.user = user;
            this.mostrarOcultos = mostrarOcultos;
            AsignarTipo();
            ActualizarTabla();
            if (!user.EsAdmin)
            {
                adminDance.Visible = false;
            }
            errorTxt.BringToFront();
            btnBuscar.BringToFront();
            textBoxBusqueda.BringToFront();
        }

        
        public void ActualizarTabla()
        {
            ActualizarTabla(true);
        }
        public void ActualizarTabla(bool conFiltro)
        {
            this.colecEntidades = new ColeccionEntidades<T>(conect,!mostrarOcultos);
            tablaInfo.DataSource = colecEntidades.ListaT;
            if (stringFiltro != "" && !(stringFiltro is null) && conFiltro)
            {
                this.colecEntidades = new ColeccionEntidades<T>(colecEntidades.NombreContieneString(stringFiltro), conect);
                tablaInfo.DataSource = colecEntidades.ListaT;
            }
            tablaInfo.Columns["NombreTabla"].Visible = false;
        }
        /// BOTON NUEVO
        private async void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_nuevo.Image = Resources.nuevo_apretado;
            btn_nuevo.Update();
            Thread.Sleep(100);
            btn_nuevo.Image = Resources.nuevo_horver;
            bool entrar = true;
            if (tablaInfo.SelectedRows.Count == 1)
            {
                if (((InterfazEntidades)tablaInfo.SelectedRows[0].DataBoundItem).Activo)
                {
                    entrar = false;
                }
            }
            if (entrar)
            {
                switch (tipo)
                {
                    case EtipoTabla.Fiestas:
                        this.Hide();
                        frmManejoFiesta frmfiesta = new frmManejoFiesta(conect, user);
                        this.Show();
                        break;
                    case EtipoTabla.Animatronicos:
                        if (await validarAdmin())
                        {
                            this.Hide();
                            frmManejoAnimatronico frmNuevoAnimatronico = new frmManejoAnimatronico(conect, user);
                            frmNuevoAnimatronico.ShowDialog();
                            this.Show();
                        }
                        break;
                    case EtipoTabla.Usuarios:
                        if (user.EsAdmin)
                        {
                            this.Hide();
                            frmManejoUsuario frmNuevoUsuario = new frmManejoUsuario(conect);
                            frmNuevoUsuario.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            await Task.Run(async () => { errorTxt.Invoke((MethodInvoker)delegate { errorTxt.Text = "no tienes permiso"; }); await Task.Delay(500); errorTxt.Invoke((MethodInvoker)delegate { errorTxt.Text = ""; }); });
                        }
                        break;
                }
            }
            ActualizarTabla();
            
        }
        private void btn_nuevo_MouseEnter(object sender, EventArgs e)
        {
            btn_nuevo.Image = Resources.nuevo_horver;
        }

        private async Task<bool> validarAdmin()
        {
            if (user.EsAdmin)
            {
                return true;
            }
            else
            {
                await Task.Run(FaltaPermiso);
                return false;
            }
        }

        private async Task FaltaPermiso()
        {
            errorTxt.Invoke((MethodInvoker)delegate
            {
                errorTxt.Text = "No tienes permiso";
            });
            await Task.Delay(500);
            errorTxt.Invoke((MethodInvoker)delegate
            {
                errorTxt.Text = "";
            });
        }
        private void btn_nuevo_MouseLeave(object sender, EventArgs e)
        {
            btn_nuevo.Image = Resources.nuevo_normal;
        }

        /// BOTON EDITAR
        private async void btn_editar_Click(object sender, EventArgs e)
        {
            btn_editar.Image = Resources.editar_apretado;
            bool entrar = true;
            if(tablaInfo.SelectedRows.Count == 1 )
            {
                if (((InterfazEntidades)tablaInfo.SelectedRows[0].DataBoundItem).Activo)
                {
                    entrar = false;
                }
            }
            if(entrar)
            {
                switch (tipo)
                {
                    case EtipoTabla.Fiestas:
                        if (tablaInfo.SelectedRows.Count == 1)
                        {
                            this.Hide();
                            frmManejoFiesta frmFiesta = new frmManejoFiesta(conect, user, (FiestaEntidad)tablaInfo.SelectedRows[0].DataBoundItem);
                            frmFiesta.ShowDialog();
                            this.Show();
                        }
                        break;
                    case EtipoTabla.Animatronicos:
                        if (await validarAdmin() && tablaInfo.SelectedRows.Count == 1)
                        {
                            this.Hide();
                            AnimatronicoEntidad editando = (AnimatronicoEntidad)tablaInfo.SelectedRows[0].DataBoundItem;
                            frmManejoAnimatronico frmNuevoAnimatronico = new frmManejoAnimatronico(conect, user, editando);
                            frmNuevoAnimatronico.ShowDialog();
                            this.Show();
                        }
                        break;
                    case EtipoTabla.Usuarios:
                        if (await validarAdmin() && tablaInfo.SelectedRows.Count == 1)
                        {
                            this.Hide();
                            UsuarioEntidad usereditando = (UsuarioEntidad)tablaInfo.SelectedRows[0].DataBoundItem;
                            frmManejoUsuario frmNuevoUser = new frmManejoUsuario(conect, usereditando);
                            frmNuevoUser.ShowDialog();
                            this.Show();
                        }
                        break;
                }
            }

            ActualizarTabla();
            
        }


        private void btn_editar_MouseEnter(object sender, EventArgs e)
        {
            btn_editar.Image = Resources.editar_hover;
        }

        private void btn_editar_MouseLeave(object sender, EventArgs e)
        {
            btn_editar.Image = Resources.editar_normal;
        }

        /// BOTON BORRAR
        private async void btn_borrar_Click(object sender, EventArgs e)
        {
            btn_borrar.Image = Resources.borrar_apretado;
            FrmConfirmar pregunta = new FrmConfirmar("Borrar?");
            bool selected = false;
            InterfazEntidades borrando = new T();
            bool entrar = true;
            if (tablaInfo.SelectedRows.Count == 1)
            {
                if (((InterfazEntidades)tablaInfo.SelectedRows[0].DataBoundItem).Activo)
                {
                    entrar = false;
                }
            }
            if (entrar)
            {
                if (tablaInfo.SelectedRows.Count == 1)
                {
                    borrando = (InterfazEntidades)tablaInfo.SelectedRows[0].DataBoundItem;
                    selected = true;
                }
                DialogResult result;
                if ((tipo == EtipoTabla.Fiestas || await validarAdmin()) && selected)
                {
                    result = pregunta.ShowDialog();
                    pregunta.Dispose();
                    if (result == DialogResult.Yes)
                    {
                        borrando.Activo = false;
                        borrando.ActualizarEntradaEnLaTabla(conect);
                    }
                }
            }
            ActualizarTabla();
        }

        private void btn_borrar_MouseEnter(object sender, EventArgs e)
        {
            btn_borrar.Image = Resources.borrar_hover;
        }

        private void btn_borrar_MouseLeave(object sender, EventArgs e)
        {
            btn_borrar.Image = Resources.borrar_normal;
        }
        private void volverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            stringFiltro = textBoxBusqueda.Text;
            ActualizarTabla(true);
        }
        private void DarColorRojoALosBorrados(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == tablaInfo.Columns["activo"].Index && e.Value != null)
            {
                bool valorActivo = (bool)e.Value;

                if (valorActivo)
                {
                    foreach (DataGridViewCell cell in tablaInfo.Rows[e.RowIndex].Cells)
                    {
                        cell.Style.BackColor = Color.LightCyan;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in tablaInfo.Rows[e.RowIndex].Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
            }

        }
        public void AsignarTipo()
        {
            InterfazEntidades asignarTipo = new T();
            switch (asignarTipo.NombreTabla)
            {
                case "animatronicos":
                    this.tipo = EtipoTabla.Animatronicos;
                    break;
                case "fiestas":
                    this.tipo = EtipoTabla.Fiestas; break;
                case "usuarios":
                    this.tipo = EtipoTabla.Usuarios; break;
            }
        }
    }
}
