using System;

namespace ExamPreparationKinddaThing.Fourth
{
    public class Trainer:Subscriber
    {
        private string speciality;
        public string Speciality
        {
            get =>  speciality;
            set => speciality =
                string.IsNullOrEmpty(value)
                ? throw new ArgumentException()
                : value;
        }

        private int yearExperience;
        public int YearExperience
        {
            get => yearExperience;
            set => yearExperience =
                value<0
                ? throw new ArgumentException()
                : value;
        }
        
        public Trainer(string name, string cardNum, double monthlyFee, string speciality, int yearExperience)
            : base(name, cardNum, monthlyFee)
        {
            Speciality = speciality;
            YearExperience = yearExperience;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()},  {Speciality}, {YearExperience} years of experience";
        }

        public string GetType
        {
            get => "Треньор";
        }
    }
}