using System;

namespace LAB2_4_BRIDGES
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFirstNumber = 19;
            int mySecondNumber = 244 * (int)myFirstNumber;
            Console.WriteLine(mySecondNumber);
            string myText = "Some Text";
            Console.WriteLine(mySecondNumber + myText);
            string moreText = "goes here";
            Console.WriteLine(myText + moreText);
            string color1 = "yellow";
            string color2 = "red";
            const bool isYellow = true;
            const bool isGreen = false;
            Console.WriteLine(color1 + isYellow); 
                Console.WriteLine( color2 + isGreen);
            double numbers;

            numbers = mySecondNumber / myFirstNumber;
            Console.WriteLine(numbers);

            Console.WriteLine("Breakpoint Here");

            string textToNumber = "80473";
            int results = 99 * int.Parse(textToNumber);
            Console.WriteLine(results);
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);





        

            
          
        }
    }
}
