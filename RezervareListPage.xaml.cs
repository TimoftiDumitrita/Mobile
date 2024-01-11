using Mobile.Models;

namespace Mobile;

public partial class RezervareListPage : ContentPage
{
	public RezervareListPage()
	{
		InitializeComponent();
	}
   
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var rezervare = (Rezervare)BindingContext;
        rezervare.Data_start = DateTime.UtcNow;
        await App.Database.SaveShopListAsync(rezervare);
       
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var rezervare = (Rezervare)BindingContext;
        await App.Database.DeleteShopListAsync(rezervare);
        await Navigation.PopAsync();
    }
}
