namespace AnimalDarling.ViewModels;

public partial class LocalizationViewModel : BaseViewModel
{
	public string LocalizedText => AnimalDarling.Resources.Strings.AppResources.HelloMessage;
}
