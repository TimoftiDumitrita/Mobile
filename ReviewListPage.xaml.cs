using Mobile.Models;
using Mobile.Data;

namespace Mobile;

public partial class ReviewListPage : ContentPage
{
	public ReviewListPage()
	{
		InitializeComponent();
	}
  

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.ReviewDatabase.GetReviewsAsync();
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ReviewPage { BindingContext = e.SelectedItem as Review });
        }
    }
}
