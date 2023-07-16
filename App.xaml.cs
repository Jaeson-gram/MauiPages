namespace Pages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new MainPage());

		navPage.BackgroundColor = Colors.Coral;
		navPage.BarTextColor = Colors.White;


		MainPage = navPage;
	}
}
