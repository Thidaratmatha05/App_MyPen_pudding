using System.Drawing.Drawing2D;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //paint the exterior
            Pen myPen = new Pen(Color.Black);

            //วงกลม วงรี
            g.DrawEllipse(myPen, 100, 50, 200, 100);
            g.DrawEllipse(myPen, 50, 250, 300, 100);
            //เส้นแยง
            g.DrawLine(myPen, 100, 100, 50, 300);
            g.DrawLine(myPen, 300, 100, 350, 300);

            // Create solid brush-Yellow.
            SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
            //สี่เหลี่ยม
            Rectangle rect = new Rectangle(100, 100, 200, 200);
            // Fill rectangle to screen.
            e.Graphics.FillRectangle(YellowBrush, rect);

            //สามเหลี่ยม
            // Create points that define polygon.
            Point point1 = new Point(50, 300);
            Point point2 = new Point(100, 100);
            Point point3 = new Point(200, 200);
            Point[] curvePoints = { point1, point2, point3 };
            // Draw polygon to screen.
            e.Graphics.FillPolygon(YellowBrush, curvePoints);
            // Create points that define polygon.
            Point point4 = new Point(350, 300);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(200, 200);
            Point[] curve = { point4, point5, point6 };
            // Draw polygon to screen.
            e.Graphics.FillPolygon(YellowBrush, curve);

            //pating the interior
            //เติมสีวงกลม
            SolidBrush OrangeBrush = new SolidBrush(Color.Orange);
            Rectangle rect1 = new Rectangle(100, 50, 200, 100);
            e.Graphics.FillEllipse(OrangeBrush, rect1);
            SolidBrush OrangeB = new SolidBrush(Color.Brown);
            Rectangle rect2 = new Rectangle(50, 250, 300, 100);
            e.Graphics.FillEllipse(OrangeB, rect2);




            //ใส่ตัวหนังสือ
            // Create string to draw.
            String drawString = "This is pudding.";
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // Create rectangle for drawing.
            float x = 200.0F;
            float y = 20.0F;
            float width = 200.0F;
            float height = 50.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);


        }
    }
}