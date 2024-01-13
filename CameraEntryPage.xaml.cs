using Mobile.Data;
using Mobile.Models;

namespace Mobile;

public partial class CameraEntryPage : ContentPage
{
    public CameraEntryPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.CameraDatabase.GetCamereAsync();
    }
    async void OnClientAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CamerePage
        {
            BindingContext = new Camera()
        });
    }
    async void OnClientViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new CamerePage
            {
                BindingContext = e.SelectedItem as Camera
            });
        }
    }
}