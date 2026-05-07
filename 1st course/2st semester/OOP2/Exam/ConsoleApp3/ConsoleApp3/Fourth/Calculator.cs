using System;
using System.Collections.Generic;

namespace ConsoleApp3.Fourth
{
    public class Calculator
    {
        private double first, second, result;
        private List<string> history;

        public double First
        {
            get => first;
            set =>
                first = value;
        }

        public double Second
        {
            get => second;
            set =>
                second = value;
        }

        public Calculator(double first, double second)
        {
            First = first;
            Second = second;
            history = new List<string>();
        }

        public void ChangeFirst(double first)
        {
            First = first;
        }

        public void ChangeSecond(double second)
        {
            Second = second;
        }

        public void Add()
        {
            result =  First + Second;
            history.Add("Addition");
        }

        public void Subtract()
        {
            result = First - Second;
            history.Add("Subtraction");
        }

        public void Multiply()
        {
            result = First * Second;
            history.Add("Multiplication");
        }

        public void Divide()
        {
            if(Second == 0)
                Console.WriteLine("The second num must be not equal to zero.");
            else
            {
                result = First / Second;
                history.Add("Division");
            }
        }

        public void PrintResult()
        {
            Console.WriteLine(result);
        }

        public void PrintHistory()
        {
            foreach(string el in history)
                Console.WriteLine(el);
        }

        public void ClearHistory()
        {
            history.Clear();
        }
    }
}