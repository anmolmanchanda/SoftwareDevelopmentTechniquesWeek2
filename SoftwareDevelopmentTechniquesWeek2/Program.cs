using System;

namespace SoftwareDevelopmentTechniquesWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }


        enum MyChoice
        {
            Case1, Case2
        }


        enum MyChoices
        {
            Apples = 5, Grapes, Oranges
        }


        public void Go()
        {
            /*int x = 0;
            int y = 1;
            int z = 2;
            if ((x >= y) || (z > y))
            {
                Console.WriteLine("here");
            } else
            {
                Console.WriteLine("there");
            }*/


            /*int i = 3;
            do
            {
                Console.WriteLine("In Loop");
                i++;
                if (i > 3)
                {
                    break;
                }
            } while (true); */


            /*int i = 0;
            switch(i)
            {
                case 0: Console.WriteLine("I=0");
                    break;
                case 1: Console.WriteLine("I=1");
                    break;
                default: Console.WriteLine("Something else");
                    break;
            }*/


            /*MyChoice i = MyChoice.Case1;
            switch(i)
            {
                case MyChoice.Case1: Console.WriteLine("I=0");
                    break;
                case MyChoice.Case2: Console.WriteLine("I=1");
                    break;
                default: Console.WriteLine("Something else");
                    break;
            }*/


            /*MyChoices choice = MyChoices.Apples;
            switch (choice)
            {
                case MyChoices.Apples: Console.WriteLine("You chose Apples");
                    break;
                case MyChoices.Grapes: Console.WriteLine("You chose Grapes");
                    break;
                default: Console.WriteLine("Poor choice");
                    break;
            }*/


            /*var values = Enum.GetValues(typeof(MyChoices));
            foreach (MyChoices choice in values)
            {
                Console.WriteLine(choice);
            }*/


            /*Console.WriteLine("We went to the market!");
            decimal totalSpent = 0;
            var values = Enum.GetValues(typeof(MyChoices));
            foreach (MyChoices choice in values)
            {
                Console.WriteLine("We bought {0}", choice);
                Console.Write("How many kilos? ");
                string weightString = Console.ReadLine();
                decimal weight = decimal.Parse(weightString);
                if (weight > 0)
                {
                    Console.Write("At what cost per kilo? ");
                    string moneyString = Console.ReadLine();
                    decimal price = decimal.Parse(moneyString);
                    Console.WriteLine("We spent on {0} {1} dollars",
                        choice, (price * weight).ToString("c"));
                    totalSpent += price * weight;
                }
            }
            Console.WriteLine("We spent total of {0}", totalSpent.ToString("c   "));*/


            /*int i = 0;
            Console.WriteLine("Type of I is {0}", i.GetType());
            decimal d = 0;
            Console.WriteLine("Type of D is {0}", d.GetType());
            Console.WriteLine("Are types the same? {0}", (i.GetType() == d.GetType()));
            Console.WriteLine("Is I an Integer? {0}", (i.GetType() == typeof(int)));*/


            var names = Enum.GetNames(typeof(MyChoices));
            foreach (string name in names)
            {
                int price = (int)Enum.Parse(typeof(MyChoices), name);
                Console.WriteLine("We saw {0} by {1} a kilo", name, price.ToString("c"));
            }
        }
    }
}
