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
            pnlHeader = new Panel();
            lblNVersion = new Label();
            ptbLogo = new PictureBox();
            lblDescription = new Label();
            lblTitle = new Label();
            lblDirectory = new Label();
            txtDirectory = new TextBox();
            btnSearch = new Button();
            txtSiteName = new TextBox();
            lblSiteName = new Label();
            ckbCanonical = new CheckBox();
            ckbMobirise = new CheckBox();
            ckbGoogle = new CheckBox();
            ckbSitemap = new CheckBox();
            btnStart = new Button();
            linkLabel1 = new LinkLabel();
            progressBar1 = new ProgressBar();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(251, 235, 93);
            pnlHeader.Controls.Add(lblNVersion);
            pnlHeader.Controls.Add(ptbLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 3, 4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(415, 57);
            pnlHeader.TabIndex = 2;
            // 
            // lblNVersion
            // 
            lblNVersion.AutoSize = true;
            lblNVersion.ForeColor = SystemColors.ControlDarkDark;
            lblNVersion.Location = new Point(263, 27);
            lblNVersion.Name = "lblNVersion";
            lblNVersion.Size = new Size(46, 15);
            lblNVersion.TabIndex = 23;
            lblNVersion.Text = "v0.0.0.0";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(147, 14);
            ptbLogo.Margin = new Padding(4, 3, 4, 3);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(109, 28);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = SystemColors.GrayText;
            lblDescription.Location = new Point(41, 113);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(335, 84);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Adicione a tag canonical, tire a marca d'água do Mobirise, adicione a tag de verificação do Google e/ou crie um sitemap para o seu site.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.GrayText;
            lblTitle.Location = new Point(35, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 45);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "GERENCIE SEU SITE";
            // 
            // lblDirectory
            // 
            lblDirectory.AutoSize = true;
            lblDirectory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDirectory.ForeColor = SystemColors.GrayText;
            lblDirectory.Location = new Point(35, 173);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(154, 25);
            lblDirectory.TabIndex = 11;
            lblDirectory.Text = "Diretório do Site:";
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(41, 200);
            txtDirectory.Margin = new Padding(3, 2, 3, 2);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(264, 23);
            txtDirectory.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(317, 198);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Abrir";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += OnButtonSearchClicked;
            // 
            // txtSiteName
            // 
            txtSiteName.Location = new Point(41, 256);
            txtSiteName.Margin = new Padding(3, 2, 3, 2);
            txtSiteName.Name = "txtSiteName";
            txtSiteName.Size = new Size(358, 23);
            txtSiteName.TabIndex = 15;
            // 
            // lblSiteName
            // 
            lblSiteName.AutoSize = true;
            lblSiteName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSiteName.ForeColor = SystemColors.GrayText;
            lblSiteName.Location = new Point(35, 230);
            lblSiteName.Name = "lblSiteName";
            lblSiteName.Size = new Size(112, 25);
            lblSiteName.TabIndex = 14;
            lblSiteName.Text = "URL do Site:";
            // 
            // ckbCanonical
            // 
            ckbCanonical.AutoSize = true;
            ckbCanonical.Checked = true;
            ckbCanonical.CheckState = CheckState.Checked;
            ckbCanonical.ForeColor = SystemColors.GrayText;
            ckbCanonical.Location = new Point(41, 291);
            ckbCanonical.Margin = new Padding(3, 2, 3, 2);
            ckbCanonical.Name = "ckbCanonical";
            ckbCanonical.Size = new Size(241, 19);
            ckbCanonical.TabIndex = 16;
            ckbCanonical.Text = "Gerar tag canonical em todas as páginas;";
            ckbCanonical.UseVisualStyleBackColor = true;
            // 
            // ckbMobirise
            // 
            ckbMobirise.AutoSize = true;
            ckbMobirise.Checked = true;
            ckbMobirise.CheckState = CheckState.Checked;
            ckbMobirise.ForeColor = SystemColors.GrayText;
            ckbMobirise.Location = new Point(41, 314);
            ckbMobirise.Margin = new Padding(3, 2, 3, 2);
            ckbMobirise.Name = "ckbMobirise";
            ckbMobirise.Size = new Size(202, 19);
            ckbMobirise.TabIndex = 17;
            ckbMobirise.Text = "Tirar a marca d'água do Mobirise;";
            ckbMobirise.UseVisualStyleBackColor = true;
            // 
            // ckbGoogle
            // 
            ckbGoogle.AutoSize = true;
            ckbGoogle.ForeColor = SystemColors.GrayText;
            ckbGoogle.Location = new Point(41, 336);
            ckbGoogle.Margin = new Padding(3, 2, 3, 2);
            ckbGoogle.Name = "ckbGoogle";
            ckbGoogle.Size = new Size(272, 19);
            ckbGoogle.TabIndex = 18;
            ckbGoogle.Text = "Adicionar tag de verificação do Google Search;";
            ckbGoogle.UseVisualStyleBackColor = true;
            // 
            // ckbSitemap
            // 
            ckbSitemap.AutoSize = true;
            ckbSitemap.Checked = true;
            ckbSitemap.CheckState = CheckState.Checked;
            ckbSitemap.ForeColor = SystemColors.GrayText;
            ckbSitemap.Location = new Point(41, 358);
            ckbSitemap.Margin = new Padding(3, 2, 3, 2);
            ckbSitemap.Name = "ckbSitemap";
            ckbSitemap.Size = new Size(99, 19);
            ckbSitemap.TabIndex = 19;
            ckbSitemap.Text = "Criar sitemap;";
            ckbSitemap.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(317, 386);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(82, 22);
            btnStart.TabIndex = 20;
            btnStart.Text = "Começar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += OnButtonStartClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.Location = new Point(10, 394);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 15);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Criado por Enrique";
            linkLabel1.LinkClicked += OnLinkClicked;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 418);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.MaximumSize = new Size(413, 22);
            progressBar1.MinimumSize = new Size(413, 22);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(413, 22);
            progressBar1.TabIndex = 22;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 440);
            Controls.Add(progressBar1);
            Controls.Add(linkLabel1);
            Controls.Add(btnStart);
            Controls.Add(ckbSitemap);
            Controls.Add(ckbGoogle);
            Controls.Add(ckbMobirise);
            Controls.Add(ckbCanonical);
            Controls.Add(txtSiteName);
            Controls.Add(lblSiteName);
            Controls.Add(btnSearch);
            Controls.Add(txtDirectory);
            Controls.Add(lblDirectory);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(431, 479);
            MinimumSize = new Size(431, 479);
            Name = "FrmMain";
            Text = "LTB Marketing Digital | Gerenciador de Site";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblNVersion;
    }
}