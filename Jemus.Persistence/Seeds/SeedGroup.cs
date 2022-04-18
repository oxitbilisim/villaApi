
using Jemus.Domain.Utilities;
using Jemus.Entities.Models;
using System;
using System.Collections.Generic;

namespace Jemus.Persistence.Seeds
{
    public static class SeedGroup
    {
        public static List<Group> GroupList()
        {
                return new List<Group>()
            {
                 new Group
                  {
                      Id = Guid.NewGuid(),
                      Ad ="SistemAdmin",
                      Tanim="SistemAdmin"
                  },
                 new Group
                  {
                      Id = Guid.NewGuid(),
                      Ad ="IlAdmin",
                      Tanim="IlAdmin"
                  },
                 new Group
                  {
                      Id = Guid.NewGuid(),
                      Ad ="IlceAdmin",
                      Tanim="IlceAdmin"
                  },
                  new Group
                  {
                      Id = Guid.NewGuid(),
                      Ad ="Karakol",
                      Tanim="Karakol"
                  }
            };

            
        }
    }
}
