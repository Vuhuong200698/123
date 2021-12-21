namespace BTL_TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        MaNhaCungCap = c.Int(nullable: false, identity: true),
                        TenNhaCungCap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        MaSanPham = c.String(nullable: false, maxLength: 20),
                        TenSanPham = c.String(maxLength: 50),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.NhaCungCaps", t => t.MaNhaCungCap, cascadeDelete: true)
                .Index(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPhams", "MaNhaCungCap", "dbo.NhaCungCaps");
            DropIndex("dbo.SanPhams", new[] { "MaNhaCungCap" });
            DropTable("dbo.SanPhams");
            DropTable("dbo.NhaCungCaps");
        }
    }
}
