using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sms.Forms.ViewModels;

namespace Sms.Forms.Views
{
    /// <summary>
    /// Interaction logic for BooksCatalog.xaml
    /// </summary>
    public partial class BooksCatalog : UserControl
    {
        public BooksCatalog()
        {
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContext = new BooksCatalogViewModel();
            }
            InitializeComponent();
        }
    }
}
