﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {

        private BindingList<string> _products;

        public BindingList<string> Products
        {

            get
            {
                return _products;
            }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set { _cart = value; NotifyOfPropertyChange(() => Cart); }
        }

        private string _itemQSuantity;

        public string ItemQuantity
        {
            get { return _itemQSuantity; }
            set { _itemQSuantity = value; NotifyOfPropertyChange(() => Products); }
        }

        public string SubTotal
        {
            // TODO - REPLACE with Calculation
            get { return "$0.00"; }

        }        
        
        public string Tax
        {
            // TODO - REPLACE with Calculation
            get { return "$0.00"; }

        }        
        
        public string Total
        {
            // TODO - REPLACE with Calculation
            get { return "$0.00"; }

        }


        public bool CanAddToCart
        {
            get
            {
                bool output = false;


                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;


                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;


                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}
