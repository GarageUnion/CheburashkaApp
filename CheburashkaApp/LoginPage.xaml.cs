namespace CheburashkaApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void EnterButton_Clicked(object sender, EventArgs e)
    {
        //�������� �������� �� ������������ ������/������
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