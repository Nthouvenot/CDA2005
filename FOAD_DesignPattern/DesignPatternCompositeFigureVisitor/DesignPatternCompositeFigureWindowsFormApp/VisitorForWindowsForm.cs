using CompositeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCompositeFigureWindowsFormApp
{
    class VisitorForWindowsForm : IVisitor
    {
        private Graphics graphic;

        public VisitorForWindowsForm(Graphics formGraphic)
        {
            this.graphic = formGraphic;
        }

        public void Visit(Circle circle)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphic.DrawEllipse(pen, new System.Drawing.Rectangle(circle.Coordinate.XCoordinnate - (circle.Radius / 2), circle.Coordinate.YCoordinnate - (circle.Radius / 2), circle.Radius, circle.Radius));
        }

        public void Visit(Figures figures)
        {
           
        }

        public void Visit(CompositeLibrary.Rectangle rectangle)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphic.DrawRectangle((pen), new System.Drawing.Rectangle(rectangle.Coordinate.XCoordinnate, rectangle.Coordinate.YCoordinnate, rectangle.CoordinateSecondDot.XCoordinnate - rectangle.Coordinate.XCoordinnate, rectangle.CoordinateSecondDot.YCoordinnate - rectangle.Coordinate.YCoordinnate));
        }

        public void Visit(Square square)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphic.DrawRectangle((pen), new System.Drawing.Rectangle(square.Coordinate.XCoordinnate, square.Coordinate.YCoordinnate, square.Width, square.Width));
        }

        public void Visit(Triangle triangle)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphic.DrawLine(pen, new Point(triangle.Coordinate.XCoordinnate, triangle.Coordinate.YCoordinnate), new Point(triangle.CoordinateSecondDot.XCoordinnate, triangle.CoordinateSecondDot.YCoordinnate));
            graphic.DrawLine(pen, new Point(triangle.CoordinateSecondDot.XCoordinnate, triangle.CoordinateSecondDot.YCoordinnate), new Point(triangle.CoordinateThirdDot.XCoordinnate, triangle.CoordinateThirdDot.YCoordinnate));
            graphic.DrawLine(pen, new Point(triangle.CoordinateThirdDot.XCoordinnate, triangle.CoordinateThirdDot.YCoordinnate), new Point(triangle.Coordinate.XCoordinnate, triangle.Coordinate.YCoordinnate));
        }
    }
}
