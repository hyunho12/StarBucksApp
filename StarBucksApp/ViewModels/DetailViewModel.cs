using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using StarBucksApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBucksApp.ViewModels
{
    [INotifyPropertyChanged]
    [QueryProperty(nameof(SelectedProudct), nameof(SelectedProudct))]
    public partial class DetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        Product _selectedProudct;

        [ObservableProperty]
        List<ProductSize> _productSizes;

        [RelayCommand]
        async Task Back()
        {
            await Shell.Current.GoToAsync("..", true);
        }

        public DetailViewModel() { }

        public override Task Initialize()
        {
            return Task.CompletedTask;
        }

        public override Task Stop()
        {
            return Task.CompletedTask;
        }
    }
}
