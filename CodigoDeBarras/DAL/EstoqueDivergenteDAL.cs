using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoDeBarras.DAL
{
    public class EstoqueDivergenteDAL
    {
        private SistemaLojaEntities context = new SistemaLojaEntities();

        public List<EstoqueDivergente> SalvarEstoqueDivergente()
        {
            context.SalvaEstoqueDivergente();
            return context.EstoqueDivergentes.Select(p => p).ToList();
        }

        public List<EstoqueDivergente> ListaEstoqueDivergente()
        {
            return context.EstoqueDivergentes.Select(p => p).ToList();
        }
    }
}
