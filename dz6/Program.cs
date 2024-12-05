using System;
namespace dz6
{
    class Program
    {
        static void Main()
        {
            var system = new NarcoticTrackingSystem();
            var registeredNarcotic = new RegisteredNarcotic("Морфин", 80.5, 100, 500, "REG12345", "Фармкомпания А");
            var unregisteredNarcotic = new UnregisteredNarcotic("Фентанил", 95.0, 50, 1000, "Иванов И.И.");
            system.AddNarcotic(registeredNarcotic);
            system.AddNarcotic(unregisteredNarcotic);
            Console.WriteLine("Список всех веществ:");
            system.DisplayAllNarcotics();
            registeredNarcotic.ChangeSupplier("Фармкомпания Б");
            unregisteredNarcotic.UpdateBuyer("Петров П.П.");
            Console.WriteLine("\nОбновленный список веществ:");
            system.DisplayAllNarcotics();
            Console.WriteLine("\nВещества, превышающие лимит в 60 грамм:");
            var overLimit = system.GetOverLimitNarcotics(60);
            foreach (var Narcotic in overLimit)
            {
                Narcotic.DisplayInfo();
            }
        }
    }
}