namespace EstadisticaFutbol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDeTablasAspNetIdentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "ADMINISTRADOR.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("ADMINISTRADOR.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("ADMINISTRADOR.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "ADMINISTRADOR.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Decimal(nullable: false, precision: 1, scale: 0),
                        TwoFactorEnabled = c.Decimal(nullable: false, precision: 1, scale: 0),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Decimal(nullable: false, precision: 1, scale: 0),
                        AccessFailedCount = c.Decimal(nullable: false, precision: 10, scale: 0),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "ADMINISTRADOR.AspNetUserClaims",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ADMINISTRADOR.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "ADMINISTRADOR.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("ADMINISTRADOR.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ADMINISTRADOR.AspNetUserRoles", "UserId", "ADMINISTRADOR.AspNetUsers");
            DropForeignKey("ADMINISTRADOR.AspNetUserLogins", "UserId", "ADMINISTRADOR.AspNetUsers");
            DropForeignKey("ADMINISTRADOR.AspNetUserClaims", "UserId", "ADMINISTRADOR.AspNetUsers");
            DropForeignKey("ADMINISTRADOR.AspNetUserRoles", "RoleId", "ADMINISTRADOR.AspNetRoles");
            DropIndex("ADMINISTRADOR.AspNetUserLogins", new[] { "UserId" });
            DropIndex("ADMINISTRADOR.AspNetUserClaims", new[] { "UserId" });
            DropIndex("ADMINISTRADOR.AspNetUsers", "UserNameIndex");
            DropIndex("ADMINISTRADOR.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("ADMINISTRADOR.AspNetUserRoles", new[] { "UserId" });
            DropIndex("ADMINISTRADOR.AspNetRoles", "RoleNameIndex");
            DropTable("ADMINISTRADOR.AspNetUserLogins");
            DropTable("ADMINISTRADOR.AspNetUserClaims");
            DropTable("ADMINISTRADOR.AspNetUsers");
            DropTable("ADMINISTRADOR.AspNetUserRoles");
            DropTable("ADMINISTRADOR.AspNetRoles");
        }
    }
}
