using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StarBucksApp.Models;

namespace StarBucksApp.ViewModels
{
    [QueryProperty(nameof(SelectedProduct), nameof(SelectedProduct))]
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Product _selectedProduct;

        public DetailPageViewModel() { }

        [RelayCommand]
        public async Task BackAsync()
        {
            await Shell.Current.GoToAsync("..", true);
        }
    }
}
