using BACK.Entidades;

namespace RENT_A_TRONIC
{
    partial class FrmTabla<T> : Form where T : InterfazEntidades, new()
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            enie = new Label();
            tablaInfo = new DataGridView();
            btn_nuevo = new PictureBox();
            btn_editar = new PictureBox();
            btn_borrar = new PictureBox();
            adminDance = new PictureBox();
            Helpy_dancing = new PictureBox();
            volverAtras = new PictureBox();
            errorTxt = new Label();
            textBoxBusqueda = new TextBox();
            btnBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tablaInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_nuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminDance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Helpy_dancing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volverAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            SuspendLayout();
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
            // 
            // tablaInfo
            // 
            tablaInfo.AllowUserToAddRows = false;
            tablaInfo.AllowUserToDeleteRows = false;
            tablaInfo.AllowUserToResizeColumns = false;
            tablaInfo.AllowUserToResizeRows = false;
            tablaInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablaInfo.BackgroundColor = SystemColors.Control;
            tablaInfo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            tablaInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tablaInfo.DefaultCellStyle = dataGridViewCellStyle2;
            tablaInfo.Location = new Point(52, 39);
            tablaInfo.MultiSelect = false;
            tablaInfo.Name = "tablaInfo";
            tablaInfo.ReadOnly = true;
            tablaInfo.RowTemplate.Height = 25;
            tablaInfo.ScrollBars = ScrollBars.Vertical;
            tablaInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaInfo.Size = new Size(761, 569);
            tablaInfo.TabIndex = 10;
            tablaInfo.CellFormatting += DarColorRojoALosBorrados;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.Transparent;
            btn_nuevo.Image = Properties.Resources.nuevo_normal;
            btn_nuevo.Location = new Point(916, 79);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(114, 126);
            btn_nuevo.SizeMode = PictureBoxSizeMode.Zoom;
            btn_nuevo.TabIndex = 12;
            btn_nuevo.TabStop = false;
            btn_nuevo.Click += btn_nuevo_Click;
            btn_nuevo.MouseEnter += btn_nuevo_MouseEnter;
            btn_nuevo.MouseLeave += btn_nuevo_MouseLeave;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.Transparent;
            btn_editar.Image = Properties.Resources.editar_normal;
            btn_editar.Location = new Point(916, 211);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(114, 126);
            btn_editar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_editar.TabIndex = 13;
            btn_editar.TabStop = false;
            btn_editar.Click += btn_editar_Click;
            btn_editar.MouseEnter += btn_editar_MouseEnter;
            btn_editar.MouseLeave += btn_editar_MouseLeave;
            // 
            // btn_borrar
            // 
            btn_borrar.BackColor = Color.Transparent;
            btn_borrar.Image = Properties.Resources.borrar_normal;
            btn_borrar.Location = new Point(916, 343);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(114, 132);
            btn_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_borrar.TabIndex = 14;
            btn_borrar.TabStop = false;
            btn_borrar.Click += btn_borrar_Click;
            btn_borrar.MouseEnter += btn_borrar_MouseEnter;
            btn_borrar.MouseLeave += btn_borrar_MouseLeave;
            // 
            // adminDance
            // 
            adminDance.BackColor = Color.Transparent;
            adminDance.Image = Properties.Resources.DANCING_AFTON;
            adminDance.Location = new Point(1023, 542);
            adminDance.Name = "adminDance";
            adminDance.Size = new Size(157, 115);
            adminDance.SizeMode = PictureBoxSizeMode.Zoom;
            adminDance.TabIndex = 16;
            adminDance.TabStop = false;
            // 
            // Helpy_dancing
            // 
            Helpy_dancing.BackColor = Color.Transparent;
            Helpy_dancing.Image = Properties.Resources.SECOND_DANCE_HELPY;
            Helpy_dancing.Location = new Point(906, 465);
            Helpy_dancing.Name = "Helpy_dancing";
            Helpy_dancing.Size = new Size(136, 143);
            Helpy_dancing.SizeMode = PictureBoxSizeMode.Zoom;
            Helpy_dancing.TabIndex = 15;
            Helpy_dancing.TabStop = false;
            // 
            // volverAtras
            // 
            volverAtras.BackColor = Color.Transparent;
            volverAtras.Image = Properties.Resources.atras;
            volverAtras.Location = new Point(1112, 12);
            volverAtras.Name = "volverAtras";
            volverAtras.Size = new Size(58, 50);
            volverAtras.SizeMode = PictureBoxSizeMode.Zoom;
            volverAtras.TabIndex = 17;
            volverAtras.TabStop = false;
            volverAtras.Click += volverAtras_Click;
            // 
            // errorTxt
            // 
            errorTxt.Anchor = AnchorStyles.Bottom;
            errorTxt.AutoSize = true;
            errorTxt.BackColor = Color.Transparent;
            errorTxt.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            errorTxt.ForeColor = Color.Red;
            errorTxt.Location = new Point(848, 41);
            errorTxt.Name = "errorTxt";
            errorTxt.Size = new Size(0, 21);
            errorTxt.TabIndex = 18;
            errorTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Font = new Font("Minecraft", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxBusqueda.Location = new Point(76, 556);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(275, 30);
            textBoxBusqueda.TabIndex = 19;
            textBoxBusqueda.Visible = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.lupa;
            btnBuscar.Location = new Point(366, 546);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(57, 50);
            btnBuscar.SizeMode = PictureBoxSizeMode.Zoom;
            btnBuscar.TabIndex = 20;
            btnBuscar.TabStop = false;
            btnBuscar.Visible = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmTabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoConVertical;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 645);
            Controls.Add(btnBuscar);
            Controls.Add(textBoxBusqueda);
            Controls.Add(errorTxt);
            Controls.Add(volverAtras);
            Controls.Add(adminDance);
            Controls.Add(Helpy_dancing);
            Controls.Add(btn_borrar);
            Controls.Add(btn_editar);
            Controls.Add(btn_nuevo);
            Controls.Add(tablaInfo);
            Controls.Add(enie);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Hiragana;
            Name = "FrmTabla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA RENT-A-TRONIC";
            ((System.ComponentModel.ISupportInitialize)tablaInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_nuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminDance).EndInit();
            ((System.ComponentModel.ISupportInitialize)Helpy_dancing).EndInit();
            ((System.ComponentModel.ISupportInitialize)volverAtras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label enie;
        private DataGridView tablaInfo;
        private PictureBox btn_nuevo;
        private PictureBox btn_editar;
        private PictureBox btn_borrar;
        private PictureBox adminDance;
        private PictureBox Helpy_dancing;
        private PictureBox volverAtras;
        private Label errorTxt;
        private TextBox textBoxBusqueda;
        private PictureBox btnBuscar;
    }
}