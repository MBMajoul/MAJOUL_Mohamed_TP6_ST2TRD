using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAJOUL_Mohamed_TP6_ST2TRD
{
    class PizzaBuilder
    {
        public void Construct(Builder builder)
        {
            builder.BuildSauce();
            builder.BuildMIngredient();
            builder.BuildSIngredient();
        }
    }
    abstract class Builder
    {
        protected Pizza pizza;
        public Pizza Pizza
        {
            get { return pizza; }
        }
        public abstract void BuildSauce();
        public abstract void BuildMIngredient();
        public abstract void BuildSIngredient();
    }
    class Margherita : Builder
    {
        public Margherita()
        {
            pizza = new Pizza("Margherita");
        }
        public override void BuildSauce()
        {
            pizza["sauce"] = "Sauce tomate";
        }
        public override void BuildMIngredient()
        {
            pizza["mingredient"] = "Mozzarella";
        }
        public override void BuildSIngredient()
        {
            pizza["singredient"] = "Origan";
        }
    }
    class Reine : Builder
    {
        public Reine()
        {
            pizza = new Pizza("Reine");
        }
        public override void BuildSauce()
        {
            pizza["sauce"] = "Sauce tomate";
        }
        public override void BuildMIngredient()
        {
            pizza["mingredient"] = "Mozzarella";
        }
        public override void BuildSIngredient()
        {
            pizza["singredient"] = "Jambon; Champignons";
        }
    }
    class Royale : Builder
    {
        public Royale()
        {
            pizza = new Pizza("Royale");
        }
        public override void BuildSauce()
        {
            pizza["sauce"] = "Sauce tomate";
        }
        public override void BuildMIngredient()
        {
            pizza["mingredient"] = "Mozzarella";
        }
        public override void BuildSIngredient()
        {
            pizza["singredient"] = "Jambon; Champignons; Olives";
        }
    }
    class Pizza
    {
        private string _pizzaType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();
        public Pizza(string pizzaType)
        {
            this._pizzaType = pizzaType;
        }
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Pizza Type: {0}", _pizzaType);
            Console.WriteLine(" Sauce : {0}", _parts["sauce"]);
            Console.WriteLine(" Main Ingredient: {0}", _parts["mingredient"]);
            Console.WriteLine(" Side Ingredient: {0}", _parts["singredient"]);
        }
    }
}
