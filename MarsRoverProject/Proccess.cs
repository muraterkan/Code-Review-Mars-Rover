using MarsRoverProject.Models;
using System;


namespace MarsRoverProject
{
    public class Proccess
    {
        public static DirectionsEnum HeadDirection = DirectionsEnum.N;

        private readonly PlateauModel _plateau;
        private readonly PositionModel _position;
        private readonly DirectionsEnum _headDirection;

        public Proccess(PlateauModel plateau, PositionModel position, DirectionsEnum headDirection)
        {
            _plateau = plateau;
            _position = position;
            _headDirection = headDirection;
        }

        //İkinci Rover için Nasa Komutları Set Ediliyor
        public void SetRoverPosition(int x, int y, DirectionsEnum direction)
        {
            RoverModel rover = new RoverModel(_plateau, _position, _headDirection);

            if (rover.position == null)
            {
                rover.position = new  PositionModel(x, y);
            }
            else
            {
                rover.position.XPosition = x;
                rover.position.YPosition = y;
            }

            HeadDirection = direction;
        }

        //Nasa'dan Gelen Kod Ayrıştırılıyor 
        public void GetNasaCode(string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
               ProcessDetermination(command[i]);
            }
        }

        //Ayrıştırılan Herbir Kod Switch Döngüsüne Sokularak Hangi Aksiyonun Yapılacağı Buulunuyor.
        public void ProcessDetermination(char command)
        {
            switch (command)
            {
                case 'L':
                    Rotate("L");
                    break;
                case 'R':
                    Rotate("R");
                    break;
                case 'M':
                    Move();
                    break;
                default:
                    Console.WriteLine("Wrong Parameter: " + command);
                    break;
            }
        }

        //Rover'ın Yön değiştiriliyor.
        public void Rotate(string rType)
        {
            if (rType == "L")
            {
                if ((int)HeadDirection - 1 < (int)DirectionsEnum.N)
                {
                    HeadDirection = DirectionsEnum.W;
                }
                else
                {
                    HeadDirection = (DirectionsEnum)((int)HeadDirection - 1);
                }
            }
            else
            {
                if ((int)HeadDirection + 1 > (int)DirectionsEnum.W)
                {
                    HeadDirection = DirectionsEnum.N;
                }
                else
                {
                    HeadDirection = (DirectionsEnum)((int)HeadDirection + 1);
                }
            }
        }

        //Rover Hareket Edecek ve Pozisyonu Modele Kayıt Ediliyor
        public bool Move()
        {
            RoverModel rover = new RoverModel(_plateau, _position, _headDirection);

            if (!rover.plateau.IsMoveAvailable(rover.position))
            {
                return false;
            }

            switch (HeadDirection)
            {
                case DirectionsEnum.N:
                    rover.position.YPosition += 1;
                    break;
                case DirectionsEnum.E:
                    rover.position.XPosition += 1;
                    break;
                case DirectionsEnum.S:
                    rover.position.YPosition -= 1;
                    break;
                case DirectionsEnum.W:
                    rover.position.XPosition -= 1;
                    break;
            }

            return true;
        }

        //Rover'ın Son Durumu Nasa'ya İletiliyor
        public string GetLastPosition()
        {
            RoverModel rover = new RoverModel(_plateau, _position, _headDirection);
            
            return string.Concat(rover.position.XPosition, " ", rover.position.YPosition, " ", rover.HeadDirection);
        }
    }
}
