using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Sms.DL.Entities;

namespace Sms.DataService.DataAccessLayer
{
    /// <summary>
    /// DAL для книг
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// Конструктор контекста
        /// </summary>
        public DatabaseContext()
            : base("DefaultConnection")
        {
            //Не геннерировать прокси для lazy
            base.Configuration.ProxyCreationEnabled = false;
        }

        /// <summary>
        /// Книги
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Каталоги
        /// </summary>
        public DbSet<Catalog> Catalogs { get; set; }
        
    }
}