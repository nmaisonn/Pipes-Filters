using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterSaver : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider xProvider=new PictureProvider();
            xProvider.SavePicture(image,@"luke.jpg");
            return image;
        }
    }

}
