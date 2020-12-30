using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    
    class PrsonalData : CoffeeBuilder
    {
        public override void AddName()
        {
            Drink.coffee = new Name() { Name = "Arabaica" };
        }

        public override void AddLogin()
        {
            Drink.milk = new login() { Name = "Arabaica123123" };
        }

    }
    abstract class CoffeeBuilder
    {
        public abstract void AddName();
        public abstract void AddLogin();

    }
    class CoffeeDrink
    {
        public Name name { get; set; }
        public Login login { get; set; }
        public override string ToString()
        {
            string result = name.Name + Environment.NewLine +
                login.Name + Environment.NewLine;
            return result;
        }
    }
    class Name
    {
        public string Name { get; set; }
    }
    class Login
    {
        public string Name { get; set; }
    }

}
