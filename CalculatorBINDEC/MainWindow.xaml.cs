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

namespace CalculatorBINDEC
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

        private void ConvertClick(object sender, RoutedEventArgs e)
        {
            Converter converter = new Converter(textInput.Text);

            if(radioDECBIN.IsChecked== true)
            {
                if (!converter.ToSystem(2))
                {
                    textOutput.Text = "błąd";
                }
                else
                {
                    textOutput.Text = converter.Value;
                }
            }
            else
            {
                if (!converter.ToDecimal(2))
                {
                    textOutput.Text = "błąd";
                }
                else
                {
                    textOutput.Text = converter.Value;
                }
            }

        }
    }
}
