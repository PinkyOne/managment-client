using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPrototype1Screens
{
    /// <summary>
    /// Interaction logic for Load.xaml
    /// </summary>
    public partial class Load : UserControl
    {
        public Load()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IpAddress_LostFocus(IpAddress, e);
            SocketClient.Address = IpAddress.Text;
            SocketClient socketClient=new SocketClient();
            socketClient.Connect(Client.Instance);
        }

        private void IpAddress_LostFocus(object sender, RoutedEventArgs e)
        {

            var textBlock = sender as TextBox;
            string address = "";
            if (textBlock != null)
            {
                address = textBlock.Text;
            }
            string[] parts = address.Split('.');
            int[] nums = new int[4];
            int i = 0;
            for (var index = 0; index < parts.Length; index++)
            {
                var part = parts[index];
                try
                {
                    nums[index] = int.Parse(part);
                    if (nums[index] < 0 || nums[index] > 255)
                    {
                        throw new CannotFoundServerException();
                    }
                }
                catch (Exception exception)
                {
                    throw new CannotFoundServerException();
                }
            }
            if (parts.Length != 4)
            {
                throw new CannotFoundServerException();
            }
        }
    }

    public class CannotFoundServerException : Exception
    {
    }
}