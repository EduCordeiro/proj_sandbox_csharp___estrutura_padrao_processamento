using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace proj_sandbox_csharp___estrutura_padrao_processamento
{
    public class ObjCore
    {

        public ObjConf oConfig = new ObjConf();

        // Usando o padrão Singleton
        public objMySqlConnect ?oMySqlConnection;
        private MySqlCommand ?ComandoSQL;
        private MySqlDataReader ?readerMySql;
        

        public ObjCore()
        {
            
            ComandoSQL = new MySqlCommand();            

            string sPathEXE = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            //string sPathEXE_Anterior = sPathEXE.Substring(0, sPathEXE.LastIndexOf("\\", sPathEXE.Length - 2)) + "\\" + "Teste";
            string sNameEXE = System.AppDomain.CurrentDomain.FriendlyName.ToString();
            string sNameConfJson = sNameEXE + ".json";
            string sNameScripeySQL = sNameEXE + ".sql";


            //======================================================================
            // Deserializando arquivo .conf para obter os parâmetros.
            //======================================================================
            string TextContet = File.ReadAllText(sPathEXE + "\\" + sNameConfJson);
            var objConfigTMP = JsonSerializer.Deserialize<ObjConf>(TextContet);

            if (objConfigTMP != null)
            {
                oConfig = objConfigTMP;

                //================================================================================
                // Definindo template de variável para troca padrão
                //================================================================================
                oConfig.PathEntrada = oConfig.PathEntrada.Replace("@PathLocalApp", sPathEXE);
                oConfig.PathSaida = oConfig.PathSaida.Replace("@PathLocalApp", sPathEXE);
                //================================================================================


                if (oConfig.Tentar_conectar_Mysql == "true")
                {

                    if (oConfig.Uri != null)
                    {
                        oMySqlConnection = objMySqlConnect.getInstance(oConfig.Uri);



                        // Pegando a conexão Singleton
                        if (oMySqlConnection != null)
                        {
                            ComandoSQL.Connection = oMySqlConnection.conn;

                            //==========================================================================================
                            //                                  TESTE DE CONEXAO
                            // Observe que enquanto um DataReader estiver aberto,
                            // a Conexão estará em uso exclusivamente por esse DataReader.
                            // Você não pode executar nenhum comando para a Conexão,
                            // incluindo a criação de outro DataReader,
                            // até que o DataReader original seja fechado.                        
                            //==========================================================================================
                            ComandoSQL.CommandText = "SELECT * FROM "
                                                   + " produtos "
                                                   + " WHERE id = @id ";

                            ComandoSQL.Parameters.AddWithValue("@id", "1");
                            ComandoSQL.Prepare();

                            using (readerMySql = ComandoSQL.ExecuteReader())
                            {

                                while (readerMySql.Read())
                                {
                                    //  MessageBox.Show(readerMySql.GetString(0) + " " + readerMySql.GetString(1));

                                }
                            }
                            //==========================================================================================

                            //======================================================================
                            // Preparando nome da base e das das tabelas
                            //======================================================================
                            oConfig.Database = oConfig.Database.Replace("@Database", sNameEXE);

                            oConfig.Tabela_Processamento = oConfig.Tabela_Processamento.Replace("@Database", oConfig.Database);
                            oConfig.Tabela_Controle_arquivos = oConfig.Tabela_Controle_arquivos.Replace("@Database", oConfig.Database);
                            oConfig.Tabela_Controle_lotes = oConfig.Tabela_Controle_lotes.Replace("@Database", oConfig.Database);
                            //======================================================================

                            //======================================================================
                            // Carregando ScriptSql
                            //======================================================================
                            string sScriptSQLContet = File.ReadAllText(sPathEXE + "\\" + sNameScripeySQL);

                            ComandoSQL.CommandText = sScriptSQLContet.Replace("@Database", oConfig.Database)
                                                                     .Replace("@Tabela_Processamento", oConfig.Tabela_Processamento)
                                                                     .Replace("@Tabela_Controle_arquivos", oConfig.Tabela_Controle_arquivos)
                                                                     .Replace("@Tabela_Controle_lotes", oConfig.Tabela_Controle_lotes)
                                                                     ;
                            ComandoSQL.ExecuteNonQuery();
                            //======================================================================

                        }

                    }
                }

            }

        }

        public void ProcessarArquivo(string arquivoTXT)
        {

            //====================================
            // Limpando tabela de processamento
            //====================================
            ComandoSQL.CommandText = "DELETE FROM " + oConfig.Tabela_Processamento;
            ComandoSQL.ExecuteNonQuery();

            //====================================
            // Lendo o arquivo
            //====================================
            int counter = 0;
            string sField_01 = "";
            string sField_02 = "";
            string sField_03 = "";
            string sField_04 = "";
            string sField_05 = "";
            string sField_06 = "";
            string sField_07 = "";
            string sField_08 = "";
            string sField_09 = "";
            string sField_10 = "";
            string sField_11 = "";
            string sArquivoAFP = "";



            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"" + arquivoTXT + ""))
            {                
                counter++;

                sField_01 = line.Substring(0, 9).Trim();
                sField_02 = line.Substring(16, 9).Trim();
                sField_03 = line.Substring(25, 9).Trim();
                sField_04 = line.Substring(34, 10).Trim();
                sField_05 = line.Substring(44, 15).Trim();
                sField_06 = line.Substring(61, 21).Trim();
                sField_07 = line.Substring(81, 11).Trim();
                sField_08 = line.Substring(92, 18).Trim();
                sField_09 = line.Substring(110, 5).Trim();
                sField_10 = line.Substring(115, 39).Trim();
                sField_11 = line.Substring(154, 1).Trim();
                sArquivoAFP = line.Substring(897, 50).Trim();

                //==========================================================================================
                ComandoSQL.CommandText = "INSERT INTO "
                                       + oConfig.Tabela_Processamento
                                       + " (FIELD_01, FIELD_02, FIELD_03, FIELD_04, FIELD_05, FIELD_06, FIELD_07, FIELD_08, FIELD_09, FIELD_10, FIELD_11, ARQUIVO_AFP) "
                                       + "VALUES("
                                       +  "'" + sField_01 + "'"
                                       + ",'" + sField_02 + "'"
                                       + ",'" + sField_03 + "'"
                                       + ",'" + sField_04 + "'"
                                       + ",'" + sField_05 + "'"
                                       + ",'" + sField_06 + "'"
                                       + ",'" + sField_07 + "'"
                                       + ",'" + sField_08 + "'"
                                       + ",'" + sField_09 + "'"
                                       + ",'" + sField_10 + "'"
                                       + ",'" + sField_11 + "'"
                                       + ",'" + sArquivoAFP + "'"
                                       + ")";
                ComandoSQL.ExecuteNonQuery();
                /*
                ComandoSQL.Parameters.AddWithValue("@id", "1");
                ComandoSQL.Prepare();

                using (readerMySql = ComandoSQL.ExecuteReader())
                {

                    while (readerMySql.Read())
                    {
                        //  MessageBox.Show(readerMySql.GetString(0) + " " + readerMySql.GetString(1));

                    }
                }
                */
                //==========================================================================================

            }

        }
        
    }
}
