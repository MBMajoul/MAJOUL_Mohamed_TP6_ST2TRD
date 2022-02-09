using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJOUL_Mohamed_TP6_ST2TRD
{
    public class MainApp
    {
        public static void Main()
        {
            Console.WriteLine("Exercice 1");
            Console.WriteLine("");
            Builder builder;
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            builder = new Margherita();
            pizzaBuilder.Construct(builder);
            builder.Pizza.Show();
            builder = new Reine();
            pizzaBuilder.Construct(builder);
            builder.Pizza.Show();
            builder = new Royale();
            pizzaBuilder.Construct(builder);
            builder.Pizza.Show();
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Exercice 2");
            Console.WriteLine("");
            Collection collection = new Collection();
            collection[0] = new Values(56);
            collection[1] = new Values(2);
            collection[2] = new Values(0);
            collection[3] = new Values(92);
            collection[4] = new Values(2);
            collection[5] = new Values(24);
            collection[6] = new Values(5);
            Iterator iterator = collection.CreateIterator();
            iterator.Step = 1;
            Console.WriteLine("Iterating over collection:");
            for (Values value = iterator.First(); !iterator.IsDone; value = iterator.Next())
            {
                Console.WriteLine(value.Value);
            }
            Console.ReadKey();
        }
    }
}
