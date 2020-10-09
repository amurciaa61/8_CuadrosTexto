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

    }
}
