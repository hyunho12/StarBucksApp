namespace StarBucksApp.Pages;

public partial class CustomTabBar : BasePage
{
	public CustomTabBar()
	{
		InitializeComponent();
	}

    private void ViewContentChanged(View oldViewContent, View newViewContent) { }
    public View ViewContent
    {
        get => (View)GetValue(ViewContentProperty);
        set => SetValue(ViewContentProperty, value);
    }

    public static readonly BindableProperty ViewContentProperty = BindableProperty.Create(nameof(ViewContent), typeof(View), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as CustomTabBar;
        if (newV != null && !(newV is View)) return;
        var oldViewContent = (View)old;
        var newViewContent = (View)newV;
        me?.ViewContentChanged(oldViewContent, newViewContent);
    });

}