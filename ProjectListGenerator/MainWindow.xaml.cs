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
using System.Data.SqlClient;

namespace ProjectListGenerator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DBConnector dbconnection = new DBConnector();
            //dbconnection.Connect("copago1");

            //using (SqlDataReader reader = dbconnection.Query("select * from WarenwirtschaftSet"))
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));
            //    }
            //}

            //dbconnection.Disconnect();
            Warenwirtschaft blub = new Warenwirtschaft();
            Console.WriteLine(blub.GetAll().Count);
        }
    }
}
