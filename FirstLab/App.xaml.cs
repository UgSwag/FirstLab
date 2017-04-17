using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FirstLab
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //this connects binding
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            this.MainWindow.DataContext = new MainViewModel();
        }
    }
}
