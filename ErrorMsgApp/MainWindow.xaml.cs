using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
        MessageBoxIcon image;
        MessageBoxButtons btn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TypeSelector_DropDownClosed(object sender, EventArgs e)
        {
            BtnSelector.IsEnabled = true;

            //set selected image to the image var
            switch (TypeSelector.Text)
            {
                case "Error":
                    image = MessageBoxIcon.Error;
                    break;
                case "Information":
                    image = MessageBoxIcon.Information;
                    break;
                case "Warning":
                    image = MessageBoxIcon.Warning;
                    break;
                case "Question":
                    image = MessageBoxIcon.Question;
                    break;
                default:
                    image = MessageBoxIcon.None;
                    break;
            }
        }

        private void BtnSelector_DropDownClosed(object sender, EventArgs e)
        {
            TITLE.IsEnabled = true;
            switch (BtnSelector.Text)
            {
                case "Abort Retry Ignore":
                    btn = MessageBoxButtons.AbortRetryIgnore;
                    break;
                case "OK Cancel":
                    btn = MessageBoxButtons.OKCancel;
                    break;
                case "Yes No":
                    btn = MessageBoxButtons.YesNo;
                    break;
                case "Yes No Cancel":
                    btn = MessageBoxButtons.YesNoCancel;
                    break;
                case "OK":
                    btn = MessageBoxButtons.OK;
                    break;
                default:
                    btn = MessageBoxButtons.OK;
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
            System.Windows.Forms.MessageBox.Show(MSG.Text, TITLE.Text, btn, image);
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/WhoIsFishie/ErrorMsgApp");
        }
    }
}
