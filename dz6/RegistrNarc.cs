using System;
namespace dz6
{
    // Класс "Зарегистрированное вещество"
    class RegisteredNarcotic : Narcotic
    {
        public string RegistrationNumber { get; set; } // Регистрационный номер
        public string Supplier { get; set; } // Поставщик
        public RegisteredNarcotic(string name, double potency, int legalLimit, double pricePerGram)
        {
            Name = name;
            Potency = potency;
            LegalLimit = legalLimit;
            PricePerGram = pricePerGram;
        }
        public RegisteredNarcotic(string name, double potency, int legalLimit, double pricePerGram, string registrationNumber, string supplier)
        {
            Name = name;
            Potency = potency;
            LegalLimit = legalLimit;
            PricePerGram = pricePerGram;
            RegistrationNumber = registrationNumber;
            Supplier = supplier;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Вещество: {Name}, Концентрация: {Potency}, Легальный лимит: {LegalLimit}, Цена за грамм: {PricePerGram}, Регистрационный номер: {RegistrationNumber}, Поставщик: {Supplier}");
        }
        public void ChangeSupplier(string newSupplier)
        {
            Supplier = newSupplier;
        }
    }
}
