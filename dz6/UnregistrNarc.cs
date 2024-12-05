using System;

namespace dz6
{
    // Класс "Незарегистрированное вещество"
    class UnregisteredNarcotic : Narcotic
    {
        public string Buyer { get; set; } // Покупатель
        public UnregisteredNarcotic(string name, double potency, int legalLimit, double pricePerGram)
        {
            Name = name;
            Potency = potency;
            LegalLimit = legalLimit;
            PricePerGram = pricePerGram;
        }
        public UnregisteredNarcotic(string name, double potency, int legalLimit, double pricePerGram, string buyer)
        {
            Name = name;
            Potency = potency;
            LegalLimit = legalLimit;
            PricePerGram = pricePerGram;
            Buyer = buyer;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Вещество: {Name}, Концентрация: {Potency}, Легальный лимит: {LegalLimit}, Цена за грамм: {PricePerGram}, Покупатель: {Buyer}");
        }
        public void UpdateBuyer(string newBuyer)
        {
            Buyer = newBuyer;
        }
    }
}
