namespace EstadisticaFutbol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTablaCampeonatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.CAMPEONATO",
                c => new
                    {
                        CODIGO = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        DESCRIPCION = c.String(nullable: false, maxLength: 50),
                        FECHA_INICIO = c.DateTime(nullable: false),
                        FECHA_CULMINACION = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CODIGO);
            
        }
        
        public override void Down()
        {
            DropTable("ADMINISTRADOR.CAMPEONATO");
        }
    }
}
