using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Sms.Forms.DataService;

namespace Sms.Forms.ViewModels
{
    /// <summary>
    /// ViewModel для каталога книг
    /// </summary>
    public class BooksCatalogViewModel : INotifyPropertyChanged
    {
        DataServiceClient _dataClient = null;
        /// <summary>
        /// Конструктор инициализации
        /// </summary>
        public BooksCatalogViewModel()
        {
            _dataClient = new DataServiceClient();
            _booksCatalog = _dataClient.GetCatalogs(); 
        }

        public ICollection<Catalog> _booksCatalog = null;
        /// <summary>
        /// Коллекция книг для байндинга
        /// </summary>
        public ICollection<Catalog> BooksCatalog
        {
            get
            {
                return _booksCatalog; 
            }
        }


        /// <summary>
        /// Открыть ссылку на сайт
        /// </summary>
        public ICommand OpenUrlCommand
        {
            get;
            private set;
        }

        /// <summary>
        /// Выбранный каталог книг
        /// </summary>
        private Catalog _selectedItemCatalog = null;
        public Catalog SelectedItemCatalog
        {
            get
            {
                return _selectedItemCatalog;
            }
            set
            {
                if (value == null) return;
                _selectedItemCatalog = value;
                OnPropertyChanged("SelectedItemCatalog");
            }
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
        #endregion
    }
}
