using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Models
{
    public class PositionModel : IPosition
    {
        private int xPosition;
        private int yPosition;

        public PositionModel(int XPosition, int YPosition)
        {
            xPosition = XPosition;
            yPosition = YPosition;
        }

        public int XPosition
        {
            get { return xPosition; }

            set { xPosition = value; }
        }

        public int YPosition
        {
            get { return yPosition; }

            set { yPosition = value; }
        }
    }
}