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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero;
        public MainWindow()
        {
            InitializeComponent();
            numero = GeneraNumeroRandom();
        }

        public int GeneraNumeroRandom()
        {
            Random ran = new Random();
            int numero = ran.Next(0, 101);
            return numero;
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (numero == int.Parse(NumeroTextBox.Text))
                PistaTextBlock.Text = "Has acertado!";
            else if (numero < int.Parse(NumeroTextBox.Text))
                PistaTextBlock.Text = "Te has pasado...";
            else if (numero > int.Parse(NumeroTextBox.Text))
                PistaTextBlock.Text = "Te has quedado corto...";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numero = GeneraNumeroRandom();
            PistaTextBlock.Text = "";
            NumeroTextBox.Text = "";
        }
    }
}
