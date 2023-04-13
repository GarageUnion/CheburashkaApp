namespace CheburashkaApp;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private void MakeProfileButton_Clicked(object sender, EventArgs e)
    {
        if (CheckCorrectRegistration.CheckAll(loginEntry.Text, passwordEntry.Text, passwordRepeatEntry.Text, nameEntry.Text, datePicker.Date))
        {
            DisplayAlert("����������� ���������", "��� ����� ����������� ������� �� ������ � ������, ������������ �� ��� email", "OK");
            Navigation.PopAsync();
        }
        else
        {
            loginEntry_Completed(null, null);
            passwordEntry_Completed(null, null);
            passwordRepeatEntry_Completed(null, null);
            nameEntry_Completed(null, null);
            datePicker_DateSelected(null, null);
        }
    }
    #region checkcorrect
    void loginEntry_Completed(object sender, EventArgs e)
    {
        if (loginEntry.Text != null && loginEntry.Text != "") 
        {
            if (!CheckCorrectRegistration.CheckLoginFree(loginEntry.Text))
            {
                invalidLoginInput.Text = "���� email ��� �����";
            }
            else if (!CheckCorrectRegistration.CheckLoginCorrect(loginEntry.Text))
            {
                invalidLoginInput.Text = "���� email �� ����������";
            }
            else invalidLoginInput.Text = null;
        }
        else invalidLoginInput.Text = "������� email";
    }
    void passwordEntry_Completed(object sender, EventArgs e)
    {
        if (passwordEntry.Text != null && passwordEntry.Text!="")
        {
            if (!CheckCorrectRegistration.CheckPasswordLength(passwordEntry.Text))
            {
                invalidPasswordInput.Text = "������ ������� ��������";
            }
            else if (!CheckCorrectRegistration.CheckPasswordCorrect(passwordEntry.Text))
            {
                invalidPasswordInput.Text = "������ �������� ������������ �������";
            }
            else invalidPasswordInput.Text = null;
            if (passwordRepeatEntry.Text != null && !CheckCorrectRegistration.CheckPasswordsSame(passwordEntry.Text, passwordRepeatEntry.Text))
            {
                invalidPasswordRepeatInput.Text = "������ �� ���������";
            }
        }
        else invalidPasswordInput.Text = "������� ������";
    }
    void passwordRepeatEntry_Completed(object sender, EventArgs e)
    {
        if (passwordRepeatEntry.Text != null && passwordRepeatEntry.Text != "")
        {
            if (!CheckCorrectRegistration.CheckPasswordsSame(passwordEntry.Text, passwordRepeatEntry.Text))
            {
                invalidPasswordRepeatInput.Text = "������ �� ���������";
            }
            else invalidPasswordRepeatInput.Text = null;
        }
        else invalidPasswordRepeatInput.Text = "������� ������";
    }
    void nameEntry_Completed(object sender, EventArgs e)
    {
        if (nameEntry.Text != null && nameEntry.Text != "")
        {
            if (!CheckCorrectRegistration.CheckNameCorrect(nameEntry.Text))
            {
                invalidNameInput.Text = "��� �������� ������������ �������";
            }
            else invalidNameInput.Text = null;
        }
        else invalidNameInput.Text = "������� ���";
    }
    void datePicker_DateSelected(object sender, EventArgs e)
    {
        if (!CheckCorrectRegistration.CheckAgeCorrect(datePicker.Date))
        {
            invalidDateInput.Text = $"��� ������ {CheckCorrectRegistration.minimumAge}-�� ���";
        }
        else invalidDateInput.Text = null;
    }
    #endregion
}