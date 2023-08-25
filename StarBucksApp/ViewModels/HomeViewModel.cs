using CommunityToolkit.Mvvm.ComponentModel;
using StarBucksApp.Models;
using StarBucksApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBucksApp.ViewModels
{
    [INotifyPropertyChanged]
    public partial class HomeViewModel : BaseViewModel
    {
        public string[] Categories { get; set; }

        [ObservableProperty]
        public string _categorySelectedValue;

        [ObservableProperty]
        ObservableCollection<Product> _products;
        
        public override Task Initialize()
        {
            //CategorySelectedValue = "All";
            Categories = Enum.GetNames(typeof(CoffeeCategory)).Cast<string>().Select(x => x.ToString()).ToArray();
            Products = new ObservableCollection<Product>(ProductService.Instance.GetProducts());
            return Task.CompletedTask;
        }

        public override Task Stop()
        {
            return Task.CompletedTask;
        }
    }
}
