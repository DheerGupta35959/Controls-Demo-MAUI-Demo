namespace InputControlDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		lblSlider.Text = slide.Value.ToString();
	}

	private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		if (stepper != null)
		{
			lblSlider.Text = stepper.Value.ToString();
		}
	}
}

