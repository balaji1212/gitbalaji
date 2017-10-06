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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //bubbling event- first child will reveive events and it will go to parent 
           // btn365.KeyDown += Btn365_KeyDown;
            //chk1.KeyDown += Chk1_KeyDown;



            //tunneling - first parent event is received and then child events is called 
            btn365.PreviewKeyDown += Btn365_PreviewKeyDown; ;
            chk1.PreviewKeyDown += Chk1_PreviewKeyDown;

        }

        private void Chk1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("checkbox received keydown event");
        }

        private void Btn365_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("button received Keydown");
        }

            private void Chk1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("checkbox received keydown event");
        }

        private void Btn365_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("button received Keydown");
        }

        private void chk1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
