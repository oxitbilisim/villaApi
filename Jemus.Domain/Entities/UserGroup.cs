using System;
using System.Collections;
using Jemus.Domain;
using Jemus.Domain.Auth;

namespace Jemus.Entities.Models
{
    /// <summary>
    /// Kullanıcı Grup Model Sınıfı
    /// </summary>
    public class UserGroup : BaseSimpleModel
    {
        /// <summary>
        /// Kullanıcı Grup Model Sınıfı Boş Oluşturucu
        /// </summary>
        public UserGroup()
        {
            // Null(default) constructor
            // if there is a ICollection, add
            // --> this.CollectionModel = new HashSet<CollectionModel>();
        }

        public Guid GroupId { get; set; }

        public virtual Group Grup { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
