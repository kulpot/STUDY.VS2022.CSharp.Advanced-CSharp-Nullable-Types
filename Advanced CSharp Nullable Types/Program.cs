using Advanced_CSharp_Nullable_Types;
using System;

//ref link:https://www.youtube.com/watch?v=d0oM_Cf9PbY&list=PLhq7kqloVlM9iFmPZpQMgFjL6LytLv1Md&index=1
//

namespace NullableTypes
{
    //Nullable Types
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5; // Value Type
            //Random random = new Random(); // References Types
            //Random r2 = null; // r2 no value
            /*
            int? x = null; // ? is a generic class which is nullable type that can be stored in

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }*/

            Database d = new Database();
            int? userAge = d.GetUsersAge("Kulpot");

            if(userAge.HasValue)
            {
                Console.WriteLine(userAge.Value);
            }
            else
            {
                Console.WriteLine("No valid age");
            }
        }
    }
}