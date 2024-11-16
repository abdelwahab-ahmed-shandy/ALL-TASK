/*
I was going to write the whole task, but I found that there are too many words.
I will save time for something else that is better.
I will write the title, but when I have free time...
We used both static void and static that return values ​​only for practice......
 */
namespace Task___2
{
    internal class Program
    {
        static void PrintMainMenu()
        {
            Console.WriteLine("\n===============================================");
            Console.WriteLine("P - Print Numbers. ");
            Console.WriteLine("A - Add A Number. ");
            Console.WriteLine("M - Display Mean Of The Numbers. ");
            Console.WriteLine("S - Display The Smallest Numbers. ");
            Console.WriteLine("L - Display The Largest Numbers. ");
            Console.WriteLine("F - Find A Number. ");
            Console.WriteLine("C - Claer The Whole List. ");
            Console.WriteLine("Q - Quit. ");
            Console.WriteLine("===============================================\n");
        }

        static char ReadSelection()
        {
            Console.Write("\nChosse Any Character : ");
            return char.Parse(Console.ReadLine().ToUpper());
        }

        static void PrintNumbersOfList(List<int> ListNumber)
        {
            Console.Write("Print Numbers : ");
            if (ListNumber.Count > 0)
            {
                Console.WriteLine("Print Numbers : ");
                for (int i = 0; i < ListNumber.Count; i++)
                {
                    Console.Write($"{ListNumber[i]} ,");
                }
            }
            else
            {
                Console.WriteLine("The List Empty \n");
            }
        }

        static void AddNumberInList(List<int> ListNumber)
        {
            Console.Write("Add Number : ");
            int EnterNumber = int.Parse(Console.ReadLine());
            ListNumber.Add(EnterNumber);
            Console.WriteLine($"Number {EnterNumber} Is Added\n");
        }

        static void ClearList(List<int> ListNumber)
        {
            Console.WriteLine("Clear The Whole List\n");
            ListNumber.Clear();
        }

        static void SumAndAverage(List<int> ListNumber)
        {
            if (ListNumber.Count > 0)
            {
                int Sum = 0;
                for (int i = 0; i < ListNumber.Count; i++)
                {
                    Sum += ListNumber[i];
                }
                double Average = (double)Sum / ListNumber.Count;
                Console.WriteLine($"The Average Number Is : {Average}\n");
            }
            else
            {
                Console.WriteLine("The List Empty , You Can First Enter Numbers\n");
            }
        }

        static int SmallerNumber(List<int> ListNumber)
        {
            int SmallerNumber = 2147483647, LargerNumber = 0;
            for (int i = 0; i < ListNumber.Count; i++)
            {
                if (ListNumber[i] < SmallerNumber)
                    SmallerNumber = ListNumber[i];
            }
            return SmallerNumber;
        }

        static int LargerNumber(List<int> ListNumber)
        {
            int LargerNumber = 0;
            for (int i = 0; i < ListNumber.Count; i++)
            {
                if (ListNumber[i] > LargerNumber)
                    LargerNumber = ListNumber[i];
            }
            return LargerNumber;
        }

        static void FindNumber(List<int> ListNumber)
        {
            bool IsFound = false;
            Console.Write("Find Number Is : ");
            int FoundNumber = int.Parse(Console.ReadLine());
            if (ListNumber.Count > 0)
            {
                for (int i = 0; i < ListNumber.Count; i++)
                {
                    if (ListNumber[i] == FoundNumber)
                    {
                        Console.WriteLine($"The Number Is Available : {FoundNumber}\n");
                        IsFound = true;
                    }
                }
            }
            if (!IsFound)
            {
                Console.WriteLine($"The number {FoundNumber} does not exist in the list.");
            }

        }

        static void PrintEnding()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("Happy Ending Goodbye");
            Console.WriteLine("===============================================");
        }

            static void Main (string[] args)
            {
                char EnterCharacter = ' ';
                List<int> ListNumber = new List<int>();

                while (EnterCharacter != 'Q')
                {
                    PrintMainMenu();
                    EnterCharacter = ReadSelection();
                    if (EnterCharacter == 'P')
                    {
                        PrintNumbersOfList(ListNumber);
                    }

                    else if (EnterCharacter == 'A')
                    {
                        AddNumberInList(ListNumber);
                    }

                    else if (EnterCharacter == 'C')
                    {
                        ClearList(ListNumber);
                    }

                    else if (EnterCharacter == 'M')
                    {
                        SumAndAverage(ListNumber);
                    }

                    else if (EnterCharacter == 'S')
                    {
                        if (ListNumber.Count > 0)
                        {
                            Console.WriteLine($"The Smaller Number Is : {SmallerNumber(ListNumber)}\n");
                        }
                        else
                        {
                            Console.WriteLine("The List Empty , You Can First Enter Numbers\n");
                        }
                    }

                    else if (EnterCharacter == 'L')
                    {
                        if (ListNumber.Count > 0)
                        {
                            Console.WriteLine($"The Smaller Number Is : {LargerNumber(ListNumber)}\n");
                        }
                        else
                        {
                            Console.WriteLine("The List Empty , You Can First Enter Numbers\n");
                        }
                    }

                    else if (EnterCharacter == 'F')
                    {
                    FindNumber(ListNumber);                       
                    }
                }
                PrintEnding();
            }
        }
    }
