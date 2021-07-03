using MarsRoverProject.Interfaces;

namespace MarsRoverProject.Models
{
    public class RoverModel : IRover
    {
        private PlateauModel _plateau;
        private PositionModel _position;
        private DirectionsEnum _headDirection = Proccess.HeadDirection;

        public RoverModel(PlateauModel plateau, PositionModel position, DirectionsEnum headDirection)
        {
            _plateau = plateau;
            _position = position;
            _headDirection = HeadDirection;
        }

        public PlateauModel plateau
        {
            get { return _plateau; }

            set { _plateau = value; }
        }

        public PositionModel position
        {
            get { return _position; }

            set { _position = value; }
        }

        public DirectionsEnum HeadDirection
        {
            get { return _headDirection; }

            set { _headDirection = value; }
        }
    }
}
