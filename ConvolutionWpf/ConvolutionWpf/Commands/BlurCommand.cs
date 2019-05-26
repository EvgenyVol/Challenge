using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Catel.MVVM;

namespace ConvolutionWpf.Commands
{
    public class BlurCommand : Command
    {
        private readonly Func<WriteableBitmap> _imageFactory;

        public BlurCommand(Func<WriteableBitmap> imageFactory)
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

            int kernel = 5;

            for (int i = 0; i < image.PixelWidth - kernel; i++)
            {
                for (int j = 0; j < image.PixelHeight - kernel; j++)
                {
                    int index = j * image.BackBufferStride + 4 * i;
                    
                    for (int c = 0; c < 3; c++)
                    {
                        int blurPixel = 0;
                        for (int m = 0; m < kernel; m++)
                        {
                            for (int n = 0; n < kernel; n++)
                            {
                                blurPixel += pixels[index + c + n * 4 + m * image.BackBufferStride];
                            }
                        }
                        resultPixels[index + c] = (byte)(blurPixel / (kernel * kernel));
                    }
                    resultPixels[index + 3] = resultPixels[index + 3];
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