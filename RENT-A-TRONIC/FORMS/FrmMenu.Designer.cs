namespace RENT_A_TRONIC
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            pictureBox1 = new PictureBox();
            BotonCerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            DisplayError = new Label();
            lblSaludo = new Label();
            btnAnimatronicos = new PictureBox();
            btnFiestas = new PictureBox();
            btnUsuarios = new PictureBox();
            adminDance = new PictureBox();
            adminDance2 = new PictureBox();
            btnOptions = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAnimatronicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnFiestas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDance2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOptions).BeginInit();
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
            // DisplayError
            // 
            DisplayError.Anchor = AnchorStyles.Bottom;
            DisplayError.AutoSize = true;
            DisplayError.BackColor = Color.Transparent;
            DisplayError.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayError.ForeColor = Color.Red;
            DisplayError.Location = new Point(745, 494);
            DisplayError.Name = "DisplayError";
            DisplayError.Size = new Size(0, 21);
            DisplayError.TabIndex = 9;
            DisplayError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Minecraft", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblSaludo.Location = new Point(399, 128);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(224, 35);
            lblSaludo.TabIndex = 10;
            lblSaludo.Text = "Bienvenid@";
            // 
            // btnAnimatronicos
            // 
            btnAnimatronicos.BackColor = Color.Transparent;
            btnAnimatronicos.Image = Properties.Resources.animatronicos_normal;
            btnAnimatronicos.Location = new Point(440, 191);
            btnAnimatronicos.Name = "btnAnimatronicos";
            btnAnimatronicos.Size = new Size(299, 104);
            btnAnimatronicos.TabIndex = 11;
            btnAnimatronicos.TabStop = false;
            btnAnimatronicos.Click += btnAnimatronicos_Click;
            // 
            // btnFiestas
            // 
            btnFiestas.BackColor = Color.Transparent;
            btnFiestas.Image = Properties.Resources.fiestas_normal;
            btnFiestas.Location = new Point(440, 319);
            btnFiestas.Name = "btnFiestas";
            btnFiestas.Size = new Size(299, 104);
            btnFiestas.TabIndex = 12;
            btnFiestas.TabStop = false;
            btnFiestas.Click += btnFiestas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.Image = Properties.Resources.usuarios_normal;
            btnUsuarios.Location = new Point(440, 451);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(299, 104);
            btnUsuarios.TabIndex = 13;
            btnUsuarios.TabStop = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // adminDance
            // 
            adminDance.BackColor = Color.Transparent;
            adminDance.Image = Properties.Resources.DANCING_AFTON_1;
            adminDance.Location = new Point(940, 31);
            adminDance.Name = "adminDance";
            adminDance.Size = new Size(176, 169);
            adminDance.SizeMode = PictureBoxSizeMode.Zoom;
            adminDance.TabIndex = 14;
            adminDance.TabStop = false;
            // 
            // adminDance2
            // 
            adminDance2.BackColor = Color.Transparent;
            adminDance2.Image = Properties.Resources.DANCING_AFTON_2;
            adminDance2.Location = new Point(51, 31);
            adminDance2.Name = "adminDance2";
            adminDance2.Size = new Size(176, 169);
            adminDance2.SizeMode = PictureBoxSizeMode.Zoom;
            adminDance2.TabIndex = 15;
            adminDance2.TabStop = false;
            // 
            // btnOptions
            // 
            btnOptions.BackColor = Color.Transparent;
            btnOptions.Image = Properties.Resources.settings;
            btnOptions.Location = new Point(1024, 285);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(92, 88);
            btnOptions.SizeMode = PictureBoxSizeMode.Zoom;
            btnOptions.TabIndex = 16;
            btnOptions.TabStop = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 645);
            Controls.Add(btnOptions);
            Controls.Add(adminDance2);
            Controls.Add(adminDance);
            Controls.Add(btnUsuarios);
            Controls.Add(btnFiestas);
            Controls.Add(btnAnimatronicos);
            Controls.Add(lblSaludo);
            Controls.Add(DisplayError);
            Controls.Add(pictureBox2);
            Controls.Add(BotonCerrar);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Hiragana;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA RENT-A-TRONIC";
            FormClosing += FrmInicioSesion_FormClosing;
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAnimatronicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnFiestas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDance).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDance2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox BotonCerrar;
        private PictureBox pictureBox2;
        private Label DisplayError;
        private Label lblSaludo;
        private PictureBox btnAnimatronicos;
        private PictureBox btnFiestas;
        private PictureBox btnUsuarios;
        private PictureBox adminDance;
        private PictureBox adminDance2;
        private PictureBox btnOptions;
    }
}