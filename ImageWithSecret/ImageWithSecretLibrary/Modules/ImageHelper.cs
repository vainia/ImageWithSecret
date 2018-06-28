using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageWithSecretLibrary.Modules
{
    public static class ImageHelper
    {
        unsafe static public Bitmap ArrToBmp(Color[,] arr)
        {
            int Y = arr.GetLength(0), X = arr.GetLength(1);
            Bitmap bmp = new Bitmap(X, Y, PixelFormat.Format32bppArgb);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride - 4 * X)
                {
                    for (int x = 0; x < X; ++x, ptr += 4)
                    {
                        Color clr = arr[y, x];
                        ptr[3] = clr.A;
                        ptr[2] = clr.R;
                        ptr[1] = clr.G;
                        ptr[0] = clr.B;
                    }
                }
            }
            bmp.UnlockBits(data);
            return bmp;
        }
        unsafe public static Bitmap ArrToBmp(byte[] arr, int X, int Y)
        {
            int rowsize = 4 * X;
            Bitmap bmp = new Bitmap(X, Y, PixelFormat.Format32bppArgb);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride) Marshal.Copy(arr, y * rowsize, (IntPtr)ptr, rowsize);
            }
            bmp.UnlockBits(data);
            return bmp;
        }
        unsafe public static byte[] BmpToArr(Bitmap bmp)
        {
            int Y = bmp.Height, X = bmp.Width, rowsize = 4 * X;
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, X, Y), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] arr = new byte[4 * Y * X];
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                for (int y = 0; y < Y; ++y, ptr += data.Stride) Marshal.Copy((IntPtr)ptr, arr, y * rowsize, rowsize);
            }
            bmp.UnlockBits(data);
            return arr;
        }
    }
}
