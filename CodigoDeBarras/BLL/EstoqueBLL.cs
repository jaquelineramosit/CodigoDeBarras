using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CodigoDeBarras.DAL;
using CodigoDeBarras.Entity;

namespace CodigoDeBarras.BLL
{
    public class EstoqueBLL
    {
        OleDbConnection connection;
        System.Data.DataTable dt = null;
        EstoqueDAL estoqueDAL;

        public object DbNull { get; private set; }

        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);

        public List<Estoque> ObterListaEstoque()
        {
            try
            {
                List<Estoque> lstEstoque = new List<Estoque>();
                estoqueDAL = new EstoqueDAL();

                lstEstoque = estoqueDAL.ObterListaEstoque();

                return lstEstoque;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public List<EstoqueImpressaoEtiqueta> ObterListaExcel(string arquivo)
        {
            try
            {
             
                //Conecta ao BD Excel
                AbreConexaoExcel(arquivo);
                dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomeSheet = dt.Rows[0]["Table_Name"].ToString();
                OleDbCommand command = new OleDbCommand("select * from [" + nomeSheet + "]", connection);

                List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();

                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    string strCodEAN = "";
                    int iQtdeCarac = 0;
                    int j = 0;

                    while (dr.Read())
                    {
                        EstoqueImpressaoEtiqueta cEstoqueImpressaoEtiqueta = new EstoqueImpressaoEtiqueta();
                        cEstoqueImpressaoEtiqueta.EstoqueDisp = Convert.ToInt32(dr[11]);
                        for (int i = 0; i < cEstoqueImpressaoEtiqueta.EstoqueDisp; i++)
                        {
                            strCodEAN = dr[1].ToString();
                            iQtdeCarac = strCodEAN.Length;
                            for (int k = 0; k < (13 - iQtdeCarac); k++)
                            {
                                strCodEAN = "0" + strCodEAN;
                            }
                            cEstoqueImpressaoEtiqueta.idCodigo = Convert.ToInt32(dr[0]);
                            cEstoqueImpressaoEtiqueta.CodigoBarras = strCodEAN;
                            cEstoqueImpressaoEtiqueta.NumeroFab = dr[8].ToString();
                            cEstoqueImpressaoEtiqueta.NomeProduto = dr[2].ToString();
                            cEstoqueImpressaoEtiqueta.Grupo = dr[3].ToString();
                            cEstoqueImpressaoEtiqueta.EstoqueDisp = Convert.ToInt32(dr[11]);
                            cEstoqueImpressaoEtiqueta.Venda = Convert.ToDecimal(dr[14]);
                            //cEstoque.NomeCurtoProduto = dr[6].ToString();
                            lstEstoqueImpressaoEtiqueta.Add(cEstoqueImpressaoEtiqueta);
                        }
                       
                    }
                }
                
                FechaConexaoExcel();
                return lstEstoqueImpressaoEtiqueta;
            }
            catch (Exception ex)
            {
                FechaConexaoExcel();
                MessageBox.Show("Ocorreu ao carregar os dados da planilha excel. Verifique se o está no formato modelo! Erro: " + ex.Message);
                return null;
            }
        }

        public List<Estoque> ObterListaExcelEstoqueReal(string arquivo)
        {
            int numeroLinha = 1;
            progressBar cprogressBar = new progressBar();
            cprogressBar.Show();
            try
            {

                frmEstoqueSistema novoForm = new frmEstoqueSistema();
                System.Threading.Thread.Sleep(500);

                cprogressBar.lblMensagem.Text = "Excluindo registros de estoque...";

                ExcluirEstoque();

                cprogressBar.lblMensagem.Text = "Salvando registros de estoque atualizados...";
                System.Threading.Thread.Sleep(500);

                //Conecta ao BD Excel
                AbreConexaoExcel(arquivo);
                dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                
                string nomeSheet = dt.Rows[0]["Table_Name"].ToString();
                
                //INCLUIR UM VERSIONAMENTO DE INCLUSÃO, DEIXAR NO MÁXIMO AS 5 ULTIMAS INCLUSÕES E IR APAGANDO AS ULTIMAS
                List<Estoque> lstEstoque = new List<Estoque>();

                DataSet ds = new DataSet();
                OleDbCommand command = new OleDbCommand("select * from [" + nomeSheet + "]", connection);

                DataAdapter data = new OleDbDataAdapter(command);
                data.Fill(ds);

                cprogressBar.barraDeProgresso.Maximum = ds.Tables[0].Rows.Count;
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Estoque cEstoque = new Estoque();

                        cEstoque.IdCodigo = Convert.ToInt32(dr[0]);
                        
                        cEstoque.CodBarras = dr[1].ToString();
                        cEstoque.NomeProduto = dr[2].ToString();
                        cEstoque.Grupo = dr[3].ToString();
                        cEstoque.Curva = dr[4].ToString();
                        cEstoque.Unidade = dr[7].ToString();
                        cEstoque.NumeroFab = dr[8].ToString();
                        
                        if (dr[9].ToString() != "") { cEstoque.EstoqueMin = Convert.ToInt32(dr[9]); } else { cEstoque.EstoqueMin = null; }
                        if (dr[10].ToString() != "") { cEstoque.EstoqueMax = Convert.ToInt32(dr[10]); } else { cEstoque.EstoqueMax = null; }
                        cEstoque.EstoqueDisp = Convert.ToInt32(dr[11]);

                        if (dr[12].ToString() != "") { cEstoque.Custo = Convert.ToDecimal(dr[12]); } else { cEstoque.Custo = null; }
                        if (dr[13].ToString() != "") { cEstoque.Lucro = Convert.ToDecimal(dr[13]); } else { cEstoque.Lucro = null; }
                        cEstoque.Venda = Convert.ToDecimal(dr[14]);
                        if (dr[15].ToString() != "") { cEstoque.Dolar = Convert.ToDecimal(dr[15]); } else { cEstoque.Dolar = null; }

                        if (dr[16].ToString() != "") { cEstoque.ABC = Convert.ToInt32(dr[16]); } else { cEstoque.ABC = null; }
                        if (dr[17].ToString() != "") { cEstoque.Fornecedor = Convert.ToInt32(dr[17]); } else { cEstoque.Fornecedor = null; }

                        cEstoque.Local = dr[18].ToString();
                        cEstoque.Gaveta = dr[19].ToString();
                        cEstoque.Utilizado = dr[20].ToString();
                        cEstoque.Fabricante = dr[21].ToString();
                        cEstoque.SubGrupo = dr[22].ToString();
                        cEstoque.NomeCurto = dr[23].ToString();
                        cEstoque.Foto = dr[24].ToString();
                        cEstoque.NCM = dr[25].ToString();

                        if (dr[27].ToString() != "") { cEstoque.C_CST_O = Convert.ToInt32(dr[27]); } else { cEstoque.C_CST_O = null; }
                        if (dr[28].ToString() != "") { cEstoque.C_CST = Convert.ToInt32(dr[28]); } else { cEstoque.C_CST = null; }
                        if (dr[29].ToString() != "") { cEstoque.C_ECF_ALIQ = Convert.ToInt32(dr[29]); } else { cEstoque.C_ECF_ALIQ = null; }
                        if (dr[30].ToString() != "") { cEstoque.C_ICMS = Convert.ToInt32(dr[30]); } else { cEstoque.C_ICMS = null; }
                        if (dr[31].ToString() != "") { cEstoque.C_ICMS_ST = Convert.ToInt32(dr[31]); } else { cEstoque.C_ICMS_ST = null; }
                        if (dr[32].ToString() != "") { cEstoque.C_IPI = Convert.ToInt32(dr[32]); } else { cEstoque.C_IPI = null; }
                        if (dr[33].ToString() != "") { cEstoque.C_RED_BCALC = Convert.ToInt32(dr[33]); } else { cEstoque.C_RED_BCALC = null; }

                        if (dr[34].ToString() != "") { cEstoque.DataUltVenda = Convert.ToDateTime(dr[34]); } else {cEstoque.DataUltVenda = null;}
                        if (dr[35].ToString() != "") { cEstoque.DataUltCompra = Convert.ToDateTime(dr[35]); } else { cEstoque.DataUltCompra = null; }
                        if (dr[40].ToString() != "") { cEstoque.CFOP_INUF = Convert.ToInt32(dr[40]); } else { cEstoque.CFOP_INUF = null; }
                        if (dr[41].ToString() != "") { cEstoque.CFOP_OUTUF = Convert.ToInt32(dr[41]); } else { cEstoque.CFOP_OUTUF = null; }

                        cEstoque.DataModif = DateTime.Now;

                        lstEstoque.Add(cEstoque);

                        estoqueDAL.SalvarEstoque(cEstoque);

                        cprogressBar.lblMensagem.Text = "Salvando " + numeroLinha + " de " + lstEstoque.Count + "...";

                        cprogressBar.barraDeProgresso.Value = numeroLinha;
                        numeroLinha += 1;
                    }
                }
                ds.Dispose();
                data.Dispose();
                cprogressBar.Close();
                FechaConexaoExcel();
                return lstEstoque;
            }
            catch (Exception ex)
            {
                FechaConexaoExcel();
                
                MessageBox.Show("Ocorreu ao carregar os dados da planilha excel. Verifique se o está no formato modelo! Erro: " + ex.Message + ". Linha: " + numeroLinha + ". Caminho: " + ex.StackTrace);
                return null;
            }
        }

        public List<CustoPorGrupo> ObterListaCustoPorGrupo()
        {
            estoqueDAL = new EstoqueDAL();
            return estoqueDAL.ObterListaCustoPorGrupo();
        }

        public List<CustoPorSubGrupo> ObterListaCustoPorSubGrupo(string grupo)
        {
            estoqueDAL = new EstoqueDAL();
            return estoqueDAL.ObterListaCustoPorSubGrupo(grupo);
        }

        public Estoque ObterItemEstoquePorCodigoBarras(string codigoBarras)
        {
            try
            {
                estoqueDAL = new EstoqueDAL();
                return estoqueDAL.ObterItemEstoquePorCodigoBarras(codigoBarras);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public Estoque ObterItemEstoquePorNumeroFab(string numemroFab)
        {
            try
            {
                estoqueDAL = new EstoqueDAL();
                return estoqueDAL.ObterItemEstoquePorNumeroFab(numemroFab);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public void ExcluirEstoque()
        {
            try
            {
                //limpa a tabela Estoque
                estoqueDAL = new EstoqueDAL();
                estoqueDAL.ExcluirEstoque();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*public List<Estoque> ObterListaExcelEstoqueReal(string arquivo)
        {
            try
            {
                //Conecta ao BD Excel
                AbreConexaoExcel(arquivo);
                dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomeSheet = dt.Rows[0]["Table_Name"].ToString();
                OleDbCommand command = new OleDbCommand("select * from [" + nomeSheet + "]", connection);

                List<Estoque> lstEstoque = new List<Estoque>();

                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    string strCodEAN = "";
                    int iQtdeCarac = 0;
                    while (dr.Read())
                    {
                        Estoque cEstoque = new Estoque();
                        cEstoque.Qtde = Convert.ToInt32(dr[5]);
                        for (int i = 0; i < cEstoque.Qtde; i++)
                        {
                            strCodEAN = dr[1].ToString();
                            iQtdeCarac = strCodEAN.Length;
                            for (int j = 0; j < (13 - iQtdeCarac); j++)
                            {
                                strCodEAN = "1" + strCodEAN;
                            }
                            cEstoque.IdEstoque = Convert.ToInt32(dr[0]);
                            cEstoque.CodBarras = strCodEAN;
                            cEstoque.Numero_Fabricante = dr[2].ToString();
                            cEstoque.NomeProduto = dr[3].ToString();
                            cEstoque.Grupo = dr[4].ToString();
                            cEstoque.Qtde = Convert.ToInt32(dr[5]);
                            cEstoque.Venda = Convert.ToDecimal(dr[6]);
                            //cEstoque.NomeCurtoProduto = dr[6].ToString();
                            lstEstoque.Add(cEstoque);
                        }
                    }
                }

                FechaConexaoExcel();
                return lstEstoque;

            }
            catch (Exception ex)
            {
                FechaConexaoExcel();
                MessageBox.Show("Ocorreu ao carregar os dados da planilha excel. Verifique se o está no formato modelo! Erro: " + ex.Message);
                return null;
            }
        }
        */

        public void SalvarEstoque(Estoque estoque)
        {
            try
            {
                estoqueDAL = new EstoqueDAL();
                estoqueDAL.SalvarEstoque(estoque);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu ao salvar estoque. Erro: " + ex.Message);
            }
        }

        private void AbreConexaoExcel(string nomeArquivo)
        {
            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + nomeArquivo + ";Extended Properties=Excel 12.0;";

            connection = new OleDbConnection(conn);

            if (connection != null)
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
        }

        private void FechaConexaoExcel()
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }

    //******************************************
    //OBS: PARA CONECTAR O BANCO DE DADOS EXCEL
    //É NECESSÁRIO DOWNLOAD DO Microsoft Access Database Engine 2010 Redistributable
    //https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255
    //ALEM DE SETAR AS REFERENCIAS DO OFFICE
    //MICROSOFT.OFFICE.CORE
    //MICROSOFT.OFFICE.INTEROP.ACCESS.DAO
    //MICROSOFT.OFFICE.INTEROP.EXCEL

}
