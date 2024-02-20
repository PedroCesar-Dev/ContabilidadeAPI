using System;
using System.Collections.Generic;

namespace ContabilidadeAPI.Models
{
    public partial class TbFuncionario
    {
        public int IdFuncionario { get; set; }
        public string? NomeFuncionario { get; set; }
        public string? CpfFuncionario { get; set; }
        public string? EnderecoFuncionario { get; set; }
        public string? Cargo { get; set; }
        public decimal? Salario { get; set; }
        public string? ContaBancaria { get; set; }
        public string? Beneficios { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TbEmpresa? IdEmpresaNavigation { get; set; }
    }
}
