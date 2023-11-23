namespace RENT_A_TRONIC.FORMS
{
    partial class FrmConfirmar
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
            si = new PictureBox();
            no = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)si).BeginInit();
            ((System.ComponentModel.ISupportInitialize)no).BeginInit();
            SuspendLayout();
            // 
            // pregunta
            // 
            pregunta.Anchor = AnchorStyles.Top;
            pregunta.AutoSize = true;
            pregunta.BackColor = Color.Transparent;
            pregunta.Font = new Font("Minecraft", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            pregunta.ForeColor = SystemColors.ControlText;
            pregunta.Location = new Point(221, 47);
            pregunta.Name = "pregunta";
            pregunta.Size = new Size(285, 37);
            pregunta.TabIndex = 0;
            pregunta.Text = "Estas seguro?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.THINKING_HELPY;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // si
            // 
            si.BackColor = Color.Transparent;
            si.Image = Properties.Resources.si_normal;
            si.Location = new Point(243, 145);
            si.Name = "si";
            si.Size = new Size(100, 50);
            si.SizeMode = PictureBoxSizeMode.Zoom;
            si.TabIndex = 2;
            si.TabStop = false;
            si.Click += si_Click;
            si.MouseEnter += si_MouseEnter;
            si.MouseLeave += si_MouseLeave;
            // 
            // no
            // 
            no.BackColor = Color.Transparent;
            no.Image = Properties.Resources.no_normal;
            no.Location = new Point(380, 145);
            no.Name = "no";
            no.Size = new Size(100, 50);
            no.SizeMode = PictureBoxSizeMode.Zoom;
            no.TabIndex = 3;
            no.TabStop = false;
            no.Click += no_Click;
            no.MouseEnter += no_MouseEnter;
            no.MouseLeave += no_MouseLeave;
            // 
            // FrmConfirmar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.azulejo;
            ClientSize = new Size(562, 230);
            Controls.Add(no);
            Controls.Add(si);
            Controls.Add(pictureBox1);
            Controls.Add(pregunta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfirmar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += FrmConfirmar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)si).EndInit();
            ((System.ComponentModel.ISupportInitialize)no).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pregunta;
        private PictureBox pictureBox1;
        private PictureBox si;
        private PictureBox no;
    }
}