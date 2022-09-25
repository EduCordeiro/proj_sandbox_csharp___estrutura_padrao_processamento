using System.Security.Authentication.ExtendedProtection;
using System.Windows.Forms;

namespace proj_sandbox_csharp___estrutura_padrao_processamento
{
    public partial class frmMain : Form
    {

        ObjCore oCore;
        public frmMain()
        {

            InitializeComponent();

            chkl_Arquivos.Items.Clear();

            ObjCore oCore = new ObjCore();

            txt_PathEntrada.Text = oCore.objConfig.PathEntrada;
            txt_PathSaida.Text = oCore.objConfig.PathSaida;

        }

        private void MarcarTodos(bool CheckThem)
        {
            for (int i = 0; i <= (chkl_Arquivos.Items.Count - 1); i++)
            {
                if (CheckThem)
                {
                    chkl_Arquivos.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    chkl_Arquivos.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void btn_SelecionarPath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogPathEntrada.ShowDialog() == DialogResult.OK)
            {
                txt_PathEntrada.Text = folderBrowserDialogPathEntrada.SelectedPath;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DesmarcarTodos_Click(object sender, EventArgs e)
        {
            MarcarTodos(false);
        }

        private void btn_MarcarTodos_Click(object sender, EventArgs e)
        {
            MarcarTodos(true);
        }

        private void btn_SelecionaPathSaida_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogPathEntrada.ShowDialog() == DialogResult.OK)
            {
                txt_PathSaida.Text = folderBrowserDialogPathEntrada.SelectedPath;
            }
        }

        private void txt_PathEntrada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chkl_Arquivos.Items.Clear();
                DirectoryInfo diretorio = new DirectoryInfo(txt_PathEntrada.Text);
                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                FileInfo[] Arquivos = diretorio.GetFiles("*.*");

                //Começamos a listar os arquivos                
                foreach (FileInfo fileinfo in Arquivos)
                {
                    chkl_Arquivos.Items.Add(fileinfo.Name);
                }
            }
            catch
            {

            }

        }

        private void btn_Processar_Click(object sender, EventArgs e)
        {
            // oCore.objConfig.PathEntrada = txt_PathEntrada.Text;
            // oCore.objConfig.PathSaida = txt_PathSaida.Text;
            string sArquivoProcessar = "";
            for (int iContArquivo = 0; iContArquivo <= chkl_Arquivos.CheckedItems.Count -1; iContArquivo++)
            {
              sArquivoProcessar = txt_PathEntrada.Text + "\\" + chkl_Arquivos.CheckedItems[iContArquivo];

              ObjCore.ProcessarArquivo(sArquivoProcessar);
            }
        }
    }
}