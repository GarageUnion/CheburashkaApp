namespace CheburashkaApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void EnterButton_Clicked(object sender, EventArgs e)
    {
        //добавить проверку на корректность логина/пароля
        Navigation.PopAsync();
    }
    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    private void RegistrationButton_Clicked(object sender, EventArgs e)
    {

    }
}