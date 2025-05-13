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

            void menu()//מפעיל
            {
                List<int> numbers = new List<int>();
                numbers = seriesUpdate();
                bool exit = true;
                while (exit)
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
                            Console.WriteLine(Minimum(numbers));
                            break;
                        case 6:
                            Console.WriteLine(maximum(numbers));
                            break;
                        case 7:
                            Console.WriteLine(average(numbers));
                            break;
                        case 8:
                            Console.WriteLine(amountOfElements(numbers));
                            break;
                        case 9:
                            Console.WriteLine(SumSeries(numbers));
                            break;
                        case 10:
                            exit = false;
                            break;
                        default:
                            break;

                    }
                }


            }
            List<int> seriesUpdate() // קבלת סטרינג , בדיקה והמרה למערך מספרים  
            {
                bool positiveNumbers = true;
                Console.WriteLine("enter series numbers");
                string series = Console.ReadLine();
                List<int> seriesNumbers = new List<int>();
                List<string> seriesString = new List<string>(series.Split(","));
                foreach (string str in seriesString)
                {
                    if (int.TryParse(str, out int numm))
                    {
                        if (int.Parse(str) < 0)
                        {
                            positiveNumbers = false;
                            break;
                        }
                    }
                    else
                    {
                        if (str != ",")
                        {
                            positiveNumbers = false;
                            break;
                        }
                    }
                }
                if (!positiveNumbers)
                {
                    return seriesUpdate();
                }
                else
                {
                    foreach (var number in seriesString)
                    {
                        int num = int.Parse(number);
                        seriesNumbers.Add(num);
                    }
                }

                return seriesNumbers;
            }

            void printSeries(List<int> numbersList)//הדפסת הסדרה
            {
                foreach (var number in numbersList)
                {
                    Console.WriteLine(number);
                }
            }

            void printReverse(List<int> numbersList)//הדפסת הסדרה הפוך
            {
                for (int i = (numbersList.Count) - 1; i > -1; i--)
                {
                    Console.WriteLine(numbersList[i]);
                }
            }

            void sortSeries(List<int> numbersList)//הדפסת הסדרה בצורה ממויינת
            {
                List<int> sortList = new List<int>();
                List<int> tempList = new List<int>();
                for (int i = 0; i < numbersList.Count; i++)
                {
                    tempList.Add(numbersList[i]);
                }
                while (tempList.Count != 0)
                {
                    int minimum = Minimum(tempList);
                    sortList.Add(minimum);
                    tempList.Remove(minimum);
                }
                foreach (var number in sortList)
                {
                    Console.WriteLine(number);
                }

            }

            int Minimum(List<int> numbersList)//מחזירה מינימום
            {
                int minimum = numbersList[0];
                foreach (var number in numbersList)
                {
                    if (number < minimum)
                    {
                        minimum = number;
                    }
                }
                return minimum;
            }

            int maximum(List<int> numbersList)//מחזירה מקסימום
            {
                int maximum = numbersList[0];
                foreach (var number in numbersList)
                {
                    if (number > maximum)
                    {
                        maximum = number;
                    }
                }
                return maximum;
            }

            int average(List<int> numbersList)//חישוב ממוצע
            {
                int sum = SumSeries(numbersList);
                return sum / numbersList.Count;
            }


            int amountOfElements(List<int> numbersList)//כמות האלמנטים בסדרה
            {
                return numbersList.Count;
            }

            int SumSeries(List<int> numbersList)//סוכמת את המספרים בסדרה
            {
                int sum = 0;
                foreach (var number in numbersList)
                {
                    sum += number;
                }
                return sum;
            }
        }


    }

}
