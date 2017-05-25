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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;


namespace FirstLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel  details = new MainViewModel ();

     
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void SaveButton__Click(object sender, RoutedEventArgs e)
        {
            string constring = "server=localhost; database=savemycontacts; user id=root; password=1994derrick";
            string query = "insert into savemycontacts.custormers(Phone,SurName,FirstName,LastName,City,Phone2,Country,Year) value('" + this.Number1TextBox.Text + "','" + this.SurnameTextBox.Text + "','" + this.SecondNameTextBox.Text + "','" + this.OtherNameTextBox.Text + "','"+this.CityTextBox.Text+"','"+this.Number2TextBox.Text+"','"+this.___Countries_.SelectedItem+"','"+this.ComboBox3.SelectedItem+"');";
            MySqlConnection connection = new MySqlConnection(constring);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader Reader;
            try
            {
                connection.Open();
                Reader = command.ExecuteReader();
                if ((SecondNameTextBox == null) && (SecondNameTextBox == null) && (OtherNameTextBox == null))
                {

                    MessageBox.Show("Check your entries");
                }
                else
                {
                    MessageBox.Show("Contact well saved, you may proceed");
                    while (Reader.Read())
                    {

                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
           
           
            
        }

        /*this also avoids entry of numbers in the space Surname entry*/
        private void SurnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = string.Empty;
    
            if (SurnameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = SurnameTextBox.Text;
                SurnameTextBox.Text = oldText;
            }
            else
            {
                SurnameTextBox.Text = oldText;
               
            }
            SurnameTextBox.SelectionStart = SurnameTextBox.Text.Length;
        
    }

        /*this also avoids entry of numbers in the space Second name entry*/

        private void SecondNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = string.Empty;

            if (SecondNameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = SecondNameTextBox.Text;
                SecondNameTextBox.Text = oldText;
            }
            else
            {
                SecondNameTextBox.Text = oldText;

            }
            SecondNameTextBox.SelectionStart = SecondNameTextBox.Text.Length;
        }

        /*this also avoids entry of numbers in the space othername entry*/
        private void OtherNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = string.Empty;
            if (OtherNameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = OtherNameTextBox.Text;
                OtherNameTextBox.Text = oldText;
            }
            else
            {
                OtherNameTextBox.Text = oldText;

            }
            OtherNameTextBox.SelectionStart = OtherNameTextBox.Text.Length;

        }

        /*this method avoids the entry of numbers and other characters annd only takes a city as a string*/
        private void CityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = string.Empty;
            if (CityTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = CityTextBox.Text;
                CityTextBox.Text = oldText;
            }
            else
            {
                CityTextBox.Text = oldText;

            }
            OtherNameTextBox.SelectionStart = OtherNameTextBox.Text.Length;

        }


        /// <summary>
        /// cancel button that delets everything incase of changes
        /// </summary>
        private void ___CancelButton_1_Click(object sender, RoutedEventArgs e)
        {
            OtherNameTextBox.Clear();
            SecondNameTextBox.Clear();
            SurnameTextBox.Clear();
            Number1TextBox.Clear();
            Number2TextBox.Clear();
            Number3TextBox.Clear();
            CityTextBox.Clear();
        }
    }
}

