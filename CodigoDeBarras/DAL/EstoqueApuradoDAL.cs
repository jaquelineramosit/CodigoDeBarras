using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace CodigoDeBarras.DAL
{
    public class EstoqueApuradoDAL
    {
        private SistemaLojaEntities context = new SistemaLojaEntities();

        public EstoqueApurado IncluirCodigoBarras(EstoqueApurado estoqueApurado)
        {
            EstoqueApurado cEstoqueApuradoNovo = new EstoqueApurado();
            Entity.EstoqueApuradoEntity estoqueApuradoEntity = new Entity.EstoqueApuradoEntity();
            try
            {
                cEstoqueApuradoNovo.CodBarrasApurado = estoqueApurado.CodBarrasApurado;
                cEstoqueApuradoNovo.EstoqueDispApurado = Convert.ToInt32(estoqueApurado.EstoqueDispApurado);
                cEstoqueApuradoNovo.DataUltModif = DateTime.Now;
                
                context.EstoqueApuradoes.Add(cEstoqueApuradoNovo);
                
                context.SaveChanges();
                return context.EstoqueApuradoes.FirstOrDefault(p => p.CodBarrasApurado == cEstoqueApuradoNovo.CodBarrasApurado);
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
                return null;
                throw;
            }
        }

        public void ExcluirEstoqueApuradoId(EstoqueApurado estoqueApurado)
        {
            try
            {
                context.Entry(estoqueApurado).State = System.Data.Entity.EntityState.Deleted;
                context.EstoqueApuradoes.Remove(estoqueApurado);
                

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
            }
        }

        public void ExcluirEstoqueApurado()
        {
            try
            {
                //ANTES DE FAZER A EXCLUSÃO DOS REGISTROS, SALVAR OS DADOS NA TABELA DE LOG

                List<EstoqueApurado> lstEstoqueApurado = new List<EstoqueApurado>();
                lstEstoqueApurado = ObterListaEstoqueApurado();

                foreach (var item in lstEstoqueApurado)
                {
                    context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    context.EstoqueApuradoes.Remove(item);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<CodigoDeBarras.Entity.EstoqueApuradoEntity> ObterListaEstoqueApuradoComProdutoTotal()
        {
            var retorno = context.SelecEstoqueApuradoGrid().ToList();
            List<CodigoDeBarras.Entity.EstoqueApuradoEntity> lstEstoqueApuradoEntity = new List<Entity.EstoqueApuradoEntity>();
            CodigoDeBarras.Entity.EstoqueApuradoEntity estoqueApuradoEntity;
            foreach (var item in retorno)
            {
                estoqueApuradoEntity = new Entity.EstoqueApuradoEntity();
                estoqueApuradoEntity.Id = item.IdEstoqueApurado;
                estoqueApuradoEntity.CodBarrasApurado = item.CodBarrasApurado;
                estoqueApuradoEntity.NomeProduto = item.NomeProduto;
                estoqueApuradoEntity.codEncontrado = item.codEncontrado;
                lstEstoqueApuradoEntity.Add(estoqueApuradoEntity);
            }

            return lstEstoqueApuradoEntity;
        }

        public Entity.EstoqueApuradoEntity ObterListaEstoqueApuradoPorId(int idIdEstoqueApurado)
        {
            var retorno = context.SelecEstoqueApuradoGrid().FirstOrDefault(p=> p.IdEstoqueApurado == idIdEstoqueApurado);
            List<CodigoDeBarras.Entity.EstoqueApuradoEntity> lstEstoqueApuradoEntity = new List<Entity.EstoqueApuradoEntity>();
            CodigoDeBarras.Entity.EstoqueApuradoEntity estoqueApuradoEntity = new Entity.EstoqueApuradoEntity(); ;

            estoqueApuradoEntity.Id = retorno.IdEstoqueApurado;
            estoqueApuradoEntity.CodBarrasApurado = retorno.CodBarrasApurado;
            estoqueApuradoEntity.NomeProduto = retorno.NomeProduto;
            estoqueApuradoEntity.codEncontrado = retorno.codEncontrado;
            
            return estoqueApuradoEntity;
        }

        public EstoqueApurado ObterListaEstoqueId(int idEstoqueApurado)
        {
            try
            {
                return context.EstoqueApuradoes.FirstOrDefault(p => p.IdEstoqueApurado == idEstoqueApurado);
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
                return null;
            }
        }

        public List<EstoqueApurado> ObterListaEstoqueApurado()
        {
            try
            {
                List<EstoqueApurado> lstEstoqueApurado = new List<EstoqueApurado>();

                lstEstoqueApurado = context.EstoqueApuradoes.Select(p => p).ToList();

                return lstEstoqueApurado;
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
    }
}
