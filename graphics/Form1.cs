using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace graphics
{
   
    public partial class Form1 : Form
    {
       // DataTable DT = new DataTable();
        int x, y;
        int nx = -1, ny = -1;
        public float steps;
        public int q = 0;
        public Bitmap bt, clip, fil;
        Color cl;
        double angleInDegrees;
        List<Point> points = new List<Point>();
        List<Point> pointsCircle = new List<Point>();
        List<Point> pPoints = new List<Point>();
        PointF[] pointss;
        List<Point> nPoints = new List<Point>();
        List<Edget> edgets = new List<Edget>();
        List<float> M = new List<float>();
        List<int> Ymin = new List<int>();
        List<int> Ymax = new List<int>();
        List<int> Xstart = new List<int>();
        Bitmap bit;
        int max = 0, min;
        System.Drawing.Point coordinates;
        Graphics g;
        int h = -1;

   
        public Form1()
        {
            InitializeComponent();
            bt = new Bitmap(pic.Width, pic.Height);
             // clip = new Bitmap(pic.Width, pic.Height);
            cl = new Color();
            cl = Color.Red;
        }
        ///
        public class Point
        {
            int _x;
            int _y;
            public Point(int x, int y)
            {
                this._x = x;
                this._y = y;
            }

            public int X
            {
                get { return _x; }
                set { _x = value; }
            }
            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }
        }

        public class Edget
        {
            Point _Point1;
            Point _Point2;
            public Edget(Point x, Point y)
            {
                this._Point1 = x;
                this._Point2 = y;
            }

            public Point Point1
            {
                get { return _Point1; }
                set { _Point1 = value; }
            }
            public Point Point2
            {
                get { return _Point2; }
                set { _Point2 = value; }
            }
        }
        ///
        ///
        public List<Point> sort(List<Point> list)
        {
            Point temp;
            for (int j = 0; j <= list.Count - 2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i].X > list[i + 1].X)
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }
        public List<Point> pointsBetweenEdget(int y0, int y1, float m, int x)
        {
            List<Point> points = new List<Point>();
            float X = x;
            for (int i = min; i <= max; i++)
            {
                if (i >= y0 && i <= y1)
                {
                    points.Add(new Point((int)Math.Round(X, MidpointRounding.AwayFromZero), i));
                    X = (float)Math.Round(X, 1) + (float)Math.Round(m, 1);
                }
                else
                {
                    points.Add(new Point(-1, i));
                }
            }
            return points;
        }

        public List<List<Point>> listsOfPointsBettweenEdgets()
        {
            List<List<Point>> lists = new List<List<Point>>();
            for (int i = 0; i < edgets.Count; i++)
            {
                lists.Add(pointsBetweenEdget(Ymin[i], Ymax[i], M[i], Xstart[i]));
                Console.WriteLine("ymin = " + Ymin[i] + "ymax + " + Ymax[i]);
            }
            return lists;
        }


        public List<List<Point>> listsOfPairs()
        {
            List<List<Point>> listData = listsOfPointsBettweenEdgets();
            List<List<Point>> lists = new List<List<Point>>(listData[0].Count);
            List<List<Point>> finalLists = new List<List<Point>>(listData.Count);
            foreach (List<Point> list in listData)
            {
                Console.WriteLine("points");
                foreach (Point point in list)
                {
                    if (point.X != -1) Console.WriteLine("X = " + point.X + " Y = " + point.Y);
                }
            }
            for (int i = 0; i < max - min; i++)
            {
                List<Point> values = new List<Point>();
                foreach (List<Point> list in listData)
                {
                    if (list[i].X != -1)
                    {
                        values.Add(list[i]);
                    }
                }
                lists.Add(values);
            }
            for (int i = 0; i < lists.Count; i++)
            {
                finalLists.Add(sort(lists[i]));
            }
            return finalLists;
        }
        ///
        // Defining region codes       //BinaryCode
        const int INSIDE = 0;               // 0000 
        const int LEFT = 1;                 // 0001 
        const int RIGHT = 2;                // 0010 
        const int BOTTOM = 4;                // 0100 
        const int TOP = 8;                      // 1000 
        ///  
        // Defining x_max, y_max and x_min, y_min for 
        // clipping rectangle. Since diagonal points are 
        // enough to define a rectangle 
        /// Window_Co-ordinates
        const int x_max = 200;
        const int y_max = 200;
        const int x_min = 100;
        const int y_min = 100;
        int computeCode(double x, double y)
        {
           
            int code = INSIDE;
            if (x < x_min)
                code |= LEFT;
            else if (code > x_max)
                code |= RIGHT;
            else if (code < y_min)
                code |= BOTTOM;
            else if (code > y_max)
                code |= TOP;

            return code;
        }
        void cohenSutherlandClip(double x1, double y1,double x2, double y2)
        {
            int code1 = computeCode(x1, y1);
            int code2 = computeCode(x2, y2);
            bool accept = false;
            while (true)
            {
                if ((code1 == 0) && (code2 == 0))
                {
                    accept = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    // If both endpoints are outside rectangle, 
                    // in same region 
                    break;
                }
                else
                {
                    int code_out;
                    double x = 0, y = 0;

                    // At least one endpoint is outside the  
                    // rectangle, pick it. 
                    if (code1 != 0)
                        code_out = code1;
                    else
                        code_out = code2;
                    // Find intersection point; 
                    // using formulas y = y1 + slope * (x - x1), 
                    // x = x1 + (1 / slope) * (y - y1) 
                    if((code_out & TOP) !=TOP)
                    {
                        x = x1 + (x2 - x1) * (y_max - y1) / (y2 - y1);
                        y = y_max;
                    
                    }
                    else if ((code_out & BOTTOM) != BOTTOM)
                    {
                        // point is below the rectangle 
                        x = x1 + (x2 - x1) * (y_min - y1) / (y2 - y1);
                        y = y_min;
                    }
                    else if ((code_out & RIGHT) != Right)
                    {
                        // point is to the right of rectangle 
                        y = y1 + (y2 - y1) * (x_max - x1) / (x2 - x1);
                        x = x_max;
                    }
                    else if ((code_out & LEFT) != Left)
                    {
                        // point is to the left of rectangle 
                        y = y1 + (y2 - y1) * (x_min - x1) / (x2 - x1);
                        x = x_min;
                    }

                    // Now intersection point x,y is found 
                    // We replace point outside rectangle 
                    // by intersection point 
                    if (code_out == code1)
                    {
                        x1 = x;
                        y1 = y;
                        code1 = computeCode(x1, y1);
                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        code2 = computeCode(x2, y2);
                    }
                
                }
            }
            if (accept)
            {
                button3.Text = "Line accepted from " + x1 + ", "
                     + y1 + " to " + x2 + ", " + y2;
                drawline_DDA(x1, y1, x2, y2);
            }
            else
                button3.Text = "Line rejected"; 
          
        }

        private void drawline_DDA(double x1, double y1, double x2, double y2)
        {
            throw new System.NotImplementedException();
        }
        public void drawline_DDA(int x1, int y1, int x2, int y2)
        {
           
            int dx = x2 - x1;
            int dy = y2 - y1;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xinc = dx / (float)steps;
            float yinc = dy / (float)steps;
            bt.SetPixel(x1, y1, Color.Red);
            float x = x1, y = y1;

            for (int i = 0; i < steps; i++)
            {
                DataGridViewRow r = new DataGridViewRow();


                r.CreateCells(dgv);
                r.Cells[0].Value = i;
                r.Cells[1].Value = x;
                r.Cells[2].Value = y;
                x = x + xinc;
                y = y + yinc;
                r.Cells[3].Value = (int)Math.Round(x);
                r.Cells[4].Value = (int)Math.Round(y);
                bt.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Red);
                q++;
                dgv.Rows.Add(r);
                pic.Image = bt;
            }
           
        }
        public void drawline_DDA1(int x1, int y1, int x2, int y2,Color color)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xinc = dx / (float)steps;
            float yinc = dy / (float)steps;
            bt.SetPixel(x1, y1, Color.Red);
            float x = x1, y = y1;

            for (int i = 0; i < steps; i++)
            {
                
                x = x + xinc;
                y = y + yinc;
               
                bt.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Red);
                q++;
                pic.Image = bt;
            }

        }
        public void drawline_Bresenham(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            Bitmap bt = new Bitmap(pic.Width, pic.Height);
            bool s = false;
            if (dy > dx)
            {
                int t = dx;
                dx = dy;
                dy = t;
                s = true;
            }
            int dx2 = 2 * dx;
            int dy2 = 2 * dy;

            int pi = dy2 - dx;
            int x = x1, y = y1;

            for (int i = 0; i < dx; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgv);
                r.Cells[0].Value = i;
                r.Cells[1].Value = x;
                r.Cells[2].Value = y;
                r.Cells[3].Value = pi;
                if (pi > 0)
                {
                    y++;
                    pi = pi + dy2 - dx2;
                }
                else
                    pi = pi + dy2;
               x++;
                r.Cells[4].Value = x;
                r.Cells[5].Value = y;
                if (!s)
                    bt.SetPixel(x, y, Color.Blue);
                else
                {
                    bt.SetPixel(y, x, Color.Blue);
                    r.Cells[1].Value = y;
                    r.Cells[2].Value = x;
                    r.Cells[4].Value = y;
                    r.Cells[5].Value = x;
                }
                dgv.Rows.Add(r);
            }
            pic.Image = bt;
        }
        public void drawCircle(int radus, int xc, int yc)
        {
           
            int x = 0;
            int y = radus;
            int i = 0;
            int p = 1-radus;
            bt.SetPixel(x + xc, yc + y, Color.Black);
            bt.SetPixel(x + xc, yc + y, Color.Black);
            bt.SetPixel(x + xc, yc + y, Color.Black);
            bt.SetPixel(x + xc, yc + y, Color.Black);

            pic.Image = null;
            while (y >= x)
            {
                x++;
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgv);
                r.Cells[0].Value = i;
                r.Cells[1].Value = x;
                r.Cells[3].Value = p;
                if (p <= 0)
                {
                    p = p + 2 * x + 1;
                    r.Cells[2].Value = y;

                } 
                else
                {

                    p = p + 2 * x - 2 * y + 1;
                    y--;
                    r.Cells[2].Value = y;
                }
          
                bt.SetPixel(x + xc, yc + y, Color.Blue);
                bt.SetPixel(-x + xc, yc + y, Color.Blue);
                bt.SetPixel(x + xc, yc - y, Color.Blue);
                bt.SetPixel(xc - x, yc - y, Color.Blue);

                bt.SetPixel(xc + y, yc + x, Color.Blue);
                bt.SetPixel(xc - y, yc + x, Color.Blue);
                bt.SetPixel(xc + y, yc - x, Color.Blue);
                bt.SetPixel(xc - y, yc - x, Color.Blue);
              
                dgv.Rows.Add(r);
                i++;
            }
            pic.Image = bt;
        
        }
        public void drawEllipce(int rx, int ry)
        {
            int x = 0, y = ry;
            int d0 = (ry * ry) - rx * rx * ry + ((1 / 4) * rx * rx);
            int i = 0;
            while ((2 * ry * ry * x) < (2 * rx * rx * y))
            {
                x++;
                if (d0 < 0)
                    d0 = d0 + 2 * ry * ry * x + ry * ry;
                else
                {
                    y--;
                    d0 = d0 + (2 * ry * ry * x) - (2 * rx * rx) * y + ry * ry;
                }
                bt.SetPixel(x + 100, y + 100, Color.Blue);
                bt.SetPixel(-x + 100, y + 100, Color.Blue);
                bt.SetPixel(-x + 100, -y + 100, Color.Blue);
                bt.SetPixel(x + 100, -y + 100, Color.Blue);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgv);
                r.Cells[0].Value = i;
                r.Cells[1].Value = d0;
                r.Cells[2].Value = x;
                r.Cells[3].Value = y;
                r.Cells[4].Value = 2 * ry * ry * x;
                r.Cells[5].Value = 2 * rx * rx * y;
                dgv.Rows.Add(r);
                i++;
            }

            double p0 = ry * ry * (x + 0.5) * (x + 0.5) + rx * rx * (y - 1) * (y - 1) - rx * rx * ry * ry;
            while (y > 0)
            {
                y--;
                if (p0 < 0)
                {
                    x++;
                    p0 = p0 + 2 * ry * ry * x - 2 * rx * rx * y + rx * rx;
                }
                else
                {
                    p0 = p0 - 2 * rx * rx * y + rx * rx;
                }
                bt.SetPixel(x + 100, y + 100, Color.Blue);
                bt.SetPixel(-x + 100, y + 100, Color.Blue);
                bt.SetPixel(-x + 100, -y + 100, Color.Blue);
                bt.SetPixel(x + 100, -y + 100, Color.Blue);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgv);
                r.Cells[0].Value = i;
                r.Cells[1].Value = p0;
                r.Cells[2].Value = x;
                r.Cells[3].Value = y;
                r.Cells[4].Value = 2 * ry * ry * x;
                r.Cells[5].Value = 2 * rx * rx * y;
                dgv.Rows.Add(r);
                i++;
            }
            pic.Image = bt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            pic.Image = null;

            Bitmap bt = new Bitmap(pic.Width, pic.Height);
            if (DDA.Checked==true)
            {
                int x1 = int.Parse(x1Box.Text);
                int y1 = int.Parse(y1Box.Text);
                int x2 = int.Parse(x2Box.Text);
                int y2 = int.Parse(y2Box.Text);

                drawline_DDA(x1, y1, x2, y2);
            }
            else if (Bresenham.Checked == true)
            {
                int x1 = int.Parse(x1Box.Text);
                int y1 = int.Parse(y1Box.Text);
                int x2 = int.Parse(x2Box.Text);
                int y2 = int.Parse(y2Box.Text);
                drawline_Bresenham(x1, y1, x2, y2);
            }
            if (Circle.Checked == true)
            {
                int x1 = int.Parse(x1Box.Text);
                int y1 = int.Parse(y1Box.Text);
                int rx = int.Parse(R1Box.Text);
                drawCircle(rx, x1 ,y1);
            
            } 
            else if (elipse.Checked==true)
            {
                int rx = int.Parse(R1Box.Text);
                int ry = int.Parse(R2Box.Text);
                if (elipse.Checked == true)
                    drawEllipce(rx, ry);
            }
            }
       
        private void Bresenham_CheckedChanged(object sender, EventArgs e)
        {
            R1Box.Visible = false;
            R2Box.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            if (Bresenham.Checked==true)
            {
               
                dgv.Columns[0].HeaderText = "i";
                dgv.Columns[1].HeaderText = "x";
                dgv.Columns[2].HeaderText = "y";
                dgv.Columns[3].HeaderText = "p";
                dgv.Columns[4].HeaderText = "x+1";
                dgv.Columns[5].HeaderText = "y+1";
             

            }
        }
        private void DDA_CheckedChanged(object sender, EventArgs e)
        {
            R1Box.Visible = false;
            R2Box.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            if (DDA.Checked == true)
            {
        
                dgv.Columns[0].HeaderText = "i";
                dgv.Columns[1].HeaderText = "x";
                dgv.Columns[2].HeaderText = "y";
                dgv.Columns[3].HeaderText = "Round x";
                dgv.Columns[4].HeaderText = "Round y";
                dgv.Columns[5].HeaderText = "";
            }
        }
    
        private void Circle_CheckedChanged(object sender, EventArgs e)
        {
            x2Box.Visible = false;
            label2.Visible = false;
            y2Box.Visible = false;
            label4.Visible = false;
            R2Box.Visible = false;
            label6.Visible = false;
            if(Circle.Checked==true)
          
                dgv.Columns[0].HeaderText = "i";
                dgv.Columns[1].HeaderText = "x";
                dgv.Columns[2].HeaderText = "y";
                dgv.Columns[3].HeaderText = "p";
               
        }

        private void elipse_CheckedChanged(object sender, EventArgs e)
        {
            x2Box.Visible = false;
            label2.Visible = false;
            y2Box.Visible = false;
            label4.Visible = false;
            if (elipse.Checked == true)
            
           
            dgv.Columns[0].HeaderText = "i";
            dgv.Columns[1].HeaderText = "pi";
            dgv.Columns[2].HeaderText = "xi+1";
            dgv.Columns[3].HeaderText = "yi+1";
            dgv.Columns[4].HeaderText = "2ry2Xi+1";
            dgv.Columns[5].HeaderText = "2rx2Yi+1";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            pic.Image = null;
            button3.Text = "Excute";
            dgv.Rows.Clear();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (TransBox.Checked== true)
            {

                int tx = int.Parse(textBox_Bersinham_trans_x.Text);
                int ty = int.Parse(textBox_Bersinham_trans_y.Text);
                int x1 = int.Parse(x1Box.Text);
                int y1 = int.Parse(y1Box.Text);
                int x2 = int.Parse(x2Box.Text);
                int y2 = int.Parse(y2Box.Text);
                x1 += tx;
                x2 += tx;
                y1 += ty;
                y2 += ty;
                drawline_Bresenham(x1, y1, x2, y2);
           
              
            }
            else if (ScalBox.Checked==true)
            {
            
              int sx = int.Parse(scale_x.Text);
              int sy = int.Parse(scale_y.Text);
              int x1 = int.Parse(x1Box.Text);
              int y1 = int.Parse(y1Box.Text);
              int x2 = int.Parse(x2Box.Text);
              int y2 = int.Parse(y2Box.Text);
              x1 *= sx;
              x2 *= sx;
              y1 *= sy;
              y2 *= sy;
              drawline_Bresenham(x1, y1, x2, y2);
            
            }
            else if (RotaBox.Checked == true)
            {
                int x1 = int.Parse(x1Box.Text);
                int y1 = int.Parse(y1Box.Text);
                int x2 = int.Parse(x2Box.Text);
                int y2 = int.Parse(y2Box.Text);
                double a = double.Parse(angle.Text);
                double angleInRadians = a * (Math.PI / 180);
                int xn1, yn1, xn2, yn2;
                xn1 = (int)((x1 * Math.Cos(angleInRadians)) - (y1 * Math.Sin(angleInRadians)));
                xn2 = (int)((x2 * (Math.Cos(angleInRadians))) - (y2 * Math.Sin(angleInRadians)));
                yn1 = (int)((y1 * (Math.Cos(angleInRadians))) + (x1 * Math.Sin(angleInRadians)));
                yn2 = (int)((y2 * (Math.Cos(angleInRadians))) + (x2 * Math.Sin(angleInRadians)));
                drawline_DDA(xn1, yn1, xn2, yn2);
            }
            else if(Clipping.Checked==true)
            {
        
                double x1 = double.Parse(x1Box.Text);
                double y1 = double.Parse(y1Box.Text);
                double x2 =double.Parse(x2Box.Text);
                double y2 = double.Parse(y2Box.Text);
                cohenSutherlandClip(x1, y1, x2, y2);
            }
        }

       
        private void TransBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (TransBox.Checked == true)
            {
                angle.Visible = false;
                label9.Visible = false;
            }
        }

        private void Clipping_CheckedChanged(object sender, System.EventArgs e)
        {
            dgv.Columns[0].HeaderText = "i";
            dgv.Columns[1].HeaderText = "x";
            dgv.Columns[2].HeaderText = "y";
            dgv.Columns[3].HeaderText = "Round x";
            dgv.Columns[4].HeaderText = "Round y";
            dgv.Columns[5].HeaderText = "";
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            points.Add(new Point(50, 300));
            points.Add(new Point(50, 50));
            points.Add(new Point(50, 10));
            points.Add(new Point(300, 10));
            points.Add(new Point(300, 300));


            pointss = new PointF[points.Count];
            int j = 0;
            foreach (Point point in points)
            {
                pointss[j] = new PointF(point.X, point.Y);
                j++;
            }
            for (int i = 0; i < points.Count; i++)
            {
                if (i != points.Count - 1) drawline_DDA1(points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y, Color.White);
            }
            drawline_DDA1(points[points.Count - 1].X, points[points.Count - 1].Y, points[0].X, points[0].Y, Color.White);
            pic.Image = bt;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            
         
            pointsCircle.Add(new Point(int.Parse(x1Box.Text), int.Parse(y1Box.Text)));
            x1Box.Clear();
            y1Box.Clear();
           
            boundaryFill(pointsCircle[h].X, pointsCircle[h].Y, ColorTranslator.ToHtml(Color.White), ColorTranslator.ToHtml(Color.Brown));
            pic.Image = bt;
        }
        void boundaryFill(int x, int y, String boundCol, String fillCol)
        {
            int color = bt.GetPixel(x, y).ToArgb();
            int colorfill  = ColorTranslator.FromHtml(fillCol).ToArgb();
            int colorbound = ColorTranslator.FromHtml(boundCol).ToArgb();
            if (color != colorbound && color != colorfill)
            {
                bt.SetPixel(x, y, ColorTranslator.FromHtml(fillCol));
                boundaryFill(x + 1, y, boundCol, fillCol);
                boundaryFill(x - 1, y, boundCol, fillCol);
                boundaryFill(x, y + 1, boundCol, fillCol);
                boundaryFill(x, y - 1, boundCol, fillCol);

            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            // floodFill(pointsCircle[h].X, pointsCircle[h].Y, ColorTranslator.ToHtml(Color.Brown), ColorTranslator.ToHtml(Color.Orange));
            floodFill(int.Parse(x1Box.Text), int.Parse(y1Box.Text), ColorTranslator.ToHtml(Color.Red), ColorTranslator.ToHtml(Color.White));
            
            pic.Image = bt;
        }
        void floodFill(int x, int y, String oriCol, String fillCol)
        {
            int color = bt.GetPixel(x, y).ToArgb();
            int colorOld = ColorTranslator.FromHtml(oriCol).ToArgb();
            if (color == colorOld)
            {
                bt.SetPixel(x, y, ColorTranslator.FromHtml(fillCol));
                // right semi-circle
                floodFill(x, y + 1, oriCol, fillCol);
                floodFill(x, y - 1, oriCol, fillCol);
                // left semi-circle
                floodFill(x + 1, y, oriCol, fillCol);
                floodFill(x - 1, y, oriCol, fillCol);
            }
        }
        public void scanLineFilling()
        {
            min = points[0].Y;
            max = points[0].Y;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].Y > max)
                {
                    max = points[i].Y;
                }
                if (points[i].Y < min)
                {
                    min = points[i].Y;
                }
                if (i == 0) { pPoints.Add(points[points.Count - 1]); }
                else { pPoints.Add(points[i - 1]); }
                if (i != points.Count - 1) { nPoints.Add(points[i + 1]); }
                else { nPoints.Add(points[0]); }
                edgets.Add(new Edget(new Point(points[i].X, points[i].Y), new Point(nPoints[i].X, nPoints[i].Y)));
            }
            for (int i = 0; i < edgets.Count; i++)
            {
                M.Add(((float)(edgets[i].Point2.X - edgets[i].Point1.X) / (float)(edgets[i].Point2.Y - edgets[i].Point1.Y)));
                if (edgets[i].Point2.Y > edgets[i].Point1.Y)
                {
                    if (edgets[i].Point2.Y == edgets[i].Point1.Y && edgets[i].Point2.X > edgets[i].Point1.X)
                    {
                        Ymin.Add(edgets[i].Point1.Y);
                        Xstart.Add(edgets[i].Point2.X);
                        Ymax.Add(edgets[i].Point2.Y);
                    }
                    else
                    {
                        Ymin.Add(edgets[i].Point1.Y);
                        Xstart.Add(edgets[i].Point1.X);
                        Ymax.Add(edgets[i].Point2.Y);
                    }
                }
                else
                {
                    Ymin.Add(edgets[i].Point2.Y);
                    Xstart.Add(edgets[i].Point2.X);
                    Ymax.Add(edgets[i].Point1.Y);
                }
            }
            for (int i = 0; i < edgets.Count; i++)
            {
                if (pPoints[i].Y < points[i].Y && points[i].Y < nPoints[i].Y && i == 0)
                {
                    edgets[edgets.Count - 1].Point2.Y = points[i].Y - 1;
                    Ymax[edgets.Count - 1] = points[i].Y - 1;
                    edgets[edgets.Count - 1].Point2.X = (int)Math.Round(pPoints[i].X + M[edgets.Count - 1] * (points[i].Y - 1 - pPoints[i].Y), MidpointRounding.AwayFromZero);
                }
                else if (pPoints[i].Y < points[i].Y && points[i].Y < nPoints[i].Y)
                {
                    edgets[i - 1].Point2.Y = points[i].Y - 1;
                    Ymax[i - 1] = points[i].Y - 1;
                    edgets[i - 1].Point2.X = (int)Math.Round(pPoints[i].X + M[i - 1] * (points[i].Y - 1 - pPoints[i].Y), MidpointRounding.AwayFromZero);
                }
                else if (pPoints[i].Y > points[i].Y && points[i].Y > nPoints[i].Y)
                {
                    edgets[i].Point1.Y = points[i].Y - 1;
                    Ymax[i] = points[i].Y - 1;
                    edgets[i].Point1.X = (int)Math.Round(nPoints[i].X + M[i] * (points[i].Y - 1 - nPoints[i].Y), MidpointRounding.AwayFromZero);
                }
            }
            foreach (List<Point> list in listsOfPairs())
            {

                for (int i = 0; i < list.Count / 2; i += 2)
                {
                    drawline_DDA1(list[i].X, list[i].Y, list[i + 1].X, list[i + 1].Y, Color.Brown);
                }
            }
        }
        int i = 0;
        private void button8_Click(object sender, System.EventArgs e)
        {
            if (x1Box.Text != "")
            {
                points.Add(new Point(int.Parse(x1Box.Text), int.Parse(y1Box.Text)));
            }
            else
            {
                points.Add(new Point(coordinates.X, coordinates.Y));
            }
            i++;
            x1Box.Clear();
            y2Box.Clear();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            scanLineFilling();
            pic.Image = bt;
        }
      
        }
    }
   

