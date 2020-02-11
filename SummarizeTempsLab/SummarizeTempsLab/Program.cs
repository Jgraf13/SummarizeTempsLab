﻿using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;

            Console.WriteLine("Enter File Name");

            filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");

                Console.WriteLine("Enter Threshold");

                string input;
                int Threshold;
                input = Console.ReadLine();
                Threshold = int.Parse(input);
                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempCount = 0;


                using (StreamReader sr = File.OpenText(filename))
                {

                    string line = sr.ReadLine();
                    int temp;

                    while (line != null)
                    {
                        temp = int.Parse(input);

                        sumTemps += temp;

                        tempCount += 1;

                        if (temp >= Threshold)
                        {
                            numAbove += 1;

                        }

                        else
                        {
                            numBelow += 1;
                        }

                        line = sr.ReadLine();

                    }


                }

                Console.WriteLine("Temperature above =" + numAbove);
                Console.WriteLine("Temperature below =" + numBelow);
                int average = sumTemps / tempCount;
                Console.WriteLine("Average temp" + average);

            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
        

    }

}