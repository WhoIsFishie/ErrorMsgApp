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

namespace ErrorMsgApp
{
    public partial class MainWindow : Window
    {
        //hold the image var
        MessageBoxImage image;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TypeSelector_DropDownClosed(object sender, EventArgs e)
        {
            TITLE.IsEnabled = true;

            //set selected image to the image var
            switch (TypeSelector.Text)
            {
                case "Error":
                    image = MessageBoxImage.Error;
                    break;
                case "Information":
                    image = MessageBoxImage.Information;
                    break;
                case "Warning":
                    image = MessageBoxImage.Warning;
                    break;
                case "Question":
                    image = MessageBoxImage.Question;
                    break;
                default:
                    image = MessageBoxImage.None;
                    break;
            }
        }

        private void TITLE_TextChanged(object sender, TextChangedEventArgs e)
        {
            MSG.IsEnabled = true;
        }

        private void MSG_TextChanged(object sender, TextChangedEventArgs e)
        {
            genbutton.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MSG.Text, TITLE.Text, MessageBoxButton.OK, image);
        }
    }
}
