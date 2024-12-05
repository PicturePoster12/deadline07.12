using System;
namespace dz6
{
    abstract class Narcotic()
    {
        public string Name { get; set; } // Название вещества
        public double Potency { get; set; } // Концентрация вещества
        public int LegalLimit { get; set; } // Легальный предел в граммах
        public double PricePerGram { get; set; } // Цена за грамм
        public abstract void DisplayInfo();
        public bool IsOverLimit(int amount) // Проверка превышения легального лимита
        {
            return amount > LegalLimit;
        }
        public double CalculateCost(int amount)
        {
            return amount * PricePerGram;
        }
    }
}
