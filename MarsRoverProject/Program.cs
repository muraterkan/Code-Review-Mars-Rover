using MarsRoverProject.Models;
using System;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Plato Tanımlama
                PlateauModel plateau = new PlateauModel(5, 5);

                // Birinci Rover Pozisyonu
                PositionModel position = new PositionModel(1, 2);
                
                // Rover Oluşturulur
                Proccess proc = new Proccess(plateau, position, DirectionsEnum.N);

                //Nasa Parametresi Programa Gönderilir
                proc.GetNasaCode("LMLMLMLMM");
                Console.WriteLine(proc.GetLastPosition());

                //Daha Önce Tanımlanan Rover Tanımları Değiştirilir
                proc.SetRoverPosition(3, 3, DirectionsEnum.E);
                proc.GetNasaCode("MMRMMRMRRM");
                Console.WriteLine(proc.GetLastPosition());
            }
        }
    }
}
