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
            btnDiretorio = new Button();
            txtDiretorio = new TextBox();
            lstArquivos = new ListBox();
            fbdDiretorio = new FolderBrowserDialog();
            btnCarregar = new Button();
            lblDiretorio = new Label();
            lblArquivos = new Label();
            lblMascara = new Label();
            txtMascara = new TextBox();
            btnAlterar = new Button();
            SuspendLayout();
            // 
            // btnDiretorio
            // 
            btnDiretorio.Location = new Point(559, 20);
            btnDiretorio.Name = "btnDiretorio";
            btnDiretorio.Size = new Size(78, 24);
            btnDiretorio.TabIndex = 0;
            btnDiretorio.Text = "Buscar";
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
            // btnCarregar
            // 
            btnCarregar.Location = new Point(559, 62);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(78, 24);
            btnCarregar.TabIndex = 3;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
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
            // txtMascara
            // 
            txtMascara.Location = new Point(15, 250);
            txtMascara.Name = "txtMascara";
            txtMascara.Size = new Size(538, 23);
            txtMascara.TabIndex = 6;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(560, 250);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(78, 24);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // FrmRenomeador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 289);
            Controls.Add(btnAlterar);
            Controls.Add(lblMascara);
            Controls.Add(txtMascara);
            Controls.Add(lblArquivos);
            Controls.Add(lblDiretorio);
            Controls.Add(btnCarregar);
            Controls.Add(lstArquivos);
            Controls.Add(txtDiretorio);
            Controls.Add(btnDiretorio);
            Name = "FrmRenomeador";
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
        private Button btnCarregar;
        private Label lblDiretorio;
        private Label lblArquivos;
        private Label lblMascara;
        private TextBox txtMascara;
        private Button btnAlterar;
    }
}
