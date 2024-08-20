namespace MauiFlipClock;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            var currentTime = DateTime.Now;
            Digit1.Text = currentTime.Hour.ToString("D2")[0].ToString();
            Digit2.Text = currentTime.Hour.ToString("D2")[1].ToString();
            Digit3.Text = currentTime.Minute.ToString("D2")[0].ToString();
            Digit4.Text = currentTime.Minute.ToString("D2")[1].ToString();
            return true;
        });
    }

}

