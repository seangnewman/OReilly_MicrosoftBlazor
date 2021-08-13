using System;

namespace PizzaPlace.Shared
{
    public class Pizza
    {

        public Pizza(int id, string name, decimal price, Spiciness spiciness)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
            Spiciness = spiciness;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public Spiciness Spiciness { get; private set; }
    }
}
