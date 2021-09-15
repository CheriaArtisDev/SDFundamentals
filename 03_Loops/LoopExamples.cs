using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {

        // while for foreach do while
        [TestMethod]
        public void WhileLoops()
        {
            // while (condition) {Body of code}

            int counter = 1;

            while (counter != 10)
            {
                Console.WriteLine(counter);
                counter += 1;
            }

            counter = 1;
            while(true)
            {
                Console.WriteLine(counter);
                if (counter == 7)
                {
                    Console.WriteLine("Goal reached.");
                    break;
                }

                counter++;
            }

            Random rng = new Random();
            bool isRunning = true;
            int someCount;

            while(isRunning)
            {
                // 0 (inclusive) 21 (non inclusive) to generate numbers between 1 and 20
                someCount = rng.Next(0, 21); 

                if(someCount == 13 || someCount < 5)
                {
                    // continues the loop without progressing in code
                    continue;
                }

                Console.WriteLine(someCount);

                if(someCount == 17)
                {
                    // Exit condition
                    isRunning = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int targetNumber = 21;

            // 1 for Keyword
            // 2 Starting point/counter initialization
            // 3 Condition to continue the loop
            // 4 what to do after each loop
            // 5 Body of code to loop through

            //1     //2         //3         //4 
            for(int i = 0; i < targetNumber; i++)
            {
                //5
                Console.WriteLine(i); ;
            }

            string[] students = {"David", "Nate", "Anastacia", "Jeffrey", "Ethan" };

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Good morning {students[i]}");
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethan" };

            //1 foreach Keyword
            //2 type of the collection
            //3 local variable name in the current iteration
            //4 in Keyword separates the individual item and the collection
            //5 collection being iterated through
            //6 body of code to loop through

            //1     //2         //3    //4    //5
            foreach(string studentName in students)
            {
                //6
                Console.WriteLine(studentName + " is in class today");
            }

            string myName = "Simon William Pawlak";
            foreach(char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            int counter = 0;

            // do while loops always run at least once
            //1 do Keyword
            //2 body of code to loop
            //3 while keyword
            //4 condition to continue looping

            //1
            do
            {
                //2
                Console.WriteLine("Hello" + counter);
                counter++;
            }


            //3     //4
            while (false);
        }
    }
}
