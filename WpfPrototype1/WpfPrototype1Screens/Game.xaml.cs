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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        public Game()
        {
            this.InitializeComponent();
        }

        private void help(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Image image = sender as Image;
            Uri uri = new Uri(@"1 ic.png".Replace("1", Client.Instance.Avatar.ToString()), UriKind.RelativeOrAbsolute);
            image.Source = new BitmapImage(uri);
        }

        private void name1_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            textBlock.Text = Client.Instance.Name;
        }

        private void Image_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void name1_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void Run_Loaded(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Path = new PropertyPath("EgpCount");
            binding.Mode = BindingMode.TwoWay;
            binding.Source = Bank.Instance;
            Max_Kol_EGP.SetBinding(TextBlock.TextProperty, binding);
        }

        private void Max_Kol_ESM_Loaded(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Path = new PropertyPath("EsmCount");
            binding.Mode = BindingMode.TwoWay;
            binding.Source = Bank.Instance;
            Max_Kol_ESM.SetBinding(TextBlock.TextProperty, binding);
        }

        private void Min_ESM_Loaded(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Path = new PropertyPath("EsmPrice");
            binding.Mode = BindingMode.TwoWay;
            binding.Source = Bank.Instance;
            Min_ESM.SetBinding(TextBlock.TextProperty, binding);
        }

        private void Max_EGP_Loaded(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Path = new PropertyPath("EgpPrice");
            binding.Mode = BindingMode.TwoWay;
            binding.Source = Bank.Instance;
            Max_EGP.SetBinding(TextBlock.TextProperty, binding);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (Kol_ESM.Text != null)
                Kol_ESM.Text = (1 + int.Parse(Kol_ESM.Text)).ToString();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (sender as CheckBox);
            if (checkBox != null) checkBox.IsChecked = !checkBox.IsChecked;
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (Kol_ESM.Text != null)
                Kol_ESM.Text = (-1 + int.Parse(Kol_ESM.Text)).ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Kol_EGP.Text != null)
                Kol_EGP.Text = (1 + int.Parse(Kol_EGP.Text)).ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Kol_EGP.Text != null)
                Kol_EGP.Text = (-1 + int.Parse(Kol_EGP.Text)).ToString();
        }

        private void _5k_Click(object sender, RoutedEventArgs e)
        {
            RadioButton checkBox = (sender as RadioButton);
            if (checkBox != null) checkBox.IsChecked = !checkBox.IsChecked;
            _10k.IsChecked = false;
        }

        private void _10k_Click(object sender, RoutedEventArgs e)
        {
            RadioButton checkBox = (sender as RadioButton);
            if (checkBox != null) checkBox.IsChecked = !checkBox.IsChecked;
            _5k.IsChecked = false;
        }
    }
}