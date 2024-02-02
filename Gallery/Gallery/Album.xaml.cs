namespace Gallery;

public partial class Album : ContentPage
{
	public Album()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PhotoAlbum());
    }
}