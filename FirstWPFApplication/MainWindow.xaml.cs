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

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirst.Text = String.Empty;

            txtFirst.Clear();

            //Label label = new Label();
            //label.Content = "Hello World";
        }

        private void btnClickme_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFirst.Text;

            MessageBox.Show($"Hello {name}, nice to meet you!");
        }
    }
}
