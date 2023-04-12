namespace VersionNumberRepro;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnVersionInfoClicked(object sender, EventArgs e)
	{
		await Shell.Current.DisplayAlert("VersionInfo", $"VersionString is {AppInfo.VersionString} and BuildString is {AppInfo.BuildString}", "OK");
	}
}

