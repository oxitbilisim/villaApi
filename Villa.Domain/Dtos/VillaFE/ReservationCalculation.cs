using System.Collections.Generic;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class ReservationCalculation
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public string DateNight { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DownPayment { get; set; }
        public decimal Deposit { get; set; }
        public string IncluededInPrice { get; set; }
        public decimal CleaningFee { get; set; }
    }
}