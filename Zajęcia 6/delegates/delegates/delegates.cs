using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo); // może trzymać referencje do funkcji o sygnaturze void nazwa (Photo photo)

        public void Process(string path, Action<Photo> filterHandler)  //
        {
            var photo = new Photo(path);

            //var filters = new PhotoFilters(); bez delegat byśmy musieli ciągle wywoływać wszystkie funkcje, tak to sobie je agregujemy
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            filterHandler(photo); // używamy tego co dostaniemy w filterHanfler

            photo.Save();
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("ApplyBrightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("ApplyContrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize");
        }
    }

    public class Photo
    {
        private string _path;

        public Photo(string path)
        {
                this._path = path;
        }

        public string Save()
        {
            return _path;
        }
    }
}
