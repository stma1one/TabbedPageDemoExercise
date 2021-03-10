﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        Student Sd;
        public MainPage()
        {
            Sd = new Student();
            this.BindingContext = Sd;
            InitializeComponent();
            Tab1.BindingContext = this.BindingContext;
            Tab2.BindingContext = this.BindingContext;
            Tab3.BindingContext = this.BindingContext;
        }
    }
}
