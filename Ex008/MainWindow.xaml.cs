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

namespace Ex008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aleatorio, inicio, fim;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btn_sortear_Click(object sender, RoutedEventArgs e)
        {
            inicio = Convert.ToInt32(txt_inicio.Text);
            fim = Convert.ToInt32(txt_fim.Text);

            Random random = new Random();
            aleatorio = random.Next(inicio, fim);

            lbl_resultado.Content = $"Sorteando de {inicio} a {fim} ...";
            await Task.Delay(2000);
            lbl_resultado.Content = $"Sorteei o {aleatorio}";
        }
    }
}
