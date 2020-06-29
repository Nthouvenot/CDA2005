using System;
using System.Collections.Generic;
using System.Text;

namespace IntroVisualStudio.Models
{
    class Point
    {
        private int x;
        private int y;

        /// <summary>
        /// constructor no param
        /// </summary>
        public Point():this(0, 0)
        {

        }

        /// <summary>
        /// constructor one param string
        /// </summary>
        /// <param name="_x"></param>
        public Point(int _x) : this(_x, 0)
        {

        }

        /// <summary>
        /// constructor with two integer param
        /// </summary>
        /// <param name="_x"></param>
        /// <param name="_y"></param>
        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }
}
