using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Auto_parking
{
    class FindContours
    {
        public int count = 0;
        /// <summary>
        /// Method used to process the image and set the output result images.
        /// </summary>
        /// <param name="colorImage">Source color image.</param>
        /// <param name="thresholdValue">Value used for thresholding.</param>
        /// <param name="processedGray">Resulting gray image.</param>
        /// <param name="processedColor">Resulting color image.</param>
        public int IdentifyContours(Bitmap colorImage, int thresholdValue, bool invert, out Bitmap processedGray, out Bitmap processedColor, out List<Rectangle> list)
        {
            List<Rectangle> listR = new List<Rectangle>();
            #region Conversion To grayscale
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            //grayImage = grayImage.Resize(400, 400, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            Image<Gray, byte> bi = new Image<Gray, byte>(grayImage.Width, grayImage.Height);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);

            #endregion


            #region  Image normalization and inversion (if required)

            ////CvInvoke.cvAdaptiveThreshold(grayImage, grayImage, 255,
            ////    Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY, 21, 2);
            ////string ff = grayImage.GetAverage().Intensity;

            ////grayImage = grayImage.ThresholdBinary(new Gray(grayImage.GetAverage().Intensity / 2.5), new Gray(255));

            ////double thr = cout_avg(grayImage) / 1.5;
            //double thr = cout_avg_new(grayImage)/1.5;
            //grayImage = grayImage.ThresholdBinary(new Gray(thr), new Gray(255));
            ////grayImage = grayImage.Dilate(3);
            //if (invert)
            //{
            //    grayImage._Not();
            //}
            //#endregion

            //#region Extracting the Contours
            //using (MemStorage storage = new MemStorage())
            //{

            //    Contour<Point> contours = grayImage.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
            //    while (contours != null)
            //    {

            //        Rectangle rect = contours.BoundingRectangle;
            //        //Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);
            //        //color.Draw(currentContour.BoundingRectangle, new Bgr(0, 255, 0), 1);
            //        CvInvoke.cvDrawContours(color, contours, new MCvScalar(255, 255, 0), new MCvScalar(0), -1, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
            //        if (rect.Width > 20 && rect.Width < 150
            //            && rect.Height > 80 && rect.Height < 150)
            //        {
            //            count++;
            //            Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);
            //            CvInvoke.cvDrawContours(color, contours, new MCvScalar(0,255,255), new MCvScalar(255), -1, 3, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));

            //            color.Draw(contours.BoundingRectangle, new Bgr(0, 255, 0), 2);
            //            bi.Draw(contours, new Gray(255), -1);
            //            listR.Add(contours.BoundingRectangle);


            //        }

            //        contours = contours.HNext;

            //    }
            //    for (int i = 0; i < count; i++)
            //    {
            //        for (int j = i + 1; j < count; j++)
            //        {
            //            if(  (listR[j].X < (listR[i].X + listR[i].Width) && listR[j].X > listR[i].X)
            //                && (listR[j].Y < (listR[i].Y + listR[i].Width) && listR[j].Y > listR[i].Y)  )
            //            {
            //                listR.RemoveAt(j);
            //                count--;
            //                j --;
            //            }
            //            else if(  (listR[i].X < (listR[j].X + listR[j].Width) && listR[i].X > listR[j].X)
            //                && (listR[i].Y < (listR[j].Y + listR[j].Width) && listR[i].Y > listR[j].Y))
            //            {
            //                listR.RemoveAt(i);
            //                count--;
            //                i--;
            //                break;
            //            }

            //        }
            //    }
            //}
            #endregion

            #region tim gia tri thresh de co so ky tu lon nhat

            //Image<Gray, byte> bi2 = new Image<Gray, byte>(grayImage.Width, grayImage.Height);
            //Image<Bgr, byte> color2 = new Image<Bgr, byte>(colorImage);
            //double thr = cout_avg_new(grayImage);
            double thr = 0;
            if (thr == 0)
            {
                thr = grayImage.GetAverage().Intensity;
            }
            //double thr = 50;
            //double min = 0, max = 255;
            //if (thr - 80 > 0)
            //{
            //    min = thr - 80;
            //}
            //if (thr + 80 < 255)
            //{
            //    max = thr + 80;
            //}
            //List<Rectangle> list_best = null;
            Rectangle[] li = new Rectangle[9];
            Image<Bgr, byte> color_b = new Image<Bgr, byte>(colorImage); ;
            Image<Gray, byte> src_b = grayImage.Clone();
            Image<Gray, byte> bi_b = bi.Clone();
            Image<Bgr, byte> color2;
            Image<Gray, byte> src;
            Image<Gray, byte> bi2;
            int c = 0, c_best = 0;
            //IntPtr a = color_b.Ptr;
            //CvInvoke.cvReleaseImage(ref a);
            for (double value = 0; value <= 127; value += 3)
            {
                for (int s = -1; s <= 1 && s + value != 1; s += 2)
                {
                    color2 = new Image<Bgr, byte>(colorImage);
                    //src = grayImage.Clone();
                    bi2 = bi.Clone();
                    listR.Clear();
                    //list_best.Clear();
                    c = 0;
                    double t = 127 + value * s;
                    src = grayImage.ThresholdBinary(new Gray(t), new Gray(255));

                    using (MemStorage storage = new MemStorage())
                    {

                        Contour<Point> contours = src.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                        while (contours != null)
                        {

                            Rectangle rect = contours.BoundingRectangle;
                            CvInvoke.cvDrawContours(color2, contours, new MCvScalar(255, 255, 0), new MCvScalar(0), -1, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            double ratio = (double)rect.Width / rect.Height;
                            if (rect.Width > 20 && rect.Width < 150
                                && rect.Height > 80 && rect.Height < 180
                                && ratio > 0.1 && ratio < 1.1 && rect.X > 20)
                            {
                                c++;
                                CvInvoke.cvDrawContours(color2, contours, new MCvScalar(0, 255, 255), new MCvScalar(255), -1, 3, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));

                                color2.Draw(contours.BoundingRectangle, new Bgr(0, 255, 0), 2);
                                bi2.Draw(contours, new Gray(255), -1);
                                listR.Add(contours.BoundingRectangle);


                            }

                            contours = contours.HNext;

                        }
                    }
                    //IntPtr a = color_b.Ptr;
                    //CvInvoke.cvReleaseImage(ref a);
                    double avg_h = 0;
                    double dis = 0;
                    for (int i = 0; i < c; i++)
                    {
                        avg_h += listR[i].Height;
                        for (int j = i + 1; j < c; j++)
                        {
                            if ((listR[j].X < (listR[i].X + listR[i].Width) && listR[j].X > listR[i].X)
                                && (listR[j].Y < (listR[i].Y + listR[i].Width) && listR[j].Y > listR[i].Y))
                            {
                                //avg_h -= listR[j].Height;
                                listR.RemoveAt(j);
                                c--;
                                j--;
                            }
                            else if ((listR[i].X < (listR[j].X + listR[j].Width) && listR[i].X > listR[j].X)
                                && (listR[i].Y < (listR[j].Y + listR[j].Width) && listR[i].Y > listR[j].Y))
                            {
                                avg_h -= listR[i].Height;
                                listR.RemoveAt(i);
                                c--;
                                i--;
                                break;
                            }

                        }
                    }
                    avg_h = avg_h / c;
                    for (int i = 0; i < c; i++)
                    {
                        dis += Math.Abs(avg_h - listR[i].Height);
                    }

                    if (c <= 8 && c > 1 && c > c_best && dis <= c * 8)
                    {
                        listR.CopyTo(li);
                        c_best = c;
                        color_b = color2;
                        bi_b = bi2;
                        src_b = src;
                        //dis_b = dis;
                        //if (c == 8)
                        //{
                        //    break;
                        //}
                    }
                }
                if (c_best == 8) break;
            }

            count = c_best;
            grayImage = src_b;
            color = color_b;
            bi = bi_b;
            listR.Clear();
            for (int i = 0; i < li.Length; i++)
            {
                if (li[i].Height != 0) listR.Add(li[i]);
            }



            #endregion

            #region Asigning output
            processedColor = color.ToBitmap();
            processedGray = grayImage.ToBitmap();
            list = listR;
            #endregion
            return count;
        }
        private double cout_avg(Image<Gray, byte> src)
        {
            double d = 0;
            List<Rectangle> lsR = new List<Rectangle>();
            Image<Gray, byte> grayImage = new Image<Gray, byte>(src.Width, src.Height);
            CvInvoke.cvAdaptiveThreshold(src, grayImage, 255,
                Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY, 21, 2);
            grayImage = grayImage.Dilate(3);
            grayImage = grayImage.Erode(3);

            using (MemStorage storage = new MemStorage())
            {
                Contour<Point> contours = grayImage.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                while (contours != null)
                {

                    Rectangle rect = contours.BoundingRectangle;

                    if (rect.Width > 50 && rect.Width < 150
                        && rect.Height > 80 && rect.Height < 150)
                    {
                        lsR.Add(rect);
                    }
                    contours = contours.HNext;
                }
            }

            for (int i = 0; i < lsR.Count; i++)
            {
                Bitmap tmp = src.ToBitmap();
                Bitmap tmp2 = tmp.Clone(lsR[i], tmp.PixelFormat);
                Image<Gray, byte> tmp3 = new Image<Gray, byte>(tmp2);
                d += tmp3.GetAverage().Intensity / lsR.Count;
            }

            return d;
        }
        private double cout_avg_new(Image<Gray, byte> src)
        {
            double d = 0;
            List<Rectangle> lsR = new List<Rectangle>();
            Image<Gray, byte> grayImage = new Image<Gray, byte>(src.Width, src.Height);

            CvInvoke.cvAdaptiveThreshold(src, grayImage, 255,
                Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, Emgu.CV.CvEnum.THRESH.CV_THRESH_BINARY, 21, 2);

            grayImage = grayImage.Dilate(3);
            grayImage = grayImage.Erode(3);

            using (MemStorage storage = new MemStorage())
            {
                Contour<Point> contours = grayImage.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                while (contours != null)
                {

                    Rectangle rect = contours.BoundingRectangle;
                    if (rect.Width > 50 && rect.Width < 150
                        && rect.Height > 80 && rect.Height < 150)
                    {
                        lsR.Add(rect);
                    }
                    contours = contours.HNext;
                }
            }

            for (int i = 0; i < lsR.Count; i++)
            {
                Bitmap tmp = src.ToBitmap();
                Bitmap tmp2 = tmp.Clone(lsR[i], tmp.PixelFormat);
                Image<Gray, byte> tmp3 = new Image<Gray, byte>(tmp2);
                int T = 0;
                int T0 = 128;
                do
                {
                    T = T0;
                    int m = 0, M = 0;
                    int min = 0, max = 0;
                    for (int y = 0; y < tmp3.Rows; y++)
                        for (int x = 0; x < tmp3.Cols; x++)
                        {
                            int value = (int)tmp3.Data[y, x, 0];
                            if (value <= T)
                            {
                                m++;
                                min += value;
                            }
                            else
                            {
                                M++;
                                max += value;
                            }
                        }
                    T0 = (min / m + max / M) / 2;
                } while (T - T0 > 1 || T0 - T > 1);


                d += (double)T0 / (double)lsR.Count;
            }

            return d;
        }

        private Image<Gray, byte> search(double thr, Image<Gray, byte> grayImage, double min, double max
            , out List<Rectangle> list_out, out int count, Image<Bgr, byte> color, out Image<Bgr, byte> color_out,
            Image<Gray, byte> bi, out Image<Gray, byte> bi_out)
        {
            List<Rectangle> listR = null, list_best = null;
            Image<Bgr, byte> color2 = color;
            Image<Gray, byte> src = grayImage;
            Image<Gray, byte> bi2 = bi;

            int c = 0, c_best = 0;
            for (double value = min; value <= max; value += 0.1)
            {

                double t = thr / value;
                src = grayImage.ThresholdBinary(new Gray(t), new Gray(255));

                using (MemStorage storage = new MemStorage())
                {

                    Contour<Point> contours = src.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                    while (contours != null)
                    {

                        Rectangle rect = contours.BoundingRectangle;
                        CvInvoke.cvDrawContours(color2, contours, new MCvScalar(255, 255, 0), new MCvScalar(0), -1, 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                        if (rect.Width > 20 && rect.Width < 150
                            && rect.Height > 80 && rect.Height < 150)
                        {
                            c++;
                            CvInvoke.cvDrawContours(color2, contours, new MCvScalar(0, 255, 255), new MCvScalar(255), -1, 3, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));

                            color2.Draw(contours.BoundingRectangle, new Bgr(0, 255, 0), 2);
                            bi2.Draw(contours, new Gray(255), -1);
                            listR.Add(contours.BoundingRectangle);


                        }

                        contours = contours.HNext;

                    }
                    for (int i = 0; i < c; i++)
                    {
                        for (int j = i + 1; j < c; j++)
                        {
                            if ((listR[j].X < (listR[i].X + listR[i].Width) && listR[j].X > listR[i].X)
                                && (listR[j].Y < (listR[i].Y + listR[i].Width) && listR[j].Y > listR[i].Y))
                            {
                                listR.RemoveAt(j);
                                c--;
                                j--;
                            }
                            else if ((listR[i].X < (listR[j].X + listR[j].Width) && listR[i].X > listR[j].X)
                                && (listR[i].Y < (listR[j].Y + listR[j].Width) && listR[i].Y > listR[j].Y))
                            {
                                listR.RemoveAt(i);
                                c--;
                                i--;
                                break;
                            }

                        }
                    }
                }
                if (c <= 8 && c > c_best)
                {
                    list_best = listR;
                    c_best = c;
                    if (c == 8)
                    {
                        color_out = color2;
                        bi_out = bi2;
                        list_out = list_best;
                        count = c_best;
                        return src;
                    }
                }
            }
            color_out = color2;
            bi_out = bi2;
            list_out = list_best;
            count = c_best;
            return src;
        }
    }
}
