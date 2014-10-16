using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Runtime.Serialization;
using Sms.DL.Data;

namespace Sms.DL.Entities
{
    [DataContract]
    /// <summary>
    /// Класс книга
    /// </summary>
    public class Book : IEntity
    {
        [DataMember]
        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; }

        [DataMember]
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        [DataMember]
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        [DataMember]
        /// <summary>
        /// Год выпуска
        /// </summary>
        public DateTime ProductionDate { get; set; }

        [DataMember]
        /// <summary>
        /// Обложка
        /// </summary>
        public byte[] BookImage { get; set; }

        [DataMember]
        /// <summary>
        /// Ссылка на электронную версию
        /// </summary>
        public string Url { get; set; }

        [DataMember]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Каталоги книги
        /// </summary>
        public virtual ICollection<Catalog> Catalogs { get; set; }
    }
}
