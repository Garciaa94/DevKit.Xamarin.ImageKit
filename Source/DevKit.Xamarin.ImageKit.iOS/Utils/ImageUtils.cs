﻿using System.Threading.Tasks;
using UIKit;

namespace DevKit.Xamarin.ImageKit.iOS.Utils
{
    public static class ImageUtils
    {
        public static UIImage ToImage(this byte[] data)
        {
            UIKit.UIImage image;
            try
            {
                image = new UIImage(Foundation.NSData.FromArray(data));
            }
            catch
            {
                return null;
            }
            return image;
        }
    }
}