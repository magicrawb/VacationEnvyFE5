namespace VacationEnvyFE5.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        StateId = c.Int(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.StateId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.CityAlbums",
                c => new
                    {
                        CityAlbumId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DatePosted = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        CityId = c.Int(nullable: false),
                        CountryAlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityAlbumId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.CountryAlbums", t => t.CountryAlbumId, cascadeDelete: false)
                .Index(t => t.CityId)
                .Index(t => t.CountryAlbumId);
            
            CreateTable(
                "dbo.CountryAlbums",
                c => new
                    {
                        CountryAlbumId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DatePosted = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        CountryId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CountryAlbumId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CountryId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: false)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Biography = c.String(),
                        DateCreated = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Birthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CityId = c.Int(),
                        CountryId = c.Int(),
                        Gender = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.CityId)
                .Index(t => t.CountryId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserFollows",
                c => new
                    {
                        UserFollowId = c.Int(nullable: false, identity: true),
                        FromId = c.String(maxLength: 128),
                        ToId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserFollowId)
                .ForeignKey("dbo.AspNetUsers", t => t.FromId)
                .ForeignKey("dbo.AspNetUsers", t => t.ToId)
                .Index(t => t.FromId)
                .Index(t => t.ToId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        PictureId = c.Int(nullable: false, identity: true),
                        UrlName = c.String(),
                        Caption = c.String(),
                        TagName = c.String(),
                        IsCityCoverPic = c.Boolean(nullable: false),
                        IsCountryCoverPic = c.Boolean(nullable: false),
                        CountryAlbumId = c.Int(nullable: false),
                        CityAlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PictureId)
                .ForeignKey("dbo.CityAlbums", t => t.CityAlbumId, cascadeDelete: true)
                .ForeignKey("dbo.CountryAlbums", t => t.CountryAlbumId, cascadeDelete: true)
                .Index(t => t.CountryAlbumId)
                .Index(t => t.CityAlbumId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Pictures", "CountryAlbumId", "dbo.CountryAlbums");
            DropForeignKey("dbo.Pictures", "CityAlbumId", "dbo.CityAlbums");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserFollows", "ToId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserFollows", "FromId", "dbo.AspNetUsers");
            DropForeignKey("dbo.CountryAlbums", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropForeignKey("dbo.CountryAlbums", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.CityAlbums", "CountryAlbumId", "dbo.CountryAlbums");
            DropForeignKey("dbo.CityAlbums", "CityId", "dbo.Cities");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Pictures", new[] { "CityAlbumId" });
            DropIndex("dbo.Pictures", new[] { "CountryAlbumId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.UserFollows", new[] { "ToId" });
            DropIndex("dbo.UserFollows", new[] { "FromId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "CountryId" });
            DropIndex("dbo.AspNetUsers", new[] { "CityId" });
            DropIndex("dbo.States", new[] { "CountryId" });
            DropIndex("dbo.CountryAlbums", new[] { "UserId" });
            DropIndex("dbo.CountryAlbums", new[] { "CountryId" });
            DropIndex("dbo.CityAlbums", new[] { "CountryAlbumId" });
            DropIndex("dbo.CityAlbums", new[] { "CityId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Pictures");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.UserFollows");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.States");
            DropTable("dbo.Countries");
            DropTable("dbo.CountryAlbums");
            DropTable("dbo.CityAlbums");
            DropTable("dbo.Cities");
        }
    }
}
