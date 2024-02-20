using System;
using System.Collections.Generic;

namespace ContabilidadeAPI.Models
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbContasARecebers = new HashSet<TbContasAReceber>();
        }

        public int IdCliente { get; set; }
        public string? NomeCliente { get; set; }
        public string? CpfCliente { get; set; }
        public string? EnderecoCliente { get; set; }
        public string? TipoCliente { get; set; }
        public string? HistoricoTransacoes { get; set; }
        public decimal? SaldoDevedor { get; set; }
        public decimal? SaldoCredor { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TbEmpresa? IdEmpresaNavigation { get; set; }
        public virtual ICollection<TbContasAReceber> TbContasARecebers { get; set; }
    }
}
