namespace AnimalDarling.Views;

public partial class PetSearchPage : ContentPage
{
	public PetSearchPage(PetSearchViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
