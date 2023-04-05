using AnimalDarling.Enums;
using AnimalDarling.Models;
using AnimalDarling.Services;

namespace AnimalDarling.ViewModels;

public partial class DashboardViewModel : BaseViewModel
{
    [ObservableProperty]
    ImageSource avatarSource;

    [ObservableProperty]
    string avatarText;

    public ObservableCollection<Razes> RazeCollection { get; set; } = new ObservableCollection<Razes>();
    public ObservableCollection<RazesDetail> RazesDetailCollection { get; set; } = new ObservableCollection<RazesDetail>();

    public DashboardViewModel()
    {
        AvatarSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQUGxavCnDLJz7fZPxRUjZkKY8FL5Dxf6iiHc0OymxANteE1I7Aui89RSzwuU1QSuOvUIs&usqp=CAU";
        AvatarText = "CT";

        var razesList = PetService.GetRazesList();

        foreach (var item in razesList)
        {
            RazeCollection.Add(item);
        }

        var detailsList = PetService.GetRazesDetailList(RazesEnum.Mallorcan);

        foreach (var item in detailsList)
        {
            RazesDetailCollection.Add(item);
        }
    }

    [RelayCommand]
    async Task NavigateToDetail(RazesDetail data)
    {
        if (data is not null)
        {
            //await Shell.Current.GoToAsync("/PetDetailPage", new Dictionary<string, object>() { { "razes", data } });

            await Shell.Current.Navigation.PushAsync(new PetDetailPage(new PetDetailViewModel(data)));
        }
    }

    [RelayCommand]
    async Task SelectionItem(Razes razes)
    {
        RazesDetailCollection.Clear();

        foreach (var item in RazeCollection)
        {
            item.IsSelected = false;
        }

        RazeCollection.FirstOrDefault(f => f.Id == razes.Id).IsSelected = true;

        var detailsList = PetService.GetRazesDetailList((RazesEnum)razes.Id);

        foreach (var item in detailsList)
        {
            RazesDetailCollection.Add(item);
        }
    }
}
