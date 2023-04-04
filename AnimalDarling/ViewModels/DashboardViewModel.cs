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
        AvatarSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQUGxavCnDLJz7fZPxRUjZkKY8FL5Dxf6iiHc0OymxANteE1I7Aui89RSzwuU1QSuOvUIs&usqp=CAU";
        AvatarText = "CT";

        RazeCollection.Add(new Razes { Id = 1, Image = "dog.svg", Text = "Pastor mallorquín", IsSelected = true });
        RazeCollection.Add(new Razes { Id = 2, Image = "dog.svg", Text = "Pastor Catalán"});
        RazeCollection.Add(new Razes { Id = 3, Image = "dog.svg", Text = "Mastín español" });
        RazeCollection.Add(new Razes { Id = 4, Image = "dog.svg", Text = "Mastín del pirineo" });
        RazeCollection.Add(new Razes { Id = 5, Image = "dog.svg", Text = "Dogo mallorquín" });
        RazeCollection.Add(new Razes { Id = 6, Image = "dog.svg", Text = "Presa Canario" });

        var listPastorMallorquin = new List<ImageSource>();
        listPastorMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar1.jpg")));
        listPastorMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/CA_BESTIAR-cuerpo.jpg")));
        listPastorMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar.jpg")));      

        RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin, Title = "Pastor Mallorquín", SubTitle = " Perro de pastoreo, de guarda y de defensa.", Text = "8 meses. Macho" });

        var listPastorMallorquin1 = new List<ImageSource>();
        listPastorMallorquin1.Add(ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/7/7c/Ca_de_Bestiar.JPG")));
        listPastorMallorquin1.Add(ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/8/80/Ca_de_bestiar.jpg")));
        listPastorMallorquin1.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar.jpg")));

        RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin1, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "4 meses. Hembra" });

        var listPastorMallorquin2 = new List<ImageSource>();
        listPastorMallorquin2.Add(ImageSource.FromUri(new Uri("https://www.petclic.es/wikipets/wp-content/uploads/sites/default/files/library/ca_de_bestiar.jpg")));
        listPastorMallorquin2.Add(ImageSource.FromUri(new Uri("https://i0.wp.com/www.mascotadomestica.com/wp-content/uploads/2012/03/pastor-mallorquin.jpg?resize=350%2C219&ssl=1")));
        listPastorMallorquin2.Add(ImageSource.FromUri(new Uri("https://media.graphassets.com/output=format:webp/k12vRR6T26eGy34ItDCC?width=1280")));

        RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin2, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "1 año. Hembra" });

        var listPastorMallorquin3 = new List<ImageSource>();
        listPastorMallorquin3.Add(ImageSource.FromUri(new Uri("https://www.perros.com/content/perros_com/imagenes/galerias/thumbs6/thor.JPG")));
        listPastorMallorquin3.Add(ImageSource.FromUri(new Uri("https://img.over-blog-kiwi.com/0/89/44/95/20140116/ob_aa742c_duque-solo-02-agosto-1995.jpg")));
        listPastorMallorquin3.Add(ImageSource.FromUri(new Uri("https://razasdeperros.page/wp-content/uploads/2020/01/pastor-mallorquin.jpg")));

        RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin3, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "1 meses. Macho" });

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
                var listPastorMallorquin = new List<ImageSource>();
                listPastorMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar1.jpg")));
                listPastorMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/CA_BESTIAR-cuerpo.jpg")));
                listPastorMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "8 meses. Macho" });

                var listPastorMallorquin1 = new List<ImageSource>();
                listPastorMallorquin1.Add(ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/7/7c/Ca_de_Bestiar.JPG")));
                listPastorMallorquin1.Add(ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/8/80/Ca_de_bestiar.jpg")));
                listPastorMallorquin1.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Ca-Bestiar.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin1, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "4 meses. Hembra" });

                var listPastorMallorquin2 = new List<ImageSource>();
                listPastorMallorquin2.Add(ImageSource.FromUri(new Uri("https://www.petclic.es/wikipets/wp-content/uploads/sites/default/files/library/ca_de_bestiar.jpg")));
                listPastorMallorquin2.Add(ImageSource.FromUri(new Uri("https://i0.wp.com/www.mascotadomestica.com/wp-content/uploads/2012/03/pastor-mallorquin.jpg?resize=350%2C219&ssl=1")));
                listPastorMallorquin2.Add(ImageSource.FromUri(new Uri("https://media.graphassets.com/output=format:webp/k12vRR6T26eGy34ItDCC?width=1280")));

                RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin2, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "1 año. Hembra" });

                var listPastorMallorquin3 = new List<ImageSource>();
                listPastorMallorquin3.Add(ImageSource.FromUri(new Uri("https://www.perros.com/content/perros_com/imagenes/galerias/thumbs6/thor.JPG")));
                listPastorMallorquin3.Add(ImageSource.FromUri(new Uri("https://img.over-blog-kiwi.com/0/89/44/95/20140116/ob_aa742c_duque-solo-02-agosto-1995.jpg")));
                listPastorMallorquin3.Add(ImageSource.FromUri(new Uri("https://razasdeperros.page/wp-content/uploads/2020/01/pastor-mallorquin.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listPastorMallorquin3, Title = "Pastor Mallorquín", SubTitle = "Perro de pastoreo, de guarda y de defensa.", Text = "1 meses. Macho" });

                break;
            case (int)RazesEnum.Cat:
                var listPastorCatalan = new List<ImageSource>();
                listPastorCatalan.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/GOS_DATURA-cuerpo.jpg")));
                listPastorCatalan.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Gos-datura1.jpg")));
                listPastorCatalan.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Gos-datura.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listPastorCatalan, Title = "Pastor Catalán", SubTitle = "Cuidado de los rebaños.", Text = "5 meses. Hembra" });
                break;
            case (int)RazesEnum.Cow:
                var listMastinEspañol = new List<ImageSource>();
                listMastinEspañol.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/MASTIN_ESPANYOL-cuerpo.jpg")));
                listMastinEspañol.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-espanyol1.jpg")));
                listMastinEspañol.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-espanyol.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listMastinEspañol, Title = "Mastín Español", SubTitle = "Guardería y defensa.", Text = "1 mth. Macho" });
                break;
            case (int)RazesEnum.Dove:
                var listMastinPirineo = new List<ImageSource>();
                listMastinPirineo.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/MASTIN_PIRINEO-cuerpo.jpg")));
                listMastinPirineo.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-Pirineo.jpg")));
                listMastinPirineo.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Mastin-Pirineo1.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listMastinPirineo, Title = "Mastín del Pirineo", SubTitle = "Guardería y defensa.", Text = "4 mth. Hembra" });
                break;
            case (int)RazesEnum.Fish:
                var listDogoMallorquin = new List<ImageSource>();
                listDogoMallorquin.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/CA_BOU-cuerpo.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listDogoMallorquin, Title = "Dogo Mallorquín", SubTitle = "Perro de guarda y defensa.", Text = "1 año Hembra" });
                break;
            case (int)RazesEnum.Horse:
                var listPresaCanario = new List<ImageSource>();
                listPresaCanario.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/PRESA_CANARIO-cuerpo.jpg")));
                listPresaCanario.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Presa-Canario.jpg")));
                listPresaCanario.Add(ImageSource.FromUri(new Uri("https://www.rsce.es/images/rsce/RREE/Nuevas_fotos/Presa-canario1.jpg")));

                RazesDetailCollection.Add(new RazesDetail { Images = listPresaCanario, Title = "Presa Canario", SubTitle = "Perro guardián y al cuidado del ganado vacuno.", Text = "3 mth. Macho" });
                break;
            default:
                break;
        }

        SetMarginIntoCollectionView();
    } 
}
