using CompositeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternCompositeFigureWindowsFormApp
{
    public partial class Form1 : Form
    {
        PictureBox pictureBoxForm1;

        public PictureBox PictureBoxForm1 { get => pictureBoxForm1; protected set => pictureBoxForm1 = value; }

        public Form1()
        {
            InitializeComponent();
            pictureBoxForm1 = new PictureBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxForm1.Dock = DockStyle.Fill;
            pictureBoxForm1.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBoxForm1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // Add the PictureBox control to the Form.
            this.Controls.Add(pictureBoxForm1);
        }

        public void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            VisitorForWindowsForm visitorForWindowsForm = new VisitorForWindowsForm(e.Graphics);
            Figures figures = new Figures(new Coordinate(0, 0));
            Triangle triangle = new Triangle(new Coordinate(10, 100), new Coordinate(60, 10), new Coordinate(110, 100));
            Circle circle = new Circle(new Coordinate(60, 150), 100);
            Figures innerFigures = new Figures(new Coordinate(10, 200));
            Square square = new Square(new Coordinate(10, 200), 100);
            CompositeLibrary.Rectangle rectangle1 = new CompositeLibrary.Rectangle(new Coordinate(10, 300), new Coordinate(20, 400));
            CompositeLibrary.Rectangle rectangle2 = new CompositeLibrary.Rectangle(new Coordinate(100, 300), new Coordinate(110, 400));
            figures.AddFigure(triangle);
            figures.AddFigure(circle);
            innerFigures.AddFigure(square);
            innerFigures.AddFigure(rectangle1);
            innerFigures.AddFigure(rectangle2);
            figures.AddFigure(innerFigures);
            figures.AcceptVisitor(visitorForWindowsForm);
            visitorForWindowsForm.Visit(figures);

        }
    }
}
