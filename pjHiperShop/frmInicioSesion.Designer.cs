namespace pjHiperShop
{
    partial class frmInicioSesion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            txtUsuario = new CustomControls.RJControls.RJTextBox();
            Carrusel = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            txtContraseña = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            label2 = new Label();
            btnIniciar = new CustomControls.RJControls.RJButton();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSalir = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)Carrusel).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BackgroundImage = (Image)resources.GetObject("txtUsuario.BackgroundImage");
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.BorderColor = Color.White;
            txtUsuario.BorderFocusColor = Color.White;
            txtUsuario.BorderRadius = 20;
            txtUsuario.BorderSize = 4;
            txtUsuario.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(826, 369);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(10, 7, 10, 7);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderColor = Color.DimGray;
            txtUsuario.PlaceholderText = "UserName";
            txtUsuario.RightToLeft = RightToLeft.No;
            txtUsuario.Size = new Size(405, 60);
            txtUsuario.TabIndex = 0;
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = false;
            // 
            // Carrusel
            // 
            Carrusel.BackgroundImageLayout = ImageLayout.Stretch;
            Carrusel.Image = (Image)resources.GetObject("Carrusel.Image");
            Carrusel.Location = new Point(0, -1);
            Carrusel.Name = "Carrusel";
            Carrusel.Size = new Size(751, 946);
            Carrusel.SizeMode = PictureBoxSizeMode.StretchImage;
            Carrusel.TabIndex = 1;
            Carrusel.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(906, 81);
            label1.Name = "label1";
            label1.Size = new Size(572, 57);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido a HiperShop";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Location = new Point(826, 445);
            label3.Name = "label3";
            label3.Size = new Size(227, 44);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Window;
            txtContraseña.BorderColor = Color.White;
            txtContraseña.BorderFocusColor = Color.White;
            txtContraseña.BorderRadius = 20;
            txtContraseña.BorderSize = 4;
            txtContraseña.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.FromArgb(64, 64, 64);
            txtContraseña.Location = new Point(826, 498);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(10, 7, 10, 7);
            txtContraseña.PasswordChar = true;
            txtContraseña.PlaceholderColor = Color.DimGray;
            txtContraseña.PlaceholderText = "Password";
            txtContraseña.RightToLeft = RightToLeft.No;
            txtContraseña.Size = new Size(405, 60);
            txtContraseña.TabIndex = 6;
            txtContraseña.Texts = "";
            txtContraseña.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(957, 186);
            label4.Name = "label4";
            label4.Size = new Size(429, 44);
            label4.TabIndex = 7;
            label4.Text = "Por favor, Identifiquese";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSlateBlue;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(826, 306);
            label2.Name = "label2";
            label2.Size = new Size(150, 44);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.MediumSlateBlue;
            btnIniciar.BackgroundColor = Color.MediumSlateBlue;
            btnIniciar.BorderColor = Color.PaleVioletRed;
            btnIniciar.BorderRadius = 20;
            btnIniciar.BorderSize = 0;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Image = (Image)resources.GetObject("btnIniciar.Image");
            btnIniciar.ImageAlign = ContentAlignment.MiddleRight;
            btnIniciar.Location = new Point(794, 659);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(334, 91);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextColor = Color.White;
            btnIniciar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MediumSlateBlue;
            btnSalir.BackgroundColor = Color.MediumSlateBlue;
            btnSalir.BorderColor = Color.PaleVioletRed;
            btnSalir.BorderRadius = 20;
            btnSalir.BorderSize = 0;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(1144, 659);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(334, 91);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.TextColor = Color.White;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 945);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciar);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Carrusel);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicioSesion";
            ((System.ComponentModel.ISupportInitialize)Carrusel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtUsuario;
        private PictureBox Carrusel;
        private Label label1;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txtContraseña;
        private Label label4;
        private Label label2;
        private Button button1;
        private CustomControls.RJControls.RJButton btnIniciar;
        public System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJButton btnSalir;
    }
}