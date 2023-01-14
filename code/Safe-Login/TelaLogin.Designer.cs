namespace Safe_Login
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
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
            this.comboBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargo.ForeColor = System.Drawing.Color.White;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargo_SelectedIndexChanged_1);
            this.comboBoxCargo.Click += new System.EventHandler(this.comboBoxCargo_Click);
            // 
            // textBoxUsuario
            // 
            resources.ApplyResources(this.textBoxUsuario, "textBoxUsuario");
            this.textBoxUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
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
            this.labelEsqueciSenha.Click += new System.EventHandler(this.labelEsqueciSenha_Click);
            this.labelEsqueciSenha.MouseLeave += new System.EventHandler(this.labelEsqueciSenha_MouseLeave);
            this.labelEsqueciSenha.MouseHover += new System.EventHandler(this.labelEsqueciSenha_MouseHover);
            // 
            // labelSaida
            // 
            resources.ApplyResources(this.labelSaida, "labelSaida");
            this.labelSaida.ForeColor = System.Drawing.Color.White;
            this.labelSaida.Name = "labelSaida";
            // 
            // iconPictureBox1
            // 
            resources.ApplyResources(this.iconPictureBox1, "iconPictureBox1");
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            resources.ApplyResources(this.iconPictureBox2, "iconPictureBox2");
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PuzzlePiece;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 24;
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.TabStop = false;
            // 
            // TelaLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
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
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
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
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
