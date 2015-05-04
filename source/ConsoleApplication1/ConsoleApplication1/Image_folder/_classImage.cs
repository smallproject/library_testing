using System;
using System.Drawing;
using System.IO;


/*
 * using System.Drawing as reference
 */
namespace ConsoleApplication1
{
    class _classImage
    {
        public void main()
        {
            BasicProperties();
            FromStreamMethod();
            TagProperty();
            AccessesResolution();
        }

        private string ImagePath()
        {
            string path =
                @"C:\git_root\library_testing\source\ConsoleApplication1\ConsoleApplication1\Image_folder\objects\IMG-20150327-WA0002.jpg";

            return path;
        }

        public void BasicProperties()
        {
            Console.WriteLine("Basic Properties");
            string filename = ImagePath();

            using (Image image = Image.FromFile(filename))
            {
                int width = image.Width;
                int height = image.Height;

                Console.WriteLine("File path: {0}", filename);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Height: {0}", height);

                Console.WriteLine("\n\n\n");
            }
        }

        public void FromStreamMethod()
        {
            Console.WriteLine("From Steam Method");
            string filename = ImagePath();
            using (FileStream stream = File.Open(filename, FileMode.Open))
            using (Image image = Image.FromStream(stream))
            {
                Console.WriteLine("Image size: {0}", image.Size);
            }

            Console.WriteLine("\n\n\n");
        }

        public void TagProperty()
        {
            Console.WriteLine("Tag property");
            string filename = ImagePath();
            using (Image image = Image.FromFile(filename))
            {
                image.Tag = "Why you are trying to open this?";
                Console.WriteLine(image.Tag);
            }
            Console.WriteLine("\n\n\n");
        }

        public void AccessesResolution()
        {
            Console.WriteLine("Access Resolution");
            string filename = ImagePath();
            using (Image image = Image.FromFile(filename))
            {
                float horizontal = image.HorizontalResolution;
                float vertical = image.VerticalResolution;

                Console.WriteLine("Horizontal Resolution: {0}", horizontal);
                Console.WriteLine("Vertical Resolution: {0}", vertical);
            }
            Console.WriteLine("\n\n\n");

        }

        public void ImageProperties()
        {
            Console.WriteLine("Full Image Properties");
            string filename = ImagePath();
            using (Image image = Image.FromFile(filename))
            {
                Console.WriteLine("Flags: " + image.Flags);
                Console.WriteLine("Frame Dimensions List: " + image.FrameDimensionsList);
                Console.WriteLine("Height: " + image.Height);
                Console.WriteLine("Horizontal Resolution: " + image.HorizontalResolution);
                Console.WriteLine("Physical Dimension: " + image.PhysicalDimension);
                Console.WriteLine("Pixel Format: " + image.PixelFormat);
                Console.WriteLine("Property Id List: " + image.PropertyIdList);
                Console.WriteLine("Property Items: " + image.PropertyItems);
                Console.WriteLine("Raw Format: " + image.RawFormat);
                Console.WriteLine("Size: " + image.Size);
                Console.WriteLine("Tag: " + image.Tag);
                Console.WriteLine("Vertical Resolution: " + image.VerticalResolution);
                Console.WriteLine("Width: " + image.Width);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
