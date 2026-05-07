using System;

namespace ExamPreparationKinddaThing.Fourth
{
    public class Sporthsman:Subscriber
    {
        private string sport;
        public string Sport
        {
            get => sport;
            set => sport =
                string.IsNullOrEmpty(value)
                ? throw new ArgumentNullException()
                : value;
        }

        private int countExercises;
        public int CountExercises
        {
            get => countExercises;
            set => countExercises =
                value<1||value>14
                ? throw new ArgumentException()
                : value;
        }

        public Sporthsman(string name, string cardNum, double monthlyFee, string sport, int countExercises)
            : base(name, cardNum, monthlyFee)
        {
            Sport = sport;
            CountExercises = countExercises;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, {Sport}, {CountExercises} exercises";
        }

        public string GetType
        {
            get => "Спортист";
        }
    }
}