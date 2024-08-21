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
            var hr = currentTime.Hour;
            if (hr > 12) hr -= 12;
            var minutes = currentTime.ToString("mm");
            var amPm = currentTime.ToString("tt");
            Hour.Text = hr.ToString();
            Minutes.Text = minutes; 
            AMPM.Text = amPm;
            return true;
        });
    }

}

