using System.IO;


namespace AdventOfCode
{
    class Day1
    {

        public Day1 ()
        {
            // Read stuff from file
            // Read '(' and increment
            // Read ')' and decrement 

            string input;
            int counter = 0;
            int basement = -1;

            using (StreamReader sr = new StreamReader("day1.txt"))
            {
                input = sr.ReadToEnd();
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') { counter++; }
                if (input[i] == ')') { counter--; }

                if (counter == -1 && basement == -1) { basement = i + 1; }
            }

            Console.WriteLine(basement);

        }

    }

}