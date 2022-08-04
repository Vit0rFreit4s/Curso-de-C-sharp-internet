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

namespace Ex006
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

        private void txt_nasc_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int idade = DateTime.Now.Year - (Convert.ToInt32(txt_nasc.Text));
            lbl_atual.Content = $"Estamos no ano de {DateTime.Now.Year}.";
            lbl_idade.Content = $"Quem nasceu em {txt_nasc.Text} vai ter {idade} anos.";

            /*
             int ano = 0;

Console.Write("Em que ano você nasceu? ");

ano = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------------------------");
Console.WriteLine($"Estamos atualmente no ano de {DateTime.Now.Year}.");
Console.WriteLine($"Se você nasceu em {ano}, vai ter {DateTime.Now.Year - ano} anos.");
             */
        }
    }
}
