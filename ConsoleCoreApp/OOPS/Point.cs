﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class Point
    {
        int x, y;

        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Point({x},{y})";
        }

        //Overloading ("+") Operator
        public static Point operator +(Point p1, Point p2) 
        {
            int x = p1.x + p2.x;
            int y = p1.y + p2.y;
            return new Point(x, y); 
        }

        //Overloading ("-") Operator
        public static Point operator -(Point p1, Point p2)
        {
            int x = p1.x - p2.x;
            int y = p1.y - p2.y;
            return new Point(x, y);
        }

        //Overloading ("==") Operator
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y ? true : false;
        }

        //Overloading ("!=") Operator
        public static bool operator !=(Point p1, Point p2)
        {
            return p1.x != p2.x || p1.y != p2.y ? true : false;
        }
    }
}
