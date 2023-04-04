using AnimalDarling.Models;
using System.Web;

namespace AnimalDarling.ViewModels;

public partial class PetDetailViewModel : BaseViewModel, IQueryAttributable, INotifyPropertyChanged
{
	[ObservableProperty]
	RazesDetail data;

    public ObservableCollection<CarouselItem> CarouselSource { get; set; } = new ObservableCollection<CarouselItem>();

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        try
		{
            Data = (RazesDetail)query["razes"];            

            CarouselSource.Clear();
            
            foreach (var item in Data.Images) {
                CarouselSource.Add(new CarouselItem { Image = item });
            }
        }
		catch (Exception e)
		{

		}
    }

	[RelayCommand]
	async Task BackButton()
	{
		await Shell.Current.Navigation.PopModalAsync();
    }
}
