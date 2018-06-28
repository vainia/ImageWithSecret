using ImageWithSecretLibrary.Interfaces;
using ImageWithSecretLibrary.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImageWithSecretLibrary
{
    public class ImageWithSecret<T_Data>
    {
        public Bitmap ImageModifying { set; get; }
        public Bitmap ImageOrigimal { set; get; }
        public IData<T_Data> DataReader { set; get; }
        public IWriteReadPixelData WriteReadData { set; get; }
        public List<IEncrypt> Encrypts = new List<IEncrypt>();
        public List<ICompression> Compressions = new List<ICompression>();
        public ICompression DataCompression { set; get; }
        private ByteOperations _byteOperations = new ByteOperations();
        // private LockBitmap _lockBitmap;
        private readonly int WriteReadDataIdPosition = 8;
        private readonly int DataCompressionIdPosition = 9;
        private readonly int Encrypt1IdPosition = 10;
        private readonly int Encrypt2IdPosition = 11;

        public byte[] imageArray { set; get; }

        public bool interactive = false;
        private ProcessDialog progress = new ProcessDialog();
        private bool skip = false;

        public Bitmap Encrypt(T_Data data)
        {
            if (ImageModifying == null)
                throw new ArgumentException("Parameter cannot be null", "Image");
            if (DataReader == null)
                throw new ArgumentException("Parameter cannot be null", "DataReader");
            if (WriteReadData == null)
                throw new ArgumentException("Parameter cannot be null", "WriteReadData");
            //_lockbitmap = new lockbitmap(ImageModifying);
            //_lockbitmap.lockbits();

            var dataToEncrypt = DataReader.ToBytes(data);
            WriteReadData.SetSettingsMode();

            var test2 = WriteReadData.GetID();

            SetConfPixel(WriteReadDataIdPosition, WriteReadData.GetID());
            if (DataCompression != null)
            {
                dataToEncrypt = DataCompression.Compression(dataToEncrypt);

                SetConfPixel(DataCompressionIdPosition, DataCompression.GetID());
            }
            else
            {

                SetConfPixel(DataCompressionIdPosition, 0b00000000);
            }

            SetConfPixel(Encrypt1IdPosition, 0b00000000);
            SetConfPixel(Encrypt2IdPosition, 0b00000000);
            if (Encrypts != null && Encrypts.Count > 0)
            {
                var i = 0;
                foreach(var enc in Encrypts)
                {
                    dataToEncrypt = enc.Encrypt(dataToEncrypt);
                    SetConfPixel(Encrypt1IdPosition + i, enc.GetID());
                    
                    if (++i > 1)
                        break;
                }
            }

            #region Write configs into image on Alpha path of color

            var dataLengthInBits = dataToEncrypt.Length * 8;
            var toWriteLength = _byteOperations.SplitSettingsBytes(new BitArray(BitConverter.GetBytes(dataLengthInBits)));
            int col = 3; // col = 0, rowIndex = 0;
            foreach (var row in toWriteLength)
            {
                imageArray[col] = (byte)((imageArray[col] & 0b11110000) | row);

                //_lockBitmap.SetPixel(col, rowIndex, WriteReadData.WriteData(_lockBitmap.GetPixel(col, rowIndex), row, null, null, null));
                col += 4; // ++col;
            }
            #endregion
            
            WriteReadData.SetDataMode();
            var toWrite = _byteOperations.SplitDataBytes(dataToEncrypt);
            int x = 0, y = 0;
            var lastIndex = toWrite.Count;
            foreach (var row in toWrite)
            {
                

                byte bR = imageArray[y + 0];
                byte bG = imageArray[y + 1];
                byte bB = imageArray[y + 2];

                imageArray[y + 0] = (byte)((bR & 0b11110000) | row[0]);
                imageArray[y + 1] = (byte)((bG & 0b11110000) | row[1]);
                imageArray[y + 2] = (byte)((bB & 0b11110000) | row[2]);

                //var p = _lockBitmap.GetPixel(x, y);
                //var np = WriteReadData.WriteData(p, null, row[0], row[1], row[2]);
                //_lockBitmap.SetPixel(x, y, np);

                if (interactive && !skip)
                {
                    progress.SetData((int)Math.Ceiling((toWrite.IndexOf(row) / ((lastIndex - 1) * 1.0)) * 100), x, y, bR, bG, bB, imageArray[y * ImageModifying.Width * 4 + x * 4 + 0], imageArray[y * ImageModifying.Width * 4 + x * 4 + 1], imageArray[y * ImageModifying.Width * 4 + x * 4 + 2]);                  
                    if (progress.ShowDialog() == DialogResult.Cancel) skip = true;
                }

                y += 4;
            }
            var test1 = imageArray;
            return ImageHelper.ArrToBmp(imageArray, ImageModifying.Width, ImageModifying.Height);

            // Unlock the bits.
            //_lockBitmap.UnlockBits();
            //return _lockBitmap.GetImage();
        }

        private byte GetConfPixel(int x)
        {
            var test = imageArray[x * 4 + 3];
            return (byte)(0b00001111 & imageArray[x * 4 + 3]);

            //return WriteReadData.ReadData(ImageModifying.GetPixel(x, 0), ImageOrigimal == null ? new Color() : ImageOrigimal.GetPixel(x, 0))[0];
        }
        private void SetConfPixel(int x, byte val)
        {
            imageArray[x * 4 + 3] = (byte)((imageArray[x * 4 + 3] & 0b11110000) | val);

            //var test1 = WriteReadData.WriteData(_lockBitmap.GetPixel(x, 0), val, null, null, null);
            //_lockBitmap.SetPixel(x, 0, WriteReadData.WriteData(_lockBitmap.GetPixel(x, 0), val, null, null, null));
            //var test2 = _lockBitmap.GetPixel(x, 0);
        }

        public static Bitmap ConvertTo32bpp(Image img)
        {
            var bmp = new Bitmap(img.Width, img.Height,
                          System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height));
            return bmp;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch
            {
                return null;
            }
        }

        // original: may be is null if mode is xor
        public T_Data Decrypt(Bitmap original)
        {
            ImageOrigimal = original;

            WriteReadData.SetSettingsMode();

            if (GetConfPixel(WriteReadDataIdPosition) != WriteReadData.GetID())
            {
                return DataReader.ToObject(System.Text.Encoding.UTF8.GetBytes("There is no hidden data in image!"));

            }
            var CompressionId = GetConfPixel(DataCompressionIdPosition);
            var EncryptId1 = GetConfPixel(Encrypt1IdPosition);
            var EncryptId2 = GetConfPixel(Encrypt2IdPosition);


            byte[] countDataList = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                var r = i * 2;
                var bigPath = GetConfPixel(r);
                var littlePath = GetConfPixel(r + 1);

                bigPath = (byte) (bigPath << 4);
                countDataList[3 - i] = (byte)(bigPath | littlePath); // index from end becouse big endian format
            }
            var dataLengthBits = BitConverter.ToInt32(countDataList, 0);
            var dataLengthBytes = dataLengthBits / 8;

            countDataList = new byte[dataLengthBytes * 2];

            WriteReadData.SetDataMode();
            int y = 0;
            for (int i = 0; i < countDataList.Length;)
            {

                byte bR = imageArray[y + 0];
                byte bG = imageArray[y + 1];
                byte bB = imageArray[y + 2];

                var d0 = (byte)(0b00001111 & bR);
                var d1 = (byte)(0b00001111 & bG);
                var d2 = (byte)(0b00001111 & bB);

                //var pixelEnc = ImageModifying.GetPixel(x, y);
                //var pixelOrg = original == null ? new Color() : original.GetPixel(x, y);
                //var d = WriteReadData.ReadData(pixelEnc, pixelOrg);

                if (i < countDataList.Length)
                    countDataList[i++] = d0;
                if (i < countDataList.Length)
                    countDataList[i++] = d1;
                if (i < countDataList.Length)
                    countDataList[i++] = d2;
                y+=4;
            }

            var data = _byteOperations.JoinBytes(countDataList);

            if (EncryptId2 > 0)
            {
                var enc = this.Encrypts.Where(r => r.GetID() == EncryptId2).FirstOrDefault();
                if (enc != null)
                {
                    data = enc.Decrypt(data);
                }
            }
            if (EncryptId1 > 0)
            {
                var enc = this.Encrypts.Where(r => r.GetID() == EncryptId1).FirstOrDefault();
                if(enc != null)
                {
                    data = enc.Decrypt(data);
                }
            }
            if (CompressionId > 0)
            {
                var compr = this.Compressions.Where(r => r.GetID() == CompressionId).FirstOrDefault();
                if (compr != null)
                {
                    data = compr.Recovery(data);
                }
            }

            return DataReader.ToObject(data);
        }
    }
}
