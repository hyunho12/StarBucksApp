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
        // DetailPage XAML���� CustomStepperView�� x:Name�� Ȯ���Ͽ� ����
        if (customStepper != null)
        {
            customStepper.CountLabel.Text = "0";
        }
    }
}