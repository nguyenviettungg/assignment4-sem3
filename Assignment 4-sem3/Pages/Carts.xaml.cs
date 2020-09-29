﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Assignment_4_sem3.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_4_sem3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Carts : Page
    {
        public Carts()
        {
            this.InitializeComponent();
            Cart cart = new Cart();
            List<CartItem> items = cart.GetCarts();
            CartItems.ItemsSource = items;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            CartItem item = textBox.Tag as CartItem;
            Cart cart = new Cart();
            if (cart.UpdateQty(item, Convert.ToInt32(textBox.Text)))
            {
                List<CartItem> items = cart.GetCarts();
                CartItems.ItemsSource = items;
            }
        }
    }
}
