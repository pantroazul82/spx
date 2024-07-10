using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.controles
{
    public partial class firmaCGl : System.Web.UI.UserControl
    {
        string tmp1 = "";
        string tmp2 = "";
        string pcolor = "";
        string pwidth = "";
        string bgcolor = "";
        string signaturefile = "";
        string cWidth = "";
        string cHeight = "";
        string sSavePath = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        void GenerateImage(string tmp1, string tmp2)
        {
            Response.Clear();
            string[] arrX = tmp1.Split(',');
            string[] arrY = tmp2.Split(',');

            int CurrX = 0;
            int CurrY = 0;

            int NextX = 0;
            int NextY = 0;

            int currCount = 0;

            bool isErr = false;

            Bitmap bmp = new Bitmap(Convert.ToInt32(cWidth), Convert.ToInt32(cHeight), PixelFormat.Format24bppRgb);
            Graphics g = null;

            try
            {
                g = Graphics.FromImage(bmp);

                g.FillRectangle(new SolidBrush(Color.FromName(bgcolor)), 0, 0, bmp.Width, bmp.Height);

                Pen pn = new Pen(new SolidBrush(Color.FromName(pcolor)), Convert.ToInt32(pwidth));

                for (int i = 0; i <= arrX.Length - 4; i++)
                {

                    if (IsNumeric(arrX[i], arrY[i], arrX[i + 1], arrY[i + 1]))
                    {
                        CurrX = Convert.ToInt32(arrX[i]);
                        CurrY = Convert.ToInt32(arrY[i]);

                        currCount = i;

                        NextX = Convert.ToInt32(arrX[i + 1]);
                        NextY = Convert.ToInt32(arrY[i + 1]);

                        g.DrawLine(pn, CurrX, CurrY, NextX, NextY);
                    }
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                isErr = true;
            }
            finally
            {
                if (null != g)
                    g.Dispose();
            }

            string formatExt = signaturefile.Split('.')[1];

            try
            {
                ImageFormat imgFormat = ParseImageFormat(formatExt);
                string outPath = Server.MapPath(sSavePath) + "/" + signaturefile;

                bmp.Save(outPath, imgFormat);

                if (Color.FromName(bgcolor) == Color.White && imgFormat == ImageFormat.Gif)
                {
                    MakeTransparent(outPath);
                }

                Response.ContentType = "image/" + formatExt;
                bmp.Save(Response.OutputStream, imgFormat);

                // dispose bitmap object 
                bmp.Dispose();
                Response.End();
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                Response.Write(err);
                isErr = true;
            }

        }

        private Bitmap MakeTransparent(string outPath)
        {
            Bitmap bmpIn = new Bitmap(outPath);

            try
            {
                ImageAttributes mImageAttributes = new ImageAttributes();
                mImageAttributes.SetColorKey(bmpIn.GetPixel(0, 0), bmpIn.GetPixel(0, 0));
                Rectangle dstRect = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

                Bitmap bmnew = new Bitmap(bmpIn.Width, bmpIn.Height);
                Graphics g = Graphics.FromImage(bmnew);
                g.DrawImage(bmpIn, dstRect, 0, 0, bmpIn.Width, bmpIn.Height, GraphicsUnit.Pixel, mImageAttributes);

                bmpIn.Dispose();
                System.IO.File.Delete(outPath);
                bmnew.Save(outPath);
                return bmnew;
            }
            catch (Exception ex)
            {
                string transErr = ex.Message.ToString();
            }
            return bmpIn;
        }

        bool IsNumeric(string str1, string str2, string str3, string str4)
        {
            try
            {
                int i = Convert.ToInt32(str1);
                i = Convert.ToInt32(str2);
                i = Convert.ToInt32(str3);
                i = Convert.ToInt32(str4);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private ImageFormat ParseImageFormat(string format)
        {
            switch (format.ToLower())
            {
                case "jpg":
                    return ImageFormat.Jpeg;
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "bmp":
                    return ImageFormat.Bmp;
                case "gif":
                    return ImageFormat.Gif;
                case "png":
                    return ImageFormat.Png;
                case "tiff":
                    return ImageFormat.Tiff;
                case "wmf":
                    return ImageFormat.Wmf;
                case "emf":
                    return ImageFormat.Emf;
                case "icon":
                    return ImageFormat.Icon;
                case "ico":
                    return ImageFormat.Icon;
                case "exif":
                    return ImageFormat.Exif;
                default:
                    return ImageFormat.Jpeg;
            }

        }
    }
}