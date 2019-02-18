using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS
        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;


        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context and show the main window
            //

            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS
        private Company GetCompanyData()
        {

            return new Company()
            {
                Name = "Jazz Story Software Inc.",
                Address = "465 Smooth Blvd.",
                City = "Detroit"
            };
        }

        private Product GetProductData()
        {
            return new Product()
            {
                ArtistID = 1,
                FirstName = "John",
                LastName = "Coltrane",
                ImageFileName = "coltrane.jpg",
                Birthdate = DateTime.Parse("09-23-1926"),
                SongName = "Bakai",
                Album = "Coltrane",
                YearProduced = 1957,
                AliveOrDeceased = Product.AliveOrNot.deceased,
                Gender = Product.GenderType.male,
                SongFact = "Written by a friend, trumpeter and one-time roommate of Coltrane's named Calvin Massey, " +
                    "Bakai means \"City\" in Arabic The title was used in memory of Emmett Till, a 14-year-old black boy " +
                    "who was killed by older white men in the American South in 1955 for whisteling at a white woman. This song" +
                    " was the beginning of John Cltrane's connection to the civil rights movement."
            };
        }

        #endregion

        #region EVENTS

        #endregion

    }
}
