namespace Mobile;

public partial class RezervarePage : ContentPage
{
    public RezervarePage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetShopListsAsync();
    }
    async void OnShopListAddedClicked(object sender, EventArgs e) { await Navigation.PushAsync(new RezervareListPage { BindingContext = new RezervareListPage() }); }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null) { await Navigation.PushAsync(new RezervareListPage { BindingContext = e.SelectedItem as RezervareListPage }); }
    }
}