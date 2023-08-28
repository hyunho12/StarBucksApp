using StarBucksApp.Pages;

namespace StarBucksApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//MainPage = new DetailPage();
	}
}
