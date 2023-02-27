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

namespace CP3Me
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // this C# XAML project is incorporating:

    // WPF Forms
    // Inheritance
    // Method Hiding
    // Aggregation - Method Has-A
    // Method Contains-A
    // Static and Extension Methods
    // Abstract
    // Interface (MISSING)
    // IEnumerable (MISSING)
    // IComparble (MISSING)
    // Generic Classes/Methods
    // Class Libraries
    // Exceptions (MISSING)
    // Deconstructors (MISSING)

    //Our Default Main Window .cs code
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent(); // Initial Code running this window

            lbProducts.ItemsSource = Data.products; // Assigns Data to our ListBox

            // Class Library
            MessageBox.Show(MyLibrary.MyMath.Add(1, 2).ToString()); //Runs the Static Method via Class Library
            

        }



        // WPF Forms click events created
        private void btnCreateProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPoints_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
