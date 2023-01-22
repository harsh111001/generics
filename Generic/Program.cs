namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            int[] intarray = { 1, 2, 3, 4, 5, };
            print<int>(intarray);
            char[] chararray = { 'a', 'b','c','d'};
            print<char>(chararray);
            double[] doublearray = { 1.1, 2.2, 3.3, 4.4 };
            print<double>(doublearray);
        }
        public static void print<T>(T[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}