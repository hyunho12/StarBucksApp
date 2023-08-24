namespace StarBucksApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new DetailPage());
        //await Shell.Current.GoToAsync($"detail");
    }

    
}