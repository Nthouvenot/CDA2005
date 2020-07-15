using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExercicePoint
{
    class Point
    {
        private int x;
        private int y;

        /// <summary>
        /// constructor with no paramater
        /// </summary>
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        /// <summary>
        /// constructeur with the two coordinate of the point in parameters
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        /// <summary>
        /// getter of the x attribute
        /// </summary>
        public int X 
        { 
            get => this.x;
        }

        /// <summary>
        /// getter of the y attribute
        /// </summary>
        public int Y
        {
            get => this.y;
        }

        /// <summary>
        /// set the coordinate of the point
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public void Move(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        /// <summary>
        /// return the coordinate of the point in string format
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return this.x + "," + this.y;
        }

        /// <summary>
        /// return an abscissa symetrical point of the current point
        /// </summary>
        /// <returns>Point</returns>
        public Point CreateSymetricalAbscissaPoint()
        {
            Point point = new Point(this.x, -(this.y));
            return point;
        }

        /// <summary>
        /// return an ordinate symetrical point of the current point
        /// </summary>
        /// <returns>Point</returns>
        public Point CreateSymetricalOrdinatePoint()
        {
            Point point = new Point(-(this.x), this.y);
            return point;
        }

        /// <summary>
        /// return an origin symetrical point of the current point
        /// </summary>
        /// <returns>Point</returns>
        public Point CreateSymetricalOriginPoint()
        {
            Point point = new Point(-(this.x), -(this.y));
            return point;
        }

        /// <summary>
        /// move x and y
        /// </summary>
        public void MoveSymetrical()
        {
            int transitionY = 0;
            transitionY = this.y;
            this.y = this.x;
            this.x = transitionY;
        }
    }
}
