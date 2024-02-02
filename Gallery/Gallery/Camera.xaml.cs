namespace Gallery;

public partial class Camera : ContentPage
{
	public Camera()
	{
		InitializeComponent();
	}


    private async void OnCaptureImageClicked(object sender, EventArgs e)
    {
        try
        {
            var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
            {
                Title = "Capture a photo"
            });

            if (photo != null)
            {
                
                CapturedImage.Source = ImageSource.FromStream(() => photo.OpenReadAsync().Result);
            }
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}



