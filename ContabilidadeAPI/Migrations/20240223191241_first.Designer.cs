﻿// <auto-generated />
using System;
using ContabilidadeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContabilidadeAPI.Migrations
{
    [DbContext(typeof(db_ConFinContext))]
    [Migration("20240223191241_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContabilidadeAPI.Models.TbCliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("CpfCliente")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Cpf_Cliente");

                    b.Property<string>("EnderecoCliente")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Endereco_Cliente");

                    b.Property<string>("HistoricoTransacoes")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Historico_Transacoes");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    b.Property<string>("NomeCliente")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome_cliente");

                    b.Property<decimal?>("SaldoCredor")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Saldo_Credor");

                    b.Property<decimal?>("SaldoDevedor")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Saldo_Devedor");

                    b.Property<string>("TipoCliente")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Tipo_Cliente");

                    b.HasKey("IdCliente")
                        .HasName("PK__tb_clien__677F38F53FF52ED6");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("tb_cliente", (string)null);
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbContasAPagar", b =>
                {
                    b.Property<int>("IdContas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_contas");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContas"), 1L, 1);

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("date")
                        .HasColumnName("data_vencimento");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    b.Property<int?>("IdFornecedor")
                        .HasColumnType("int")
                        .HasColumnName("id_fornecedor");

                    b.Property<string>("NumeroFatura")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("numero_fatura");

                    b.Property<string>("PagamentoTipo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pagamento_tipo");

                    b.Property<string>("StatusConta")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("status_conta");

                    b.Property<decimal?>("ValorContas")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valor_contas");

                    b.HasKey("IdContas")
                        .HasName("PK__tb_conta__88AFB7ADE982D06D");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdFornecedor");

                    b.ToTable("tb_contas_a_pagar", (string)null);
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbContasAReceber", b =>
                {
                    b.Property<int>("IdContas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_contas");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContas"), 1L, 1);

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("date")
                        .HasColumnName("data_vencimento");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("id_cliente");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    b.Property<string>("NumeroFatura")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("numero_fatura");

                    b.Property<string>("PagamentoTipo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pagamento_tipo");

                    b.Property<string>("StatusConta")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("status_conta");

                    b.Property<decimal?>("ValorContas")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valor_contas");

                    b.HasKey("IdContas")
                        .HasName("PK__tb_conta__88AFB7AD4FFF33B3");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("tb_contas_a_receber", (string)null);
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbEmpresa", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpresa"), 1L, 1);

                    b.Property<decimal?>("CapitalSocial")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Capital_social");

                    b.Property<string>("CnpjEmpresa")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("Cnpj_Empresa");

                    b.Property<string>("EnderecoEmpresa")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Endereco_Empresa");

                    b.Property<string>("Ramo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Regime")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Registros")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("TipoEmpresa")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Tipo_Empresa");

                    b.HasKey("IdEmpresa")
                        .HasName("PK__tb_empre__4A0B7E2CBAFA4740");

                    b.ToTable("tb_empresa", (string)null);
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbFornecedor", b =>
                {
                    b.Property<int>("IdFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_fornecedor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFornecedor"), 1L, 1);

                    b.Property<string>("CnpjFornecedor")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("Cnpj_Fornecedor");

                    b.Property<string>("CondicoesPagamento")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Condicoes_Pagamento");

                    b.Property<string>("EnderecoFornecedor")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Endereco_Fornecedor");

                    b.Property<string>("HistoricoTransacoes")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Historico_transacoes");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    b.Property<string>("NomeFornecedor")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome_Fornecedor");

                    b.Property<string>("TipoFornecedor")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Tipo_Fornecedor");

                    b.HasKey("IdFornecedor")
                        .HasName("PK__tb_forne__6C477092D18F7E8B");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("tb_fornecedor", (string)null);
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbFuncionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_funcionario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"), 1L, 1);

                    b.Property<string>("Beneficios")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Cargo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ContaBancaria")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Conta_Bancaria");

                    b.Property<string>("CpfFuncionario")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Cpf_Funcionario");

                    b.Property<string>("EnderecoFuncionario")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Endereco_Funcionario");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("id_empresa");

                    b.Property<string>("NomeFuncionario")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome_Funcionario");

                    b.Property<decimal?>("Salario")
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("IdFuncionario")
                        .HasName("PK__tb_funci__6FBD69C4973826D9");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("tb_funcionario", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbCliente", b =>
                {
                    b.HasOne("ContabilidadeAPI.Models.TbEmpresa", "IdEmpresaNavigation")
                        .WithMany("TbClientes")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__tb_client__id_em__2D27B809");

                    b.Navigation("IdEmpresaNavigation");
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbContasAPagar", b =>
                {
                    b.HasOne("ContabilidadeAPI.Models.TbEmpresa", "IdEmpresaNavigation")
                        .WithMany("TbContasAPagars")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__tb_contas__id_em__300424B4");

                    b.HasOne("ContabilidadeAPI.Models.TbFornecedor", "IdFornecedorNavigation")
                        .WithMany("TbContasAPagars")
                        .HasForeignKey("IdFornecedor")
                        .HasConstraintName("FK__tb_contas__id_fo__30F848ED");

                    b.Navigation("IdEmpresaNavigation");

                    b.Navigation("IdFornecedorNavigation");
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbContasAReceber", b =>
                {
                    b.HasOne("ContabilidadeAPI.Models.TbCliente", "IdClienteNavigation")
                        .WithMany("TbContasARecebers")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK__tb_contas__id_cl__34C8D9D1");

                    b.HasOne("ContabilidadeAPI.Models.TbEmpresa", "IdEmpresaNavigation")
                        .WithMany("TbContasARecebers")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__tb_contas__id_em__33D4B598");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdEmpresaNavigation");
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbFornecedor", b =>
                {
                    b.HasOne("ContabilidadeAPI.Models.TbEmpresa", "IdEmpresaNavigation")
                        .WithMany("TbFornecedors")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__tb_fornec__id_em__29572725");

                    b.Navigation("IdEmpresaNavigation");
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbFuncionario", b =>
                {
                    b.HasOne("ContabilidadeAPI.Models.TbEmpresa", "IdEmpresaNavigation")
                        .WithMany("TbFuncionarios")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__tb_funcio__id_em__267ABA7A");

                    b.Navigation("IdEmpresaNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbCliente", b =>
                {
                    b.Navigation("TbContasARecebers");
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbEmpresa", b =>
                {
                    b.Navigation("TbClientes");

                    b.Navigation("TbContasAPagars");

                    b.Navigation("TbContasARecebers");

                    b.Navigation("TbFornecedors");

                    b.Navigation("TbFuncionarios");
                });

            modelBuilder.Entity("ContabilidadeAPI.Models.TbFornecedor", b =>
                {
                    b.Navigation("TbContasAPagars");
                });
#pragma warning restore 612, 618
        }
    }
}