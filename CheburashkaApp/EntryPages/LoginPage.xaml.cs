
using System.Xml;

namespace CheburashkaApp;

public partial class LoginPage : ContentPage
{

	public LoginPage()
	{
		InitializeComponent();
	}

    private void EnterButton_Clicked(object sender, EventArgs e)
    {
        if (CheckLogin.CheckInServer(loginEntry.Text, passwordEntry.Text))
        {
            var userIO = new UserDataIO();
            if (RememberMeCheckBox.IsChecked == true)
            {
                userIO.WriteToFile(Encryptor.Encrypt(loginEntry.Text,passwordEntry.Text));
            }
            else
            {
                userIO.DeleteFile();
            }
            Navigation.PopAsync();
        }
        else
        {
            incorrectInputLabel.Text = "Неверный логин или пароль";
        }
    }
    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    private void RegistrationButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistrationPage());
    }
}