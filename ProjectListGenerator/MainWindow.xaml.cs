using System;
using System.Windows;

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
            DataContext = new WarenwirtschaftSet();
        }

        private void cmbBox01_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Console.WriteLine("DEBUG: Selected Value: {0}", cmbBox01.SelectedValue.ToString());
        }
    }
}
