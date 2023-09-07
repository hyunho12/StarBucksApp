using StarBucksApp.ViewModels;

namespace StarBucksApp.Pages;

public partial class DetailPage : ContentPage
{
	private DetailPageViewModel viewModel;
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}