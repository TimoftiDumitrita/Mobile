using Mobile.Models;

namespace Mobile;

public partial class Reviews : ContentPage
{
    private readonly ReviewViewModel viewModel;

    public Reviews()
    {
        InitializeComponent();
        viewModel = new ReviewViewModel();
    }

    private async void OnSubmitReviewClicked(object sender, EventArgs e)
    {
        var newReview = new Review
        {

            Rate = (int)ratingSlider.Value,
            Message = messageEditor.Text,

        };

        await viewModel.SaveReviewAsync(newReview);
    }
}