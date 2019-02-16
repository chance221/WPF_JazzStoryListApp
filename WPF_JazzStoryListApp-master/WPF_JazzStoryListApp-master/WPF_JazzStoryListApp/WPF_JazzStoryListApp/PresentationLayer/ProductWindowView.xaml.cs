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
using System.Windows.Shapes;
using WPF_JazzStoryListApp.Models;
using WPF_JazzStoryListApp.BusinessLayer;

namespace WPF_JazzStoryListApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for ProductWindowPresenter.xaml
    /// </summary>
    public partial class ProductWindowView : Window
    {
        #region FIELDS

        ProductWindowPresenter _productWindowPresenter;
        #endregion

        #region METHODS
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

        
    }
}
