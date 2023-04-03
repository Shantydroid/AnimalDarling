namespace AnimalDarling.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}
