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

namespace WpfIndovina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random_generator = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Genera_Click(object sender, RoutedEventArgs e)
        {
            int livello = int.Parse(txtLivello.Text);
            int RandomNumber = random_generator.Next(1, livello);
            int numero = int.Parse(txtNumero.Text);
            if (numero == RandomNumber)
                txtNumEstratto.Text = ($"Il numero estratto è {RandomNumber}. Complimenti!Hai vinto!");
            else if (numero < RandomNumber)
                txtNumEstratto.Text = ($"Il numero estratto è più grande di quello che hai inserito!");
            else if (numero > RandomNumber)
                txtNumEstratto.Text = ($"Il numero estratto è più piccolo di quello che hai inserito!");
        }

        private void Ricomincia_Click(object sender, RoutedEventArgs e)
        {
            txtNumEstratto.Clear();
            txtNumero.Clear();
            txtLivello.Clear();
        }
    }
}
