using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab
{
    public class MainViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        /* Private fields*/
        private string Surnamevalue;
        private string Secondnamevalue;
        private string Othernamesvalue;
        private double NumberValue;
        private string CityValue;

        /* private fields end here*/

        /// <summary>
        /// Inotify property changed implementation;
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(p));
        }

        /// <summary>
        /// initialization of the private fields
        /// </summary>
        public string Surname
        {
            get {return Surnamevalue;}
            set {Surnamevalue = value;}
        }
        public string City
        {
            get { return CityValue; }
            set
            {
                
                CityValue = value;
            }
        }
        public string Secondname
        {
            get {return Secondnamevalue; }
            set {Secondnamevalue = value;}
        }
        public string othernames
        {
            get {return Othernamesvalue;}
            set {Othernamesvalue = value;}
        }
        public double Number
        {
            get { return NumberValue; }
            set
            { NumberValue = value;}
        }

        /// <summary>
        /// These are all the required list for combo boxes.
        /// </summary>
        public List<string> HomeNumber { get; set; }
        public List<double> Years { get; set; }
        public List<string> countries { get; set; }


        /*MainViewModel constructor*/
        public MainViewModel()
        {
            this.Surname = Surname;
            this.Secondname = Secondname;
            this.othernames = othernames;
            countries = new List<string>()
            {
                 "China","USA","Japan","Kitae",
                "Ugoslavia","Nigeria","Zambia","SouthAfrica",
                "Burundi","DRC","Sudan","Ethopia","Namibia"
            };
            HomeNumber = new List<string>()
            {
                "+259", "+258", "+257", "+256", "+255", "+254","+253" ,"+252", "+251"
            };
            Years = new List<double>()
            {
             2017,2016,2015,2014,2013,2012,2011,2010,
             2009,2008,2007,2006,2005,2004,2003,2002,2001,
             2000,1999,1998,1997,1996,1995,1994,1993,1992,
             1991,1990,1989,1988,1987,1986,1985,1984
            };
            
        }
        /// <summary>
        /// this is the beggining of Validations
        /// </summary>
        public string Error
        {
            get
            {
                string errors = string.Empty;
                if(Surname!="")
                {
                    errors = "Please enter leters only!";
                }
                return errors;
            }
            
        }

        public string this[string PropertyName]
        {
            get
            {
                string result = string.Empty;
                switch (PropertyName) 
                    {
                        
                        case "Surname":
                            if (string.IsNullOrEmpty(Surname))
                                result = "Surname is required";
                            break;
                        case "Secondname":
                            if (string.IsNullOrEmpty(Secondname))
                                result = "Please enter SecondName";
                            break;
                        case "City":
                        if (string.IsNullOrEmpty(City))
                            result = "Please enter a valid city";
                        break;
                        case "Number":
                        if ((NumberValue<=9))
                            result = "Please enter SecondName";
                        break;
                }
                return result;
            }
            
        }
        


    }
}
        

