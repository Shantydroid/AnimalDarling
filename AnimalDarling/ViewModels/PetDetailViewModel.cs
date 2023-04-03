using AnimalDarling.Models;
using System.Web;

namespace AnimalDarling.ViewModels;

public partial class PetDetailViewModel : BaseViewModel, IQueryAttributable, INotifyPropertyChanged
{
	[ObservableProperty]
	RazesDetail data;

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
}
