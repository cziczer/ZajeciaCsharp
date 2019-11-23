using System;

namespace Interface
{
    interface IShape
    {
        void DrawMethod();
    }

    class Circle : IShape
    {
        void IShape.DrawMethod()
        {
            Console.WriteLine("Rysuje okrąg");
        }

        public void RandomMethod()
        {
            Console.WriteLine("Randomowa Metoda");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            // Declare an interface instance.
            IShape obj = new Circle();
            Circle imp = new Circle();
            //imp.DrawMethod();
            //obj.DrawMethod();

            //Kolizje
            ExampleClass sc = new ExampleClass();
            IPaint paint = sc;
            ISurface surface = sc;

            sc.Paint();
            paint.Paint();
            surface.Paint();
        }
    }
}
