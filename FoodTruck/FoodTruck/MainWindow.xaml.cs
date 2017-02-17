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
        const string strconn = "Server=localhost;Database=foodtruck;Uid=root;Pwd=";
        public MainWindow()
        {
            InitializeComponent();
            PreencherComboBox();
           
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {/*
            string query = "SELECT p.Preco FROM Produto p WHERE p.Nome = '{0}'";

            MySqlCommand cmd = new MySqlCommand(String.Format(query, cb_produtos.SelectedItem), new MySqlConnection(strconn));
            
            cmd.Connection.Open();
            MySqlDataReader r = cmd.ExecuteReader();
            r.Read();
            double total = r.GetDouble(0) * Convert.ToInt32(txt_qtd.Text);
            

            query = "INSERT INTO registrovenda (Data, PrecoTotal) VALUES ('{0}', {1})";
 
            DateTime dataHora = DateTime.Now;
            string txtBanco = dataHora.ToString(new CultureInfo("en-US"));                
            cmd.CommandText = String.Format(query, txtBanco , total);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            */

        }
        
        
        public void PreencherComboBox()
        {
            string query = "SELECT p.Nome FROM Produto p";

            MySqlCommand cmd = new MySqlCommand(query, new MySqlConnection(strconn));
            cmd.Connection.Open();

            MySqlDataReader r = cmd.ExecuteReader();

            //while (r.Read())
              //  cb_produtos.Items.Add(r.GetString(0));

            cmd.Connection.Close();
        }

        private void imgProduto_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int qtd = Convert.ToInt32(txtb1.Text);

            txtb1.Text = Convert.ToString(qtd + 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int qtd = Convert.ToInt32(txtb1.Text);
           
            txtb1.Text = Convert.ToString(qtd - 1);
        }

        private void txt_busca_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_busca.Text = "";
        }

        private void txt_busca_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
           
        }       
    }
}
