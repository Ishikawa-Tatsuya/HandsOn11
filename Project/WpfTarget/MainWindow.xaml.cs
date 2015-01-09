﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfTarget
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _grid.ItemsSource = new List<Member>();
        }

        private void ButtonOKClick(object sender, RoutedEventArgs e)
        {

        }
    }

    public enum Language
    {
        C,
        CPP,
        CS
    }

    [Serializable]
    public class Member
    {
        public string Name { get; set; }
        public Language Language { get; set; }
        public bool IsProgramer { get; set; }
    }
}
