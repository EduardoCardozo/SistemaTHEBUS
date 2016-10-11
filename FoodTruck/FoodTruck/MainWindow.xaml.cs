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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace FoodTruck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PreencherComboBox();      
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT p.Preco FROM Produto p WHERE p.Nome = '{0}'";
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=foodtruck;Uid=root;Pwd="),
                CommandText = String.Format(query, cb_produtos.SelectedItem)
            };
            cmd.Connection.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            r.Read();
            double total = r.GetDouble(0) * Convert.ToInt32(txt_qtd.Text);
            

            query = "INSERT INTO RegistroVenda (Data, PrecoTotal) VALUES ('{0}', {1})";
 
            DateTime dataHora = DateTime.Now;
            string txtBanco = dataHora.ToString(new CultureInfo("en-US"));                
            cmd.CommandText = String.Format(query, txtBanco , total);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        
        
        public void PreencherComboBox()
        {
            string query = "SELECT p.Nome FROM Produto p";


            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=foodtruck;Uid=root;Pwd="),
                CommandText = query
            };

            cmd.Connection.Open();

            MySqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                cb_produtos.Items.Add(r.GetString(0));

            cmd.Connection.Close();
        }
    }
}
