namespace RenomeadorDeArquivos
{
    partial class FrmRenomeador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenomeador));
            btnDiretorio = new Button();
            txtDiretorio = new TextBox();
            lstArquivos = new ListBox();
            fbdDiretorio = new FolderBrowserDialog();
            lblDiretorio = new Label();
            lblArquivos = new Label();
            lblMascara = new Label();
            btnRenomear = new Button();
            cbxMascara = new ComboBox();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnDiretorio
            // 
            btnDiretorio.Image = (Image)resources.GetObject("btnDiretorio.Image");
            btnDiretorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiretorio.Location = new Point(559, 20);
            btnDiretorio.Name = "btnDiretorio";
            btnDiretorio.Size = new Size(108, 24);
            btnDiretorio.TabIndex = 0;
            btnDiretorio.Text = "&Buscar";
            btnDiretorio.UseVisualStyleBackColor = true;
            btnDiretorio.Click += btnDiretorio_Click;
            // 
            // txtDiretorio
            // 
            txtDiretorio.Location = new Point(15, 20);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.Size = new Size(538, 23);
            txtDiretorio.TabIndex = 1;
            // 
            // lstArquivos
            // 
            lstArquivos.FormattingEnabled = true;
            lstArquivos.ItemHeight = 15;
            lstArquivos.Location = new Point(15, 62);
            lstArquivos.Name = "lstArquivos";
            lstArquivos.Size = new Size(538, 169);
            lstArquivos.TabIndex = 2;
            // 
            // lblDiretorio
            // 
            lblDiretorio.AutoSize = true;
            lblDiretorio.Location = new Point(18, 3);
            lblDiretorio.Name = "lblDiretorio";
            lblDiretorio.Size = new Size(53, 15);
            lblDiretorio.TabIndex = 4;
            lblDiretorio.Text = "Diretório";
            // 
            // lblArquivos
            // 
            lblArquivos.AutoSize = true;
            lblArquivos.Location = new Point(18, 45);
            lblArquivos.Name = "lblArquivos";
            lblArquivos.Size = new Size(78, 15);
            lblArquivos.TabIndex = 5;
            lblArquivos.Text = "Arquivos PDF";
            // 
            // lblMascara
            // 
            lblMascara.AutoSize = true;
            lblMascara.Location = new Point(18, 233);
            lblMascara.Name = "lblMascara";
            lblMascara.Size = new Size(51, 15);
            lblMascara.TabIndex = 7;
            lblMascara.Text = "Máscara";
            // 
            // btnRenomear
            // 
            btnRenomear.ImageAlign = ContentAlignment.MiddleLeft;
            btnRenomear.Location = new Point(559, 62);
            btnRenomear.Name = "btnRenomear";
            btnRenomear.Size = new Size(108, 24);
            btnRenomear.TabIndex = 8;
            btnRenomear.Text = "&Renomear";
            btnRenomear.UseVisualStyleBackColor = true;
            btnRenomear.Click += btnRenomear_Click;
            // 
            // cbxMascara
            // 
            cbxMascara.FormattingEnabled = true;
            cbxMascara.Location = new Point(15, 250);
            cbxMascara.Name = "cbxMascara";
            cbxMascara.Size = new Size(538, 23);
            cbxMascara.TabIndex = 9;
            // 
            // btnSair
            // 
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(559, 248);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(108, 24);
            btnSair.TabIndex = 10;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FrmRenomeador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 285);
            Controls.Add(btnSair);
            Controls.Add(cbxMascara);
            Controls.Add(btnRenomear);
            Controls.Add(lblMascara);
            Controls.Add(lblArquivos);
            Controls.Add(lblDiretorio);
            Controls.Add(lstArquivos);
            Controls.Add(txtDiretorio);
            Controls.Add(btnDiretorio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmRenomeador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renomeador de Arquivos";
            Load += FrmRenomeador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDiretorio;
        private TextBox txtDiretorio;
        private ListBox lstArquivos;
        private FolderBrowserDialog fbdDiretorio;
        private Label lblDiretorio;
        private Label lblArquivos;
        private Label lblMascara;
        private Button btnRenomear;
        private ComboBox cbxMascara;
        private Button btnSair;
    }
}
