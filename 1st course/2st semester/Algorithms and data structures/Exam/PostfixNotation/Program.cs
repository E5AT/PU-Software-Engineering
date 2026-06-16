namespace PostfixNotation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SolveProblem("1 17 * 1 + 2 /"));
    }

    static double SolveProblem(string text)
    {
        Stack<double> stack = new();

        foreach(string el in text.Split(' '))
        {
            double num;
            if(double.TryParse(el, out num))
            {
                stack.Push(num);
            }
            else
            {

                if(stack.Count < 2)
                {
                    throw new Exception("Invalid notation!");
                }

                double first, second;
                second = stack.Pop();
                first = stack.Pop();

                switch(el)
                {
                    case "+":
                        stack.Push(first+second);
                        break;
                    case "-":
                        stack.Push(first-second);
                        break;
                    case "*":
                        stack.Push(first*second);
                        break;
                    case "/":
                        if(second == 0)
                            throw new InvalidOperationException("Cannot divide to zero");
                        stack.Push(first/second);
                        break;
                    default:
                        throw new InvalidOperationException("Not a valid operation");
                }
            }
        }
        if(stack.Count != 1)
            throw new Exception("Invalid notation!");

        return stack.Pop();
    }
}
