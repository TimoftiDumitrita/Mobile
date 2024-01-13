using Mobile.Models;


namespace Mobile;

public partial class CamerePage : ContentPage
{
	public CamerePage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var camera = (Camera)BindingContext;
        await App.CameraDatabase.SaveCamereAsync(camera);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var camera = (Camera)BindingContext;
        await App.CameraDatabase.DeleteCamereAsync(camera);
        await Navigation.PopAsync();
    }
}