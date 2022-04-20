using System;
using System.Collections.Generic;
using System.Text;

namespace Jemus.Infrastructure.ViewModel
{
    public class KullaniciReadViewModel : BaseViewModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public string BirimAd { get; set; }
        public string BirimIlceIlAd { get; set; }
        public string BirimIlceAd { get; set; }
        public string Rol { get; set; }
    }
}
