﻿using System;
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
using System.Windows.Shapes;
using test.Classes;
using test.Pages;

namespace test.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>

    public partial class WindowOrder : Window
    {
        public WindowOrder()
        {
            InitializeComponent();
            MainFrame.Navigate(new Redact());
            manager.MainFrame = MainFrame;
        }
    }
}

