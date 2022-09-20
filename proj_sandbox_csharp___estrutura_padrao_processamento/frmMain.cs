using System.Security.Authentication.ExtendedProtection;
using System.Windows.Forms;

namespace proj_sandbox_csharp___estrutura_padrao_processamento
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            chkl_Arquivos.Items.Clear();

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

                //Marca o diretório a ser listado
                DirectoryInfo diretorio = new DirectoryInfo(txt_PathEntrada.Text);
                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                FileInfo[] Arquivos = diretorio.GetFiles("*.*");

                //Começamos a listar os arquivos
                chkl_Arquivos.Items.Clear();
                foreach (FileInfo fileinfo in Arquivos)
                {
                    chkl_Arquivos.Items.Add(fileinfo.Name);
                }
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
    }
}