using StarBucksApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBucksApp.Pages
{
    public class BasePage : ContentPage
    {
        public IViewModel ViewModel => (IViewModel)BindingContext;

        public BasePage() { }

        protected async override void OnAppearing()
        {
            await ViewModel.Initialize();
            base.OnAppearing();
        }
    }
}
