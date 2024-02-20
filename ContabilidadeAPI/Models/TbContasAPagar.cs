using System;
using System.Collections.Generic;

namespace ContabilidadeAPI.Models
{
    public partial class TbContasAPagar
    {
        public int IdContas { get; set; }
        public decimal? ValorContas { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string? StatusConta { get; set; }
        public string? NumeroFatura { get; set; }
        public string? PagamentoTipo { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdFornecedor { get; set; }

        public virtual TbEmpresa? IdEmpresaNavigation { get; set; }
        public virtual TbFornecedor? IdFornecedorNavigation { get; set; }
    }
}
