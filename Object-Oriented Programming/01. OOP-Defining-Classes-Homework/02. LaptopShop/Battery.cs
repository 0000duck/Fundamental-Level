using System;

namespace _02.LaptopShop
{
    public class Battery
    {
        private string type;
        private int numberOfCells;
        private int capacity;
        private double batteryLife;

        public Battery(string type, int numberOfCells, int capacity, double batteryLife)
        {
            this.Type = type;
            this.NumberOfCells = numberOfCells;
            this.Capacity = capacity;
            this.BatteryLife = batteryLife;
        }


        public string Type
        {
            get { return type; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Type info cannot be empty!");
                }

                type = value;
            }
        }

        public int NumberOfCells
        {
            get { return numberOfCells; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The number of cells cannot be negative!");
                }

                numberOfCells = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                   throw new Exception("The capacity cannot be negative!");
                }

                capacity = value;
            }
        }

        public double BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The battery life cannot be negative!");
                }

                batteryLife = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {Type}\n NumberOfCells: {NumberOfCells}\n Capacity: {Capacity}\n BatteryLife: {BatteryLife}\n";
        }
    }
}