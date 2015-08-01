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

namespace FTPApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Ftp ftp = new Ftp("ftp://localhost", "", "");
            ftp.CreateDirectory("TESTE2");

            var lista = ftp.DirectoryListSimple("");

            foreach (var item in lista)
            {
                listBox.Items.Add(item);
            }

            //ftp.Upload("teste.txt", @"e:\transf\doc.txt");

            ftp.Download("teste.txt", @"e:\transf\doc2.txt");

            ftp.Delete("teste.txt");

        }
    }
}
