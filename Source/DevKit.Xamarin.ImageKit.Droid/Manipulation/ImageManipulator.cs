﻿using System;
using System.Threading.Tasks;
using Android.Graphics;
using DevKit.Xamarin.ImageKit.Abstractions;
using DevKit.Xamarin.ImageKit.Droid.Utils;
using DevKit.Xamarin.ImageKit.Manipulation;

namespace DevKit.Xamarin.ImageKit.Manipulation
{
    public class ImageManipulator : IImageManipulator
    {
        public byte[] RotateImage(byte[] originalImage, SideOrientation orientation, Abstractions.ImageFormat imageFormat)
        {
            byte[] resultRotatedImage = null;
            Bitmap bitmap = originalImage.ToBitmap();

            Matrix matrix = new Matrix();
            matrix.PostRotate(orientation == SideOrientation.RotateToRigth ? 90 : -90);

            Bitmap rotatedBitmap = Bitmap.CreateBitmap(bitmap, 0, 0, bitmap.Width, bitmap.Height, matrix, true);
            resultRotatedImage = rotatedBitmap.ToByteArray(imageFormat);
            rotatedBitmap.Dispose();
            return resultRotatedImage;
        }

    }
}
