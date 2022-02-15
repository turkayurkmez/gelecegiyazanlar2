using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir base class ve bir de bu class'dan miras alan derived class olsun. Derived class, base'in davranışını DEĞİŞTİRMEMELİ 
             * Base -> Derived birbirlerinin yerine kullanılabilir olmalı.
             */
            Console.WriteLine("Hello World!");

            var geometry = GetCalcutableArea(5,1);

            Console.WriteLine(geometry.GetArea());

        }

        static IAreaCalcutable GetCalcutableArea(int x, int? y=null)
        {
            // bir biçimde bu factory method geriye kare döndürüyor.
            if (y.HasValue)
            {
                return new Rectangle { Width = x, Height = y.Value };
            }
            else
            {
                return new Square { Unit = x };
            }
        }
       
    }


    public interface IAreaCalcutable
    {
        int GetArea();
    }

    public class Rectangle : IAreaCalcutable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IAreaCalcutable
    {

        public int Unit { get; set; }

        public int GetArea()
        {
            return Unit * Unit;
        }


    }
}
