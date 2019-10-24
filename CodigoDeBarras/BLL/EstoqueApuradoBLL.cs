using System;
using System.Collections.Generic;
using CodigoDeBarras.DAL;

namespace CodigoDeBarras.BLL
{
    public class EstoqueApuradoBLL
    {
        EstoqueApuradoDAL estoqueApuradoDAL;
        public EstoqueApurado IncluirCodigoBarras(EstoqueApurado estoqueApurado)
        {
            try
            {
                estoqueApuradoDAL = new EstoqueApuradoDAL();
                return estoqueApuradoDAL.IncluirCodigoBarras(estoqueApurado);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void ExcluirEstoqueApuradoId(EstoqueApurado estoqueApurado)
        {
            try
            {
                estoqueApuradoDAL = new EstoqueApuradoDAL();
                estoqueApuradoDAL.ExcluirEstoqueApuradoId(estoqueApurado);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ExcluirEstoqueApurado()
        {
            try
            {
                estoqueApuradoDAL = new EstoqueApuradoDAL();
                estoqueApuradoDAL.ExcluirEstoqueApurado();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<CodigoDeBarras.Entity.EstoqueApuradoEntity> ObterListaEstoqueApuradoSelec()
        {
            estoqueApuradoDAL = new EstoqueApuradoDAL();
            return estoqueApuradoDAL.ObterListaEstoqueApuradoComProdutoTotal();
        }
        public Entity.EstoqueApuradoEntity ObterListaEstoqueApuradoPorId(int idIdEstoqueApurado)
        {
            estoqueApuradoDAL = new EstoqueApuradoDAL();
            return estoqueApuradoDAL.ObterListaEstoqueApuradoPorId(idIdEstoqueApurado);
        }
        public EstoqueApurado ObterListaEstoqueId(int idEstoqueApurado)
        {
            estoqueApuradoDAL = new EstoqueApuradoDAL();
            return estoqueApuradoDAL.ObterListaEstoqueId(idEstoqueApurado);
        }
        public List<EstoqueApurado> ObterListaEstoqueApurado()
        {
            try
            {
                List<EstoqueApurado> lstEstoqueApurado = new List<EstoqueApurado>();
                EstoqueApuradoDAL estoqueApuradoDAL = new EstoqueApuradoDAL();

                lstEstoqueApurado = estoqueApuradoDAL.ObterListaEstoqueApurado();

                return lstEstoqueApurado;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
