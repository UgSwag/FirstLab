using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace FirstLab
{
    class SavedCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainViewModel;

            apply.Number1 = apply.HomeNUmber_Selected + apply.Number1;
            apply.Number2 = apply.HomeNUmber_Selected + apply.Number2;

            try
            {
                if ((apply.Surname != null) && (apply.Secondname != null) && (apply.City != null)&&(apply.HomeNumber!=null))
                {
                    string constring = "server=localhost; database=savemycontacts; user id=root; password=1994derrick";
                    string query = "insert into savemycontacts.custormers(Phone,SurName,FirstName,LastName,City,Phone2,Country,Year) value('" + apply.Number1 + "','" + apply.Surname + "','" + apply.Secondname + "','" + apply.othernames + "','" + apply.City + "','" + apply.Number2 + "','" + apply.Selected_country + "','" + apply.Selected_year + "');";
                    MySqlConnection connection = new MySqlConnection(constring);
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader Reader;
                    connection.Open();
                    Reader = command.ExecuteReader();
                    MessageBox.Show("Contact well saved, you may proceed");
                    Reader.Read();

                }
                else
                {

                    MessageBox.Show("Check your entries");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
