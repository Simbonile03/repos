using System.Collections.ObjectModel;

namespace Gallery
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Photo> Photos { get; set; }
        public object PhotoScrollView { get; private set; }


        public MainPage()
        {
            InitializeComponent();
        }


 
        private PhotoScrollView.Image GetSource()
        {
            return Photos;
        }

        private void LoadPhotos(PhotoScrollView.Image Source)
        {

            Photos.Add(new Photo { Title = "Photo 1", ImagePath = "spiderman.svg.jpg" });
            Photos.Add(new Photo { Title = "Photo 2", ImagePath = "chrome.jpg" });
        }
    }

    public class Photo
    {
        public required string Title { get; set; }
        public required string ImagePath { get; set; }
    }
}
