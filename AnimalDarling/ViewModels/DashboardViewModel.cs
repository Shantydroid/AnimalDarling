using AnimalDarling.Enums;
using AnimalDarling.Models;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Security.AccessControl;
using static System.Net.WebRequestMethods;

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
        AvatarSource = "https://media.istockphoto.com/id/1209654046/vector/user-avatar-profile-icon-black-vector-illustration.jpg?s=612x612&w=0&k=20&c=EOYXACjtZmZQ5IsZ0UUp1iNmZ9q2xl1BD1VvN6tZ2UI=";
        AvatarText = "CT";

        RazeCollection.Add(new Razes { Id = 1, Image = "dog.svg", Text = "Dogs", IsSelected = true });
        RazeCollection.Add(new Razes { Id = 2, Image = "cat.svg", Text = "Cats" });
        RazeCollection.Add(new Razes { Id = 3, Image = "cow.svg", Text = "Vacas" });
        RazeCollection.Add(new Razes { Id = 4, Image = "dove.svg", Text = "Pájaros" });
        RazeCollection.Add(new Razes { Id = 5, Image = "fish.svg", Text = "Peces" });
        RazeCollection.Add(new Razes { Id = 6, Image = "horse.svg", Text = "Caballos" });

        RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
        RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
        RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
        RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
        RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });

        SetMarginIntoCollectionView();
    }

    private void SetMarginIntoCollectionView()
    {
        for (int i = 0; i < RazesDetailCollection.Count; i++)
        {
            RazesDetailCollection[i].IsPar = i % 2 == 0;
        }
    }

    [RelayCommand]
    async Task NavigateToDetail(RazesDetail data)
    {
        if (data is not null) { 
            await Shell.Current.GoToAsync("/PetDetailPage", new Dictionary<string, object>() { { "razes", data } });
        }
    }

    [RelayCommand]
    async Task SelectionItem(Razes razes)
    {
        RazesDetailCollection.Clear();

        foreach (var item in RazeCollection) {
            item.IsSelected = false;
        }

        RazeCollection.FirstOrDefault(f => f.Id == razes.Id).IsSelected = true;

        switch (razes.Id)
        {
            case (int)RazesEnum.Dog:
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://www.koin.com/wp-content/uploads/sites/10/2023/01/Image-7.jpeg?w=540")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                
                break;
            case (int)RazesEnum.Cat:
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmKeVMDCeBHqa5JzgntMFx9-PdEbnJ9aH-JA&usqp=CAU")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmKeVMDCeBHqa5JzgntMFx9-PdEbnJ9aH-JA&usqp=CAU")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmKeVMDCeBHqa5JzgntMFx9-PdEbnJ9aH-JA&usqp=CAU")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmKeVMDCeBHqa5JzgntMFx9-PdEbnJ9aH-JA&usqp=CAU")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                RazesDetailCollection.Add(new RazesDetail { Image = ImageSource.FromUri(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmKeVMDCeBHqa5JzgntMFx9-PdEbnJ9aH-JA&usqp=CAU")), Title = "Cherry", SubTitle = "King Charles Spaniel", Text = "8 mth. Girl" });
                break;
            case (int)RazesEnum.Cow:
                break;
            case (int)RazesEnum.Dove:
                break;
            case (int)RazesEnum.Fish:
                break;
            case (int)RazesEnum.Horse:
                break;
            default:
                break;
        }

        SetMarginIntoCollectionView();
    } 
}
