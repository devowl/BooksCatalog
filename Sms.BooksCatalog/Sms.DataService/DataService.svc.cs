using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sms.DataService.Contracts;
using Sms.DL.Entities;

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
            throw new NotImplementedException();
        }

        public ICollection<Catalog> GetCatalogs()
        {
            throw new NotImplementedException();
        }
    }
}
