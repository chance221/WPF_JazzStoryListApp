using WPF_MasterDetailApp.Models;
using WPF_MasterDetailApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_MasterDetailApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ProductWindowView : Window
    {
        #region FIELDS

        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region METHODS (pass events to view model)

        private void Button_Quit_Click(object sender, RoutedEventArgs e)
        {
           _productWindowPresenter.QuitApplication();
        }


        #endregion

        #region CONSTRUCTORS
        public ProductWindowView(ProductWindowPresenter productPresenter)
        {
            _productWindowPresenter = productPresenter;

            DataContext = _productWindowPresenter;

            InitializeComponent();

        }

        #endregion
        //need to figure out how ot take this out of the view and place in presenter
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
