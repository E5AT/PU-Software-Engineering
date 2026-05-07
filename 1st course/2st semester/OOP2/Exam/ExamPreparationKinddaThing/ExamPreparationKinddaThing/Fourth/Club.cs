using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparationKinddaThing.Fourth
{
    public class Club
    {
        private List<Subscriber> subscribers;

        public Club()
        {
            subscribers = new List<Subscriber>();
        }

        public void Add(Subscriber subscriber)
        {
            if (subscriber == null)
                throw new ArgumentException();
            
            subscribers.Add(subscriber);
        }

        public bool Remove(string cardNum)
        {
            Subscriber subscriberToRemove = Search(cardNum);
            
            if (subscriberToRemove == null)
                return false;
            
            subscribers.Remove(subscriberToRemove);
            return true;
        }

        public Subscriber Search(string cardNum) =>
            subscribers.Where(s=>s.CardNum == cardNum).FirstOrDefault();

        public void PrintAll()
        {
            foreach (Subscriber subscriber in subscribers)
                Console.WriteLine(subscriber.GetType());
        }

        public double GetTotalProfit() =>
            subscribers.Select(s => s.MonthlyFee).Sum();

        public Sporthsman SporthsmanWithMaxExercises()
        {
            List<Sporthsman> sporthsmans =
                subscribers.Where(s => s.GetInfo() == "Спортист").Select(s => (Sporthsman)s).ToList();

            return sporthsmans.Where(s => s.CountExercises == sporthsmans.Max(sp => sp.CountExercises))
                .FirstOrDefault();
        }
    }
}