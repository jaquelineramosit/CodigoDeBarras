using System;
using System.Collections.Generic;
using CodigoDeBarras.DAL;

namespace CodigoDeBarras.BLL
{
    public class EstoqueImpressaoEtiquetaBLL
    {
        EstoqueImpressaoEtiquetaDAL estoqueImpressaoEtiquetaDAL;
        public EstoqueImpressaoEtiqueta IncluirImpressoaEtiqueta(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {
            try
            {
                estoqueImpressaoEtiquetaDAL = new EstoqueImpressaoEtiquetaDAL();
                return estoqueImpressaoEtiquetaDAL.IncluirImpressoaEtiqueta(estoqueImpressaoEtiqueta);
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }

        }

        public void ExcluirImpressaoEtiqueta()
        {
            try
            {
                estoqueImpressaoEtiquetaDAL = new EstoqueImpressaoEtiquetaDAL();
                estoqueImpressaoEtiquetaDAL.ExcluirImpressaoEtiqueta();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ExcluirImpressaoEtiquetaId(EstoqueImpressaoEtiqueta estoqueImpressaoEtiqueta)
        {
            try
            {
                estoqueImpressaoEtiquetaDAL = new EstoqueImpressaoEtiquetaDAL();
                estoqueImpressaoEtiquetaDAL.ExcluirImpressaoEtiquetaId(estoqueImpressaoEtiqueta);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public EstoqueImpressaoEtiqueta ObterListaEstoqueImpressaoEtiquetaId(int idEstoqueImpressaoEtiqueta)
        {
            estoqueImpressaoEtiquetaDAL = new EstoqueImpressaoEtiquetaDAL();
            return estoqueImpressaoEtiquetaDAL.ObterListaEstoqueImpressaoEtiquetaId(idEstoqueImpressaoEtiqueta);
        }

        public List<EstoqueImpressaoEtiqueta> ObterListaEstoqueImpressaoEtiqueta()
        {
            try
            {
               estoqueImpressaoEtiquetaDAL = new EstoqueImpressaoEtiquetaDAL();
               return estoqueImpressaoEtiquetaDAL.ObterListaEstoqueImpressaoEtiqueta();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
