﻿using System;
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
	}
}