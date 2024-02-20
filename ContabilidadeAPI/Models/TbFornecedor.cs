using System;
using System.Collections.Generic;

namespace ContabilidadeAPI.Models
{
    public partial class TbFornecedor
    {
        public TbFornecedor()
        {
            TbContasAPagars = new HashSet<TbContasAPagar>();
        }

        public int IdFornecedor { get; set; }
        public string? NomeFornecedor { get; set; }
        public string? CnpjFornecedor { get; set; }
        public string? EnderecoFornecedor { get; set; }
        public string? TipoFornecedor { get; set; }
        public string? CondicoesPagamento { get; set; }
        public string? HistoricoTransacoes { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TbEmpresa? IdEmpresaNavigation { get; set; }
        public virtual ICollection<TbContasAPagar> TbContasAPagars { get; set; }
    }
}
