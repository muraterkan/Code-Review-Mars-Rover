using MarsRoverProject.Models;

namespace MarsRoverProject
{
    public static class MainPlateauClass
    {
        public static bool IsMoveAvailable(this PlateauModel plateau, PositionModel position)
        {
            return plateau.MinWidth 
                <= position.XPosition && position.XPosition 
                <= plateau.Width && plateau.MinHeight 
                <= position.YPosition && position.YPosition 
                <= plateau.Height;
        }
    }
}
