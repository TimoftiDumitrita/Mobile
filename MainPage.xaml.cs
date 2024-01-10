namespace Mobile
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnExploreCamereClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Camere());
        }
    }
}
