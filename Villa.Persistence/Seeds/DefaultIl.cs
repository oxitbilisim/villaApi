using Microsoft.AspNetCore.Identity;
using Villa.Domain.Enum;
using System.Collections.Generic;
using Villa.Domain.Entities;

namespace Villa.Persistence.Seeds
{
   public static class DefaultIls
    {
        public static List<Il> IlList()
        {
            return new List<Il>()
            {
                new Il
                {  
                    Id = 1,
                    Ad = "Antalya",
            
                },
                new Il
                {
                    Id = 2,
                    Ad = "Muğla",
                },
                new Il
                {
                    Id = 3,
                    Ad = "Aydın",
                },
                new Il
                {
                    Id = 4,
                    Ad = "Ankara",
                },
            
            };
        }
    }
}
