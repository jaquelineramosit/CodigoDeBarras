//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodigoDeBarras
{
    using System;
    using System.Collections.Generic;
    
    public partial class EstoqueImpressaoEtiqueta
    {
        public int IdEstoqueImpressaoEtiqueta { get; set; }
        public int idCodigo { get; set; }
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Grupo { get; set; }
        public string NumeroFab { get; set; }
        public int EstoqueDisp { get; set; }
        public decimal Venda { get; set; }
        public Nullable<int> Fornecedor { get; set; }
    }
}
