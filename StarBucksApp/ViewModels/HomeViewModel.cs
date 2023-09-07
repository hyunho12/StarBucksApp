using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StarBucksApp.Models;
using StarBucksApp.Services;
using System.Collections.ObjectModel;

namespace StarBucksApp.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Product> _products;

        [RelayCommand]
        public async Task ProductDetailAsync(object obj)
        {
            await Shell.Current.GoToAsync("detail", new Dictionary<string, object>
            {
                ["SelectedProduct"] = (Product)obj
            });
        }

        public HomeViewModel() 
        {
            Products = new ObservableCollection<Product>(ProductService.Instance.GetProducts());
        }
    }
}
