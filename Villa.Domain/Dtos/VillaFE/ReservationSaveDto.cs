using System;
using System.Collections.Generic;

namespace Villa.Domain.Dtos.VillaFE;

public class ReservationSaveDto
{
    public int VillaId  { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string name { get; set; }
    public int GuestCount { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string? Note { get; set; }
    public List<int>? ExtraServices { get; set; }
}