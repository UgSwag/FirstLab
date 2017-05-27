using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace FirstLab
{
    public class MainViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        /* Private fields*/
        private string Surnamevalue;
        private string Secondnamevalue;
        private string Othernamesvalue;
        private string NumberValue1;
        private string NumberValue2;
        private string CityValue;
        private int Selected_year_Value;
        private string Selected_country_Value;
        private string HomeNUmber_Selected_value;
       

        /* private fields end here*/

        /// <summary>
        /// Inotify property changed implementation;
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private void DoPropertyChanged(string Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }

        /// <summary>
        /// initialization of the private fields
        /// </summary>
        /// 

        /*
          this is the public property that iniatialises the private property for selected years
         */
        public int Selected_year
        {
            
            get { return Selected_year_Value; }
            set
            {
                if (value == 0)
                    return;
                Selected_year_Value = value;
                DoPropertyChanged("Selected_year");
            }
        }
        /*
            this is the public property that iniatialises the private property for selected country
       */
        public string HomeNUmber_Selected
        {
            get { return HomeNUmber_Selected_value; }
            set
            {
                HomeNUmber_Selected_value = value;
                DoPropertyChanged("Selected_country");
            }
        }


        /*
            this is the public property that iniatialises the private property for selected country
       */
        public string Selected_country
        {
            get { return Selected_country_Value; }
            set
            {
                Selected_country_Value = value;
                DoPropertyChanged("Selected_country");
            }
        }

          /*
              this is the public property that iniatialises the private property for surname
          */
        public string Surname
        {
            get { return Surnamevalue; }
            set { Surnamevalue = value; }
        }

           /*
              this is the public property that iniatialises the private property for city
           */
        public string City
        {
            get { return CityValue; }
            set
            {

                CityValue = value;
            }
        }

            /*
              this is the public property that iniatialises the private property for second name
            */
        public string Secondname
        {
            get { return Secondnamevalue; }
            set { Secondnamevalue = value; }
        }

           /*
              this is the public property that iniatialises the private property for othernames
           */
        public string othernames
        {
            get { return Othernamesvalue; }
            set { Othernamesvalue = value; }
        }

           /*
              this is the public property that iniatialises the private property for selected number1
          */
        public string Number1
        {
            get { return NumberValue1; }
            set
            { NumberValue1 = value; }
        }


        /*
            this is the public property that iniatialises the private property for selected number2
        */
        public string Number2
        {
            get { return NumberValue2; }
            set
            { NumberValue2 = value; }
        }
        /*This is the i command for saving data*/
        public ICommand Saved { get; set; }

        /// <summary>
        /// These are all the required list for combo boxes.
        /// </summary>
        public List<string> HomeNumber { get; set; }
        public List<int> Years { get; set; }
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
            Years = new List<int>()
            {
             2017,2016,2015,2014,2013,2012,2011,2010,
             2009,2008,2007,2006,2005,2004,2003,2002,2001,
             2000,1999,1998,1997,1996,1995,1994,1993,1992,
             1991,1990,1989,1988,1987,1986,1985,1984
            };
             Saved = new SavedCommand();
        }
        /// <summary>
        /// this is the beggining of Validations
        /// </summary>
        public string Error
        {
            get
            {
                string errors = string.Empty;
                if (Surname != "")
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
                        if ((NumberValue1 == null))
                            result = "Please enter number";
                        break;
                }
                return result;
            }

        }

      

    }

}


