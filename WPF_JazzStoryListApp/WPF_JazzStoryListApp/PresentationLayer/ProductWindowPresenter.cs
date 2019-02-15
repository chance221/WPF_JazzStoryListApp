using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_JazzStoryListApp.Models;

namespace WPF_JazzStoryListApp.PresentationLayer
{
    class ProductWindowPresenter  //ObservavableObject is in S1 solution but not here what does this do?
    {
        #region ENUMS

        #endregion

        #region FIELDS
 

        private Company _companyInfo;
        private Products _selectedProducts;

        public Products SelectedProducts
        {
            get { return _selectedProducts; }
            set { _selectedProducts = value; }
        }


        public Company CompanyInfo
        {
            get { return _companyInfo; }
            set { _companyInfo = value; }
        }



        #endregion

        #region CONSTRUCTORS

        public ProductWindowPresenter(Company company, Products products)
        {
            _selectedProducts = products;
            _companyInfo = company;
        }
        #endregion

        #region METHODS

        public void QuitApplication()
        {
            Environment.Exit(0);
        }
        
        #endregion
    }
}
