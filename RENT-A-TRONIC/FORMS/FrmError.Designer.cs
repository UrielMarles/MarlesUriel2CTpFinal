namespace RENT_A_TRONIC.FORMS
{
    partial class FrmError
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
            ErrorList = new ListBox();
            pregunta = new Label();
            pictureBox1 = new PictureBox();
            si = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)si).BeginInit();
            SuspendLayout();
            // 
            // ErrorList
            // 
            ErrorList.BackColor = SystemColors.InactiveCaption;
            ErrorList.FormattingEnabled = true;
            ErrorList.ImeMode = ImeMode.On;
            ErrorList.ItemHeight = 15;
            ErrorList.Items.AddRange(new object[] { "ERROREES:" });
            ErrorList.Location = new Point(182, 83);
            ErrorList.Name = "ErrorList";
            ErrorList.ScrollAlwaysVisible = true;
            ErrorList.Size = new Size(429, 169);
            ErrorList.TabIndex = 3;
            // 
            // pregunta
            // 
            pregunta.Anchor = AnchorStyles.Top;
            pregunta.AutoSize = true;
            pregunta.BackColor = Color.Transparent;
            pregunta.Font = new Font("Minecraft", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            pregunta.ForeColor = SystemColors.ControlText;
            pregunta.Location = new Point(195, 27);
            pregunta.Name = "pregunta";
            pregunta.Size = new Size(416, 37);
            pregunta.TabIndex = 0;
            pregunta.Text = "Ha ocurrido un error";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.SAD_HELPY;
            pictureBox1.Location = new Point(-7, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // si
            // 
            si.BackColor = Color.Transparent;
            si.Image = Properties.Resources.aceptar_normal;
            si.Location = new Point(325, 258);
            si.Name = "si";
            si.Size = new Size(136, 39);
            si.SizeMode = PictureBoxSizeMode.Zoom;
            si.TabIndex = 2;
            si.TabStop = false;
            si.Click += si_Click;
            si.MouseEnter += si_MouseEnter;
            si.MouseLeave += si_MouseLeave;
            // 
            // FrmError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.azulejo;
            ClientSize = new Size(623, 309);
            Controls.Add(ErrorList);
            Controls.Add(si);
            Controls.Add(pictureBox1);
            Controls.Add(pregunta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmError_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)si).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pregunta;
        private PictureBox pictureBox1;
        private PictureBox si;
        private ListBox ErrorList;
    }
}