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
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Product> products;

        public HomeViewModel() 
        {
            Products = new ObservableCollection<Product>(ProductService.Instance.GetProducts());
        }
    }
}
