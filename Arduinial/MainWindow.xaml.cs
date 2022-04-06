using System;
using System.Collections.Generic;
using System.IO.Ports;
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

namespace Arduinial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock_ReadSerial.Text = "";
            string[] ports = SerialPort.GetPortNames();
            for(int i=0; i < ports.Length; i++)
            {
                ComboBox_Ports.Items.Add(ports[i]);
            }
            
        }

        //IDK what I'm doing, but here goes nothing
        private void SerialMonitor()
        {
            string text = "Hello, World!\n";
            //for(int i = 0; i < 100; i++) TextBox_SerialOutput.AppendText(text);
            TextBlock_ReadSerial.Text = text;
        }

        private void Button_ReadSearial_Click(object sender, RoutedEventArgs e)
        {
            SerialMonitor();
        }
    }
}
