namespace RestauranteDBTA.visao
{
    partial class FormSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.CopyRigth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbAcao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Location = new System.Drawing.Point(12, 563);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(570, 33);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "CONTROLE DE RESTAURANTE V1.0";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyRigth
            // 
            this.CopyRigth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRigth.Location = new System.Drawing.Point(9, 690);
            this.CopyRigth.Name = "CopyRigth";
            this.CopyRigth.Size = new System.Drawing.Size(570, 45);
            this.CopyRigth.TabIndex = 1;
            this.CopyRigth.Text = "Este programa é protegido pela lei de Direitos Autorais e tratados internacionais" +
    "";
            this.CopyRigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(48, 676);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 3);
            this.panel1.TabIndex = 2;
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(48, 609);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(490, 23);
            this.barra.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbAcao
            // 
            this.lbAcao.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcao.ForeColor = System.Drawing.Color.Blue;
            this.lbAcao.Location = new System.Drawing.Point(48, 635);
            this.lbAcao.Name = "lbAcao";
            this.lbAcao.Size = new System.Drawing.Size(487, 38);
            this.lbAcao.TabIndex = 4;
            this.lbAcao.Text = "acao";
            this.lbAcao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 744);
            this.Controls.Add(this.lbAcao);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CopyRigth);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label CopyRigth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbAcao;
    }
}