using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContabilidadeAPI.Models
{
    public partial class db_ConFinContext : DbContext
    {
        public db_ConFinContext()
        {
        }

        public db_ConFinContext(DbContextOptions<db_ConFinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCliente> TbClientes { get; set; } = null!;
        public virtual DbSet<TbContasAPagar> TbContasAPagars { get; set; } = null!;
        public virtual DbSet<TbContasAReceber> TbContasARecebers { get; set; } = null!;
        public virtual DbSet<TbEmpresa> TbEmpresas { get; set; } = null!;
        public virtual DbSet<TbFornecedor> TbFornecedors { get; set; } = null!;
        public virtual DbSet<TbFuncionario> TbFuncionarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__tb_clien__677F38F53FF52ED6");

                entity.ToTable("tb_cliente");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.CpfCliente)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Cpf_Cliente");

                entity.Property(e => e.EnderecoCliente)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Cliente");

                entity.Property(e => e.HistoricoTransacoes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Historico_Transacoes");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.NomeCliente)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nome_cliente");

                entity.Property(e => e.SaldoCredor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Saldo_Credor");

                entity.Property(e => e.SaldoDevedor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Saldo_Devedor");

                entity.Property(e => e.TipoCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Cliente");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TbClientes)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__tb_client__id_em__2D27B809");
            });

            modelBuilder.Entity<TbContasAPagar>(entity =>
            {
                entity.HasKey(e => e.IdContas)
                    .HasName("PK__tb_conta__88AFB7ADE982D06D");

                entity.ToTable("tb_contas_a_pagar");

                entity.Property(e => e.IdContas).HasColumnName("id_contas");

                entity.Property(e => e.DataVencimento)
                    .HasColumnType("date")
                    .HasColumnName("data_vencimento");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.IdFornecedor).HasColumnName("id_fornecedor");

                entity.Property(e => e.NumeroFatura)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("numero_fatura");

                entity.Property(e => e.PagamentoTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pagamento_tipo");

                entity.Property(e => e.StatusConta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("status_conta");

                entity.Property(e => e.ValorContas)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_contas");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TbContasAPagars)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__tb_contas__id_em__300424B4");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TbContasAPagars)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK__tb_contas__id_fo__30F848ED");
            });

            modelBuilder.Entity<TbContasAReceber>(entity =>
            {
                entity.HasKey(e => e.IdContas)
                    .HasName("PK__tb_conta__88AFB7AD4FFF33B3");

                entity.ToTable("tb_contas_a_receber");

                entity.Property(e => e.IdContas).HasColumnName("id_contas");

                entity.Property(e => e.DataVencimento)
                    .HasColumnType("date")
                    .HasColumnName("data_vencimento");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.NumeroFatura)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("numero_fatura");

                entity.Property(e => e.PagamentoTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pagamento_tipo");

                entity.Property(e => e.StatusConta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("status_conta");

                entity.Property(e => e.ValorContas)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_contas");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbContasARecebers)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__tb_contas__id_cl__34C8D9D1");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TbContasARecebers)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__tb_contas__id_em__33D4B598");
            });

            modelBuilder.Entity<TbEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PK__tb_empre__4A0B7E2CBAFA4740");

                entity.ToTable("tb_empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.CapitalSocial)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Capital_social");

                entity.Property(e => e.CnpjEmpresa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Cnpj_Empresa");

                entity.Property(e => e.EnderecoEmpresa)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Empresa");

                entity.Property(e => e.Ramo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Registros)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmpresa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Empresa");
            });

            modelBuilder.Entity<TbFornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor)
                    .HasName("PK__tb_forne__6C477092D18F7E8B");

                entity.ToTable("tb_fornecedor");

                entity.Property(e => e.IdFornecedor).HasColumnName("id_fornecedor");

                entity.Property(e => e.CnpjFornecedor)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("Cnpj_Fornecedor");

                entity.Property(e => e.CondicoesPagamento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Condicoes_Pagamento");

                entity.Property(e => e.EnderecoFornecedor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Fornecedor");

                entity.Property(e => e.HistoricoTransacoes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Historico_transacoes");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.NomeFornecedor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Fornecedor");

                entity.Property(e => e.TipoFornecedor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Fornecedor");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TbFornecedors)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__tb_fornec__id_em__29572725");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__tb_funci__6FBD69C4973826D9");

                entity.ToTable("tb_funcionario");

                entity.Property(e => e.IdFuncionario).HasColumnName("id_funcionario");

                entity.Property(e => e.Beneficios)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContaBancaria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Conta_Bancaria");

                entity.Property(e => e.CpfFuncionario)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Cpf_Funcionario");

                entity.Property(e => e.EnderecoFuncionario)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Endereco_Funcionario");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.NomeFuncionario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nome_Funcionario");

                entity.Property(e => e.Salario).HasColumnType("decimal(16, 2)");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TbFuncionarios)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__tb_funcio__id_em__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
