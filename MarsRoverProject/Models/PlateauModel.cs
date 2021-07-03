using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Models
{
    public class PlateauModel : IPlateau
    {
        private int minWidth;
        private int minHeight;
        private int width;
        private int height;

        public PlateauModel(int Width, int Height)
        {
            minWidth = 0;
            minHeight = 0;
            width = Width;
            height = Height;
        }

        public int MinWidth
        {
            get { return minWidth; }

            set { minWidth = value; }
        }

        public int MinHeight
        {
            get { return minHeight; }

            set { minHeight = value; }
        }

        public int Width
        {
            get { return width; }

            set { width = value; }
        }

        public int Height
        {
            get { return height; }

            set { height = value; }
        }
    }
}
