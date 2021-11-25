using System;

namespace HouseBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator.CreateBuild();
            House newHouse = Creator.GetHouseById(1);
            Console.WriteLine(newHouse.GetFloors());

            newHouse.SetFloors(2);
            Console.WriteLine(newHouse.GetFloors());

            Console.WriteLine(newHouse.HeightMetersFloor());

            Console.ReadLine();
        }
    }
}
