using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoDeBarras.Entity
{
    public class CustoPorGrupo
    {
        private string grupo;
        private decimal custoTotal;

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public Nullable<decimal> CustoTotal { get; set; }
        
    }
}
