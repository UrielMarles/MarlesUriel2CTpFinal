using BACK.Entidades;
using RENT_A_TRONIC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RENT_A_TRONIC.FORMS
{
    public partial class FrmError : Form
    {
        private Exception excepcion;
        public FrmError(Exception excepcion)
        {
            InitializeComponent();
            this.excepcion = excepcion;

        }


        private void FrmConfirmar_Load(object sender, EventArgs e)
        {

            pregunta.BringToFront();
        }

        private void si_MouseEnter(object sender, EventArgs e)
        {
            si.Image = Resources.aceptar_hover;
        }

        private void si_MouseLeave(object sender, EventArgs e)
        {
            si.Image = Resources.aceptar_normal;
        }

        private void si_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            si.Image = Resources.aceptar_apretado;
            si.Update();
            Thread.Sleep(100);
            this.Close();
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            foreach (string error in this.excepcion.ListarErrores()) 
            {
                this.ErrorList.Items.Add(error);
            }

        }
    }
}
