using System;
using System.Collections.Generic;
using System.Text;
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
	/// Interaction logic for Screen_1_1.xaml
	/// </summary>
	public partial class Screen_1_1 : UserControl
	{
		public Screen_1_1()
		{
			this.InitializeComponent();
		}

		private void CloseB(object sender, System.Windows.RoutedEventArgs e)
		{
			//this.Close();
		}

		private void CloseB0(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process
                .Start(@"HELP.chm");
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rules_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process
               .Start(@"HELP.chm");
        }

        private void Rul(object sender, System.Windows.RoutedEventArgs e)
        {
        	System.Diagnostics.Process
               .Start(@"HELP.chm");
        }
	}
}