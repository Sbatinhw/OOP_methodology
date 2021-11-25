using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuild
{
    class House
    {
        private static int lastId = 0;

        private int id;
        private double heightMeters;
        private int floors;
        private int apartments;
        private int entrances;

        public House()
        {
            this.id = NewId();
        }

        public House(
            double heighMeters,
            int floors,
            int apartaments,
            int entrances)
        {
            this.id = NewId();
            this.heightMeters = heighMeters;
            this.floors = floors;
            this.apartments = apartaments;
            this.entrances = entrances;
        }

        public string GetId()
        {
            return id.ToString();
        }

        public string GetHeighMeters()
        {
            return heightMeters.ToString();
        }

        public void SetHeighMeters(double heighMeters)
        {
            this.heightMeters = heighMeters;
        }

        public string GetFloors()
        {
            return floors.ToString();
        }

        public void SetFloors(int floors)
        {
            this.floors = floors;
        }

        public string GetApartments()
        {
            return apartments.ToString();
        }

        public void SetApartments(int apartments)
        {
            this.apartments = apartments;
        }

        public string GetEntrances()
        {
            return entrances.ToString();
        }

        public void SetEntrances(int entrances)
        {
            this.entrances = entrances;
        }



        public int NumApartamentsInEntrancesInFloor()
        {
            return NumApartamentsInEntrances() / floors;
        }

        public int NumApartamentsInEntrances()
        {
            return apartments / entrances;
        }

        public double HeightMetersFloor()
        {
            return heightMeters / (double)floors;
        }

        private int NewId()
        {
            lastId = lastId + 1;
            return lastId;
        }
    }
}
