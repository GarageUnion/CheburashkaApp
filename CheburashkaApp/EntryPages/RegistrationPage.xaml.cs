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
            DisplayAlert("Регистрация завершена", "Для входа подтвердите аккаунт по ссылке в письме, отправленном на ваш email", "OK");
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
                invalidLoginInput.Text = "Этот email уже занят";
            }
            else if (!CheckCorrectRegistration.CheckLoginCorrect(loginEntry.Text))
            {
                invalidLoginInput.Text = "Этот email не существует";
            }
            else invalidLoginInput.Text = null;
        }
        else invalidLoginInput.Text = "Введите email";
    }
    void passwordEntry_Completed(object sender, EventArgs e)
    {
        if (passwordEntry.Text != null && passwordEntry.Text!="")
        {
            if (!CheckCorrectRegistration.CheckPasswordLength(passwordEntry.Text))
            {
                invalidPasswordInput.Text = "Пароль слишком короткий";
            }
            else if (!CheckCorrectRegistration.CheckPasswordCorrect(passwordEntry.Text))
            {
                invalidPasswordInput.Text = "Пароль содержит недопустимые символы";
            }
            else invalidPasswordInput.Text = null;
            if (passwordRepeatEntry.Text != null && !CheckCorrectRegistration.CheckPasswordsSame(passwordEntry.Text, passwordRepeatEntry.Text))
            {
                invalidPasswordRepeatInput.Text = "Пароли не совпадают";
            }
        }
        else invalidPasswordInput.Text = "Введите пароль";
    }
    void passwordRepeatEntry_Completed(object sender, EventArgs e)
    {
        if (passwordRepeatEntry.Text != null && passwordRepeatEntry.Text != "")
        {
            if (!CheckCorrectRegistration.CheckPasswordsSame(passwordEntry.Text, passwordRepeatEntry.Text))
            {
                invalidPasswordRepeatInput.Text = "Пароли не совпадают";
            }
            else invalidPasswordRepeatInput.Text = null;
        }
        else invalidPasswordRepeatInput.Text = "Введите пароль";
    }
    void nameEntry_Completed(object sender, EventArgs e)
    {
        if (nameEntry.Text != null && nameEntry.Text != "")
        {
            if (!CheckCorrectRegistration.CheckNameCorrect(nameEntry.Text))
            {
                invalidNameInput.Text = "Имя содержит недопустимые символы";
            }
            else invalidNameInput.Text = null;
        }
        else invalidNameInput.Text = "Введите имя";
    }
    void datePicker_DateSelected(object sender, EventArgs e)
    {
        if (!CheckCorrectRegistration.CheckAgeCorrect(datePicker.Date))
        {
            invalidDateInput.Text = $"Вам меньше {CheckCorrectRegistration.minimumAge}-ти лет";
        }
        else invalidDateInput.Text = null;
    }
    #endregion
}