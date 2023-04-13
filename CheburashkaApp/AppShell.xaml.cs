namespace CheburashkaApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		if (!CheckLogin.CheckInSystem())
		{
			Navigation.PushAsync(new LoginPage());
		}
    }

}
