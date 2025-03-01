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

namespace myBookStore
{
    /// <summary>
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();  
            customer.Show(); 

        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.Show();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order(); 
            order.Show();   
        }
    }
}
