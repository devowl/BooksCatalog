using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sms.DataService.Contracts;
using Sms.DataService.DataAccessLayer;
using Sms.DL.Entities;
using System.Data.Entity;
using System.IO;

namespace Sms.DataService
{
    /// <summary>
    /// Датасервис контекст
    /// </summary>
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall, ConcurrencyMode=ConcurrencyMode.Multiple)] 
    /* Будем работать в режиме инстанс для каждом вызова и в многопотоковом режиме */
    public class DataService : IDataService
    {
        public ICollection<Book> GetBooks()
        {
            using(var context = new DatabaseContext())
            {
                return context.Books.ToList();
            }
        }

        public ICollection<Catalog> GetCatalogs()
        {
            using (var context = new DatabaseContext())
            {
                return context.Catalogs.Include(c => c.Books).ToList();
            }
        }
    }
}
