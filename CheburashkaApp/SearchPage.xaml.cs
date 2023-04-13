namespace CheburashkaApp;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}
    private void SearchSettingsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SearchSettingsPage());
    }
}