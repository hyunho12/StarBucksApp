using System.Windows.Input;

namespace StarBucksApp.Pages;

public partial class CustomTabBar : ContentPage
{
	public View ViewContent
	{
		get => (View)GetValue(ViewContentProperty);
		set => SetValue(ViewContentProperty, value);
	}

	public static readonly BindableProperty ViewContentProperty = BindableProperty.Create(nameof(ViewContent), typeof(View), typeof(CustomTabBar),
		propertyChanged: (obj, oldV, newV) =>
		{
			var me = obj as CustomTabBar;
            if (newV != null && (newV is View)) { return; }
			var oldViewContent = (View)oldV;
			var newViewContent = (View)newV;
			me?.ViewContentChanged(oldViewContent, newViewContent);
        });

	private void ViewContentChanged(View oldViewContent, View newViewContent)
	{

	}

	public ICommand HomeCommand
	{
		get => (ICommand)GetValue(HomeCommandTappedProperty);
		set => SetValue(HomeCommandTappedProperty, value);
	}

	public static readonly BindableProperty HomeCommandTappedProperty = BindableProperty.Create(nameof(HomeCommand), typeof(ICommand), typeof(CustomTabBar),
		propertyChanged: (obj, oldV, newV) =>
		{
			var me = obj as CustomTabBar;
			if(newV != null && !(newV is Type)) { return; }
			var oldTappedCommand = (Type)oldV;
			var newTappedCommand = (Type)newV;
			me?.HomeCommandTappedChanged(oldTappedCommand, newTappedCommand);
		});

	private void HomeCommandTappedChanged(Type oldCommandTapped, Type newCommandTapped)
	{

	}

	public ICommand WalletCommand
	{
		get => (ICommand)GetValue(WalletCommandTappedProperty);
		set => SetValue(WalletCommandTappedProperty, value);
	}

	public static readonly BindableProperty WalletCommandTappedProperty = BindableProperty.Create(nameof(WalletCommand), typeof(ICommand), typeof(CustomTabBar),
		propertyChanged: (obj, oldV, newV) =>
		{
			var me = obj as CustomTabBar;
			if (newV != null && !(newV is Type)) return;
			var oldTappedCommand = (Type)oldV;
			var newTappedCommand = (Type)newV;
			me?.WalletCommandTappedChanged(oldTappedCommand, newTappedCommand);	
		});

	private void WalletCommandTappedChanged(Type oldCommandType,  Type newCommandType)
	{

	}

	public ICommand FavoriteCommand
	{
		get => (ICommand)GetValue(FavoriteCommandTappedProperty);
		set => SetValue(FavoriteCommandTappedProperty, value);
	}

	public static readonly BindableProperty FavoriteCommandTappedProperty = BindableProperty.Create(nameof(FavoriteCommand), typeof(ICommand), typeof(CustomTabBar),
		propertyChanged: (obj, oldV, newV) =>
		{
			var me = obj as CustomTabBar;
			if (newV != null && !(newV is Type)) return;
			var oldTappedCommand = (Type)oldV;
			var newTappedCommand = (Type)newV;
			me?.FavoriteCommandTappedChanged(oldTappedCommand, newTappedCommand);
		});

	private void FavoriteCommandTappedChanged(Type oldCommandType, Type newCommandType)
	{

	}

	public ICommand NotificationCommand
	{
		get => (ICommand)GetValue(NotificationCommandTappedProperty);
		set => SetValue(NotificationCommandTappedProperty, value);
	}

	public static readonly BindableProperty NotificationCommandTappedProperty = BindableProperty.Create(nameof(NotificationCommand), typeof(ICommand), typeof(CustomTabBar),
		propertyChanged: (obj, oldV, newV) =>
		{
			var me = obj as CustomTabBar;
            if (newV != null && !(newV is Type)) return;
            var oldTappedCommand = (Type)oldV;
			var newTappedCommand = (Type)newV;
			me?.NotificationCommandTappedChanged(oldTappedCommand, newTappedCommand);
		});

	private void NotificationCommandTappedChanged(Type oldCommandType, Type newCommandType)
	{

	}

	public CustomTabBar()
	{
		InitializeComponent();

		HomeCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/home"));
		WalletCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/wallet"));
        FavoriteCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/fav"));
		NotificationCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/notification"));
	}
}