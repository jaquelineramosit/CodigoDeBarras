using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoDeBarras.Entity
{
    public class CustoPorSubGrupo
    {
        private string grupo;
        private string subgrupo;
        private decimal custoTotal;

        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public string SubGrupo {
            get { return subgrupo; }
            set { subgrupo = value; }
        }
        public Nullable<decimal> CustoTotal { get; set; }

    }
}
