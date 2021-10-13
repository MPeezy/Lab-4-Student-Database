/* Lab #4 Get to know you classmates
 Main difference between a list and an array? Arrays are a set size and you can't add or subtract slots. A list is flexible and you can add or subract slots.
*/


using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {


            bool anotherStu = true;
            while (anotherStu == true)
            {

                string[] classList = { "Andy Beer", "Cortez Christian", "Erin Walters", "Richard Moss", "Huy Phan", "Zachary Parr", "James Mitchell", "Cullin Flynn", "Cordero Ebberhart", "Rick Magdaleno" };

                string[] homeTown = { "Berkley, MI", "Detroit, MI", "Troy, MI", "Canton, MI", "Lansing, MI", "Wyandotte, MI", "Yap, FSM", "Fowlerville, MI", "Berkley, MI", "Gilbert, AZ" };


                string[] favoriteFood = { "French Fries", "Chicken Fettuccine Alfredo", "Tacos", "Sushi", "Korean BBQ", "Sushi", "Katsu", "Pad Thai", "BBQ", "Hamburgers" };

                string[] isCool = { "cool", "very cool", "super cool", "mad cool", "extra cool", "cool", "very cool", "super cool", "mad cool", "cool" };



                Console.Write("Welcome to our C # class. Which student would you like to learn more about? (Enter a number 1-20): ");

                int numInClass = classList.Length;
                int studentNum = int.Parse(Console.ReadLine());




                  if (studentNum < 0 || studentNum > 9)

                    {
                        Console.WriteLine("That student doesn't exist. Please try again. Please enter a number between 0-9 ");
                    }
                    else
                    {
                        Console.WriteLine("Student " + studentNum + " is " + classList[studentNum] + ". What would you like to know about " + classList[studentNum] + "?(enter hometown or favorite food): ");

                    }


                    string answer = Console.ReadLine().ToLower();


                    if (answer == "hometown")

                    {
                        Console.WriteLine(classList[studentNum] + " is from  " + homeTown[studentNum] + " Would you like to know more? (enter y or n)");
                    }

                    else if (answer == "favorite food")

                    {
                        Console.WriteLine(classList[studentNum] + "'s favorite food is " + favoriteFood[studentNum] + " Would you like to know more? (enter y or n)");

                    }

                    else
                    {
                        Console.WriteLine("That data doesn't exist. Please try again. (enter hometown or favorite food: )");
                    }



                // know more?
                bool knowMore = true;
                while (knowMore == true)



                {

                        string moreAnswer = Console.ReadLine().ToLower();
                        if (moreAnswer == "y" && answer == "hometown")
                        {
                            Console.WriteLine(classList[studentNum] + "'s favorite food is " + favoriteFood[studentNum] + " and they are " + isCool[studentNum]);
                            Console.WriteLine("Would you like to learn about another student? y/n");
                      
                        }

                        else if (moreAnswer == "y" && answer == "favorite food")
                        {
                            Console.WriteLine(classList[studentNum] + " is from  " + homeTown[studentNum] + " and they are " + isCool[studentNum]);
                            Console.WriteLine("Would you like to learn about another student? y/n");
                       
                        }

                        else if (moreAnswer == "n")
                        {

                            Console.WriteLine("Thanks!");
                        }




                        string askAnoStu = Console.ReadLine().ToLower();
                    
                       if (askAnoStu== "n")
                         {
                            anotherStu = false;

                            Console.WriteLine("Thanks!");
                         }

                        else  if (askAnoStu == "y")
                         {
                        anotherStu = true;
                        //loop to top
                         }


                    
                    //COULDN'T GET ELSE STATEMENT FOR WHEN THEY DONT ENTER HOMETOWN OR FAVORITE FOOD RIGHT TO WORK
                    //COULDN"T GET ASK FOR ANOTHER STUDENT LOOP TO WORK


                }

            }
        }
    }
}