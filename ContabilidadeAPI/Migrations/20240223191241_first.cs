using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContabilidadeAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_empresa",
                columns: table => new
                {
                    id_empresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cnpj_Empresa = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    Endereco_Empresa = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Tipo_Empresa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Ramo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Capital_social = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Regime = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Registros = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tb_empre__4A0B7E2CBAFA4740", x => x.id_empresa);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_cliente = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cpf_Cliente = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Endereco_Cliente = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Tipo_Cliente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Historico_Transacoes = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Saldo_Devedor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Saldo_Credor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    id_empresa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tb_clien__677F38F53FF52ED6", x => x.id_cliente);
                    table.ForeignKey(
                        name: "FK__tb_client__id_em__2D27B809",
                        column: x => x.id_empresa,
                        principalTable: "tb_empresa",
                        principalColumn: "id_empresa");
                });

            migrationBuilder.CreateTable(
                name: "tb_fornecedor",
                columns: table => new
                {
                    id_fornecedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Fornecedor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cnpj_Fornecedor = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    Endereco_Fornecedor = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Tipo_Fornecedor = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Condicoes_Pagamento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Historico_transacoes = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    id_empresa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tb_forne__6C477092D18F7E8B", x => x.id_fornecedor);
                    table.ForeignKey(
                        name: "FK__tb_fornec__id_em__29572725",
                        column: x => x.id_empresa,
                        principalTable: "tb_empresa",
                        principalColumn: "id_empresa");
                });

            migrationBuilder.CreateTable(
                name: "tb_funcionario",
                columns: table => new
                {
                    id_funcionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Funcionario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Cpf_Funcionario = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Endereco_Funcionario = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Cargo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    Conta_Bancaria = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Beneficios = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    id_empresa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tb_funci__6FBD69C4973826D9", x => x.id_funcionario);
                    table.ForeignKey(
                        name: "FK__tb_funcio__id_em__267ABA7A",
                        column: x => x.id_empresa,
                        principalTable: "tb_empresa",
                        principalColumn: "id_empresa");
                });

            migrationBuilder.CreateTable(
                name: "tb_contas_a_receber",
                columns: table => new
                {
                    id_contas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor_contas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    data_vencimento = table.Column<DateTime>(type: "date", nullable: true),
                    status_conta = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    numero_fatura = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    pagamento_tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_empresa = table.Column<int>(type: "int", nullable: true),
                    id_cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tb_conta__88AFB7AD4FFF33B3", x => x.id_contas);
                    table.ForeignKey(
                        name: "FK__tb_contas__id_cl__34C8D9D1",
                        column: x => x.id_cliente,
                        principalTable: "tb_cliente",
                        principalColumn: "id_cliente");
                    table.ForeignKey(
                        name: "FK__tb_contas__id_em__33D4B598",
                        column: x => x.id_empresa,
                        principalTable: "tb_empresa",
                        principalColumn: "id_empresa");
                });

            migrationBuilder.CreateTable(
                name: "tb_contas_a_pagar",
                columns: table => new
                {
                    id_contas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor_contas = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    data_vencimento = table.Column<DateTime>(type: "date", nullable: true),
                    status_conta = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    numero_fatura = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    pagamento_tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_empresa = table.Column<int>(type: "int", nullable: true),
                    id_fornecedor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tb_conta__88AFB7ADE982D06D", x => x.id_contas);
                    table.ForeignKey(
                        name: "FK__tb_contas__id_em__300424B4",
                        column: x => x.id_empresa,
                        principalTable: "tb_empresa",
                        principalColumn: "id_empresa");
                    table.ForeignKey(
                        name: "FK__tb_contas__id_fo__30F848ED",
                        column: x => x.id_fornecedor,
                        principalTable: "tb_fornecedor",
                        principalColumn: "id_fornecedor");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb_cliente_id_empresa",
                table: "tb_cliente",
                column: "id_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_contas_a_pagar_id_empresa",
                table: "tb_contas_a_pagar",
                column: "id_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_contas_a_pagar_id_fornecedor",
                table: "tb_contas_a_pagar",
                column: "id_fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_tb_contas_a_receber_id_cliente",
                table: "tb_contas_a_receber",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_contas_a_receber_id_empresa",
                table: "tb_contas_a_receber",
                column: "id_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_fornecedor_id_empresa",
                table: "tb_fornecedor",
                column: "id_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_funcionario_id_empresa",
                table: "tb_funcionario",
                column: "id_empresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tb_contas_a_pagar");

            migrationBuilder.DropTable(
                name: "tb_contas_a_receber");

            migrationBuilder.DropTable(
                name: "tb_funcionario");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "tb_fornecedor");

            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_empresa");
        }
    }
}
