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
    /// Interaction logic for LOG1.xaml
    /// </summary>
    public partial class LOG1 : UserControl
    {
        public LOG1()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process
               .Start(@"HELP.chm");
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string pattern = @"(\w+)";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            string nickName = textBox.Text;
            Match m = r.Match(nickName);
            int matchCount = 0;
            while (m.Success)
            {
                Console.WriteLine("Match" + (++matchCount));
                for (int i = 1; i <= 2; i++)
                {
                    Group g = m.Groups[i];
                    Console.WriteLine("Group" + i + "='" + g + "'");
                    CaptureCollection cc = g.Captures;
                    for (int j = 0; j < cc.Count; j++)
                    {
                        Capture c = cc[j];
                        System.Console.WriteLine("Capture" + j + "='" + c + "', Position=" + c.Index);
                    }
                }
                m = m.NextMatch();
            }
            if (nickName.Length > 10
                || nickName.Length < 4
                || matchCount != 1)
            {
                textBox.Text = "Имя введено неверно";
            }
            Client.Instance.Name = textBox.Text;
        }

        private void _10_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 10;
        }

        private void _1_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 1;
        }

        private void _2_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 2;
        }

        private void _3_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 3;
        }

        private void _4_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 4;
        }

        private void _5_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 5;
        }

        private void _6_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 6;
        }

        private void _7_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 7;
        }

        private void _8_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 8;
        }

        private void _9_ava_Click(object sender, RoutedEventArgs e)
        {
            Client.Instance.Avatar = 9;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
        }
}