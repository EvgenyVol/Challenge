using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Catel.MVVM;

namespace ConvolutionWpf.Commands
{
    public class FlipCommand : Command
    {
        private readonly Func<WriteableBitmap> _imageFactory;

        public FlipCommand(Func<WriteableBitmap> imageFactory)
            : base(() => { })
        {
            _imageFactory = imageFactory;
        }

        private static bool isHorizontalFlip = true;

        public void ExecuteCommand()
        {
            var image = _imageFactory();
            if (image == null)
                return;

            var pixels = new byte[image.PixelHeight * image.BackBufferStride];
            image.CopyPixels(pixels, image.BackBufferStride, 0);

            var resultPixels = new byte[2 * image.PixelHeight * image.BackBufferStride];
            

            //int index = j * image.BackBufferStride + 4 * i;
            //todo
            for (int i = 0; i < image.PixelWidth; ++i)
            {
                for (int j = 0; j < image.PixelHeight ; ++j)
                {
                    int index = j * image.BackBufferStride + 4 * i;
                    int indexRes;

                    if (isHorizontalFlip)
                    {
                        indexRes = j * image.BackBufferStride + image.BackBufferStride - 4 * i;
                    }
                    else
                    {
                        indexRes = image.BackBufferStride * image.PixelHeight - j * image.BackBufferStride + image.BackBufferStride - 4 * i;
                    }
                    for (int k = 0; k < 3; ++k)
                    {
                        resultPixels[indexRes + k] = pixels[index + k];
                    }

                    resultPixels[index + 3] = pixels[index + 3];
                }
            }

            isHorizontalFlip = !isHorizontalFlip;
        
            image.WritePixels(new Int32Rect(0, 0, image.PixelWidth, image.PixelHeight), resultPixels, image.BackBufferStride, 0);
        }

        protected override void Execute(object parameter, bool ignoreCanExecuteCheck)
        {
            ExecuteCommand();
        }
    }
}