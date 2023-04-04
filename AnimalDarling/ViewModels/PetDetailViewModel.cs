using AnimalDarling.Models;
using System.Web;

namespace AnimalDarling.ViewModels;

public partial class PetDetailViewModel : BaseViewModel, IQueryAttributable
{
	[ObservableProperty]
	RazesDetail data;

    public ObservableCollection<CarouselItem> CarouselSource { get; set; } = new ObservableCollection<CarouselItem>();

    public PetDetailViewModel()
    {
        for (int i = 0; i < 5; i++)
        {
            CarouselSource.Add(new CarouselItem { Image = ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar1.jpg")) });
        }
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        try
		{
			Data = (RazesDetail)query["razes"];
        }
		catch (Exception)
		{

		}
    }

	[RelayCommand]
	async Task BackButton()
	{
		await Shell.Current.Navigation.PopModalAsync();
    }
}
