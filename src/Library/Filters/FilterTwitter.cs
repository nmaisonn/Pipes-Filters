using System;
using System.Drawing;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        public IPicture Filter(IPicture image)
        {
            TwitterImage xImagenTwitter=new TwitterImage();
            xImagenTwitter.PublishToTwitter("NM",@"luke.jpg");
            return image;
        }
    }
}