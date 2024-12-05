using System;
namespace Tumakov
{
    public class Building
    {
        private int number;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;
        private static int lastNumber = 0;
        public Building(double height = 0, int floors = 0, int apartments = 0, int entrances = 0)
        {
            Number = LastUsedNumber();
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
            if (number <= 0 | height <= 0 | floors <= 0 | apartments <= 0 | entrances <= 0 | apartments % entrances != 0 | apartments % floors != 0)
            {
                throw new ArgumentException();
            } 
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public int Apartments
        {
            get { return apartments; }
            set { apartments = value; }
        }
        public int Entrances
        {
            get { return entrances; }
            set { entrances = value; }
        }
        public double FloorHeight()
        {
            return height / floors;
        }
        public int ApartmentsPerEntranceCount()
        {
            return apartments / entrances;
        }
        public int ApartmentsPerFloorCount()
        {
            return apartments / floors;
        }
        private static int LastUsedNumber()
        {
            return ++lastNumber;
        }
        public void Print()
        {
            Console.WriteLine($"Номер здания: {number}");
            Console.WriteLine($"Высота здания: {height} м");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {FloorHeight():F2} м");
            Console.WriteLine($"Количество квартир на этаже: {ApartmentsPerFloorCount()}");
            Console.WriteLine($"Количество квартир в подъезде: {ApartmentsPerEntranceCount()}");
        }
    }
}
