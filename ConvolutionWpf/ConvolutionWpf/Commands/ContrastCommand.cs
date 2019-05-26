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
            var histogram = new Int32[256];
            var cumHistogram = histogram;
            var p = 0.005;
            var numPixel = image.PixelHeight * image.PixelWidth;
            var alphaLow = 0;
            var alphaHigh = 255;

            for (int i = 0; i < image.PixelHeight - 3; i++)
            {
                for (int j = 0; j < image.PixelWidth - 3; j++)
                {
                    int index = i * image.BackBufferStride + 4 * j + 3;
                    histogram[pixels[index]] += 1;
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
                    break;
                }
            }

            for (int i = 0; i < image.PixelHeight; i++)
            {
                for (int j = 0; j < image.PixelWidth; j++)
                {
                    int index = i * image.BackBufferStride + 4 * j;

                    for (int c = 0; c < 3; c++)
                    {
                        resultPixels[index + c] = pixels[index + c];
                    }
                    if (pixels[index + 3] <= alphaLow)
                    {
                        resultPixels[index + 3] = 0;
                    }
                    else if (pixels[index + 3] >= alphaHigh)
                    {
                        resultPixels[index + 3] = 255;
                    }
                    else
                    {
                        resultPixels[index + 3] = (byte)((pixels[index + 3] - alphaLow) / ((alphaHigh - alphaLow) * 255));
                    }
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