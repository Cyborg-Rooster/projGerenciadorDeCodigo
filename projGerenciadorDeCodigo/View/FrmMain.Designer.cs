namespace projGerenciadorDeCodigo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.ckbCanonical = new System.Windows.Forms.CheckBox();
            this.ckbMobirise = new System.Windows.Forms.CheckBox();
            this.ckbGoogle = new System.Windows.Forms.CheckBox();
            this.ckbSitemap = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.ptbLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(472, 76);
            this.pnlHeader.TabIndex = 2;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(168, 19);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(125, 38);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDescription.Location = new System.Drawing.Point(47, 151);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(383, 112);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Adicione a tag canonical, tire a marca d\'água do Mobirise, adicione a tag de veri" +
    "ficação do Google e/ou crie um sitemap para o seu site.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle.Location = new System.Drawing.Point(40, 97);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(383, 54);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "GERENCIE SEU SITE";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDirectory.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDirectory.Location = new System.Drawing.Point(40, 231);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(195, 32);
            this.lblDirectory.TabIndex = 11;
            this.lblDirectory.Text = "Diretório do Site:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(47, 266);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(301, 27);
            this.txtDirectory.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(362, 264);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Abrir";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.OnButtonSearchClicked);
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(47, 342);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(409, 27);
            this.txtSiteName.TabIndex = 15;
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSiteName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSiteName.Location = new System.Drawing.Point(40, 307);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(142, 32);
            this.lblSiteName.TabIndex = 14;
            this.lblSiteName.Text = "URL do Site:";
            // 
            // ckbCanonical
            // 
            this.ckbCanonical.AutoSize = true;
            this.ckbCanonical.Checked = true;
            this.ckbCanonical.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCanonical.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ckbCanonical.Location = new System.Drawing.Point(47, 388);
            this.ckbCanonical.Name = "ckbCanonical";
            this.ckbCanonical.Size = new System.Drawing.Size(303, 24);
            this.ckbCanonical.TabIndex = 16;
            this.ckbCanonical.Text = "Gerar tag canonical em todas as páginas;";
            this.ckbCanonical.UseVisualStyleBackColor = true;
            // 
            // ckbMobirise
            // 
            this.ckbMobirise.AutoSize = true;
            this.ckbMobirise.Checked = true;
            this.ckbMobirise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMobirise.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ckbMobirise.Location = new System.Drawing.Point(47, 418);
            this.ckbMobirise.Name = "ckbMobirise";
            this.ckbMobirise.Size = new System.Drawing.Size(254, 24);
            this.ckbMobirise.TabIndex = 17;
            this.ckbMobirise.Text = "Tirar a marca d\'água do Mobirise;";
            this.ckbMobirise.UseVisualStyleBackColor = true;
            // 
            // ckbGoogle
            // 
            this.ckbGoogle.AutoSize = true;
            this.ckbGoogle.Checked = true;
            this.ckbGoogle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbGoogle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ckbGoogle.Location = new System.Drawing.Point(47, 448);
            this.ckbGoogle.Name = "ckbGoogle";
            this.ckbGoogle.Size = new System.Drawing.Size(344, 24);
            this.ckbGoogle.TabIndex = 18;
            this.ckbGoogle.Text = "Adicionar tag de verificação do Google Search;";
            this.ckbGoogle.UseVisualStyleBackColor = true;
            // 
            // ckbSitemap
            // 
            this.ckbSitemap.AutoSize = true;
            this.ckbSitemap.Checked = true;
            this.ckbSitemap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSitemap.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ckbSitemap.Location = new System.Drawing.Point(47, 478);
            this.ckbSitemap.Name = "ckbSitemap";
            this.ckbSitemap.Size = new System.Drawing.Size(122, 24);
            this.ckbSitemap.TabIndex = 19;
            this.ckbSitemap.Text = "Criar sitemap;";
            this.ckbSitemap.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(362, 514);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnButtonStartClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(12, 526);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 20);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Criado por Enrique";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 549);
            this.progressBar1.MaximumSize = new System.Drawing.Size(472, 29);
            this.progressBar1.MinimumSize = new System.Drawing.Size(472, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(472, 29);
            this.progressBar1.TabIndex = 22;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 578);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ckbSitemap);
            this.Controls.Add(this.ckbGoogle);
            this.Controls.Add(this.ckbMobirise);
            this.Controls.Add(this.ckbCanonical);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.lblSiteName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 625);
            this.MinimumSize = new System.Drawing.Size(490, 625);
            this.Name = "FrmMain";
            this.Text = "LTB Marketing Digital | Gerenciador de Site";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHeader;
        private PictureBox ptbLogo;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblDirectory;
        private TextBox txtDirectory;
        private Button btnSearch;
        private TextBox txtSiteName;
        private Label lblSiteName;
        private CheckBox ckbCanonical;
        private CheckBox ckbMobirise;
        private CheckBox ckbGoogle;
        private CheckBox ckbSitemap;
        private Button btnStart;
        private LinkLabel linkLabel1;
        private ProgressBar progressBar1;
    }
}