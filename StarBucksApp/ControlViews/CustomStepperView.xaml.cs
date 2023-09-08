namespace StarBucksApp.ControlViews;

public partial class CustomStepperView : ContentView
{
	int count;
	public CustomStepperView()
	{
        InitializeComponent();
        count = 0;        
        this.CountLabel.Text = Convert.ToString(count);        
    }

	private void Substract_Tapped(object sender, EventArgs e)
	{
		if (count <= 0)
		{
			return;			
		}
        this.CountLabel.Text = Convert.ToString(--count);
    }

	private void Add_Tapped(object obj, EventArgs e)
	{
		this.CountLabel.Text = Convert.ToString(++count);
	}
}