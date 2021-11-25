using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HouseBuild
{
    static class Creator
    {
        static Hashtable HouseHashTable = new Hashtable();

        public static void CreateBuild()
        {
            House newHouse = new House(2.5, 1, 1, 1);
            AddHouseInHashTable(newHouse);
        }

        public static void CreateBuild(
            double heighMeters,
            int floors,
            int apartaments,
            int entrances)
        {
            House newHouse = new House(heighMeters, floors, apartaments, entrances);
            AddHouseInHashTable(newHouse);
        }

        public static House GetHouseById(int id)
        {
            return (House)HouseHashTable[id.ToString()];
        }

        public static void AddHouseInHashTable(House house)
        {
            HouseHashTable.Add(house.GetId(), house);
        }

        public static void DeleteHouseById(string id)
        {
            HouseHashTable.Remove(id);
        }
    }
}
