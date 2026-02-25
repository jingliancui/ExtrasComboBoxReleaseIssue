namespace SampleApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext ??= new MainPageViewModel();

		countryComboBox.DisplayMemberFunc = item => ((CountryModel)item).Name;
	}
}
