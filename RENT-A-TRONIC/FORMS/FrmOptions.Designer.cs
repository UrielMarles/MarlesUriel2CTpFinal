namespace RENT_A_TRONIC.FORMS
{
    partial class FrmOptions
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
            pregunta = new Label();
            pictureBox1 = new PictureBox();
            btnSesion = new Button();
            borrados = new Button();
            ResetearTabla = new Button();
            crearBackup = new Button();
            pictureBox2 = new PictureBox();
            DisplayError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pregunta
            // 
            pregunta.Anchor = AnchorStyles.Top;
            pregunta.AutoSize = true;
            pregunta.BackColor = Color.Transparent;
            pregunta.Font = new Font("Minecraft", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            pregunta.ForeColor = SystemColors.ControlText;
            pregunta.Location = new Point(95, 27);
            pregunta.Name = "pregunta";
            pregunta.Size = new Size(225, 37);
            pregunta.TabIndex = 0;
            pregunta.Text = "OPCIONES";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.THINKING_HELPY;
            pictureBox1.Location = new Point(342, 442);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.Black;
            btnSesion.Font = new Font("Pivot Classic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSesion.ForeColor = SystemColors.ControlLightLight;
            btnSesion.Location = new Point(53, 126);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(334, 42);
            btnSesion.TabIndex = 7;
            btnSesion.Text = "Cerrar Sesion";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += btnSesion_Click;
            // 
            // borrados
            // 
            borrados.BackColor = Color.Black;
            borrados.Font = new Font("Pivot Classic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            borrados.ForeColor = SystemColors.ControlLightLight;
            borrados.Location = new Point(53, 215);
            borrados.Name = "borrados";
            borrados.Size = new Size(334, 42);
            borrados.TabIndex = 8;
            borrados.Text = "Mostrar borrados";
            borrados.UseVisualStyleBackColor = false;
            borrados.Click += cambiarVisibilidad;
            // 
            // ResetearTabla
            // 
            ResetearTabla.BackColor = Color.Black;
            ResetearTabla.Font = new Font("Pivot Classic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ResetearTabla.ForeColor = SystemColors.ControlLightLight;
            ResetearTabla.Location = new Point(53, 298);
            ResetearTabla.Name = "ResetearTabla";
            ResetearTabla.Size = new Size(334, 42);
            ResetearTabla.TabIndex = 9;
            ResetearTabla.Text = "Restaurar Base";
            ResetearTabla.UseVisualStyleBackColor = false;
            ResetearTabla.Click += ResetearTabla_Click;
            // 
            // crearBackup
            // 
            crearBackup.BackColor = Color.Black;
            crearBackup.Font = new Font("Pivot Classic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            crearBackup.ForeColor = SystemColors.ControlLightLight;
            crearBackup.Location = new Point(53, 375);
            crearBackup.Name = "crearBackup";
            crearBackup.Size = new Size(334, 42);
            crearBackup.TabIndex = 10;
            crearBackup.Text = "Guardar Backup";
            crearBackup.UseVisualStyleBackColor = false;
            crearBackup.Click += crearBackup_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.atras;
            pictureBox2.Location = new Point(330, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // DisplayError
            // 
            DisplayError.Anchor = AnchorStyles.Bottom;
            DisplayError.AutoSize = true;
            DisplayError.BackColor = Color.Transparent;
            DisplayError.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayError.ForeColor = Color.Red;
            DisplayError.Location = new Point(76, 482);
            DisplayError.Name = "DisplayError";
            DisplayError.Size = new Size(0, 21);
            DisplayError.TabIndex = 13;
            DisplayError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.azulejo;
            ClientSize = new Size(448, 542);
            Controls.Add(DisplayError);
            Controls.Add(pictureBox2);
            Controls.Add(crearBackup);
            Controls.Add(ResetearTabla);
            Controls.Add(borrados);
            Controls.Add(btnSesion);
            Controls.Add(pictureBox1);
            Controls.Add(pregunta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmOptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += FrmConfirmar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pregunta;
        private PictureBox pictureBox1;
        private Button btnSesion;
        private Button borrados;
        private Button ResetearTabla;
        private Button crearBackup;
        private PictureBox pictureBox2;
        private Label DisplayError;
    }
}