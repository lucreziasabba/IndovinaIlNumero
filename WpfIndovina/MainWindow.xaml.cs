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
        

        public MainWindow()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int livello;
        int randomnumber;
        int tentativi = 0;
        
        private void Genera_Click(object sender, RoutedEventArgs e)
        {
            txtTentativi.Text = ($"Hai fatto {tentativi} tentativi!");
            int livello = int.Parse(txtLivello.Text);
            if (livello < 0 || livello >= 101)
                MessageBox.Show("Il numero è fuori dai limiti");
            else
            {
                randomnumber = random.Next(1, livello);
                txtNumEstratto.Text = ($"Sto pensando..");
                txtNumero.IsEnabled = true;
            }
            
        }

        private void Indovina_Click(object sender, RoutedEventArgs e)
        {
            tentativi++;
            int numero = int.Parse(txtNumero.Text);
            if (numero == randomnumber)
            {
                txtNumEstratto.Text = ($"Il numero estratto è {randomnumber}. Complimenti!Hai vinto!");
                txtTentativi.Text = ($"Hai vinto con {tentativi} tentativi!");
            }
            else if (numero < randomnumber)
            {
                txtNumEstratto.Text = ($"Il numero estratto è più grande di quello che hai inserito!");
                txtTentativi.Text = ($"Hai fatto {tentativi} tentativi!");
            }
                
            else if (numero > randomnumber)
            {
                txtNumEstratto.Text = ($"Il numero estratto è più piccolo di quello che hai inserito!");
                txtTentativi.Text = ($"Hai fatto {tentativi} tentativi!");
            }
                
        }

        private void Ricomincia_Click(object sender, RoutedEventArgs e)
        {
            txtNumEstratto.Clear();
            txtNumero.Clear();
            txtLivello.Clear();
            txtTentativi.Clear();
        }
    }
}
