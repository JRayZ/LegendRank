﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchTotalPage : ContentPage
    {
        public MatchTotalPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}