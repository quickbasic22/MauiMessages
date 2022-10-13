namespace MauiMessages;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NewPage1), typeof(NewPage1));
		MainPage = new AppShell();
	}
}
