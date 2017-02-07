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
using System.Windows.Shapes;

namespace FoodTruck
{
    /// <summary>
    /// Interaction logic for windowalt.xaml
    /// </summary>
    public partial class windowalt : Window
    {
        public windowalt()
        {
            InitializeComponent();
        }

        private void BTN_N_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BTN_S_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new windowaltesp().Show();
        }
 
    }
}
