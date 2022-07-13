using Microsoft.AspNetCore.Identity;
using Villa.Domain.Enum;
using System.Collections.Generic;
using Villa.Domain.Entities;

namespace Villa.Persistence.Seeds
{

    public static class DefaultParaBirimis
    {
        public static List<ParaBirimi> ParaBirimiList()
        {
            return new List<ParaBirimi>()
            {
                new ParaBirimi
                {  
                    Id = 1,
                    Ad = "TL",
            
                },
                new ParaBirimi
                {
                    Id = 2,
                    Ad = "USD",
                },
                new ParaBirimi
                {
                    Id = 3,
                    Ad = "EURO",
                },
                new ParaBirimi
                {
                    Id = 4,
                    Ad = "GBP",
                },
            
            };
        }
    }
}
