﻿using System;
using System.IO;
using Xamarin.Forms;

namespace DreamInventory
{
    public partial class MainPage : ContentPage
    {
        string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
