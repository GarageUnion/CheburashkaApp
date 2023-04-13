namespace CheburashkaApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void EnterButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AppShell());
    }
}