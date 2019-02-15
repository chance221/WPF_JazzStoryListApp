using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_JazzStoryListApp.Models
{
    class Company
    {
        //propf tab tab is good for not only setting but also making changes to the attributes of a class object. But if we are just putting information in and taking it out a simpler form is available.
        //use an auto implimented property by using prop tab tab (notice it leaves off the f)
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
    }
}
