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

namespace WpfApp2
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
        private void button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void buttom2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void buttom_Click(object sender, RoutedEventArgs e)
        {
            string strHoten;
            strHoten = textBox1.Text + " " + textBox2.Text;
            String strMessage, strHoTen, strTitle, strNgoaiNgu = "";
            strHoTen = textBox1.Text + " " + textBox2.Text;
            if (radioButton1.IsChecked == true)
                strTitle = "Mr.";
            else
                strTitle = "Miss/Mrs.";
            strMessage = "" + strTitle + " " + strHoTen;
            if (checkBox1.IsChecked == true)
            {
                strNgoaiNgu = "Tiếng Anh";
            }
            if (checkBox2.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tiếng Trung" : (strNgoaiNgu + " và Tiếng Trung");
            }
            strMessage = strMessage + "\nNgoại ngữ của bạn là: " + strNgoaiNgu;
            String strMessagees ="";
            if (comboBox1.SelectedIndex >= 0)
            {
                strMessagees = "Quê Quán: " + comboBox1.Text;
            }
            MessageBox.Show("Xin chào bạn: " + strHoten + Environment.NewLine + strMessage + Environment.NewLine + strMessagees);
        }
    }
}
