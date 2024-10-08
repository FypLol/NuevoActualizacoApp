namespace Proyecto_Mibanco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_BancaPorInternet = new Label();
            groupBoxLogin1 = new GroupBox();
            pictureBoxCodigo = new PictureBox();
            lbl_Codigo = new Label();
            lbl_ClaveDigitios = new Label();
            lbl_NumeroTarjeta = new Label();
            txtBox_CodigoVerificacion = new TextBox();
            txtBox_Clave5Digitos = new TextBox();
            txtBox_Usuario = new TextBox();
            btn_ContinuarLogin = new Button();
            pictureBoxPantalalAzul = new PictureBox();
            groupBoxLogin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCodigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPantalalAzul).BeginInit();
            SuspendLayout();
            // 
            // lbl_BancaPorInternet
            // 
            lbl_BancaPorInternet.AutoSize = true;
            lbl_BancaPorInternet.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BancaPorInternet.Location = new Point(154, 44);
            lbl_BancaPorInternet.Name = "lbl_BancaPorInternet";
            lbl_BancaPorInternet.Size = new Size(150, 23);
            lbl_BancaPorInternet.TabIndex = 0;
            lbl_BancaPorInternet.Text = "Banca por Internet";
            // 
            // groupBoxLogin1
            // 
            groupBoxLogin1.Controls.Add(pictureBoxCodigo);
            groupBoxLogin1.Controls.Add(lbl_Codigo);
            groupBoxLogin1.Controls.Add(lbl_ClaveDigitios);
            groupBoxLogin1.Controls.Add(lbl_NumeroTarjeta);
            groupBoxLogin1.Controls.Add(txtBox_CodigoVerificacion);
            groupBoxLogin1.Controls.Add(txtBox_Clave5Digitos);
            groupBoxLogin1.Controls.Add(txtBox_Usuario);
            groupBoxLogin1.Controls.Add(btn_ContinuarLogin);
            groupBoxLogin1.Controls.Add(lbl_BancaPorInternet);
            groupBoxLogin1.Location = new Point(409, -6);
            groupBoxLogin1.Name = "groupBoxLogin1";
            groupBoxLogin1.Size = new Size(530, 573);
            groupBoxLogin1.TabIndex = 1;
            groupBoxLogin1.TabStop = false;
            // 
            // pictureBoxCodigo
            // 
            pictureBoxCodigo.BackColor = Color.Transparent;
            pictureBoxCodigo.Image = (Image)resources.GetObject("pictureBoxCodigo.Image");
            pictureBoxCodigo.Location = new Point(300, 308);
            pictureBoxCodigo.Name = "pictureBoxCodigo";
            pictureBoxCodigo.Size = new Size(130, 44);
            pictureBoxCodigo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCodigo.TabIndex = 3;
            pictureBoxCodigo.TabStop = false;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_Codigo.Location = new Point(92, 384);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(61, 21);
            lbl_Codigo.TabIndex = 8;
            lbl_Codigo.Text = "Codigo";
            // 
            // lbl_ClaveDigitios
            // 
            lbl_ClaveDigitios.AutoSize = true;
            lbl_ClaveDigitios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_ClaveDigitios.Location = new Point(15, 240);
            lbl_ClaveDigitios.Name = "lbl_ClaveDigitios";
            lbl_ClaveDigitios.Size = new Size(220, 21);
            lbl_ClaveDigitios.TabIndex = 7;
            lbl_ClaveDigitios.Text = "Clave de Internet de 6 digitos";
            lbl_ClaveDigitios.Click += lbl_ClaveDigitios_Click;
            // 
            // lbl_NumeroTarjeta
            // 
            lbl_NumeroTarjeta.AutoSize = true;
            lbl_NumeroTarjeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_NumeroTarjeta.Location = new Point(154, 110);
            lbl_NumeroTarjeta.Name = "lbl_NumeroTarjeta";
            lbl_NumeroTarjeta.Size = new Size(66, 21);
            lbl_NumeroTarjeta.TabIndex = 6;
            lbl_NumeroTarjeta.Text = "Usuario";
            // 
            // txtBox_CodigoVerificacion
            // 
            txtBox_CodigoVerificacion.Location = new Point(251, 384);
            txtBox_CodigoVerificacion.Name = "txtBox_CodigoVerificacion";
            txtBox_CodigoVerificacion.Size = new Size(249, 23);
            txtBox_CodigoVerificacion.TabIndex = 5;
            // 
            // txtBox_Clave5Digitos
            // 
            txtBox_Clave5Digitos.Location = new Point(251, 240);
            txtBox_Clave5Digitos.Name = "txtBox_Clave5Digitos";
            txtBox_Clave5Digitos.Size = new Size(249, 23);
            txtBox_Clave5Digitos.TabIndex = 4;
            // 
            // txtBox_Usuario
            // 
            txtBox_Usuario.Location = new Point(251, 108);
            txtBox_Usuario.Name = "txtBox_Usuario";
            txtBox_Usuario.Size = new Size(249, 23);
            txtBox_Usuario.TabIndex = 3;
            // 
            // btn_ContinuarLogin
            // 
            btn_ContinuarLogin.BackColor = Color.FromArgb(229, 34, 41);
            btn_ContinuarLogin.FlatAppearance.BorderSize = 0;
            btn_ContinuarLogin.FlatAppearance.MouseDownBackColor = SystemColors.MenuBar;
            btn_ContinuarLogin.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btn_ContinuarLogin.FlatStyle = FlatStyle.Flat;
            btn_ContinuarLogin.ForeColor = Color.White;
            btn_ContinuarLogin.Location = new Point(75, 491);
            btn_ContinuarLogin.Name = "btn_ContinuarLogin";
            btn_ContinuarLogin.Size = new Size(393, 41);
            btn_ContinuarLogin.TabIndex = 2;
            btn_ContinuarLogin.Text = "Continuar";
            btn_ContinuarLogin.UseVisualStyleBackColor = false;
            btn_ContinuarLogin.Click += btn_ContinuarLogin_Click;
            // 
            // pictureBoxPantalalAzul
            // 
            pictureBoxPantalalAzul.Image = (Image)resources.GetObject("pictureBoxPantalalAzul.Image");
            pictureBoxPantalalAzul.Location = new Point(-2, -6);
            pictureBoxPantalalAzul.Name = "pictureBoxPantalalAzul";
            pictureBoxPantalalAzul.Size = new Size(410, 573);
            pictureBoxPantalalAzul.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxPantalalAzul.TabIndex = 2;
            pictureBoxPantalalAzul.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 561);
            Controls.Add(pictureBoxPantalalAzul);
            Controls.Add(groupBoxLogin1);
            MinimumSize = new Size(950, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxLogin1.ResumeLayout(false);
            groupBoxLogin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCodigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPantalalAzul).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_BancaPorInternet;
        private GroupBox groupBoxLogin1;
        private TextBox txtBox_CodigoVerificacion;
        private TextBox txtBox_Clave5Digitos;
        private TextBox txtBox_Usuario;
        private Button btn_ContinuarLogin;
        private Label lbl_ClaveDigitios;
        private Label lbl_NumeroTarjeta;
        private Label lbl_Codigo;
        private PictureBox pictureBoxPantalalAzul;
        private PictureBox pictureBoxCodigo;
    }
}
