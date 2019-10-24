using System;
using System.Collections.Generic;
using CodigoDeBarras.DAL;

namespace CodigoDeBarras.BLL
{
    public class EstoqueDivergenteBLL
    {
        EstoqueDivergenteDAL estoqueDivergenteDAL;

        public List<EstoqueDivergente> SalvarEstoqueDivergente()
        {
            estoqueDivergenteDAL = new EstoqueDivergenteDAL();
            return estoqueDivergenteDAL.SalvarEstoqueDivergente();
        }

        public List<EstoqueDivergente> ListaEstoqueDivergente()
        {
            estoqueDivergenteDAL = new EstoqueDivergenteDAL();
            return estoqueDivergenteDAL.ListaEstoqueDivergente();
        }
    }
}
