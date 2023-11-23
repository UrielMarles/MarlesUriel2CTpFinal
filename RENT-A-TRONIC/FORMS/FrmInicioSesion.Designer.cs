namespace RENT_A_TRONIC
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            pictureBox1 = new PictureBox();
            BotonCerrar = new PictureBox();
            EntrarBtn = new PictureBox();
            pictureBox2 = new PictureBox();
            IngresoNombre = new TextBox();
            IngreseUsuario = new Label();
            enie = new Label();
            label1 = new Label();
            IngresoContrasenia = new TextBox();
            DisplayError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EntrarBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.DANCING_HELPY;
            pictureBox1.Location = new Point(51, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonCerrar
            // 
            BotonCerrar.BackColor = Color.Transparent;
            BotonCerrar.BackgroundImageLayout = ImageLayout.None;
            BotonCerrar.Image = Properties.Resources.cerrar_normal;
            BotonCerrar.Location = new Point(1107, -27);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(74, 79);
            BotonCerrar.TabIndex = 1;
            BotonCerrar.TabStop = false;
            BotonCerrar.Click += BotonCerrar_Click;
            BotonCerrar.MouseEnter += BotonCerrar_MouseEnter;
            BotonCerrar.MouseLeave += BotonCerrar_MouseLeave;
            // 
            // EntrarBtn
            // 
            EntrarBtn.BackColor = Color.Transparent;
            EntrarBtn.Image = Properties.Resources.entrar_normal;
            EntrarBtn.Location = new Point(493, 436);
            EntrarBtn.Name = "EntrarBtn";
            EntrarBtn.Size = new Size(219, 69);
            EntrarBtn.SizeMode = PictureBoxSizeMode.Zoom;
            EntrarBtn.TabIndex = 2;
            EntrarBtn.TabStop = false;
            EntrarBtn.MouseClick += EntrarBtn_MouseClick;
            EntrarBtn.MouseEnter += EntrarBtn_MouseEnter;
            EntrarBtn.MouseLeave += EntrarBtn_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TITULO;
            pictureBox2.Location = new Point(332, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(541, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // IngresoNombre
            // 
            IngresoNombre.BackColor = SystemColors.ScrollBar;
            IngresoNombre.BorderStyle = BorderStyle.FixedSingle;
            IngresoNombre.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IngresoNombre.Location = new Point(466, 227);
            IngresoNombre.Name = "IngresoNombre";
            IngresoNombre.Size = new Size(261, 28);
            IngresoNombre.TabIndex = 4;
            // 
            // IngreseUsuario
            // 
            IngreseUsuario.AutoSize = true;
            IngreseUsuario.BackColor = Color.Transparent;
            IngreseUsuario.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            IngreseUsuario.Location = new Point(482, 190);
            IngreseUsuario.Name = "IngreseUsuario";
            IngreseUsuario.Size = new Size(230, 21);
            IngreseUsuario.TabIndex = 5;
            IngreseUsuario.Text = "INGRESE USUARIO:";
            // 
            // enie
            // 
            enie.AutoSize = true;
            enie.BackColor = Color.Transparent;
            enie.Font = new Font("Minecraft", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            enie.Location = new Point(698, 282);
            enie.Name = "enie";
            enie.Size = new Size(13, 13);
            enie.TabIndex = 6;
            enie.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(456, 292);
            label1.Name = "label1";
            label1.Size = new Size(276, 21);
            label1.TabIndex = 7;
            label1.Text = "INGRESE CONTRASENA";
            // 
            // IngresoContrasenia
            // 
            IngresoContrasenia.BackColor = SystemColors.ScrollBar;
            IngresoContrasenia.BorderStyle = BorderStyle.FixedSingle;
            IngresoContrasenia.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IngresoContrasenia.Location = new Point(466, 336);
            IngresoContrasenia.Name = "IngresoContrasenia";
            IngresoContrasenia.PasswordChar = '*';
            IngresoContrasenia.Size = new Size(261, 28);
            IngresoContrasenia.TabIndex = 8;
            // 
            // DisplayError
            // 
            DisplayError.Anchor = AnchorStyles.Bottom;
            DisplayError.AutoSize = true;
            DisplayError.BackColor = Color.Transparent;
            DisplayError.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayError.ForeColor = Color.Red;
            DisplayError.Location = new Point(389, 142);
            DisplayError.Name = "DisplayError";
            DisplayError.Size = new Size(0, 21);
            DisplayError.TabIndex = 9;
            DisplayError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 645);
            Controls.Add(DisplayError);
            Controls.Add(IngresoContrasenia);
            Controls.Add(label1);
            Controls.Add(enie);
            Controls.Add(IngreseUsuario);
            Controls.Add(IngresoNombre);
            Controls.Add(pictureBox2);
            Controls.Add(EntrarBtn);
            Controls.Add(BotonCerrar);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Hiragana;
            Name = "FrmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA RENT-A-TRONIC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)EntrarBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox BotonCerrar;
        private PictureBox EntrarBtn;
        private PictureBox pictureBox2;
        private TextBox IngresoNombre;
        private Label IngreseUsuario;
        private Label enie;
        private Label label1;
        private TextBox IngresoContrasenia;
        private Label DisplayError;
    }
}