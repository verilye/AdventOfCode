using System.IO;

namespace AdventOfCode
{
    class Day2
    {

        public Day2()
        {

            getRibbon();
            
        }

        void getRibbon(){

            int runningTotal = 0;

            using (StreamReader sr = new StreamReader("day2.txt"))
            {
                // read a line
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // separate into 3 numbers separated by 'x' char
                    string[] dims = line.Split('x');
                    int[] intDims = new int[3];

                    int prev = 0;

                    for (int i = 0; i < dims.Length; i++)
                    {
                        intDims[i] = int.Parse(dims[i]);

                        if (intDims[i] < prev)
                        {
                            int temp = intDims[i - 1];
                            intDims[i - 1] = intDims[i];
                            intDims[i] = temp;
                        }

                        prev = intDims[i];

                    }

                    int l = intDims[0];
                    int w = intDims[1];
                    int h = intDims[2];

                    // chuck em in formula, keeping track of smallest numbers
                    int ribbon = 2*(l + w);

                    // 2 smallest numbers * together is the smallest side
                    ribbon += (l * w* h);

                    // add em to running total
                    runningTotal += ribbon;
                }
            }

            Console.WriteLine(runningTotal);


        }

        void getWrappingPaper(){
            // l = length, w = width, h = height
            // Formula
            // 2*l*w + 2*w*h + 2*h*l + (smallest side * second smallest side)

            int runningTotal = 0;

            using (StreamReader sr = new StreamReader("day2.txt"))
            {
                // read a line
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // separate into 3 numbers separated by 'x' char
                    string[] dims = line.Split('x');
                    int[] intDims = new int[3];

                    int prev = 0;

                    for (int i = 0; i < dims.Length; i++)
                    {
                        intDims[i] = int.Parse(dims[i]);

                        if (intDims[i] < prev)
                        {
                            int temp = intDims[i - 1];
                            intDims[i - 1] = intDims[i];
                            intDims[i] = temp;
                        }

                        prev = intDims[i];

                    }

                    int l = intDims[0];
                    int w = intDims[1];
                    int h = intDims[2];

                    // chuck em in formula, keeping track of smallest numbers
                    int area = 2 * (l * w) + 2 * (w * h) + 2 * (h * l);

                    // 2 smallest numbers * together is the smallest side
                    area += (l * w);

                    // add em to running total
                    runningTotal += area;
                }
            }

            Console.WriteLine(runningTotal);

            return;
        }
    }
}