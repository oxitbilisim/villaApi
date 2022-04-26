
using Jemus.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Jemus.Persistence.Seeds
{
    public static class SeedMenu
    {
        public static List<Menu> MenuList()
        {
            return new List<Menu>()
            {
                 new Menu
                  {
                      Id = Guid.NewGuid(),
                      Label ="Panel",
                      Icon="pi pi-fw pi-globe",
                      RouteLink="/"
                  },
                  new Menu
                  {
                      Id = Guid.NewGuid(),
                      Label="Kullanıcı",
                      Icon="fa fa-gavel",
                      RouteLink="/kullanıcı"
                  },
                   new Menu
                  {
                      Id = Guid.NewGuid(),
                      Label="Kullanıcı Grup",
                      Icon="fa fa-balance-scale",
                      RouteLink="/kullanicigrup"
                             },
                   //new Menu
                   //   {
                   //          Id = "60ab32b2-d884-4ebf-b537-86c6c3459c01".ToString(),
                   //          Label="Tanımlar",
                   //          Icon="pi pi-fw pi-id-card",
                   //          RouteLink="/tanimlar",
                   //            items = new List<Menu>
                   //            {
                   //                new Menu
                   //                {
                   //                    Id = Guid.NewGuid(),
                   //                    Label="Kullanıcı",
                   //                    Icon="pi pi-fw pi-money-bill",
                   //                    RouteLink="/tanimlar/kullanici",
                              
                   //                },
                   //                new Menu
                   //                {
                   //                    Id = Guid.NewGuid(),
                   //                    Label="Bolge Tanımları",
                   //                    Icon= "pi pi-fw pi-ticket",
                   //                    RouteLink="/tanimlar/bolge",
                   //                }
                   //            }
                   //    },
            };
     

        }
    }
}
