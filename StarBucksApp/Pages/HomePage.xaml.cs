using StarBucksApp.ViewModels;

namespace StarBucksApp.Pages;

public partial class HomePage : CustomTabBar
{
	private HomeViewModel viewModel;
	public HomePage(HomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}