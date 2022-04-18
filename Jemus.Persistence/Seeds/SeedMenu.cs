
using Jemus.Entities.Models;
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
                  }
            };

        }
    }
}
