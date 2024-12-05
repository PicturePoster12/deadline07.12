using System;
namespace dz6
{
    // Класс "Система учета веществ"
    class NarcoticTrackingSystem
    {
        public List<Narcotic> Narcotics { get; set; } = new List<Narcotic>();

        public void AddNarcotic(Narcotic narcotic)
        {
            Narcotics.Add(narcotic);
        }
        public void DisplayAllNarcotics()
        {
            foreach (var narcotic in Narcotics)
            {
                narcotic.DisplayInfo();
            }
        }
        public List<Narcotic> GetOverLimitNarcotics(int limit)
        {
            var result = new List<Narcotic>();
            foreach (var narcotic in Narcotics)
            {
                if (narcotic.IsOverLimit(limit))
                {
                    result.Add(narcotic);
                }
            }
            return result;
        }
    }
}
