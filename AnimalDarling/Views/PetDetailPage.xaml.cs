namespace AnimalDarling.Views;

public partial class PetDetailPage : ContentPage
{
	public PetDetailPage(PetDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
