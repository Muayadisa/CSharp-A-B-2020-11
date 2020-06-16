using System;

namespace Lesson11
{
   
    interface IWash
    {
        string WashItem();
    }

    interface IWipe
    {
        string WipeItem();
    }

    abstract class HouseItem
    {
        public virtual decimal Price { get; set; } = 10;
    }


    class Computer : HouseItem, IWipe
    {
        public override decimal Price { get; set; } = 1000;

        public string WipeItem()
        {
            return $"Computer is wiped!";
        }
    }

    class Floor : HouseItem, IWash
    {
        public string WashItem()
        {
            return $"Floor is washed!";
        }
    }

    class Dish : HouseItem, IWash, IWipe
    {
        public string WashItem()
        {
            return $"Dishes are washed!";
        }

        public string WipeItem()
        {
            return $"Dishes are wiped!";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            HouseItem[] itemsToClean = new HouseItem[]
            {
                new Computer(), new Dish(), new Dish(), new Floor()
            };

            // to get the interface implementations - we must convert the type of each item - to the right inteface: 
            foreach (HouseItem item in itemsToClean)
            {
                if (item is IWash)
                {
                    Console.WriteLine(((IWash)item).WashItem());
                }
                if(item is IWipe)
                {
                    Console.WriteLine(((IWipe)item).WipeItem());
                }
            }

            /*
            Computer is wiped!
            Dishes are washed!
            Dishes are wiped!
            Dishes are washed!
            Dishes are wiped!
            Floor is washed!
            */

            Console.ReadKey();
        }
    }
}
