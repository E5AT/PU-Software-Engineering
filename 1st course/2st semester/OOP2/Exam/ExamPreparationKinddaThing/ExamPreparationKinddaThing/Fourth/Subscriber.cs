using System;

namespace ExamPreparationKinddaThing.Fourth
{
    public abstract class Subscriber
    {
        private string name;
        public string Name
        {
            get => name;
            set => name =
                value.Length<3
                    ? throw new ArgumentException()
                    : value;
        }

        private string cardNum;
        public string CardNum
        {
            get => cardNum;
            set => cardNum = 
                value.Length<5
                    ? throw new ArgumentException()
                    : value;
        }

        private double monthlyFee;
        public double MonthlyFee
        {
            get=> monthlyFee;
            set => monthlyFee =
                value > 0
                    ? value
                    : throw new ArgumentException();
        }

        public Subscriber(string name, string cardNum, double monthlyFee)
        {
            Name = name;
            CardNum = cardNum;
            MonthlyFee = monthlyFee;
        }

        public virtual string GetInfo()
        {
            return $"{Name}, {CardNum}, {MonthlyFee}$";
        }

        public string GetType;
    }
}