using System.Runtime.CompilerServices;

namespace Generic
{
    //we can not use <,= etc. for comparing generics
    //we can use system.IComparable for comparing generics
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] arr;
        public GenericMaximum(T[] arr)
        {
            this.arr = arr;
        }
        public void genericmax() 
        {
            Array.Sort(this.arr);
            printMax(arr[arr.Length-1]);
        }
        public void printMax(T maximum)
        {
            Console.WriteLine($"maximum among all is {maximum}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            int[] intarray = { 11, 20, 301, 4, 51, };
            char[] chararray = { 'z', 'b','c','d'};
            double[] doublearray = { 101.1, 20.2, 31.3, 47.4 };
            GenericMaximum<int> genericmax = new GenericMaximum<int>(intarray);
            genericmax.genericmax();
            GenericMaximum<char> genericmaxchar = new GenericMaximum<char>(chararray);
            genericmaxchar.genericmax();
            GenericMaximum<double> genericmaxdouble = new GenericMaximum<double>(doublearray);
            genericmaxdouble.genericmax();
        }
        
    }
}