namespace Safe_Login
{
    partial class TelaEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEsqueciSenha));
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonRedefinir = new System.Windows.Forms.Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            resources.ApplyResources(this.iconPictureBox1, "iconPictureBox1");
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 122;
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.TabStop = false;
            // 
            // labelUsuario
            // 
            resources.ApplyResources(this.labelUsuario, "labelUsuario");
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Name = "labelUsuario";
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
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSenha
            // 
            resources.ApplyResources(this.labelSenha, "labelSenha");
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Name = "labelSenha";
            // 
            // buttonRedefinir
            // 
            resources.ApplyResources(this.buttonRedefinir, "buttonRedefinir");
            this.buttonRedefinir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.buttonRedefinir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRedefinir.ForeColor = System.Drawing.Color.White;
            this.buttonRedefinir.Name = "buttonRedefinir";
            this.buttonRedefinir.UseVisualStyleBackColor = false;
            this.buttonRedefinir.Click += new System.EventHandler(this.buttonRedefinir_Click);
            // 
            // iconPictureBox2
            // 
            resources.ApplyResources(this.iconPictureBox2, "iconPictureBox2");
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.TabStop = false;
            // 
            // EsqueciSenha
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.buttonRedefinir);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.iconPictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EsqueciSenha";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonRedefinir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}