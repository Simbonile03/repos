using Gallery;
using System.Collections.ObjectModel;

namespace PhotoScrollView
{
    internal class Image
    {
        public static implicit operator Image(ObservableCollection<Photo> v)
        {
            throw new NotImplementedException();
        }
    }
}