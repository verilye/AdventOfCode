namespace AdventOfCode
{
    class Day3
    {

        public Day3()
        {

            // Log Coordinates and check if coordinate has been visited
            // Hashmap with x and y coordinates?
            int x = 0;
            int y = 0;
            int roboX = 0;
            int roboY = 0;
            int counter = 0;
            bool roboFlip = false;
            IDictionary<string, int> map = new Dictionary<string, int>();

            string input;
            using (StreamReader sr = new StreamReader("day3.txt"))
            {
                input = sr.ReadToEnd();
            }

            for (int i = 0; i < input.Length; i++)
            {

                string c;

                if (roboFlip == true)
                {

                    roboFlip = false;

                    if (input[i] == '>') { x++; }
                    if (input[i] == '<') { x--; }
                    if (input[i] == '^') { y++; }
                    if (input[i] == 'v') { y--; }

                    c = x + "," + y;

                }
                else
                {
                    roboFlip = true;
                    if (input[i] == '>') { roboX++; }
                    if (input[i] == '<') { roboX--; }
                    if (input[i] == '^') { roboY++; }
                    if (input[i] == 'v') { roboY--; }

                    c = roboX + "," + roboY;
                }


                if (map.ContainsKey(c))
                {

                }
                else
                {
                    map.Add(c, 1);
                    counter++;
                }

            }

            Console.WriteLine(counter);
        }
    }
}