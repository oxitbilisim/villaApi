using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class RezervasyonCustomerDtoQ
    {
        public int? Id { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
 
        public string Not { get; set; }
    }
}