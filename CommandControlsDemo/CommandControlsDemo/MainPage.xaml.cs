namespace CommandControlsDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void testBtnClicked(object sender, EventArgs e)
	{
		DisplayAlert("Test", "This is a Demo", "Ok");
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("Radio Button", "Changes: true", "OK");
	}

	private void searchControl_SearchButtonPressed(object sender, EventArgs e)
	{
		DisplayAlert("Search Bar", "Search Button Pressed", "OK");
	}

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Swipe Item", "Swipe Item Invoked", "OK");
	}
}


