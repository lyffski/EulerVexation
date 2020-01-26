using System;


namespace EulerVexation
{

    class Program
    {
        static void _001()
        {
            EulerProblemID._001_MultiplesOf._001p p001 = new EulerProblemID._001_MultiplesOf._001p();
            p001.Solve();
        }

        static void _002()
        {
            EulerProblemID._002_EvenFibonacciNumbers._002p p002 = new EulerProblemID._002_EvenFibonacciNumbers._002p();
            p002.Solve();
        }

        static void _003()
        {
            EulerProblemID._003_Largest_prime_factor._003p p003 = new EulerProblemID._003_Largest_prime_factor._003p();
            p003.Solve();
        }

        static void _004()
        {
            EulerProblemID._004_Largest_palindrome_product._004p p004 = new EulerProblemID._004_Largest_palindrome_product._004p();
            p004.Solve();
        }

        static void _005()
        {
            EulerProblemID._005_SmallesFactor._005p p005 = new EulerProblemID._005_SmallesFactor._005p();
            p005.Solve();
        }
        
        static void _006()
        {
            EulerProblemID._006_Sum_square_difference._006p p006 = new EulerProblemID._006_Sum_square_difference._006p();
            p006.Solve();
        }

        static void _007()
        {
            EulerProblemID._007_10001Prime._007p p007 = new EulerProblemID._007_10001Prime._007p();
            p007.Solve(); 
        }

        static void Main(string[] args)
        {
           

            Console.WriteLine();
                int pNum = Convert.ToInt32(Console.ReadLine());
                switch (pNum)
                {
                    case 1:
                        _001();
                        break;
                    case 2:
                        _002();
                        break;
                    case 3:
                        _003();
                        break;
                    case 4:
                        _004();
                        break;
                    case 5:
                        _005();
                        break;
                    case 6:
                        _006();
                        break;
                    case 7:
                        _007();
                        break;
                }

                Console.Write("\n\nPress Any Key to Exit...");
                Console.ReadKey();
            }


        }

    }




