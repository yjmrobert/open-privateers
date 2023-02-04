using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenPrivateers.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VariantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VariantLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ships_ShipClasses_ShipClassId",
                        column: x => x.ShipClassId,
                        principalTable: "ShipClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleProperties",
                columns: table => new
                {
                    ShipModuleId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleProperties", x => new { x.ShipModuleId, x.AttributeId });
                    table.ForeignKey(
                        name: "FK_ModuleProperties_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleProperties_ShipModules_ShipModuleId",
                        column: x => x.ShipModuleId,
                        principalTable: "ShipModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeaponClassificationId = table.Column<int>(type: "int", nullable: true),
                    DamageTypeId = table.Column<int>(type: "int", nullable: true),
                    PrioritizedTarget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamagePerHit = table.Column<int>(type: "int", nullable: false),
                    AntiShipFire = table.Column<int>(type: "int", nullable: false),
                    AirDefense = table.Column<int>(type: "int", nullable: false),
                    SiegeFire = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    LockOnTime = table.Column<int>(type: "int", nullable: false),
                    Cooldown = table.Column<int>(type: "int", nullable: false),
                    ProjectilesPerShot = table.Column<int>(type: "int", nullable: false),
                    ShotsPerSalvo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponClassifications_WeaponClassificationId",
                        column: x => x.WeaponClassificationId,
                        principalTable: "WeaponClassifications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShipSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemHealth = table.Column<int>(type: "int", nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShipSystems_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemHealth = table.Column<int>(type: "int", nullable: false),
                    ShipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponSystems_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeaponId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abilities_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AttackPriorities",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    ShipClassId = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackPriorities", x => new { x.WeaponId, x.ShipClassId });
                    table.ForeignKey(
                        name: "FK_AttackPriorities_ShipClasses_ShipClassId",
                        column: x => x.ShipClassId,
                        principalTable: "ShipClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttackPriorities_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleInstallations",
                columns: table => new
                {
                    ShipSystemId = table.Column<int>(type: "int", nullable: false),
                    ShipModuleId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleInstallations", x => new { x.ShipSystemId, x.ShipModuleId });
                    table.ForeignKey(
                        name: "FK_ModuleInstallations_ShipModules_ShipModuleId",
                        column: x => x.ShipModuleId,
                        principalTable: "ShipModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleInstallations_ShipSystems_ShipSystemId",
                        column: x => x.ShipSystemId,
                        principalTable: "ShipSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponInstallations",
                columns: table => new
                {
                    WeaponSystemId = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponInstallations", x => new { x.WeaponSystemId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_WeaponInstallations_WeaponSystems_WeaponSystemId",
                        column: x => x.WeaponSystemId,
                        principalTable: "WeaponSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponInstallations_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_WeaponId",
                table: "Abilities",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_AttackPriorities_ShipClassId",
                table: "AttackPriorities",
                column: "ShipClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleInstallations_ShipModuleId",
                table: "ModuleInstallations",
                column: "ShipModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleProperties_AttributeId",
                table: "ModuleProperties",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_ShipClassId",
                table: "Ships",
                column: "ShipClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipSystems_ShipId",
                table: "ShipSystems",
                column: "ShipId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponInstallations_WeaponId",
                table: "WeaponInstallations",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_DamageTypeId",
                table: "Weapons",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponClassificationId",
                table: "Weapons",
                column: "WeaponClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponSystems_ShipId",
                table: "WeaponSystems",
                column: "ShipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "AttackPriorities");

            migrationBuilder.DropTable(
                name: "ModuleInstallations");

            migrationBuilder.DropTable(
                name: "ModuleProperties");

            migrationBuilder.DropTable(
                name: "WeaponInstallations");

            migrationBuilder.DropTable(
                name: "ShipSystems");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "ShipModules");

            migrationBuilder.DropTable(
                name: "WeaponSystems");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "WeaponClassifications");

            migrationBuilder.DropTable(
                name: "ShipClasses");
        }
    }
}
