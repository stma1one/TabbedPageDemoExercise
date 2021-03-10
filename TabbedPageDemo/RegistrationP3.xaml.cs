using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabbedPageDemo
{
    public partial class RegistrationP3 : ContentPage
    {
        
        public RegistrationP3()
        {
           
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            this.LblName.SetBinding(Label.TextProperty, "Name");
            this.LblAddress.SetBinding(Label.TextProperty, "Address");
            this.DpBirthdate.SetBinding(DatePicker.DateProperty, "BirthDate");
            this.EntClass.SetBinding(Label.TextProperty, "Class");
            this.SwCs.SetBinding(Switch.IsToggledProperty, "LikeCs");
            this.SwMath.SetBinding(Switch.IsToggledProperty, "LikeMath");
            LblName.Text = $"Name:{LblName.Text}";
            LblAddress.Text = $"Address:{LblAddress.Text}";
            EntClass.Text = $"Class: {EntClass.Text}";
            DpBirthdate.Format = "dd/MM/yyyy";
            Label ClassNo = new Label();
            ((StackLayout)Content).Children.Add(ClassNo);
            ClassNo.SetBinding(Label.TextProperty, "ClassNo");
            ClassNo.IsVisible = false;
            EntClass.Text = $"{EntClass.Text}{ClassNo.Text}";

            



        }


    }
}
