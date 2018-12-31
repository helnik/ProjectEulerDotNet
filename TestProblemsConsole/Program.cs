using Problems;
using System;
using System.Collections.Generic;

namespace TestProblemsConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
            Answer res;
            
            //Problem1
            res = Problem01.Solution1();
            Console.WriteLine($"Problem1 first solution result = {res.Result} found in {res.TimeTaken} ms");
            res = Problem01.Solution2();
            Console.WriteLine($"Problem1 second solution result = {res.Result} found in {res.TimeTaken} ms");

            //Problem2
            res = Problem02.Solution1();
            Console.WriteLine($"Problem2 first solution result = {res.Result} found in {res.TimeTaken} ms");
            res = Problem02.Solution2();
            Console.WriteLine($"Problem2 second solution result = {res.Result} found in {res.TimeTaken} ms");

            //Problem3
            //res = Problem3.Solution1(); Extremly slow
            //Console.WriteLine($"Problem3 first solution result = {res.Result} found in {res.TimeTaken} ms");

            res = Problem03.Solution2();
            Console.WriteLine($"Problem3 second solution result = {res.Result} found in {res.TimeTaken} ms");

            //Problem4
            res = Problem04.Solution1();
            Console.WriteLine($"Problem4 first solution result = {res.Result} found in {res.TimeTaken} ms");

            //Problem5
            res = Problem05.Solution1();
            Console.WriteLine($"Problem5 first solution result = {res.Result} found in {res.TimeTaken} ms");
            res = Problem05.Solution2();
            Console.WriteLine($"Problem5 second solution result = {res.Result} found in {res.TimeTaken} ms");

            //Problem 6
            res = Problem06.Solution1();
            Console.WriteLine($"Problem6 first solution result = {res.Result} found in {res.TimeTaken} ms");
            res = Problem06.Solution2();
            Console.WriteLine($"Problem6 second solution result = {res.Result} found in {res.TimeTaken} ms");
            
            //Problem 7
            res = Problem07.Solution1();
            Console.WriteLine($"Problem7 first solution result = {res.Result} found in {res.TimeTaken} ms");

            //Problem 8
            res = Problem08.Solution1();
            Console.WriteLine($"Problem8 first solution result = {res.Result} found in {res.TimeTaken} ms. Digits = {res.ExtraInfo}");

            //Problem 9
            res = Problem09.Solution1();
            Console.WriteLine($"Problem9 first solution result = {res.Result} found in {res.TimeTaken} ms. Digits = {res.ExtraInfo}");

            //Problem 10
            res = Problem10.Solution1();
            Console.WriteLine($"Problem10 first solution result = {res.Result} found in {res.TimeTaken} ms.");
            res = Problem10.Solution2();
            Console.WriteLine($"Problem10 second solution result = {res.Result} found in {res.TimeTaken} ms. {res.ExtraInfo}");
            res = Problem10.Solution3();
            Console.WriteLine($"Problem10 third solution result = {res.Result} found in {res.TimeTaken} ms. {res.ExtraInfo}");

            Console.ReadKey();
        }
    }
}
