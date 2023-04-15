namespace CheburashkaApp;

public partial class MyProfilePage : ContentPage
{
	public MyProfilePage()
	{
		InitializeComponent();
	}

    private void LogoutButton_Clicked(object sender, EventArgs e)
    {
		var userIO = new UserDataIO();
		userIO.DeleteFile();
        Navigation.PushAsync(new LoginPage());
    }
}