using System;
using System.Collections.Generic;

namespace ContabilidadeAPI.Models
{
    public partial class TbEmpresa
    {
        public TbEmpresa()
        {
            TbClientes = new HashSet<TbCliente>();
            TbContasAPagars = new HashSet<TbContasAPagar>();
            TbContasARecebers = new HashSet<TbContasAReceber>();
            TbFornecedors = new HashSet<TbFornecedor>();
            TbFuncionarios = new HashSet<TbFuncionario>();
        }

        public int IdEmpresa { get; set; }
        public string? RazaoSocial { get; set; }
        public string? CnpjEmpresa { get; set; }
        public string? EnderecoEmpresa { get; set; }
        public string? TipoEmpresa { get; set; }
        public string? Ramo { get; set; }
        public decimal? CapitalSocial { get; set; }
        public string? Regime { get; set; }
        public string? Registros { get; set; }

        public virtual ICollection<TbCliente> TbClientes { get; set; }
        public virtual ICollection<TbContasAPagar> TbContasAPagars { get; set; }
        public virtual ICollection<TbContasAReceber> TbContasARecebers { get; set; }
        public virtual ICollection<TbFornecedor> TbFornecedors { get; set; }
        public virtual ICollection<TbFuncionario> TbFuncionarios { get; set; }
    }
}
