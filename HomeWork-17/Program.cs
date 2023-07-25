namespace HomeWork_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задания 1");

            //Тестирование задания 1


            // для тестовой коллекции
            var x1 = new TestClass(14);
            var x2 = new TestClass(15);
            var x3 = new TestClass(99);
            var x4 = new TestClass(32);
            var x5 = new TestClass(58);
            var x6 = new TestClass(47);

            var TestCollection = new List<TestClass>() { x1, x2, x3, x4, x5, x6 };

            var test = TestCollection.GetMax<TestClass>(ToNumber);

            Console.WriteLine(test.Number);
                       
            // Тестирование задания 2, 3, 4

            Console.WriteLine("Задания 2, 3, 4");

            string dirName = @".\Files";

            var test4 = new BypassFiles(dirName);


            test4.GetFile();

            Console.ReadKey();



            // Произвольный метод преобразующий входной тип в число
            float ToNumber<T>(T t) where T : class
            {
                Type myType = typeof(T);
                float num = 0;

                foreach (var l in myType.GetProperties())
                {
                    var ff = (myType.GetProperty(l.Name))?.GetValue(t);
                    num = num + (float)Convert.ToDecimal(ff);
                }
                return num;

            }

        }
    }
}