using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace CodigoDeBarras.DAL
{
    public class EstoqueImpressaoEtiquetaDAL
    {
        private SistemaLojaEntities context;

        public EstoqueImpressaoEtiqueta IncluirImpressoaEtiqueta(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {
            EstoqueImpressaoEtiqueta cEstoqueImpressaoEtiquetaNovo = new EstoqueImpressaoEtiqueta();
            try
            {
                using (context = new SistemaLojaEntities())
                { 
                    cEstoqueImpressaoEtiquetaNovo.idCodigo = estoqueImpressaoEtiqueta.idCodigo;
                    cEstoqueImpressaoEtiquetaNovo.CodigoBarras = estoqueImpressaoEtiqueta.CodigoBarras;
                    cEstoqueImpressaoEtiquetaNovo.NomeProduto = estoqueImpressaoEtiqueta.NomeProduto;
                    cEstoqueImpressaoEtiquetaNovo.Grupo = estoqueImpressaoEtiqueta.Grupo;
                    cEstoqueImpressaoEtiquetaNovo.NumeroFab = estoqueImpressaoEtiqueta.NumeroFab;
                    cEstoqueImpressaoEtiquetaNovo.EstoqueDisp = estoqueImpressaoEtiqueta.EstoqueDisp;
                    cEstoqueImpressaoEtiquetaNovo.Venda = estoqueImpressaoEtiqueta.Venda;
                    cEstoqueImpressaoEtiquetaNovo.Fornecedor = estoqueImpressaoEtiqueta.Fornecedor;
                
                    context.EstoqueImpressaoEtiquetas.Add(cEstoqueImpressaoEtiquetaNovo);

                    context.SaveChanges();
                    
                    //retorna o ultimo item cadastrado na tabela
                    return (from r in context.EstoqueImpressaoEtiquetas orderby r.IdEstoqueImpressaoEtiqueta descending select r).FirstOrDefault();
                }
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

        public void ExcluirImpressaoEtiquetaId(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {
            try
            {
                using (context = new SistemaLojaEntities())
                {
                    context.Entry(estoqueImpressaoEtiqueta).State = System.Data.Entity.EntityState.Deleted;
                    context.EstoqueImpressaoEtiquetas.Remove(estoqueImpressaoEtiqueta);

                    context.SaveChanges();
                }
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

        public void ExcluirImpressaoEtiqueta()
        {
            try
            {
                List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
                lstEstoqueImpressaoEtiqueta = ObterListaEstoqueImpressaoEtiqueta();

                using (context = new SistemaLojaEntities())
                { 

                    foreach (var item in lstEstoqueImpressaoEtiqueta)
                    {
                        context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        context.EstoqueImpressaoEtiquetas.Remove(item);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public EstoqueImpressaoEtiqueta ObterListaEstoqueImpressaoEtiquetaId(int idEstoqueImpressaoEtiqueta)
        {
            try
            {
                using (context = new SistemaLojaEntities())
                { 
                    return context.EstoqueImpressaoEtiquetas.FirstOrDefault(p => p.IdEstoqueImpressaoEtiqueta == idEstoqueImpressaoEtiqueta);
                }
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

        public List<EstoqueImpressaoEtiqueta> ObterListaEstoqueImpressaoEtiqueta()
        {
            try
            {
                List<EstoqueImpressaoEtiqueta> lstEstoqueImpressaoEtiqueta = new List<EstoqueImpressaoEtiqueta>();
                using (context = new SistemaLojaEntities())
                { 
                    lstEstoqueImpressaoEtiqueta = context.EstoqueImpressaoEtiquetas.Select(p => p).ToList();
                }
                return lstEstoqueImpressaoEtiqueta;
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
    }
}
