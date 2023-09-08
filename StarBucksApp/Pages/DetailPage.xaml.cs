using StarBucksApp.ViewModels;

namespace StarBucksApp.Pages;

public partial class DetailPage : ContentPage
{
	private DetailPageViewModel viewModel;
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        InitializeCustomStepperView();

    }

    private void InitializeCustomStepperView()
    {
        // DetailPage XAML에서 CustomStepperView의 x:Name을 확인하여 참조
        if (customStepper != null)
        {
            customStepper.CountLabel.Text = "0";
        }
    }
}