using Microsoft.AspNetCore.Identity;
using Villa.Domain.Enum;
using System.Collections.Generic;
using Villa.Domain.Entities;

namespace Villa.Persistence.Seeds
{

    public static class DefaultMulks
    {
        public static List<Mulk> MulkList()
        {
            return new List<Mulk>()
            {
                new Mulk
                {  
                    Id = 1,
                    Ad = "Villa",
            
                },
                new Mulk
                {
                    Id = 2,
                    Ad = "Apart",
                },
                new Mulk
                {
                    Id = 3,
                    Ad = "Ev",
                },
                new Mulk
                {
                    Id = 4,
                    Ad = "Bungalov",
                },
            
            };
        }
    }
}
