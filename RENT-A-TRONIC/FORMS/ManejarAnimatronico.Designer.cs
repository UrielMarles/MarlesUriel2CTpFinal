namespace RENT_A_TRONIC.FORMS
{
    partial class frmManejoAnimatronico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            textBoxNombre = new TextBox();
            lblDescripcion = new Label();
            textBoxDescripcion = new RichTextBox();
            alma2 = new PictureBox();
            label1 = new Label();
            botonMenos = new PictureBox();
            alma3 = new PictureBox();
            alma1 = new PictureBox();
            botonMas = new PictureBox();
            DisplayError = new Label();
            btn_aceptar = new PictureBox();
            btn_cancelar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)alma2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonMenos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alma3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alma1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonMas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_aceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancelar).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Black;
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Font = new Font("Papyrus", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(28, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(341, 78);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "NOMBRE :";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.MenuText;
            textBoxNombre.Font = new Font("Papyrus", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = SystemColors.Info;
            textBoxNombre.Location = new Point(424, 24);
            textBoxNombre.MaxLength = 50;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(581, 83);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Black;
            lblDescripcion.BorderStyle = BorderStyle.Fixed3D;
            lblDescripcion.Font = new Font("Papyrus", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.ForeColor = SystemColors.ButtonHighlight;
            lblDescripcion.Location = new Point(28, 136);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(488, 78);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "DESCRIPCION:";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BackColor = SystemColors.MenuText;
            textBoxDescripcion.Font = new Font("Papyrus", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.ForeColor = SystemColors.Menu;
            textBoxDescripcion.Location = new Point(28, 239);
            textBoxDescripcion.MaxLength = 200;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(1082, 111);
            textBoxDescripcion.TabIndex = 6;
            textBoxDescripcion.Text = "";
            // 
            // alma2
            // 
            alma2.BackColor = Color.Transparent;
            alma2.Image = Properties.Resources.ALMA;
            alma2.Location = new Point(839, 380);
            alma2.Name = "alma2";
            alma2.Size = new Size(99, 78);
            alma2.SizeMode = PictureBoxSizeMode.Zoom;
            alma2.TabIndex = 7;
            alma2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Papyrus", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 380);
            label1.Name = "label1";
            label1.Size = new Size(633, 78);
            label1.TabIndex = 8;
            label1.Text = "CANTIDAD ALMAS:";
            // 
            // botonMenos
            // 
            botonMenos.BackColor = Color.Transparent;
            botonMenos.Image = Properties.Resources.menos_normal;
            botonMenos.Location = new Point(667, 380);
            botonMenos.Name = "botonMenos";
            botonMenos.Size = new Size(102, 93);
            botonMenos.SizeMode = PictureBoxSizeMode.Zoom;
            botonMenos.TabIndex = 9;
            botonMenos.TabStop = false;
            botonMenos.Click += botonMenos_Click;
            botonMenos.MouseEnter += botonMenos_MouseEnter;
            botonMenos.MouseLeave += botonMenos_MouseLeave;
            // 
            // alma3
            // 
            alma3.BackColor = Color.Transparent;
            alma3.Image = Properties.Resources.ALMA;
            alma3.Location = new Point(921, 380);
            alma3.Name = "alma3";
            alma3.Size = new Size(99, 78);
            alma3.SizeMode = PictureBoxSizeMode.Zoom;
            alma3.TabIndex = 10;
            alma3.TabStop = false;
            // 
            // alma1
            // 
            alma1.BackColor = Color.Transparent;
            alma1.Image = Properties.Resources.ALMA;
            alma1.Location = new Point(759, 380);
            alma1.Name = "alma1";
            alma1.Size = new Size(99, 78);
            alma1.SizeMode = PictureBoxSizeMode.Zoom;
            alma1.TabIndex = 11;
            alma1.TabStop = false;
            // 
            // botonMas
            // 
            botonMas.BackColor = Color.Transparent;
            botonMas.Image = Properties.Resources.nuevo_normal;
            botonMas.Location = new Point(1008, 380);
            botonMas.Name = "botonMas";
            botonMas.Size = new Size(102, 93);
            botonMas.SizeMode = PictureBoxSizeMode.Zoom;
            botonMas.TabIndex = 12;
            botonMas.TabStop = false;
            botonMas.Click += botonMas_Click;
            botonMas.MouseEnter += botonMas_MouseEnter;
            botonMas.MouseLeave += botonMas_MouseLeave;
            // 
            // DisplayError
            // 
            DisplayError.Anchor = AnchorStyles.Bottom;
            DisplayError.AutoSize = true;
            DisplayError.BackColor = Color.Transparent;
            DisplayError.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayError.ForeColor = Color.Red;
            DisplayError.Location = new Point(562, 162);
            DisplayError.Name = "DisplayError";
            DisplayError.Size = new Size(0, 21);
            DisplayError.TabIndex = 13;
            DisplayError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Transparent;
            btn_aceptar.Image = Properties.Resources.aceptar_normal;
            btn_aceptar.Location = new Point(667, 479);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(291, 88);
            btn_aceptar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_aceptar.TabIndex = 14;
            btn_aceptar.TabStop = false;
            btn_aceptar.Click += btn_aceptar_Click;
            btn_aceptar.MouseEnter += btn_aceptar_MouseEnter;
            btn_aceptar.MouseLeave += btn_aceptar_MouseLeave;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Transparent;
            btn_cancelar.Image = Properties.Resources.cancelar_normal;
            btn_cancelar.Location = new Point(318, 480);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(291, 88);
            btn_cancelar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cancelar.TabIndex = 15;
            btn_cancelar.TabStop = false;
            btn_cancelar.Click += btn_cancelar_Click;
            btn_cancelar.MouseEnter += btn_cancelar_MouseEnter;
            btn_cancelar.MouseLeave += btn_cancelar_MouseLeave;
            // 
            // frmManejoAnimatronico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoEpico1;
            ClientSize = new Size(1191, 580);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(DisplayError);
            Controls.Add(botonMas);
            Controls.Add(alma1);
            Controls.Add(alma3);
            Controls.Add(botonMenos);
            Controls.Add(label1);
            Controls.Add(alma2);
            Controls.Add(textBoxDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(textBoxNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManejoAnimatronico";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)alma2).EndInit();
            ((System.ComponentModel.ISupportInitialize)botonMenos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alma3).EndInit();
            ((System.ComponentModel.ISupportInitialize)alma1).EndInit();
            ((System.ComponentModel.ISupportInitialize)botonMas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_aceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancelar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private TextBox textBoxNombre;
        private Label lblDescripcion;
        private RichTextBox textBoxDescripcion;
        private PictureBox alma2;
        private Label label1;
        private PictureBox botonMenos;
        private PictureBox alma3;
        private PictureBox alma1;
        private PictureBox botonMas;
        private Label DisplayError;
        private PictureBox btn_aceptar;
        private PictureBox btn_cancelar;
    }
}