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
    public partial class FrmConfirmar : Form
    {
        private string texto;
        public FrmConfirmar(string texto)
        {
            InitializeComponent();
            this.texto = texto;
        }

        private void FrmConfirmar_Load(object sender, EventArgs e)
        {

            pregunta.BringToFront();
            pregunta.Text = texto;
        }

        private void si_MouseEnter(object sender, EventArgs e)
        {
            si.Image = Resources.si_hover;
        }

        private void si_MouseLeave(object sender, EventArgs e)
        {
            si.Image = Resources.si_normal;
        }

        private void si_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            si.Image = Resources.si_apretado;
            si.Update();
            Thread.Sleep(100);
            this.Close();
        }

        private void no_MouseEnter(object sender, EventArgs e)
        {
            no.Image = Resources.no_hover;
        }

        private void no_MouseLeave(object sender, EventArgs e)
        {
            no.Image = Resources.no_normal;
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            no.Image = Resources.no_apretado;
            no.Update();
            Thread.Sleep(100);
            this.Close();
        }
    }
}
