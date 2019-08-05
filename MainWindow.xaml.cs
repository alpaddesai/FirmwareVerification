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

namespace SystemVerilogDV
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

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void HW_Emulation_Click(object sender, RoutedEventArgs e)
        {
            Hardware_Emulation Hardware_EmulationObject = new Hardware_Emulation();
            Hardware_EmulationObject.Show();
        }

        private void System_Level_Modeling_Click(object sender, RoutedEventArgs e)
        {
            System_Level_Modeling System_Level_ModelingObject = new System_Level_Modeling();
            System_Level_ModelingObject.Show();
        }

        private void SystemVerilog_Assertions_Click(object sender, RoutedEventArgs e)
        {
            SystemVerilogAssertions SystemVerilogAssertionsObject = new SystemVerilogAssertions();
            SystemVerilogAssertionsObject.Show();
        }

        private void RichTextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void FPGA_Vivado_Click(object sender, RoutedEventArgs e)
        {
            FPGAVivadoDesignSuite FPGAVivadoDesignSuiteObject = new FPGAVivadoDesignSuite();
            FPGAVivadoDesignSuiteObject.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XilinxTrainingCertificate XilinxTrainingCertificateObject = new XilinxTrainingCertificate();
            XilinxTrainingCertificateObject.Show();
        }
    }
}
