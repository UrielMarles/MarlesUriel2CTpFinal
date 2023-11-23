namespace RENT_A_TRONIC.FORMS
{
    partial class frmManejoFiesta
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
            DisplayError = new Label();
            btn_aceptar = new PictureBox();
            btn_cancelar = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            nombreTxT = new TextBox();
            label2 = new Label();
            telefonoTxT = new TextBox();
            label3 = new Label();
            CorreoTxT = new TextBox();
            label4 = new Label();
            fechaElegida = new MonthCalendar();
            opcionesAnims = new ComboBox();
            label1 = new Label();
            anim1 = new TextBox();
            anim2 = new TextBox();
            anim3 = new TextBox();
            borrarAnims = new PictureBox();
            label5 = new Label();
            precioTxT = new TextBox();
            asdsad = new Label();
            lugarTxt = new TextBox();
            sumarBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_aceptar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrarAnims).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sumarBtn).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Black;
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(23, 6);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(324, 40);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "NOMBRE CLIENTE:";
            // 
            // DisplayError
            // 
            DisplayError.Anchor = AnchorStyles.Bottom;
            DisplayError.AutoSize = true;
            DisplayError.BackColor = Color.Transparent;
            DisplayError.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayError.ForeColor = Color.Red;
            DisplayError.Location = new Point(565, 247);
            DisplayError.Name = "DisplayError";
            DisplayError.Size = new Size(0, 21);
            DisplayError.TabIndex = 13;
            DisplayError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.Transparent;
            btn_aceptar.Image = Properties.Resources.aceptar_normal;
            btn_aceptar.Location = new Point(853, 551);
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
            btn_cancelar.Location = new Point(542, 551);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(291, 88);
            btn_cancelar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cancelar.TabIndex = 15;
            btn_cancelar.TabStop = false;
            btn_cancelar.Click += btn_cancelar_Click;
            btn_cancelar.MouseEnter += btn_cancelar_MouseEnter;
            btn_cancelar.MouseLeave += btn_cancelar_MouseLeave;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // nombreTxT
            // 
            nombreTxT.BackColor = SystemColors.MenuText;
            nombreTxT.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nombreTxT.ForeColor = SystemColors.Info;
            nombreTxT.Location = new Point(366, 6);
            nombreTxT.MaxLength = 50;
            nombreTxT.Name = "nombreTxT";
            nombreTxT.Size = new Size(435, 45);
            nombreTxT.TabIndex = 18;
            nombreTxT.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(368, 40);
            label2.TabIndex = 19;
            label2.Text = "TELEFONO CLIENTE:";
            // 
            // telefonoTxT
            // 
            telefonoTxT.BackColor = SystemColors.MenuText;
            telefonoTxT.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            telefonoTxT.ForeColor = SystemColors.Info;
            telefonoTxT.Location = new Point(408, 62);
            telefonoTxT.MaxLength = 50;
            telefonoTxT.Name = "telefonoTxT";
            telefonoTxT.Size = new Size(382, 45);
            telefonoTxT.TabIndex = 20;
            telefonoTxT.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 126);
            label3.Name = "label3";
            label3.Size = new Size(323, 40);
            label3.TabIndex = 21;
            label3.Text = "CORREO CLIENTE:";
            // 
            // CorreoTxT
            // 
            CorreoTxT.BackColor = SystemColors.MenuText;
            CorreoTxT.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CorreoTxT.ForeColor = SystemColors.Info;
            CorreoTxT.Location = new Point(366, 126);
            CorreoTxT.MaxLength = 50;
            CorreoTxT.Name = "CorreoTxT";
            CorreoTxT.Size = new Size(419, 45);
            CorreoTxT.TabIndex = 22;
            CorreoTxT.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(853, 9);
            label4.Name = "label4";
            label4.Size = new Size(264, 40);
            label4.TabIndex = 24;
            label4.Text = "ELEGIR FECHA";
            // 
            // fechaElegida
            // 
            fechaElegida.Location = new Point(869, 82);
            fechaElegida.MaxSelectionCount = 1;
            fechaElegida.Name = "fechaElegida";
            fechaElegida.TabIndex = 25;
            fechaElegida.DateChanged += fechaElegida_DateChanged;
            // 
            // opcionesAnims
            // 
            opcionesAnims.FormattingEnabled = true;
            opcionesAnims.Location = new Point(484, 309);
            opcionesAnims.Name = "opcionesAnims";
            opcionesAnims.Size = new Size(243, 23);
            opcionesAnims.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 274);
            label1.Name = "label1";
            label1.Size = new Size(406, 40);
            label1.TabIndex = 27;
            label1.Text = "AÑADIR ANIMATRONICO";
            // 
            // anim1
            // 
            anim1.BackColor = SystemColors.MenuText;
            anim1.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            anim1.ForeColor = SystemColors.Info;
            anim1.Location = new Point(70, 352);
            anim1.MaxLength = 50;
            anim1.Name = "anim1";
            anim1.ReadOnly = true;
            anim1.Size = new Size(288, 45);
            anim1.TabIndex = 29;
            anim1.TextAlign = HorizontalAlignment.Center;
            // 
            // anim2
            // 
            anim2.BackColor = SystemColors.MenuText;
            anim2.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            anim2.ForeColor = SystemColors.Info;
            anim2.Location = new Point(70, 415);
            anim2.MaxLength = 50;
            anim2.Name = "anim2";
            anim2.ReadOnly = true;
            anim2.Size = new Size(288, 45);
            anim2.TabIndex = 30;
            anim2.TextAlign = HorizontalAlignment.Center;
            // 
            // anim3
            // 
            anim3.BackColor = SystemColors.MenuText;
            anim3.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            anim3.ForeColor = SystemColors.Info;
            anim3.Location = new Point(70, 481);
            anim3.MaxLength = 50;
            anim3.Name = "anim3";
            anim3.ReadOnly = true;
            anim3.Size = new Size(288, 45);
            anim3.TabIndex = 31;
            anim3.TextAlign = HorizontalAlignment.Center;
            // 
            // borrarAnims
            // 
            borrarAnims.BackColor = Color.Transparent;
            borrarAnims.Image = Properties.Resources.borrar_normal;
            borrarAnims.Location = new Point(446, 380);
            borrarAnims.Name = "borrarAnims";
            borrarAnims.Size = new Size(148, 115);
            borrarAnims.SizeMode = PictureBoxSizeMode.Zoom;
            borrarAnims.TabIndex = 32;
            borrarAnims.TabStop = false;
            borrarAnims.Click += borrarAnims_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(853, 309);
            label5.Name = "label5";
            label5.Size = new Size(239, 40);
            label5.TabIndex = 33;
            label5.Text = "PRECIO FINAL";
            // 
            // precioTxT
            // 
            precioTxT.BackColor = SystemColors.MenuText;
            precioTxT.Font = new Font("Papyrus", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            precioTxT.ForeColor = SystemColors.Info;
            precioTxT.Location = new Point(869, 380);
            precioTxT.MaxLength = 50;
            precioTxT.Name = "precioTxT";
            precioTxT.ReadOnly = true;
            precioTxT.Size = new Size(202, 66);
            precioTxT.TabIndex = 36;
            precioTxT.TextAlign = HorizontalAlignment.Center;
            // 
            // asdsad
            // 
            asdsad.AutoSize = true;
            asdsad.BackColor = Color.Black;
            asdsad.BorderStyle = BorderStyle.Fixed3D;
            asdsad.Font = new Font("Papyrus", 18F, FontStyle.Bold, GraphicsUnit.Point);
            asdsad.ForeColor = SystemColors.ButtonHighlight;
            asdsad.Location = new Point(109, 190);
            asdsad.Name = "asdsad";
            asdsad.Size = new Size(221, 40);
            asdsad.TabIndex = 38;
            asdsad.Text = "DIRE LUGAR:";
            // 
            // lugarTxt
            // 
            lugarTxt.BackColor = SystemColors.MenuText;
            lugarTxt.Font = new Font("Papyrus", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lugarTxt.ForeColor = SystemColors.Info;
            lugarTxt.Location = new Point(371, 199);
            lugarTxt.MaxLength = 50;
            lugarTxt.Name = "lugarTxt";
            lugarTxt.Size = new Size(419, 45);
            lugarTxt.TabIndex = 39;
            lugarTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // sumarBtn
            // 
            sumarBtn.BackColor = Color.Transparent;
            sumarBtn.Image = Properties.Resources.nuevo_normal;
            sumarBtn.Location = new Point(594, 380);
            sumarBtn.Name = "sumarBtn";
            sumarBtn.Size = new Size(155, 107);
            sumarBtn.SizeMode = PictureBoxSizeMode.Zoom;
            sumarBtn.TabIndex = 40;
            sumarBtn.TabStop = false;
            sumarBtn.Click += sumarBtn_Click;
            // 
            // frmManejoFiesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoEpico1;
            ClientSize = new Size(1189, 641);
            Controls.Add(sumarBtn);
            Controls.Add(lugarTxt);
            Controls.Add(asdsad);
            Controls.Add(precioTxT);
            Controls.Add(label5);
            Controls.Add(borrarAnims);
            Controls.Add(anim3);
            Controls.Add(anim2);
            Controls.Add(anim1);
            Controls.Add(label1);
            Controls.Add(opcionesAnims);
            Controls.Add(fechaElegida);
            Controls.Add(label4);
            Controls.Add(CorreoTxT);
            Controls.Add(label3);
            Controls.Add(telefonoTxT);
            Controls.Add(label2);
            Controls.Add(nombreTxT);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(DisplayError);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManejoFiesta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)btn_aceptar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrarAnims).EndInit();
            ((System.ComponentModel.ISupportInitialize)sumarBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label DisplayError;
        private PictureBox btn_aceptar;
        private PictureBox btn_cancelar;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox CorreoTxT;
        private Label label3;
        private TextBox telefonoTxT;
        private Label label2;
        private TextBox nombreTxT;
        private MonthCalendar fechaElegida;
        private Label label4;
        private ComboBox opcionesAnims;
        private PictureBox borrarAnims;
        private TextBox anim3;
        private TextBox anim2;
        private TextBox anim1;
        private Label label1;
        private Label label5;
        private TextBox precioTxT;
        private TextBox lugarTxt;
        private Label asdsad;
        private PictureBox sumarBtn;
    }
}