using System;
using System.Collections.Generic;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class ReservationInfoDto
    {
        public int Id { get; set; }
        public string? VillaName { get; set; }
        
        public string? VillaRegionName { get; set; }
        public string? VillaUrl { get; set; }
        public string? GuestName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public Int64? VillaId { get; set; }
        public Int64? VillaImageId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? GuestCount { get; set; }
        public int NightCount { get; set; }
        public string Currency { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DownPayment { get; set; }
        public decimal Deposit { get; set; }
        public string IncluededInPrice { get; set; }
        public decimal CleaningFee { get; set; }
    }
}