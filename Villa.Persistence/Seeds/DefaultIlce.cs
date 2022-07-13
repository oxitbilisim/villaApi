using Microsoft.AspNetCore.Identity;
using Villa.Domain.Enum;
using System.Collections.Generic;
using Villa.Domain.Entities;

namespace Villa.Persistence.Seeds
{
   public static class DefaultIlces
    {
        public static List<Ilce> IlceList()
        {
            return new List<Ilce>()
            {
                new Ilce
                {  
                    Id = 1,
                    IlId = 1,
                    Ad = "Kaş",
                },
                new Ilce
                {  
                    Id = 2,
                    IlId = 1,
                    Ad = "Alanya",
                },
                new Ilce
                {  
                    Id = 3,
                    IlId = 1,
                    Ad = "Manavgat",
                },
                new Ilce
                {  
                    Id = 4,
                    IlId = 1,
                    Ad = "Kemer",
                },
                new Ilce
                {  
                    Id = 5,
                    IlId = 1,
                    Ad = "Konyaaltı",
                },
                new Ilce
                {
                    Id = 6,
                    IlId = 2,
                    Ad = "Bodrum",
                },
                new Ilce
                {
                    Id = 7,
                    IlId = 2,
                    Ad = "Fethiye",
                },
                new Ilce
                {
                    Id = 8,
                    IlId = 2,
                    Ad = "Msrmaris",
                },
            
            };
        }
    }
}
