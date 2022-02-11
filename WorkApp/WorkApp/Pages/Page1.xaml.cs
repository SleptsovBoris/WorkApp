using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private Page1ViewModel vm = new Page1ViewModel();
        public Page1()
        {
            InitializeComponent();
            BindingContext = vm;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.ChangeNumber();
        }
        
    }
}