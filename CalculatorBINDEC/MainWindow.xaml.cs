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

            var inputSystem = GetInputSystem();
            var outputSystem = GetOutputSystem();

            if (inputSystem == 10 && converter.ToSystem(outputSystem))
            {
                textOutput.Text= converter.Value;
            }

            if (outputSystem == 10 && converter.ToDecimal(inputSystem))
            {
                textOutput.Text = converter.Value;
            }

            if (converter.ToDecimal(inputSystem) && converter.ToSystem(outputSystem))
            {
                textOutput.Text = converter.Value;
            }


        }
        private int GetInputSystem()
        {
            if(radioInputBIN.IsChecked == true) 
            {
                return 2;
            }
            else if (radioInputOCT.IsChecked == true)
            {
                return 8;
            }
            else if (radioInputDEC.IsChecked == true)
            {
                return 10;
            }
            else
            {
                return 16;
            }
        }
        private int GetOutputSystem()
        {
            if (radioOutputBIN.IsChecked == true)
            {
                return 2;
            }
            else if (radioOutputOCT.IsChecked == true)
            {
                return 8;
            }
            else if (radioOutputDEC.IsChecked == true)
            {
                return 10;
            }
            else
            {
                return 16;
            }
        }
    }
}
