using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submission
{
    public class Store
    {
        public Store()
        {
            //Shoes = new List<Shoe>();
            //Shoe shoeOne = new Shoe();
            //shoeOne.Color = "Black";
            //shoeOne.Size = "9";
            //Shoes.Add(shoeOne);


           //the store constructor
            Shoes = new List<Shoe>();
            List<string> Colors = new List<string>()
           { "Red", "Black", "Yellow", "White", "Green",
             "Blue", "Gold", "Silver", "Grey", "Brown", "Pink" };
            List<string> Sizes = new List<string>()
           { "4.5", "6", "6.5", "7", "7.5", "8", "8.5",
             "9", "9.5", "10", "10.5", "11", "11.5", "12" };

            foreach (string color in Colors)
            {
               foreach (string size in Sizes)
                {//performing the add operation
                    Shoe shoe = new Shoe();
                    shoe.Color = color;
                    shoe.Size = size;
                    Shoes.Add(shoe);
                }

            }
        }
        public List<Shoe> Shoes {  get; set; }
    }
}
