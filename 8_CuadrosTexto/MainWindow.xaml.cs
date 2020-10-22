using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _8_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = mensajeNombreTextBlock;
            apellidoTextBox.Tag = mensajeApellidoTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            TextBlock objetoTextBlock = (TextBlock)tb.Tag;
            if (e.Key == Key.F1)
            {
                if (objetoTextBlock.IsVisible)
                    objetoTextBlock.Visibility = Visibility.Hidden;
                else
                    objetoTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                string edadString = edadTextBox.Text;
                int edad;
                if (int.TryParse(edadString,out edad))
                    mensajeEdadTextBlock.Text = (edad >=0)?"": "Edad incorrecta";
                else
                    mensajeEdadTextBlock.Text = "Edad incorrecta";
            }
        }
    }
}
