using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiating the store class
            Store store = new Store();
            ////store.Shoes = new List<Shoe>();


            //calling the method from the store class
            foreach (Shoe shoe in store.Shoes)
            {
                Console.WriteLine(shoe.Color + " of size " + shoe.Size);
            }
            //sum of shoes in store
            Console.WriteLine(store.Shoes.Count);

            ////Shoe class
            //// Shoe shoeOne = new Shoe();
            //// shoeOne.Size = "9";
            ////shoeOne.Color = "Red";

            ////store.Shoes.Add(shoeOne);

            ////Console.WriteLine(shoeOne.Color + " of size: " + shoeOne.Size);
            ////Console.WriteLine(store.Shoes[0].Color + " of size " + store.Shoes[0].Size);
            Console.ReadLine();
        }
    }
}
