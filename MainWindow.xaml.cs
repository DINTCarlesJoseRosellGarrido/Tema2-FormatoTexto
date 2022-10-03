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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textoVisto.Text = bloqueTexto.Text;
        }

        private void negrita_Checked(object sender, RoutedEventArgs e)
        {
            textoVisto.FontWeight = FontWeights.Bold;
        }

        private void cursiva_Checked(object sender, RoutedEventArgs e)
        {
            textoVisto.FontStyle = FontStyles.Italic;
        }

        private void negrita_Unchecked(object sender, RoutedEventArgs e)
        {
            textoVisto.FontWeight = FontWeights.Normal;
        }

        private void cursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            textoVisto.FontStyle = FontStyles.Normal;
        }

        private void colorAzul_Checked(object sender, RoutedEventArgs e)
        {
            textoVisto.Foreground = Brushes.Blue;
        }

        private void colorRojo_Checked(object sender, RoutedEventArgs e)
        {
            textoVisto.Foreground = Brushes.Red;
        }

        private void colorVerde_Checked(object sender, RoutedEventArgs e)
        {
            textoVisto.Foreground = Brushes.Green;
        }
    }
}
