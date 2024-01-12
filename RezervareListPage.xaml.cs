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
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new RezervareListPage { BindingContext = e.SelectedItem as Rezervare });
        }
    }
    }
