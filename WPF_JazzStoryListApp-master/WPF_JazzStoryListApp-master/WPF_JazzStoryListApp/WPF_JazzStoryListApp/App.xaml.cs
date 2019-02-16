using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_JazzStoryListApp;
using WPF_JazzStoryListApp.BusinessLayer;

namespace WPF_JazzStoryListApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Here is where we create a new Business Layer object. 
            // Before we are able to do this, we need to create a new 
            // product business layer class that holds the fields, properties 
            // and constructors that allow us to work with this class of objects

            ProductBL productViewerBL = new ProductBL(); //If there are red squigilies itsmost likely because it is not linking to the class correctly
        }
    }
}
