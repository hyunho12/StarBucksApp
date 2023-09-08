namespace StarBucksApp.ControlViews;

public partial class CustomStepperView : ContentView
{
    int count = 0;
	public CustomStepperView()
	{
		InitializeComponent();
        count = 0;
	}

    private void SubStractTapped(object sender, EventArgs e)
    {
        if (count < 0)
        {
            return;
        }
        this.CountLabel.Text = Convert.ToString(count--);
    }

    private void Add_Tapped(object sender, EventArgs e)
    {
        this.CountLabel.Text = Convert.ToString(count++);
    }
}