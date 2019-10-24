using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoDeBarras.DAL
{
    public class CommonDAL
    {
        private SistemaLojaEntities context;

        public string[] ObterTodasTabelas()
        {
            using (context = new SistemaLojaEntities())
            {
                string[] tabelas = context.SelecTodasTabelas().ToArray();
                return tabelas;
            }
        }
    }
}
