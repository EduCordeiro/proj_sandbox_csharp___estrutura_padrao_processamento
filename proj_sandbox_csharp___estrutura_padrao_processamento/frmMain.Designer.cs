namespace proj_sandbox_csharp___estrutura_padrao_processamento
{
    partial class frmMain
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
            this.tbc_Opcoes = new System.Windows.Forms.TabControl();
            this.tbp_Entrada = new System.Windows.Forms.TabPage();
            this.btn_MarcarTodos = new System.Windows.Forms.Button();
            this.btn_DesmarcarTodos = new System.Windows.Forms.Button();
            this.chkl_Arquivos = new System.Windows.Forms.CheckedListBox();
            this.btn_SelecionarPath = new System.Windows.Forms.Button();
            this.txt_PathEntrada = new System.Windows.Forms.TextBox();
            this.tbp_Saida = new System.Windows.Forms.TabPage();
            this.tbp_Processamento = new System.Windows.Forms.TabPage();
            this.btn_Sobre = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.folderBrowserDialogPathEntrada = new System.Windows.Forms.FolderBrowserDialog();
            this.tbc_Opcoes.SuspendLayout();
            this.tbp_Entrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Opcoes
            // 
            this.tbc_Opcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Opcoes.Controls.Add(this.tbp_Entrada);
            this.tbc_Opcoes.Controls.Add(this.tbp_Saida);
            this.tbc_Opcoes.Controls.Add(this.tbp_Processamento);
            this.tbc_Opcoes.Location = new System.Drawing.Point(23, 12);
            this.tbc_Opcoes.Name = "tbc_Opcoes";
            this.tbc_Opcoes.SelectedIndex = 0;
            this.tbc_Opcoes.Size = new System.Drawing.Size(648, 342);
            this.tbc_Opcoes.TabIndex = 0;
            // 
            // tbp_Entrada
            // 
            this.tbp_Entrada.Controls.Add(this.btn_MarcarTodos);
            this.tbp_Entrada.Controls.Add(this.btn_DesmarcarTodos);
            this.tbp_Entrada.Controls.Add(this.chkl_Arquivos);
            this.tbp_Entrada.Controls.Add(this.btn_SelecionarPath);
            this.tbp_Entrada.Controls.Add(this.txt_PathEntrada);
            this.tbp_Entrada.Location = new System.Drawing.Point(4, 24);
            this.tbp_Entrada.Name = "tbp_Entrada";
            this.tbp_Entrada.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Entrada.Size = new System.Drawing.Size(640, 314);
            this.tbp_Entrada.TabIndex = 0;
            this.tbp_Entrada.Text = "Entrada";
            this.tbp_Entrada.UseVisualStyleBackColor = true;
            // 
            // btn_MarcarTodos
            // 
            this.btn_MarcarTodos.Location = new System.Drawing.Point(368, 36);
            this.btn_MarcarTodos.Name = "btn_MarcarTodos";
            this.btn_MarcarTodos.Size = new System.Drawing.Size(109, 23);
            this.btn_MarcarTodos.TabIndex = 4;
            this.btn_MarcarTodos.Text = "Marcar Todos";
            this.btn_MarcarTodos.UseVisualStyleBackColor = true;
            this.btn_MarcarTodos.Click += new System.EventHandler(this.btn_MarcarTodos_Click);
            // 
            // btn_DesmarcarTodos
            // 
            this.btn_DesmarcarTodos.Location = new System.Drawing.Point(483, 36);
            this.btn_DesmarcarTodos.Name = "btn_DesmarcarTodos";
            this.btn_DesmarcarTodos.Size = new System.Drawing.Size(109, 23);
            this.btn_DesmarcarTodos.TabIndex = 3;
            this.btn_DesmarcarTodos.Text = "Desmarcar Todos";
            this.btn_DesmarcarTodos.UseVisualStyleBackColor = true;
            this.btn_DesmarcarTodos.Click += new System.EventHandler(this.btn_DesmarcarTodos_Click);
            // 
            // chkl_Arquivos
            // 
            this.chkl_Arquivos.FormattingEnabled = true;
            this.chkl_Arquivos.Location = new System.Drawing.Point(3, 65);
            this.chkl_Arquivos.Name = "chkl_Arquivos";
            this.chkl_Arquivos.Size = new System.Drawing.Size(628, 238);
            this.chkl_Arquivos.TabIndex = 2;
            // 
            // btn_SelecionarPath
            // 
            this.btn_SelecionarPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_SelecionarPath.Location = new System.Drawing.Point(598, 7);
            this.btn_SelecionarPath.Name = "btn_SelecionarPath";
            this.btn_SelecionarPath.Size = new System.Drawing.Size(36, 23);
            this.btn_SelecionarPath.TabIndex = 1;
            this.btn_SelecionarPath.Text = "...";
            this.btn_SelecionarPath.UseVisualStyleBackColor = true;
            this.btn_SelecionarPath.Click += new System.EventHandler(this.btn_SelecionarPath_Click);
            // 
            // txt_PathEntrada
            // 
            this.txt_PathEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PathEntrada.Location = new System.Drawing.Point(6, 7);
            this.txt_PathEntrada.Name = "txt_PathEntrada";
            this.txt_PathEntrada.Size = new System.Drawing.Size(586, 23);
            this.txt_PathEntrada.TabIndex = 0;
            // 
            // tbp_Saida
            // 
            this.tbp_Saida.Location = new System.Drawing.Point(4, 24);
            this.tbp_Saida.Name = "tbp_Saida";
            this.tbp_Saida.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Saida.Size = new System.Drawing.Size(640, 314);
            this.tbp_Saida.TabIndex = 1;
            this.tbp_Saida.Text = "Saída";
            this.tbp_Saida.UseVisualStyleBackColor = true;
            // 
            // tbp_Processamento
            // 
            this.tbp_Processamento.Location = new System.Drawing.Point(4, 24);
            this.tbp_Processamento.Name = "tbp_Processamento";
            this.tbp_Processamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Processamento.Size = new System.Drawing.Size(640, 314);
            this.tbp_Processamento.TabIndex = 2;
            this.tbp_Processamento.Text = "Processamento";
            this.tbp_Processamento.UseVisualStyleBackColor = true;
            // 
            // btn_Sobre
            // 
            this.btn_Sobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Sobre.Location = new System.Drawing.Point(23, 360);
            this.btn_Sobre.Name = "btn_Sobre";
            this.btn_Sobre.Size = new System.Drawing.Size(75, 23);
            this.btn_Sobre.TabIndex = 1;
            this.btn_Sobre.Text = "Sobre";
            this.btn_Sobre.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sair.Location = new System.Drawing.Point(592, 360);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 395);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Sobre);
            this.Controls.Add(this.tbc_Opcoes);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tbc_Opcoes.ResumeLayout(false);
            this.tbp_Entrada.ResumeLayout(false);
            this.tbp_Entrada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbc_Opcoes;
        private TabPage tbp_Entrada;
        private TabPage tbp_Saida;
        private Button btn_Sobre;
        private Button btn_Sair;
        private TabPage tbp_Processamento;
        private Button btn_SelecionarPath;
        private TextBox txt_PathEntrada;
        private FolderBrowserDialog folderBrowserDialogPathEntrada;
        private CheckedListBox chkl_Arquivos;
        private Button btn_MarcarTodos;
        private Button btn_DesmarcarTodos;
    }
}