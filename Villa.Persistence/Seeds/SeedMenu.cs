
using Villa.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Villa.Persistence.Seeds
{
    public static class SeedMenu
    {
        public static List<Menu> MenuList()
        {
            return new List<Menu>()
            {
                 new Menu
                  {
                      Id = 1,
                      Label ="Panel",
                      Icon="pi pi-fw pi-globe",
                      RouteLink="/"
                  },
                  new Menu
                  {
                      Id = 2,
                      Label="Kullanıcı",
                      Icon="fa fa-gavel",
                      RouteLink="/kullanıcı"
                  },
                   new Menu
                  {
                      Id = 3,
                      Label="Kullanıcı Grup",
                      Icon="fa fa-balance-scale",
                      RouteLink="/kullanicigrup"
                             },
                   new Menu
                      {
                             Id = 5,
                             Label="Tanımlar",
                             Icon="pi pi-fw pi-id-card",
                             RouteLink="/tanimlar",
                               // items = new List<Menu>
                               // {
                               //     new Menu
                               //     {
                               //         Id = 6,
                               //         Label="Bolge",
                               //         Icon= "pi pi-fw pi-ticket",
                               //         RouteLink="/tanimlar/bolge",
                               //         ParentMenuId = 5,
                               //     },
                               //     new Menu
                               //     {
                               //         Id = 7,
                               //         Label="Kategori",
                               //         Icon= "pi pi-fw pi-ticket",
                               //         RouteLink="/tanimlar/bolge",
                               //         ParentMenuId = 5,
                               //     }
                               // }
                       },
            };
     

        }
    }
}
