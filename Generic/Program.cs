using System.Runtime.CompilerServices;

namespace Generic
{
    //we can not use <,= etc. for comparing generics
    //we can use system.IComparable for comparing generics
    public class GenericMaximum<T> where T : IComparable
    {
        public void genericmaximumamong3(T first,T second,T third) 
        {
            T mx=first;
            if(mx.CompareTo(second)<0)
            {
                mx = second;
            }
            if(mx.CompareTo(third)<0)
            {
                mx = third;
            }
            Console.WriteLine($"maximum among {first}, {second}, {third} is --> {mx}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            int[] intarray = { 1, 2, 3, 4, 5, };
            char[] chararray = { 'a', 'b','c','d'};
            double[] doublearray = { 1.1, 2.2, 3.3, 4.4 };
            GenericMaximum<int> obj = new GenericMaximum<int>();
            obj.genericmaximumamong3(11,21,31);
            GenericMaximum<double> obj1 = new GenericMaximum<double>();
            obj1.genericmaximumamong3(1.1,2.1,1.9);
            GenericMaximum<char> obj2 = new GenericMaximum<char>();
            obj2.genericmaximumamong3('d','b','c');
        }
        
    }
}