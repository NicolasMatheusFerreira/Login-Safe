namespace Safe_Login
{
    partial class TelaRegistroUsuarios
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
            FontAwesome.Sharp.IconToolStripButton iconToolStripButtonDeletar;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanelContainerMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripFerramentas = new System.Windows.Forms.ToolStrip();
            this.iconSplitButtonRecarregar = new FontAwesome.Sharp.IconSplitButton();
            this.iconDropDownButtonSalvar = new FontAwesome.Sharp.IconDropDownButton();
            this.iconToolStripButtonAdicionar = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButtonEditar = new FontAwesome.Sharp.IconToolStripButton();
            this.dataGridViewRegistro = new System.Windows.Forms.DataGridView();
            iconToolStripButtonDeletar = new FontAwesome.Sharp.IconToolStripButton();
            this.flowLayoutPanelContainerMenu.SuspendLayout();
            this.toolStripFerramentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // iconToolStripButtonDeletar
            // 
            iconToolStripButtonDeletar.ForeColor = System.Drawing.Color.Silver;
            iconToolStripButtonDeletar.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            iconToolStripButtonDeletar.IconColor = System.Drawing.Color.Silver;
            iconToolStripButtonDeletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButtonDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            iconToolStripButtonDeletar.Name = "iconToolStripButtonDeletar";
            iconToolStripButtonDeletar.Size = new System.Drawing.Size(138, 36);
            iconToolStripButtonDeletar.Text = "Deletar usuário";
            // 
            // flowLayoutPanelContainerMenu
            // 
            this.flowLayoutPanelContainerMenu.Controls.Add(this.toolStripFerramentas);
            this.flowLayoutPanelContainerMenu.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelContainerMenu.Name = "flowLayoutPanelContainerMenu";
            this.flowLayoutPanelContainerMenu.Size = new System.Drawing.Size(776, 43);
            this.flowLayoutPanelContainerMenu.TabIndex = 0;
            // 
            // toolStripFerramentas
            // 
            this.toolStripFerramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.toolStripFerramentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripFerramentas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconSplitButtonRecarregar,
            this.iconDropDownButtonSalvar,
            this.iconToolStripButtonAdicionar,
            this.iconToolStripButtonEditar,
            iconToolStripButtonDeletar});
            this.toolStripFerramentas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripFerramentas.Location = new System.Drawing.Point(0, 0);
            this.toolStripFerramentas.Name = "toolStripFerramentas";
            this.toolStripFerramentas.Size = new System.Drawing.Size(662, 39);
            this.toolStripFerramentas.TabIndex = 0;
            this.toolStripFerramentas.Text = "toolStrip1";
            // 
            // iconSplitButtonRecarregar
            // 
            this.iconSplitButtonRecarregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButtonRecarregar.ForeColor = System.Drawing.Color.Silver;
            this.iconSplitButtonRecarregar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconSplitButtonRecarregar.IconColor = System.Drawing.Color.Silver;
            this.iconSplitButtonRecarregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButtonRecarregar.IconSize = 48;
            this.iconSplitButtonRecarregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconSplitButtonRecarregar.Name = "iconSplitButtonRecarregar";
            this.iconSplitButtonRecarregar.Rotation = 0D;
            this.iconSplitButtonRecarregar.Size = new System.Drawing.Size(122, 36);
            this.iconSplitButtonRecarregar.Text = "Recarregar";
            this.iconSplitButtonRecarregar.ButtonClick += new System.EventHandler(this.iconSplitButtonRecarregar_ButtonClick);
            // 
            // iconDropDownButtonSalvar
            // 
            this.iconDropDownButtonSalvar.ForeColor = System.Drawing.Color.Silver;
            this.iconDropDownButtonSalvar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.iconDropDownButtonSalvar.IconColor = System.Drawing.Color.Silver;
            this.iconDropDownButtonSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButtonSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconDropDownButtonSalvar.Name = "iconDropDownButtonSalvar";
            this.iconDropDownButtonSalvar.Size = new System.Drawing.Size(90, 36);
            this.iconDropDownButtonSalvar.Text = "Salvar";
            // 
            // iconToolStripButtonAdicionar
            // 
            this.iconToolStripButtonAdicionar.ForeColor = System.Drawing.Color.Silver;
            this.iconToolStripButtonAdicionar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconToolStripButtonAdicionar.IconColor = System.Drawing.Color.Silver;
            this.iconToolStripButtonAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButtonAdicionar.IconSize = 56;
            this.iconToolStripButtonAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButtonAdicionar.Name = "iconToolStripButtonAdicionar";
            this.iconToolStripButtonAdicionar.Size = new System.Drawing.Size(151, 36);
            this.iconToolStripButtonAdicionar.Text = "Adicionar usuário";
            this.iconToolStripButtonAdicionar.Click += new System.EventHandler(this.iconToolStripButtonAdicionar_Click);
            // 
            // iconToolStripButtonEditar
            // 
            this.iconToolStripButtonEditar.ForeColor = System.Drawing.Color.Silver;
            this.iconToolStripButtonEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconToolStripButtonEditar.IconColor = System.Drawing.Color.Silver;
            this.iconToolStripButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iconToolStripButtonEditar.Name = "iconToolStripButtonEditar";
            this.iconToolStripButtonEditar.Size = new System.Drawing.Size(129, 36);
            this.iconToolStripButtonEditar.Text = "Editar usuário";
            this.iconToolStripButtonEditar.ToolTipText = "iconToolStripButtonEditar";
            // 
            // dataGridViewRegistro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewRegistro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRegistro.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewRegistro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRegistro.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRegistro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRegistro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewRegistro.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewRegistro.Name = "dataGridViewRegistro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.dataGridViewRegistro.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRegistro.RowTemplate.Height = 25;
            this.dataGridViewRegistro.Size = new System.Drawing.Size(776, 498);
            this.dataGridViewRegistro.TabIndex = 1;
            // 
            // TelaRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.dataGridViewRegistro);
            this.Controls.Add(this.flowLayoutPanelContainerMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaRegistroUsuarios";
            this.Text = "TelaRegistroUsuarios";
            this.Load += new System.EventHandler(this.TelaRegistroUsuarios_Load);
            this.flowLayoutPanelContainerMenu.ResumeLayout(false);
            this.flowLayoutPanelContainerMenu.PerformLayout();
            this.toolStripFerramentas.ResumeLayout(false);
            this.toolStripFerramentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelContainerMenu;
        private System.Windows.Forms.ToolStrip toolStripFerramentas;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButtonAdicionar;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButtonEditar;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButtonDeletar;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButtonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewRegistro;
        private FontAwesome.Sharp.IconSplitButton iconSplitButtonRecarregar;
    }
}