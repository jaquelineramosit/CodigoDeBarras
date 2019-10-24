using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoDeBarras.Entity
{
    public class EstoqueApuradoEntity
    {
        public int Id { get; set; }
        public string CodBarrasApurado { get; set; }
        public string NomeProduto { get; set; }
        public string codEncontrado { get; set; }
    }
}
