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
          
            if ((SecondNameTextBox != null) && (SecondNameTextBox != null) && (OtherNameTextBox!= null)&&(CityTextBox!=null) && (Number1TextBox!=null) && (Number2TextBox!=null)&& (Number3TextBox!=null))

            {
                MessageBox.Show("Contact added successfully");
                
            }
           
            else if ((SecondNameTextBox == null) || (SecondNameTextBox == null) || (OtherNameTextBox == null) ||(CityTextBox == null) || (Number1TextBox == null) || (Number2TextBox == null) || (Number3TextBox == null))
            {
                MessageBox.Show("Please check your entries and enter again");
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

