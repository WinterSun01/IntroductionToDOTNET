﻿//#define ABSTRACT_CHECK
#define INTERFACE_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;	//Эта библиотека позволит подключать к нашему файлу другие DLL-фалы, и использовать функции из этих DLL-файлов

namespace AbstractGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape();
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rectangle = new System.Drawing.Rectangle(Console.WindowLeft, Console.WindowTop, Console.WindowWidth, Console.WindowHeight);
            PaintEventArgs e = new PaintEventArgs(graphics, window_rectangle);
#if ABSTRACT_CHECK

			Rectangle rectangle = new Rectangle(100, 80, 200, 100, 5, Color.AliceBlue);
			rectangle.Info(e);

			Square square = new Square(120, 400, 100, 3, Color.Red);
			square.Info(e);
			//square.Width = 200;
			//square.Info(e);

			Circle circle = new Circle(150, 500, 100, 10, System.Drawing.Color.Yellow);
			circle.Info(e);

			//Able, IMovable, IFlyable, IComparable
			//I....able
			//Interface - это набор абстрактных методов.
			//Интерфейсы НЕ наследуют, интерфейсы реализуют.  
#endif

#if INTERFACE_CHECK
            Shape[] shapes = new Shape[]
                {
                    new Square(120, 400, 100, 3, Color.Red),
                    new Rectangle(100, 80, 200, 100, 5, Color.AliceBlue),
                    new Circle(150, 500, 100, 10, System.Drawing.Color.Yellow)
                };
            //foreach (Shape i in shapes) i.Info(e);
            //foreach (Shape i in shapes) if(i is IHaveDiameter)i.Info(e);
            foreach (Shape i in shapes) if (i is Rectangle) i.Info(e);
            //Оператор 'is' проверяет объект по признаку 'является' ('is-a' наследование) и 'способен' ('able' интерфейсы).
            Console.WriteLine((shapes[0] as Shape).GetType());
#endif
        }
        [DllImport("kernel32.dll")]
        public static extern bool GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}