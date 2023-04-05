using AnimalDarling.Models;

namespace AnimalDarling.ViewModels;

public partial class PetDetailViewModel : BaseViewModel, IQueryAttributable
{
    [ObservableProperty]
    RazesDetail data;

    public ObservableCollection<CarouselItem> CarouselSource { get; set; } = new ObservableCollection<CarouselItem>();

    public PetDetailViewModel(RazesDetail tmpdata)
    {
        Data = tmpdata;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        //Data = (RazesDetail)query["razes"];
    }

    [RelayCommand]
    async Task FillData()
    {
        CarouselSource.Clear();

        foreach (var item in Data.Images)
        {
            CarouselSource.Add(new CarouselItem { Image = item });
        }
    }

    [RelayCommand]
    async Task BackButton()
    {
        await Shell.Current.Navigation.PopModalAsync();
    }
}
