using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Catel.MVVM;

namespace ConvolutionWpf.Commands
{
    public class ContrastCommand : Command
    {
        private readonly Func<WriteableBitmap> _imageFactory;

        public ContrastCommand(Func<WriteableBitmap> imageFactory)
            : base(() => { })
        {
            _imageFactory = imageFactory;
        }

        public void ExecuteCommand()
        {
            var image = _imageFactory();
            if (image == null)
                return;

            var pixels = new byte[image.PixelHeight * image.BackBufferStride];
            image.CopyPixels(pixels, image.BackBufferStride, 0);

            var resultPixels = new byte[image.PixelHeight * image.BackBufferStride];

            //int index = j * image.BackBufferStride + 4 * i;
            //todo
            var histogram = new int[256];
            var histogram2 = new int[256];
            var cumHistogram = histogram;
            var p = 0.005;
            var numPixel = image.PixelHeight * image.PixelWidth * 3;
            var alphaLow = 0;
            var alphaHigh = 255;

            for (int i = 0; i < image.PixelHeight; i++)
            {
                for (int j = 0; j < image.PixelWidth; j++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        int index = i * image.BackBufferStride + 4 * j;
                        histogram[pixels[index + c]] += 1;
                    }
                }
            }

            for (int i = 1; i < 256; i++)
            {
                cumHistogram[i] = cumHistogram[i - 1] + cumHistogram[i];
            }

            for (int i = 0; i < 256; i++)
            {
                if (cumHistogram[i] > numPixel * p)
                {
                    alphaLow = i;
                    break ;
                }
            }

            for (int i = 255; i >= 0; i--)
            {
                if (cumHistogram[i] <= numPixel * (1 - p))
                {
                    alphaHigh = i;
                    break ;
                }
            }

            for (int i = 0; i < image.PixelHeight; i++)
            {
                for (int j = 0; j < image.PixelWidth; j++)
                {
                    int index = i * image.BackBufferStride + 4 * j;

                    for (int c = 0; c < 3; c++)
                    {

                        if (pixels[index + c] <= alphaLow)
                        {
                            resultPixels[index + c] = 0;
                        }
                        else if (pixels[index + c] >= alphaHigh)
                        {
                            resultPixels[index + c] = 255;
                        }
                        else
                        {
                            resultPixels[index + c] = (byte)((double)(pixels[index + c] - alphaLow) / (alphaHigh - alphaLow) * 255);
                        }
                    }
                    resultPixels[index + 3] = pixels[index + 3];
                }
            }

            image.WritePixels(new Int32Rect(0, 0, image.PixelWidth, image.PixelHeight), resultPixels, image.BackBufferStride, 0);

        }

        protected override void Execute(object parameter, bool ignoreCanExecuteCheck)
        {
            ExecuteCommand();
        }
    }
}