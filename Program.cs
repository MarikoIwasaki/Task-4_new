using System;

namespace Task_4_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give math, science, physics, and computer science scores");

            int sumscore = 0;
            double avg;
            int[] score = new int[4];


            for (int i = 0; i < score.Length; i++)
            {
                score[i] = Convert.ToInt32(Console.ReadLine());
                sumscore = sumscore + score[i];
            }
            Console.WriteLine("The total is:" + sumscore);

            avg = averageoperation(sumscore);
            Console.WriteLine("");
            Console.WriteLine("average score of 4 subjects is  " + avg);

            checkscore(avg);
            checkgrade(avg);
        }
        public static double averageoperation(int sumscore)
        {
            double avg = sumscore / 4; //double avg = sumscore / score.Length;
            //Console.WriteLine(avg);
            return avg;
        }

        public static void checkscore(double avg)
        {
            if (avg >= 80 && avg <= 100)
            {
                Console.WriteLine("average grade is A"); //Console.WriteLine("Excellent! your grade is A");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("average grade is B");// Console.WriteLine("Good! Your grade is B");
            }
            else if (avg >= 60 && avg < 70)
            {
                Console.WriteLine("average grade is C");// Console.WriteLine("Satisfactory. Your grade is C");
            }
            else if (avg >= 50 && avg < 60)
            {
                Console.WriteLine("average grade is D"); //Console.WriteLine("Pass.Your grade is D");
            }
            else if (avg < 50)
            {
                Console.WriteLine("average grade is F"); //Console.WriteLine("Fail. Your grade is F");
            }

        }

        public static void checkgrade(double avg)
        {
            string grade = Convert.ToString(Console.ReadLine());
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent! your grade is A");
                    break;
                case "B":
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case "C":
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case "D":
                    Console.WriteLine("Pass.Your grade is D");
                    break;
                case "F":
                    Console.WriteLine("Fail. Your grade is F");
                    break;
                default://code to be executed if n doesn't match any cases
                    break;

            }
        }
    }
}
