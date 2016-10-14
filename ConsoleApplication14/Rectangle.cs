using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Rectangle
    {
        
        //поля
        private double side1;
        private double side2;

        private double area;
        private double perimetr;
       
        //методы
        private double AreaCalculator()
        {
            return side1*Side2;
        }
        private double PerimeterCalculator()
        {

            return ((side1+side2)*2);
        }
        //свойства
        public double Side1
        {
            set
            {
                side1 = value;
            }
            get
            {
                return side1;
            }

        }
        public double Side2
        {
            set
            {
                side2 = value;
            }
            get
            {
                return side2;
            }

        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimetr
        {
            get
            {
                return PerimeterCalculator();
            }

        }



        //конструктор
        public Rectangle()
        {
            Console.WriteLine("Конструктор по умолчанию");
        }
        //пользовательский конструктор
        public Rectangle(double x1, double x2)
        {
            this.side1 = x1;
            this.side2 = x2;
        }
    }
}
