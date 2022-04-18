using System.Collections;
using System.Collections.Generic;
using Jemus.Domain;

namespace Jemus.Entities.Models
{
    /// <summary>
    /// Grup Model Sınıfı
    /// </summary>
    public class Group : BaseSimpleModel
    {
        /// <summary>
        /// Grup Model Sınıfı Boş Oluşturucu
        /// </summary>
        public Group()
        {
            this.KullaniciGroup = new HashSet<UserGroup>();
        }

        /// <summary>
        /// Grup Adı
        /// </summary>
        public string Ad { get; set; }

        /// <summary>
        /// Grup Tanımı
        /// </summary>
        public string Tanim { get; set; }

        public virtual ICollection<UserGroup> KullaniciGroup { get; set; }

        public virtual ICollection<GroupClaims> GroupClaims { get; set; }
    }
}
