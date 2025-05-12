using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
namespace series_analyzer
{
    class program
    {
        static void main(string[] args)
        {
            menu();

            void menu()
            {
                Console.WriteLine("enter series numbers");
                string series = Console.ReadLine();
                replaceSeries(series);
                bool temp = false;
                while (true)
                    {                
                    Console.WriteLine("For replace a series of numbers clik 1\n" +
                        "To print the serues numbers clik 2\n" +
                        "To print the series in reverse clik 3\n" +
                        "To Sort the series clik 4\n" +
                        "To max number in series clik 5\n" +
                        "To minimum number in series clik 6\n" +
                        "For the average of the series click 7\n" +
                        "For The number of elements in the series clik 8\n" +
                        "For the sum numbers in series clik 9\n" +
                        "For exit clik 10");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            replaceSeries();
                            break;
                        case 2:
                            printSeries();
                            break;
                        case 3:
                            printReverse();
                            break;
                        case 4:
                            sortSeries();
                            break;
                        case 5:
                            maximum();
                            break;
                        case 6:
                            minimum();
                            break;
                        case 7:
                            average();
                            break;
                        case 8:
                            amountOfElements();
                            break;
                        case 9:
                            SumSeries();
                            break;
                        case 10:
                            temp = false;
                            break;
                    }
                }
               
            }

        }
    }
    
}
