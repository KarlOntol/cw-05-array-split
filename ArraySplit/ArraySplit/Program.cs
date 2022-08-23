using System.Collections.Generic;

namespace ArraySplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<string>();
            GetNumbers(data);
            SomeFunc(data);
        }

        static void SomeFunc(List<string> data)
        {
            var strData = new List<string>();
            var floatData = new List<float>();
            var intData = new List<int>();
            foreach(string n in data)
            {
                if (int.TryParse(n, out int xInt))
                {
                    intData.Add(Convert.ToInt32(xInt));
                    continue;
                }
                else if (float.TryParse(n, out float xFloat))
                {
                    floatData.Add(Convert.ToSingle(xFloat));
                    continue;
                }
                else
                {
                    strData.Add(n.ToString());
                }
                    
            }
            Console.WriteLine($"Список строковых значений: {string.Join(", ", strData)}");
            Console.WriteLine($"Список чисел с плавающей точкой: {string.Join(", ", floatData)}");
            Console.WriteLine($"Список чисел: {string.Join(", ", intData)}");
        }

        static void GetNumbers(List<string> data)
        {
            do
            {
                var x = Console.ReadLine();
                data.Add(x);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine($"Список значений: {string.Join(", ", data)}");                
        }

    }
}
