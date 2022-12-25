namespace Safe_Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.checkBoxSenha = new System.Windows.Forms.CheckBox();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelCadastra = new System.Windows.Forms.Label();
            this.labelEsqueciSenha = new System.Windows.Forms.Label();
            this.labelSaida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            resources.ApplyResources(this.buttonEntrar, "buttonEntrar");
            this.buttonEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.buttonEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrar.ForeColor = System.Drawing.Color.White;
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            this.buttonEntrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonEntrar_MouseDown);
            this.buttonEntrar.MouseEnter += new System.EventHandler(this.buttonEntrar_MouseEnter);
            this.buttonEntrar.MouseLeave += new System.EventHandler(this.buttonEntrar_MouseLeave);
            // 
            // checkBoxSenha
            // 
            resources.ApplyResources(this.checkBoxSenha, "checkBoxSenha");
            this.checkBoxSenha.ForeColor = System.Drawing.Color.White;
            this.checkBoxSenha.Name = "checkBoxSenha";
            this.checkBoxSenha.UseVisualStyleBackColor = true;
            this.checkBoxSenha.Click += new System.EventHandler(this.checkBoxSenha_Click);
            // 
            // pictureBoxBanner
            // 
            resources.ApplyResources(this.pictureBoxBanner, "pictureBoxBanner");
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.TabStop = false;
            // 
            // comboBoxCargo
            // 
            resources.ApplyResources(this.comboBoxCargo, "comboBoxCargo");
            this.comboBoxCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.comboBoxCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCargo.ForeColor = System.Drawing.Color.White;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxUsuario
            // 
            resources.ApplyResources(this.textBoxUsuario, "textBoxUsuario");
            this.textBoxUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource1"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource2"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource3"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource4"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource5"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource6"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource7"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource8"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource9"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource10"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource11"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource12"),
            resources.GetString("textBoxUsuario.AutoCompleteCustomSource13")});
            this.textBoxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.ForeColor = System.Drawing.Color.White;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged_1);
            this.textBoxUsuario.Enter += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelUsuario
            // 
            resources.ApplyResources(this.labelUsuario, "labelUsuario");
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Name = "labelUsuario";
            // 
            // labelSenha
            // 
            resources.ApplyResources(this.labelSenha, "labelSenha");
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Name = "labelSenha";
            // 
            // textBoxSenha
            // 
            resources.ApplyResources(this.textBoxSenha, "textBoxSenha");
            this.textBoxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.ForeColor = System.Drawing.Color.White;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // labelCadastra
            // 
            resources.ApplyResources(this.labelCadastra, "labelCadastra");
            this.labelCadastra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCadastra.ForeColor = System.Drawing.Color.White;
            this.labelCadastra.Name = "labelCadastra";
            this.labelCadastra.Click += new System.EventHandler(this.labelCadastra_Click);
            this.labelCadastra.MouseLeave += new System.EventHandler(this.labelCadastra_MouseLeave);
            this.labelCadastra.MouseHover += new System.EventHandler(this.labelCadastra_MouseHover);
            // 
            // labelEsqueciSenha
            // 
            resources.ApplyResources(this.labelEsqueciSenha, "labelEsqueciSenha");
            this.labelEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEsqueciSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEsqueciSenha.ForeColor = System.Drawing.Color.White;
            this.labelEsqueciSenha.Name = "labelEsqueciSenha";
            this.labelEsqueciSenha.MouseLeave += new System.EventHandler(this.labelEsqueciSenha_MouseLeave);
            this.labelEsqueciSenha.MouseHover += new System.EventHandler(this.labelEsqueciSenha_MouseHover);
            // 
            // labelSaida
            // 
            resources.ApplyResources(this.labelSaida, "labelSaida");
            this.labelSaida.ForeColor = System.Drawing.Color.White;
            this.labelSaida.Name = "labelSaida";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.Controls.Add(this.labelSaida);
            this.Controls.Add(this.labelEsqueciSenha);
            this.Controls.Add(this.labelCadastra);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.checkBoxSenha);
            this.Controls.Add(this.buttonEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.CheckBox checkBoxSenha;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelCadastra;
        private System.Windows.Forms.Label labelEsqueciSenha;
        private System.Windows.Forms.Label labelSaida;
    }
}
