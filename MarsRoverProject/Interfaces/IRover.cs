using MarsRoverProject.Models;

namespace MarsRoverProject.Interfaces
{
    interface IRover
    {
        PlateauModel plateau { get; set; }

        PositionModel position { get; set; }

        DirectionsEnum HeadDirection { get; set; }
    }
}
