using Plugin.StoreReview;

namespace SampleApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private async void RequestAppStoreReview(object sender, EventArgs e)
    {
        await RequestAppStoreReview();
    }

    private async Task RequestAppStoreReview()
    {
        ReviewStatus reviewStatus = ReviewStatus.Unknown;
        reviewStatus = await CrossStoreReview.Current.RequestReview(true);
    }
}


