namespace Safe_Login
{
    partial class TelaGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGeral));
            this.ButtonRegistrar = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenhaAdmin = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRegistrar
            // 
            resources.ApplyResources(this.ButtonRegistrar, "ButtonRegistrar");
            this.ButtonRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.ButtonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegistrar.ForeColor = System.Drawing.Color.White;
            this.ButtonRegistrar.IconChar = FontAwesome.Sharp.IconChar.ScrollTorah;
            this.ButtonRegistrar.IconColor = System.Drawing.Color.White;
            this.ButtonRegistrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ButtonRegistrar.IconSize = 40;
            this.ButtonRegistrar.Name = "ButtonRegistrar";
            this.ButtonRegistrar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.ButtonRegistrar);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // textBoxSenhaAdmin
            // 
            resources.ApplyResources(this.textBoxSenhaAdmin, "textBoxSenhaAdmin");
            this.textBoxSenhaAdmin.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource1"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource2"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource3"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource4"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource5"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource6"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource7"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource8"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource9"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource10"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource11"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource12"),
            resources.GetString("textBoxSenhaAdmin.AutoCompleteCustomSource13")});
            this.textBoxSenhaAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSenhaAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSenhaAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.textBoxSenhaAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenhaAdmin.ForeColor = System.Drawing.Color.White;
            this.textBoxSenhaAdmin.Name = "textBoxSenhaAdmin";
            this.textBoxSenhaAdmin.UseSystemPasswordChar = true;
            // 
            // textBoxUsuarioAdmin
            // 
            resources.ApplyResources(this.textBoxUsuarioAdmin, "textBoxUsuarioAdmin");
            this.textBoxUsuarioAdmin.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource1"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource2"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource3"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource4"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource5"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource6"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource7"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource8"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource9"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource10"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource11"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource12"),
            resources.GetString("textBoxUsuarioAdmin.AutoCompleteCustomSource13")});
            this.textBoxUsuarioAdmin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxUsuarioAdmin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUsuarioAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.textBoxUsuarioAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuarioAdmin.ForeColor = System.Drawing.Color.White;
            this.textBoxUsuarioAdmin.Name = "textBoxUsuarioAdmin";
            // 
            // iconPictureBox2
            // 
            resources.ApplyResources(this.iconPictureBox2, "iconPictureBox2");
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 26;
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.TabStop = false;
            // 
            // labelSenha
            // 
            resources.ApplyResources(this.labelSenha, "labelSenha");
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Name = "labelSenha";
            // 
            // TelaGeral
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSenhaAdmin);
            this.Controls.Add(this.textBoxUsuarioAdmin);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaGeral";
            this.Load += new System.EventHandler(this.TelaGeral_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ButtonRegistrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenhaAdmin;
        private System.Windows.Forms.TextBox textBoxUsuarioAdmin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label labelSenha;
    }
}