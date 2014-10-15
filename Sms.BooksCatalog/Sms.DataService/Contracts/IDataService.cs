using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Sms.DL.Entities;

namespace Sms.DataService.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {
        /// <summary>
        /// Получение списка книг
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ICollection<Book> GetBooks();

        /// <summary>
        /// Получение списка каталогов книг
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ICollection<Catalog> GetCatalogs();
    }
}
