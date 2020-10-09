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
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            const string CLIENTE = " del cliente";
            string etiqueta = (sender as TextBox).Tag.ToString();
            if (e.Key == Key.F1)
            {
                switch (etiqueta)
                {
                    case "Nombre":
                        if (mensajeNombreTextBlock.Text.Length == 0)
                            mensajeNombreTextBlock.Text = etiqueta + CLIENTE;
                        else
                            mensajeNombreTextBlock.Text = "";
                        break;
                    case "Apellido":
                        if (mensajeApellidoTextBlock.Text.Length == 0)
                            mensajeApellidoTextBlock.Text = etiqueta + CLIENTE;
                        else
                            mensajeApellidoTextBlock.Text = "";
                        break;
                    default:
                        break;
                }
            }
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                string patron = "^[0-9]+$";
                string edad = edadTextBox.Text;
                Regex reg = new Regex(patron);
                if (reg.IsMatch(edad))
                    mensajeEdadTextBlock.Text = "";
                else
                    mensajeEdadTextBlock.Text = "Edad incorrecta";
            }
        }
    }
}
