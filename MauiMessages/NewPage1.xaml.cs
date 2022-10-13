namespace MauiMessages;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new ViewModels.NewPage1ViewModel();
	}
}