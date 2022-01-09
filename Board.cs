using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Intellector
{
    using static Intellector.Figure;
    using static Intellector.Color;
    using static Intellector.Field;
    using static System.Math;

    public class Board
    {
        private float k = 1.27F;

        private static Image boardW = new Bitmap("Pics\\boardW.png");

        private static Image pW = new Bitmap("Pics\\pW.png");
        private static Image mW = new Bitmap("Pics\\mW.png");
        private static Image aW = new Bitmap("Pics\\aW.png");
        private static Image lW = new Bitmap("Pics\\lW.png");
        private static Image dW = new Bitmap("Pics\\dW.png");
        private static Image iW = new Bitmap("Pics\\iW.png");

        private static Image pB = new Bitmap("Pics\\pB.png");
        private static Image mB = new Bitmap("Pics\\mB.png");
        private static Image aB = new Bitmap("Pics\\aB.png");
        private static Image lB = new Bitmap("Pics\\lB.png");
        private static Image dB = new Bitmap("Pics\\dB.png");
        private static Image iB = new Bitmap("Pics\\iB.png");

        private static Point pos0 = new Point(77, 832); // центр a1
        private static int r = 70; // радиус описанной окружности 
        private static int h = 60; // расстояние от центра к стороне

        private static Dictionary<Field, Point> coords = new Dictionary<Field, Point> // координаты относительно доски
        {
            { a1, new Point(pos0.X, pos0.Y) },
            { b1, new Point(pos0.X + 3*r/2, pos0.Y - h) },
            { c1, new Point(pos0.X + 3*r, pos0.Y) },
            { d1, new Point(pos0.X + 9*r/2, pos0.Y - h) },
            { e1, new Point(pos0.X + 6*r, pos0.Y) },
            { f1, new Point(pos0.X + 15*r/2, pos0.Y - h) },
            { g1, new Point(pos0.X + 9*r, pos0.Y) },
            { h1, new Point(pos0.X + 21*r/2, pos0.Y - h) },
            { i1, new Point(pos0.X + 12*r, pos0.Y) },

            { a2, new Point(pos0.X, pos0.Y - 2*h) },
            { b2, new Point(pos0.X + 3*r/2, pos0.Y - 3*h) },
            { c2, new Point(pos0.X + 3*r, pos0.Y - 2*h) },
            { d2, new Point(pos0.X + 9*r/2, pos0.Y - 3*h) },
            { e2, new Point(pos0.X + 6*r, pos0.Y - 2*h) },
            { f2, new Point(pos0.X + 15*r/2, pos0.Y - 3*h) },
            { g2, new Point(pos0.X + 9*r, pos0.Y - 2*h) },
            { h2, new Point(pos0.X + 21*r/2, pos0.Y - 3*h) },
            { i2, new Point(pos0.X + 12*r, pos0.Y - 2*h) },

            { a3, new Point(pos0.X, pos0.Y - 4*h) },
            { b3, new Point(pos0.X + 3*r/2, pos0.Y - 5*h) },
            { c3, new Point(pos0.X + 3*r, pos0.Y - 4*h) },
            { d3, new Point(pos0.X + 9*r/2, pos0.Y - 5*h) },
            { e3, new Point(pos0.X + 6*r, pos0.Y - 4*h) },
            { f3, new Point(pos0.X + 15*r/2, pos0.Y - 5*h) },
            { g3, new Point(pos0.X + 9*r, pos0.Y - 4*h) },
            { h3, new Point(pos0.X + 21*r/2, pos0.Y - 5*h) },
            { i3, new Point(pos0.X + 12*r, pos0.Y - 4*h) },

            { a4, new Point(pos0.X, pos0.Y - 6*h) },
            { b4, new Point(pos0.X + 3*r/2, pos0.Y - 7*h) },
            { c4, new Point(pos0.X + 3*r, pos0.Y - 6*h) },
            { d4, new Point(pos0.X + 9*r/2, pos0.Y - 7*h) },
            { e4, new Point(pos0.X + 6*r, pos0.Y - 6*h) },
            { f4, new Point(pos0.X + 15*r/2, pos0.Y - 7*h) },
            { g4, new Point(pos0.X + 9*r, pos0.Y - 6*h) },
            { h4, new Point(pos0.X + 21*r/2, pos0.Y - 7*h) },
            { i4, new Point(pos0.X + 12*r, pos0.Y - 6*h) },

            { a5, new Point(pos0.X, pos0.Y - 8*h) },
            { b5, new Point(pos0.X + 3*r/2, pos0.Y - 9*h) },
            { c5, new Point(pos0.X + 3*r, pos0.Y - 8*h) },
            { d5, new Point(pos0.X + 9*r/2, pos0.Y - 9*h) },
            { e5, new Point(pos0.X + 6*r, pos0.Y - 8*h) },
            { f5, new Point(pos0.X + 15*r/2, pos0.Y - 9*h) },
            { g5, new Point(pos0.X + 9*r, pos0.Y - 8*h) },
            { h5, new Point(pos0.X + 21*r/2, pos0.Y - 9*h) },
            { i5, new Point(pos0.X + 12*r, pos0.Y - 8*h) },

            { a6, new Point(pos0.X, pos0.Y - 10*h) },
            { b6, new Point(pos0.X + 3*r/2, pos0.Y - 11*h) },
            { c6, new Point(pos0.X + 3*r, pos0.Y - 10*h) },
            { d6, new Point(pos0.X + 9*r/2, pos0.Y - 11*h) },
            { e6, new Point(pos0.X + 6*r, pos0.Y - 10*h) },
            { f6, new Point(pos0.X + 15*r/2, pos0.Y - 11*h) },
            { g6, new Point(pos0.X + 9*r, pos0.Y - 10*h) },
            { h6, new Point(pos0.X + 21*r/2, pos0.Y - 11*h) },
            { i6, new Point(pos0.X + 12*r, pos0.Y - 10*h) },

            { a7, new Point(pos0.X, pos0.Y - 12*h) },
            { c7, new Point(pos0.X + 3*r, pos0.Y - 12*h) },
            { e7, new Point(pos0.X + 6*r, pos0.Y - 12*h) },
            { g7, new Point(pos0.X + 9*r, pos0.Y - 12*h) },
            { i7, new Point(pos0.X + 12*r, pos0.Y - 12*h) },
        };

        public Position position;

        public Field activeField = u;

        //public Color userColor = W;

        private float Dist(float x0, float y0, float x1, float y1)
        {
            return (float)Pow(Pow(x0 - x1, 2) +
                              Pow(y0 - y1, 2), 0.5);
        }

        private Field DefineField(Point point)
        {
            Field res = u;
            float minDist = 10000;

            foreach (Field field in Enum.GetValues(typeof(Field)))
                if (field != u)
                    if (Dist(coords[field].X / k, coords[field].Y / k, point.X, point.Y) < minDist)
                    {
                        minDist = Dist(coords[field].X / k, coords[field].Y / k, point.X, point.Y);
                        res = field;
                    }
            return res;
        }

        public void SetActiveField(Point point, string radioName)
        {
            Field newActiveField = DefineField(point);

            if (radioName == "radioMove")
            {
                FrmChoose frmChoose = new FrmChoose();

                List<Move> moves = position.GetMoves(); // ищем ход, который хочет походить игрок
                foreach (Move move in moves)             // если есть, то ходим
                    if ((move.from == activeField) && (move.to == newActiveField))
                    {
                        frmChoose.AddMove(move);
                    }
                if (frmChoose.moves.Count == 1) position = position.Move((Move)frmChoose.moves[0]);
                if (frmChoose.moves.Count > 1)
                {
                    frmChoose.ListMoves.DoubleClick += new EventHandler(MovesDoubleClick);
                    frmChoose.Show();
                }

                activeField = newActiveField;
            } else
                switch (radioName)
                {
                    case "radioClear": position[newActiveField] = N; break;
                    case "radiom": position[newActiveField] = m; break;
                    case "radioa": position[newActiveField] = a; break;
                    case "radiol": position[newActiveField] = l; break;
                    case "radiod": position[newActiveField] = d; break;
                    case "radiop": position[newActiveField] = p; break;
                    case "radioi": position[newActiveField] = i; break;
                    case "radiomb": position[newActiveField] = M; break;
                    case "radioab": position[newActiveField] = A; break;
                    case "radiolb": position[newActiveField] = L; break;
                    case "radiodb": position[newActiveField] = D; break;
                    case "radiopb": position[newActiveField] = P; break;
                    case "radioib": position[newActiveField] = I; break;
                }
        }

        private void MovesDoubleClick(object sender, EventArgs e)
        {
            Move move = ((FrmChoose)((ListBox)sender).Parent).moves[((ListBox)sender).SelectedIndex];
            // определяем выюранный ход по номеру в ListBox
            position = position.Move(move);
            ((Form)((ListBox)sender).Parent).Close();
            FrmMain.ActiveForm.Refresh();
        }

        // конструктор
        public Board()
        {
            position = Position.StartPos();
        }

        public void Draw(Graphics graph)
        {
            Pen redPen = new Pen(System.Drawing.Color.Red, 2);
            Pen bluePen = new Pen(System.Drawing.Color.Blue, 2);
            Brush redBrush = new SolidBrush(System.Drawing.Color.Red);
            Brush blueBrush = new SolidBrush(System.Drawing.Color.Blue);

            graph.DrawImage(boardW, 0, 0);

            Bitmap figure;
            foreach (Field field in Enum.GetValues(typeof(Field)))
                if (field != u)
                {
                    switch (position[field])
                    {
                        case p: figure = new Bitmap(pW); break;
                        case m: figure = new Bitmap(mW); break;
                        case a: figure = new Bitmap(aW); break;
                        case l: figure = new Bitmap(lW); break;
                        case d: figure = new Bitmap(dW); break;
                        case i: figure = new Bitmap(iW); break;

                        case P: figure = new Bitmap(pB); break;
                        case M: figure = new Bitmap(mB); break;
                        case A: figure = new Bitmap(aB); break;
                        case L: figure = new Bitmap(lB); break;
                        case D: figure = new Bitmap(dB); break;
                        case I: figure = new Bitmap(iB); break;

                        case N: figure = new Bitmap(1, 1); break;
                        default: figure = new Bitmap("Случилась какая-то ерунда"); break;
                    }

                    graph.DrawImage(figure, (coords[field].X - r/2)/k, (coords[field].Y - h)/k, r/k, 2*h/k);
                }

            //if (activeField != u) // рисование кружочка на активном поле
            //    graph.FillEllipse(redBrush, (coords[activeField].X-15)/k, (coords[activeField].Y-15)/k, 30, 30);

            if (activeField != u)
            if (Position.Color(position[activeField]) == position.turn) // если нажали на свою фигуру, подсвечиваем ходы
            {
                List<Move> moves = position.GetMoves();
                foreach(Move move in moves)
                    if (move.from == activeField)
                        graph.FillEllipse(blueBrush, (coords[move.to].X - 15) / k, (coords[move.to].Y - 15) / k, 30, 30);
            }
        }
    }
}
