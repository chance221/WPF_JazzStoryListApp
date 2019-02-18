using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum GenderType { none, male, female }

        public enum AliveOrNot { none, deceased, alive }

        #endregion

        #region FIELDS
        private string _songFact;
        private int _age;
        private DateTime _dateOfBirth;
        private GenderType _gender;
        private AliveOrNot _aliveOrNot;
        private int _yearProduced;
        private string _songName;
        private string _album;
        private string _firstName;
        private string _lastName;
        private int _artistID;
        private string _imageFileName;
        #endregion

        #region PROPERTIES
        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }


        public int ArtistID
        {
            get { return _artistID; }
            set { _artistID = value; }
        }


        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                //RaisePropertyChangedEvent("LastName";) //update items bound to FullName Property************************need to get clarification
            }
        }


        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                //RaisePropertyChangedEvent("FullName";) //update items bound to FullName Property ************************need to get clarification
            }
        }


        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }


        public string SongName
        {
            get { return _songName; }
            set { _songName = value; }
        }


        public int YearProduced
        {
            get { return _yearProduced; }
            set { _yearProduced = value; }
        }


        public AliveOrNot AliveOrDeceased
        {
            get { return _aliveOrNot; }
            set { _aliveOrNot = value; }
        }


        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public DateTime Birthdate
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string SongFact
        {
            get { return _songFact; }
            set { _songFact = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS
        public Product()
        {

        }

        #endregion
    }
}
