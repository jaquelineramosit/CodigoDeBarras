using CodigoDeBarras.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoDeBarras.DAL
{
    public class EstoqueDAL
    {
        private SistemaLojaEntities context = new SistemaLojaEntities();

        public void IncluirCodigoBarras(EstoqueApurado estoqueApurado)
        {
            EstoqueApurado cEstoqueApuradoNovo = new EstoqueApurado();
            try
            {
                cEstoqueApuradoNovo.CodBarrasApurado = estoqueApurado.CodBarrasApurado;
                cEstoqueApuradoNovo.EstoqueDispApurado = Convert.ToInt32(estoqueApurado.EstoqueDispApurado);

                context.EstoqueApuradoes.Add(cEstoqueApuradoNovo);
                //context.Set<Estoque>().Add(estoque);

                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entidade do tipo \"{0}\" com estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Propriedade: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public List<Estoque> ObterListaEstoque()
        {
            try
            {
                List<Estoque> lstEstoque = new List<Estoque>();

                lstEstoque = context.Estoques.Select(p => p).ToList();

                

                return lstEstoque;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entidade do tipo \"{0}\" com estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Propriedade: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public Estoque ObterItemEstoquePorCodigoBarras(string codigoBarras)
        {
            try
            {
                Estoque estoque = new Estoque();
                estoque = context.Estoques.FirstOrDefault(p => p.CodBarras == codigoBarras);

                return estoque;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public Estoque ObterItemEstoquePorNumeroFab(string numeroFab)
        {
            try
            {
                Estoque estoque = new Estoque();
                estoque = context.Estoques.FirstOrDefault(p => p.NumeroFab == numeroFab);
                return estoque;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        public List<CustoPorGrupo> ObterListaCustoPorGrupo()
        {
            CustoPorGrupo custoPorGrupo;
            List<CustoPorGrupo> lstCustoPorGrupo = new List<CustoPorGrupo>();

            var retorno = context.SelecGrupoPorCusto().ToList();
            //return retorno.ToList();

            foreach (var item in retorno)
            {
                custoPorGrupo = new CustoPorGrupo();
                custoPorGrupo.CustoTotal = item.TotalCusto != null ? item.TotalCusto : null;
                custoPorGrupo.Grupo = item.Grupo;
                lstCustoPorGrupo.Add(custoPorGrupo);
            }

            return lstCustoPorGrupo;
        }

        public List<CustoPorSubGrupo> ObterListaCustoPorSubGrupo(string grupo)
        {
            CustoPorSubGrupo custoPorSubGrupo;
            List<CustoPorSubGrupo> lstCustoPorSubGrupo = new List<CustoPorSubGrupo>();

            var retorno = context.SelecSubGrupoPorCusto().ToList();
        
            foreach (var item in retorno)
            {
                custoPorSubGrupo = new CustoPorSubGrupo();
                custoPorSubGrupo.CustoTotal = item.TotalCusto != null ? item.TotalCusto : null;
                custoPorSubGrupo.Grupo = item.Grupo;
                custoPorSubGrupo.SubGrupo = item.SubGrupo;
                lstCustoPorSubGrupo.Add(custoPorSubGrupo);
            }
            return lstCustoPorSubGrupo;   
        }

        public void SalvarEstoque(Estoque estoque)
        {
            try
            {
                context.Estoques.Add(estoque);
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entidade do tipo \"{0}\" com estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Propriedade: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            
        }

        public void ExcluirEstoque()
        {
            try
            {
               context.ExcluirEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir registros da tabela Estoque. Mensagem: " + ex.Message);
                throw;
            }
        }

        public void ExcluirEstoque(int idEstoque)
        {
            try
            {
                //IMPLEMENTAR O METODO COM O PARAMETRO
                context.ExcluirEstoque();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir registros da tabela Estoque. Mensagem: " + ex.Message);
                throw;
            }
        }
    }
}
