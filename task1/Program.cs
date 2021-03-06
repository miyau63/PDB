using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrBubl matr = new MatrBubl(new int[][]{ new int[]{4,9,6},
                                new int[]{11,0,5},
                                new int[]{14,1,2},
                                new int[]{10,2,2},
                                new int[]{15,26,30}});
            matr.Show();
            
            
                Console.WriteLine("Выберите тип алгоритма: 1 - по возрастанию, 2 - по убыванию");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Выберите тип сравнения: 1 - по сумме в строке, 2 - по максимальному элементу в строке, 3 - по миниматльному элементу в строке");
                        switch (Console.ReadLine())
                        {
                            case "1": matr.BubbleSort((a, b) => (a > b), Operat.Sum); break;
                            case "2": matr.BubbleSort((a, b) => (a > b), Operat.Max); break;
                            case "3": matr.BubbleSort((a, b) => (a > b), Operat.Min); break;
                        }
                        break;


                    case "2":
                        Console.WriteLine("Выберите тип сравнения: 1 - по сумме в строке, 2 - по максимальному элементу в строке, 3 - по миниматльному элементу в строке");
                        switch (Console.ReadLine())
                        {
                            case "1": matr.BubbleSort((a, b) => (a < b), Operat.Sum); break;
                            case "2": matr.BubbleSort((a, b) => (a < b), Operat.Max); break;
                            case "3": matr.BubbleSort((a, b) => (a < b), Operat.Min); break;
                        }
                        break;
                }
            
            
            matr.Show();

            
            

            var timer = new CountDown();

            var subscriberA = new Subscriber(timer, "Субскрубер А");
            var subscriberB = new Subscriber(timer, "Субскрубер Б");
            var subscriberC = new Subscriber(timer, "Субскрубер Ц");

            timer.Skip(1000, "вот вам событие");
            timer.Skip(1000, "вот вам второе событие");
            subscriberA.Ubsubscribe();
            timer.Skip(2000, "вот вам третье событие");
            subscriberB.Ubsubscribe();
            timer.Skip(1000, "вот вам четвертое событие");
            subscriberC.Ubsubscribe();
            timer.Skip(1000, "вот вам пятое событие");

            Console.ReadKey();
        }

        
    }
    
}
