using Mobile.Models;
using Mobile.Data;

namespace Mobile;

public partial class ReviewPage : ContentPage
{
	public ReviewPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var review = (Review)BindingContext;
        await App.ReviewDatabase.SaveReviewAsync(review);
        await Navigation.PopAsync();
    }
}