using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace series_analyzer
{
    class program
    {
        static void Main(string[] args)
        {
            menu();

            List<int> numbers = new List<int>();
            void menu()
            {
                seriesUpdate();
                bool temp = true;
                while (temp)
                    {                
                    Console.WriteLine("For replace a series of numbers clik 1\n" +
                        "To print the serues numbers clik 2\n" +
                        "To print the series in reverse clik 3\n" +
                        "To Sort the series clik 4\n" +
                        "To minimum number in series clik 5\n" +
                        "To maximum number in series clik 6\n" +
                        "For the average of the series click 7\n" +
                        "For The number of elements in the series clik 8\n" +
                        "For the sum numbers in series clik 9\n" +
                        "For exit clik 10");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                           numbers = seriesUpdate();
                            break;
                        case 2:
                            printSeries(numbers);
                            break;
                        case 3:
                            printReverse(numbers);
                            break;
                        case 4:
                            sortSeries(numbers);
                            break;
                        case 5:
                            minimum(numbers);
                            break;
                        case 6:
                            maximum(numbers);
                            break;
                        case 7:
                            average(numbers);
                            break;
                        case 8:
                            amountOfElements(numbers);
                            break;
                        case 9:
                            SumSeries(numbers);
                            break;
                        case 10:
                            temp = false;
                            break;

                    }
                }
               
            }
            List<int> seriesUpdate()
            {
                Console.WriteLine("enter series numbers");
                string series = Console.ReadLine();                
                List<int> seriesNumbers = new List<int>();
                List<string> seriesString = new List<string> (series.Split(","));
                foreach (var number in seriesString)
                {
                    int num = int.Parse(number);
                    seriesNumbers.Add(num);                 
                }
                numbers = seriesNumbers;
                return seriesNumbers;
            }
            void printSeries(List<int> numbersList)
            {
                foreach (var number in numbersList)
                {
                    Console.WriteLine(number);
                }
            }
            void printReverse(List<int> numbersList)
            {
                for (int i = (numbersList.Count)-1;i > -1;i--)
                {
                    Console.WriteLine(numbersList[i]);
                }
            }
            void sortSeries(List<int> numbersList)
            {
                List<int> sortList = new List<int>();
                List<int> tempList =new List<int>();
                for (int i = 0; i < numbersList.Count; i++)
                {
                    tempList.Add(numbersList[i]);
                }
                while (tempList.Count != 0)
                {
                    int minimum = tempList[0];
                    foreach (var number in tempList)
                    {
                        if (number < minimum)
                        {
                            minimum = number;
                        }
                    }
                    sortList.Add(minimum);
                    tempList.Remove(minimum);
                }
                foreach (var number in sortList)
                {
                    Console.WriteLine(number);
                }

            }

            void minimum(List<int> numbersList)
            {
                int minimum = numbersList[0];
                foreach (var number in numbersList)
                {
                    if (number < minimum)
                    {
                        minimum = number;
                    }
                }
                Console.WriteLine(minimum);
            }

            void maximum(List<int> numbersList)
            {
                int maximum = numbersList[0];
                foreach (var number in numbersList)
                {
                    if (number > maximum)
                    {
                        maximum = number;
                    }
                }
                Console.WriteLine(maximum);
            }
            void average(List<int> numbersList)
            {
                int sum = 0;
                foreach (var number in numbers)
                {
                    sum += number;
                }
                Console.WriteLine(sum / numbersList.Count);
            }
            void amountOfElements(List<int> numbersList)
            {
                Console.WriteLine(numbersList.Count);
            }
            void SumSeries(List<int> numbersList)
            {
                int sum = 0;
                foreach (var number in numbersList)
                {
                    sum += number;
                }
                Console.WriteLine(sum);
            }
        }

        
    }
    
}
