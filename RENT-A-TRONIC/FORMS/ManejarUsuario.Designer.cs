namespace RENT_A_TRONIC.FORMS
{
    partial class frmManejoUsuario
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
            DisplayError = new Label();
            btn_aceptar = new PictureBox();
            btn_cancelar = new PictureBox();
            label1 = new Label();
            contraseña1 = new TextBox();
            label2 = new Label();
            contraseña2 = new TextBox();
            label3 = new Label();
            telefono = new TextBox();
            label4 = new Label();
            btnEsAdmin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_aceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEsAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Black;
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Font = new Font("Papyrus", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(215, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(232, 53);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "NOMBRE :";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.MenuText;
            textBoxNombre.Font = new Font("Papyrus", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.ForeColor = SystemColors.Info;
            textBoxNombre.Location = new Point(491, 44);
            textBoxNombre.MaxLength = 50;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(581, 58);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // DisplayError
            // 
            DisplayError.Anchor = AnchorStyles.Bottom;
            DisplayError.AutoSize = true;
            DisplayError.BackColor = Color.Transparent;
            DisplayError.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayError.ForeColor = Color.Red;
            DisplayError.Location = new Point(415, 9);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Papyrus", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(188, 141);
            label1.Name = "label1";
            label1.Size = new Size(350, 53);
            label1.TabIndex = 16;
            label1.Text = "CONTRASEÑA:";
            // 
            // contraseña1
            // 
            contraseña1.BackColor = SystemColors.MenuText;
            contraseña1.Font = new Font("Papyrus", 24F, FontStyle.Regular, GraphicsUnit.Point);
            contraseña1.ForeColor = SystemColors.Info;
            contraseña1.Location = new Point(599, 136);
            contraseña1.MaxLength = 50;
            contraseña1.Name = "contraseña1";
            contraseña1.Size = new Size(473, 58);
            contraseña1.TabIndex = 17;
            contraseña1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Papyrus", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 231);
            label2.Name = "label2";
            label2.Size = new Size(532, 53);
            label2.TabIndex = 18;
            label2.Text = "REPETIR CONTRASEÑA";
            // 
            // contraseña2
            // 
            contraseña2.BackColor = SystemColors.MenuText;
            contraseña2.Font = new Font("Papyrus", 24F, FontStyle.Regular, GraphicsUnit.Point);
            contraseña2.ForeColor = SystemColors.Info;
            contraseña2.Location = new Point(599, 226);
            contraseña2.MaxLength = 50;
            contraseña2.Name = "contraseña2";
            contraseña2.Size = new Size(473, 58);
            contraseña2.TabIndex = 19;
            contraseña2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Papyrus", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(163, 317);
            label3.Name = "label3";
            label3.Size = new Size(284, 53);
            label3.TabIndex = 20;
            label3.Text = "TELEFONO:";
            // 
            // telefono
            // 
            telefono.BackColor = SystemColors.MenuText;
            telefono.Font = new Font("Papyrus", 24F, FontStyle.Regular, GraphicsUnit.Point);
            telefono.ForeColor = SystemColors.Info;
            telefono.Location = new Point(491, 312);
            telefono.MaxLength = 50;
            telefono.Name = "telefono";
            telefono.Size = new Size(581, 58);
            telefono.TabIndex = 21;
            telefono.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Papyrus", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(30, 405);
            label4.Name = "label4";
            label4.Size = new Size(625, 53);
            label4.TabIndex = 22;
            label4.Text = "TIENE PERMISOS DE ADMIN:";
            // 
            // btnEsAdmin
            // 
            btnEsAdmin.BackColor = Color.Transparent;
            btnEsAdmin.Image = Properties.Resources.si_normal;
            btnEsAdmin.Location = new Point(703, 405);
            btnEsAdmin.Name = "btnEsAdmin";
            btnEsAdmin.Size = new Size(100, 50);
            btnEsAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            btnEsAdmin.TabIndex = 23;
            btnEsAdmin.TabStop = false;
            btnEsAdmin.Click += btnEsAdmin_Click;
            // 
            // frmManejoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoEpico1;
            ClientSize = new Size(1191, 580);
            Controls.Add(btnEsAdmin);
            Controls.Add(label4);
            Controls.Add(telefono);
            Controls.Add(label3);
            Controls.Add(contraseña2);
            Controls.Add(label2);
            Controls.Add(contraseña1);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(DisplayError);
            Controls.Add(textBoxNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManejoUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)btn_aceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEsAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private TextBox textBoxNombre;
        private Label DisplayError;
        private PictureBox btn_aceptar;
        private PictureBox btn_cancelar;
        private Label label1;
        private TextBox contraseña1;
        private Label label2;
        private TextBox contraseña2;
        private Label label3;
        private TextBox telefono;
        private Label label4;
        private PictureBox btnEsAdmin;
    }
}