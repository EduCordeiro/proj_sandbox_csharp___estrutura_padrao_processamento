using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace proj_sandbox_csharp___estrutura_padrao_processamento
{
    public class ObjCore
    {

        public ObjConf objConfig;

        public ObjCore()
        {
            string sPathEXE = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            //string sPathEXE_Anterior = sPathEXE.Substring(0, sPathEXE.LastIndexOf("\\", sPathEXE.Length - 2)) + "\\" + "Teste";
            string sNameEXE = System.AppDomain.CurrentDomain.FriendlyName.ToString();
            string sNameConfJson = sNameEXE + ".json";


            //======================================================================
            // Deserializando arquivo .conf para obter os parâmetros.
            //======================================================================
            string TextContet = File.ReadAllText(sPathEXE + "\\" + sNameConfJson);
            var objConfigTMP = JsonSerializer.Deserialize<ObjConf>(TextContet);

            if(objConfigTMP != null)
              objConfig = objConfigTMP;
            //======================================================================




            //MessageBox.Show(objConfig.PathEntrada, "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Question);


            // ObjConf objConfig = JsonConvert.DeserializeObject<ObjConf>(sNameConfJson);


            /*

            using (StreamReader r = new StreamReader(sPathEXE + "\\" + sNameConf))
            {
                string jsonString = r.ReadToEnd();

                //  ListaDeConfiguracoes = JsonSerializer.Deserialize<ObjConf>(jsonString);

                //  dynamic array = JsonConvert.DeserializeObject<List<ObjConf>>(jsonString);

                
            }
            */

            //MessageBox.Show(sNameConf);
        }

        public static void ProcessarArquivo(string arquivoTXT)
        {
            int counter = 0;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"" + arquivoTXT + ""))
            {
                MessageBox.Show(line, "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Question);
                counter++;
            }
        }
        
    }
}
