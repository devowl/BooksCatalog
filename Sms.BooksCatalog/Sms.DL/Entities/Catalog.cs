using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Sms.DL.Data;

namespace Sms.DL.Entities
{
    [DataContract]
    /// <summary>
    /// Каталог с книгами
    /// </summary>
    public class Catalog : IEntity
    {
        [DataMember]
        /// <summary>
        /// Название каталога
        /// </summary>
        public string CatalogName { get; set; }

        [DataMember]
        /// <summary>
        /// Коллекция книг каталога
        /// </summary>
        public virtual ICollection<Book> Books { get; set; }

        [DataMember]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
