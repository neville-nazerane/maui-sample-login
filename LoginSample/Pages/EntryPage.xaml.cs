namespace LoginSample.Pages;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("//login");
    }
}