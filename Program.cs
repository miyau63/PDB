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
                                new int[]{11,0,7},
                                new int[]{14,1,2},
                                new int[]{9,1,2},
                                new int[]{15,3,5}});
            MatrBubl.Show();
            
            
                Console.WriteLine("Выберите тип алгоритма: 1 - по возрастанию, 2 - по убыванию");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Выберите тип сравнения: 1 - по сумме в строке, 2 - по максимальному элементу в строке, 3 - по миниматльному элементу в строке");
                        switch (Console.ReadLine())
                        {
                            case "1": MatrBubl.BubbleSort((a, b) => (a > b), Operat.Sum); break;
                            case "2": MatrBubl.BubbleSort((a, b) => (a > b), Operat.Max); break;
                            case "3": MatrBubl.BubbleSort((a, b) => (a > b), Operat.Min); break;
                        }
                        break;


                    case "2":
                        Console.WriteLine("Выберите тип сравнения: 1 - по сумме в строке, 2 - по максимальному элементу в строке, 3 - по миниматльному элементу в строке");
                        switch (Console.ReadLine())
                        {
                            case "1": MatrBubl.BubbleSort((a, b) => (a < b), Operat.Sum); break;
                            case "2": MatrBubl.BubbleSort((a, b) => (a < b), Operat.Max); break;
                            case "3": MatrBubl.BubbleSort((a, b) => (a < b), Operat.Min); break;
                        }
                        break;
                }
            
            
            MatrBubl.Show();
        }

        
    }
    
}
