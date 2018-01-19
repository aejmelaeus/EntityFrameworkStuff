using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Common;
using Database.Entitites;

namespace Database.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var context = new DatabaseContext())
            {
                var allanAdministratör = new User
                {
                    DisplayName = "Allan Administratör",
                    Email = "allan.administrator@teacher.se"
                };

                var bengtLärare = new User
                {
                    DisplayName = "Bengt Haraldsson",
                    Email = "bengt.haraldsson@test.se"
                };

                var lisaLärare = new User
                {
                    DisplayName = "Lisa Nilsson",
                    Email = "lisa.nilsson@test.se"
                };

                var nisseElev = new User
                {
                    DisplayName = "Nisse Testsson",
                    Email = "nisse.testsson@student.se"
                };

                var stinaElev = new User
                {
                    DisplayName = "Stina Svensson",
                    Email = "stina.svensson@student.se"
                };

                var kajElev = new User
                {
                    DisplayName = "Kaj Kunnas",
                    Email = "kaj.kunnas@student.se"
                };

                var fiaElev = new User
                {
                    DisplayName = "Anna Petterson",
                    Email = "anna.petterson@student.se"
                };

                var enProdukt = new Product
                {
                    Name = "En testprodukt"
                };

                var enAnnanProdukt = new Product
                {
                    Name = "En annan testprodukt"
                };

                var tenant = new Tenant
                {
                    Name = "Borgbackaskolan"
                };

                var fjugestaskolan = new Tenant
                {
                    Name = "Fjugestaskolan"
                };

                /*
                ** Tenant Users
                */

                var allanAdministratörTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = allanAdministratör,
                    Role = TenantRole.Administrator
                };

                var bengtLärareTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = bengtLärare,
                    Role = TenantRole.Teacher
                };

                var lisaLärareTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = lisaLärare,
                    Role = TenantRole.Teacher
                };

                var nisseElevTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = nisseElev,
                    Role = TenantRole.Student
                };

                var stinaElevTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = stinaElev,
                    Role = TenantRole.Student
                };

                var kajElevTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = kajElev,
                    Role = TenantRole.Student
                };

                var fiaElevTenantUser = new TenantUser
                {
                    Tenant = tenant,
                    User = fiaElev,
                    Role = TenantRole.Student
                };

                context.Tenants.Add(tenant);

                context.Users.Add(allanAdministratör);
                context.Users.Add(bengtLärare);
                context.Users.Add(lisaLärare);
                context.Users.Add(nisseElev);
                context.Users.Add(stinaElev);
                context.Users.Add(kajElev);
                context.Users.Add(fiaElev);

                context.TenantUsers.Add(allanAdministratörTenantUser);
                context.TenantUsers.Add(bengtLärareTenantUser);
                context.TenantUsers.Add(lisaLärareTenantUser);
                context.TenantUsers.Add(nisseElevTenantUser);
                context.TenantUsers.Add(stinaElevTenantUser);
                context.TenantUsers.Add(kajElevTenantUser);
                context.TenantUsers.Add(fiaElevTenantUser);


                context.Products.Add(enProdukt);
                context.Products.Add(enAnnanProdukt);


                context.SaveChanges();

                var klass7a = new Group
                {
                    Tenant = tenant,
                    CreatedByUserDisplayName = bengtLärare.DisplayName,
                    Name = "Klass 7A",
                    CreatedUtc = DateTime.UtcNow,
                    CreatedByUserId = bengtLärare.Id,
                    Members = new List<GroupMember>
                    {
                        new GroupMember
                        {
                            TenantUser = bengtLärareTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = nisseElevTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = stinaElevTenantUser
                        }
                    }
                };

                var klass7b = new Group
                {
                    Tenant = tenant,
                    CreatedByUserDisplayName = lisaLärare.DisplayName,
                    Name = "Klass 7B",
                    CreatedUtc = DateTime.UtcNow,
                    CreatedByUserId = lisaLärare.Id,
                    Members = new List<GroupMember>
                    {
                        new GroupMember
                        {
                            TenantUser = lisaLärareTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = kajElevTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = fiaElevTenantUser
                        }
                    }
                };

                var allaElever = new Group
                {
                    Tenant = tenant,
                    CreatedByUserDisplayName = allanAdministratör.DisplayName,
                    Name = "Alla elever",
                    CreatedUtc = DateTime.UtcNow,
                    CreatedByUserId = allanAdministratör.Id,
                    Members = new List<GroupMember>
                    {
                        new GroupMember
                        {
                            TenantUser = nisseElevTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = stinaElevTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = kajElevTenantUser
                        },
                        new GroupMember
                        {
                            TenantUser = fiaElevTenantUser
                        }
                    }

                };

                context.Groups.Add(klass7a);
                context.Groups.Add(klass7b);
                context.Groups.Add(allaElever);

                context.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
