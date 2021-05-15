namespace RestauranteDBTA.visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnCardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConfRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConfColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnConfImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnSuperior.SuspendLayout();
            this.menu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(37)))), ((int)(((byte)(66)))));
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.ForeColor = System.Drawing.Color.White;
            this.pnSuperior.Location = new System.Drawing.Point(196, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(1144, 59);
            this.pnSuperior.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1144, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLE DE RESTAURANTE VERSAO 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCardapio,
            this.mnProduto,
            this.mnMesa,
            this.mnUsuarios,
            this.mnConfRelatorio,
            this.mnConfColor,
            this.mnConfImage,
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(196, 698);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // mnCardapio
            // 
            this.mnCardapio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnCardapio.Image = ((System.Drawing.Image)(resources.GetObject("mnCardapio.Image")));
            this.mnCardapio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnCardapio.ImageTransparentColor = System.Drawing.Color.White;
            this.mnCardapio.Name = "mnCardapio";
            this.mnCardapio.Size = new System.Drawing.Size(183, 77);
            this.mnCardapio.Text = "CARDAPIO";
            this.mnCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnCardapio.Click += new System.EventHandler(this.mnCardapio_Click);
            // 
            // mnProduto
            // 
            this.mnProduto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnProduto.Image = ((System.Drawing.Image)(resources.GetObject("mnProduto.Image")));
            this.mnProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProduto.ImageTransparentColor = System.Drawing.Color.White;
            this.mnProduto.Name = "mnProduto";
            this.mnProduto.Size = new System.Drawing.Size(183, 77);
            this.mnProduto.Text = "PRODUTOS";
            this.mnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnProduto.Click += new System.EventHandler(this.mnProduto_Click);
            // 
            // mnMesa
            // 
            this.mnMesa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnMesa.Image = ((System.Drawing.Image)(resources.GetObject("mnMesa.Image")));
            this.mnMesa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnMesa.ImageTransparentColor = System.Drawing.Color.White;
            this.mnMesa.Name = "mnMesa";
            this.mnMesa.Size = new System.Drawing.Size(183, 77);
            this.mnMesa.Text = "MESAS";
            this.mnMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnMesa.Click += new System.EventHandler(this.mnMesa_Click);
            // 
            // mnUsuarios
            // 
            this.mnUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnUsuarios.Image")));
            this.mnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnUsuarios.ImageTransparentColor = System.Drawing.Color.White;
            this.mnUsuarios.Name = "mnUsuarios";
            this.mnUsuarios.Size = new System.Drawing.Size(183, 77);
            this.mnUsuarios.Text = "USUÁRIOS";
            this.mnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnUsuarios.Click += new System.EventHandler(this.mnUsuarios_Click);
            // 
            // mnConfRelatorio
            // 
            this.mnConfRelatorio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnConfRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("mnConfRelatorio.Image")));
            this.mnConfRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnConfRelatorio.ImageTransparentColor = System.Drawing.Color.White;
            this.mnConfRelatorio.Name = "mnConfRelatorio";
            this.mnConfRelatorio.Size = new System.Drawing.Size(183, 77);
            this.mnConfRelatorio.Text = "CONF RELATÓRIO";
            this.mnConfRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnConfRelatorio.Click += new System.EventHandler(this.mnConfRelatorio_Click);
            // 
            // mnConfColor
            // 
            this.mnConfColor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnConfColor.Image = ((System.Drawing.Image)(resources.GetObject("mnConfColor.Image")));
            this.mnConfColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnConfColor.ImageTransparentColor = System.Drawing.Color.White;
            this.mnConfColor.Name = "mnConfColor";
            this.mnConfColor.Size = new System.Drawing.Size(183, 70);
            this.mnConfColor.Text = "CONF COR FUNDO";
            this.mnConfColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnConfColor.Click += new System.EventHandler(this.mnConfColor_Click);
            // 
            // mnConfImage
            // 
            this.mnConfImage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnConfImage.Image = ((System.Drawing.Image)(resources.GetObject("mnConfImage.Image")));
            this.mnConfImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnConfImage.ImageTransparentColor = System.Drawing.Color.White;
            this.mnConfImage.Name = "mnConfImage";
            this.mnConfImage.Size = new System.Drawing.Size(183, 67);
            this.mnConfImage.Text = "CONF IMG FUNDO";
            this.mnConfImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnConfImage.Click += new System.EventHandler(this.mnConfImage_Click);
            // 
            // mnSair
            // 
            this.mnSair.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSair.ImageTransparentColor = System.Drawing.Color.White;
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(183, 77);
            this.mnSair.Text = "SAIR";
            this.mnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbUser,
            this.lbConexao});
            this.statusStrip1.Location = new System.Drawing.Point(196, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1144, 60);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = false;
            this.lbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lbUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbUser.ForeColor = System.Drawing.Color.Red;
            this.lbUser.Image = ((System.Drawing.Image)(resources.GetObject("lbUser.Image")));
            this.lbUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lbUser.Name = "lbUser";
            this.lbUser.Padding = new System.Windows.Forms.Padding(10);
            this.lbUser.Size = new System.Drawing.Size(400, 55);
            this.lbUser.Text = "USUARIO:";
            this.lbUser.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // lbConexao
            // 
            this.lbConexao.AutoSize = false;
            this.lbConexao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbConexao.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbConexao.Name = "lbConexao";
            this.lbConexao.Padding = new System.Windows.Forms.Padding(5);
            this.lbConexao.Size = new System.Drawing.Size(800, 55);
            this.lbConexao.Text = "CONEXAO:";
            this.lbConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1340, 698);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.Text = "SISTEMA DE RESTAURANTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnSuperior.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnCardapio;
        private System.Windows.Forms.ToolStripMenuItem mnProduto;
        private System.Windows.Forms.ToolStripMenuItem mnMesa;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
        private System.Windows.Forms.ToolStripMenuItem mnUsuarios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbUser;
        private System.Windows.Forms.ToolStripStatusLabel lbConexao;
        private System.Windows.Forms.ToolStripMenuItem mnConfRelatorio;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnConfColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnConfImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}