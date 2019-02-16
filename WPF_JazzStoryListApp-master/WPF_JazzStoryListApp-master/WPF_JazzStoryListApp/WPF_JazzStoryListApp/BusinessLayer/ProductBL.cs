using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_JazzStoryListApp.PresentationLayer;
using WPF_JazzStoryListApp.Models;


namespace WPF_JazzStoryListApp.BusinessLayer
{
    public class ProductBL //the access modifier needs to be public to allow other files to access this.
    {
        #region ENUMS

        #endregion

        #region FIELDS
        //As we are currently in the Product Business Layer we need to create a spot in memory for BOTH the View and the Presenter as we need them to talk to each other 
        //and access data to and from each other.

        ProductWindowView _productWindowView; 
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        // You know it is a constructor because it is a method that will have the exact same name of the class
        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //

            _productWindowView = new ProductWindowView();
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

    private Products GetProductData()
        {
            return new Products()
            {
                ArtistID = 1,
                FirstName = "John",
                LastName = "Coltrane",
                ImageFileName = "coltrane.jpg",
                Birthdate = DateTime.Parse("09-23-1926"),
                SongName = "Bakai",
                Album = "Coltrane",
                YearProduced = 1957,
                AliveOrDeceased = Products.AliveOrNot.deceased,
                Gender = Products.GenderType.male,
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
