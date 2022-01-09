using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intellector
{
    using static Intellector.Figure;
    using static Intellector.Color;
    using static Intellector.Field;

    public class Position
    {
        // индексатор
        public Figure this[Field field]                                                                                                                                                                                                                                                                                              
        {
            get
            {
                return pos[field];
            }
            set
            {
                pos[field] = value;
            }
        }

        public override int GetHashCode()
        {
            int res = 0;
            int pow = 1;
            int y = 0;
            foreach (Field field in Enum.GetValues(typeof(Field)))
                if (field != Field.u)
                {
                    if (pos[field] != N) res += pow;
                    pow *= 2;
                    if (y++ == 30) break;
                }
            return res;
        }

        public static int qFields = 59;
        
        private static Dictionary<Field, List<Field>> pMoves = new Dictionary<Field, List<Field>>
        {
            { a2, new List<Field> { a3, b2} },
            { b2, new List<Field> { a3, b3, c3} },
            { c2, new List<Field> { b2, c3, d2} },
            { d2, new List<Field> { c3, d3, e3} },
            { e2, new List<Field> { d2, e3, f2} },
            { f2, new List<Field> { e3, f3, g3} },
            { g2, new List<Field> { f2, g3, h2} },
            { h2, new List<Field> { g3, h3, i3} },
            { i2, new List<Field> { h2, i3} },

            { a3, new List<Field> { a4, b3} },
            { b3, new List<Field> { a4, b4, c4} },
            { c3, new List<Field> { b3, c4, d3} },
            { d3, new List<Field> { c4, d4, e4} },
            { e3, new List<Field> { d3, e4, f3} },
            { f3, new List<Field> { e4, f4, g4} },
            { g3, new List<Field> { f3, g4, h3} },
            { h3, new List<Field> { g4, h4, i4} },
            { i3, new List<Field> { h3, i4} },

            { a4, new List<Field> { a5, b4} },
            { b4, new List<Field> { a5, b5, c5} },
            { c4, new List<Field> { b4, c5, d4} },
            { d4, new List<Field> { c5, d5, e5} },
            { e4, new List<Field> { d4, e5, f4} },
            { f4, new List<Field> { e5, f5, g5} },
            { g4, new List<Field> { f4, g5, h4} },
            { h4, new List<Field> { g5, h5, i5} },
            { i4, new List<Field> { h4, i5} },

            { a5, new List<Field> { a6, b5} },
            { b5, new List<Field> { a6, b6, c6} },
            { c5, new List<Field> { b5, c6, d5} },
            { d5, new List<Field> { c6, d6, e6} },
            { e5, new List<Field> { d5, e6, f5} },
            { f5, new List<Field> { e6, f6, g6} },
            { g5, new List<Field> { f5, g6, h5} },
            { h5, new List<Field> { g6, h6, i6} },
            { i5, new List<Field> { h5, i6} },

            { a6, new List<Field> { a7, b6} },
            { b6, new List<Field> { a7, c7} },
            { c6, new List<Field> { b6, c7, d6} },
            { d6, new List<Field> { c7, e7} },
            { e6, new List<Field> { d6, e7, f6} },
            { f6, new List<Field> { e7, g7} },
            { g6, new List<Field> { f6, g7, h6} },
            { h6, new List<Field> { g7, i7} },
            { i6, new List<Field> { h6, i7} },
        };

        private static Dictionary<Field, List<Field>> PMoves = new Dictionary<Field, List<Field>>
        {
            { a6, new List<Field> { a5, b5} },
            { b5, new List<Field> { a5, b4, c5} },
            { c6, new List<Field> { b5, c5, d5} },
            { d5, new List<Field> { c5, d4, e5} },
            { e6, new List<Field> { d5, e5, f5} },
            { f5, new List<Field> { e5, f4, g5} },
            { g6, new List<Field> { f5, g5, h5} },
            { h5, new List<Field> { g5, h4, i5} },
            { i6, new List<Field> { h5, i5} },

            { a5, new List<Field> { a4, b4} },
            { b4, new List<Field> { a4, b3, c4} },
            { c5, new List<Field> { b4, c4, d4} },
            { d4, new List<Field> { c4, d3, e4} },
            { e5, new List<Field> { d4, e4, f4} },
            { f4, new List<Field> { e4, f3, g4} },
            { g5, new List<Field> { f4, g4, h4} },
            { h4, new List<Field> { g4, h3, i4} },
            { i5, new List<Field> { h4, i4} },

            { a4, new List<Field> { a3, b3} },
            { b3, new List<Field> { a3, b2, c3} },
            { c4, new List<Field> { b3, c3, d3} },
            { d3, new List<Field> { c3, d2, e3} },
            { e4, new List<Field> { d3, e3, f3} },
            { f3, new List<Field> { e3, f2, g3} },
            { g4, new List<Field> { f3, g3, h3} },
            { h3, new List<Field> { g3, h2, i3} },
            { i4, new List<Field> { h3, i3} },

            { a3, new List<Field> { a2, b2} },
            { b2, new List<Field> { a2, b1, c2} },
            { c3, new List<Field> { b2, c2, d2} },
            { d2, new List<Field> { c2, d1, e2} },
            { e3, new List<Field> { d2, e2, f2} },
            { f2, new List<Field> { e2, f1, g2} },
            { g3, new List<Field> { f2, g2, h2} },
            { h2, new List<Field> { g2, h1, i2} },
            { i3, new List<Field> { h2, i2} },

            { a2, new List<Field> { a1, b1} },
            { b1, new List<Field> { a1, c1} },
            { c2, new List<Field> { b1, c1, d1} },
            { d1, new List<Field> { c1, e1} },
            { e2, new List<Field> { d1, e1, f1} },
            { f1, new List<Field> { e1, g1} },
            { g2, new List<Field> { f1, g1, h1} },
            { h1, new List<Field> { g1, i1} },
            { i2, new List<Field> { h1, i1} },
        };

        private static Dictionary<Field, List<Field>> dMoves = new Dictionary<Field, List<Field>>
        {
            { a1, new List<Field> { a2, b1} },
            { b1, new List<Field> { a1, a2, b2, c2, c1} },
            { c1, new List<Field> { b1, c2, d1} },
            { d1, new List<Field> { c1, c2, d2, e2, e1} },
            { e1, new List<Field> { d1, e2, f1} },
            { f1, new List<Field> { e1, e2, f2, g2, g1} },
            { g1, new List<Field> { f1, g2, h1} },
            { h1, new List<Field> { g1, g2, h2, i2, i1} },
            { i1, new List<Field> { h1, i2} },

            { a2, new List<Field> { a1, a3, b2, b1} },
            { b2, new List<Field> { b1, a2, a3, b3, c3, c2} },
            { c2, new List<Field> { c1, b1, b2, c3, d2, d1} },
            { d2, new List<Field> { d1, c2, c3, d3, e3, e2} },
            { e2, new List<Field> { e1, d1, d2, e3, f2, f1} },
            { f2, new List<Field> { f1, e2, e3, f3, g3, g2} },
            { g2, new List<Field> { g1, f1, f2, g3, h2, h1} },
            { h2, new List<Field> { h1, g2, g3, h3, i3, i2} },
            { i2, new List<Field> { i1, h1, h2, i3} },

            { a3, new List<Field> { a2, a4, b3, b2} },
            { b3, new List<Field> { b2, a3, a4, b4, c4, c3} },
            { c3, new List<Field> { c2, b2, b3, c4, d3, d2} },
            { d3, new List<Field> { d2, c3, c4, d4, e4, e3} },
            { e3, new List<Field> { e2, d2, d3, e4, f3, f2} },
            { f3, new List<Field> { f2, e3, e4, f4, g4, g3} },
            { g3, new List<Field> { g2, f2, f3, g4, h3, h2} },
            { h3, new List<Field> { h2, g3, g4, h4, i4, i3} },
            { i3, new List<Field> { i2, h2, h3, i4} },

            { a4, new List<Field> { a3, a5, b4, b3} },
            { b4, new List<Field> { b3, a4, a5, b5, c5, c4} },
            { c4, new List<Field> { c3, b3, b4, c5, d4, d3} },
            { d4, new List<Field> { d3, c4, c5, d5, e5, e4} },
            { e4, new List<Field> { e3, d3, d4, e5, f4, f3} },
            { f4, new List<Field> { f3, e4, e5, f5, g5, g4} },
            { g4, new List<Field> { g3, f3, f4, g5, h4, h3} },
            { h4, new List<Field> { h3, g4, g5, h5, i5, i4} },
            { i4, new List<Field> { i3, h3, h4, i5} },

            { a5, new List<Field> { a4, a6, b5, b4} },
            { b5, new List<Field> { b4, a5, a6, b6, c6, c5} },
            { c5, new List<Field> { c4, b4, b5, c6, d5, d4} },
            { d5, new List<Field> { d4, c5, c6, d6, e6, e5} },
            { e5, new List<Field> { e4, d4, d5, e6, f5, f4} },
            { f5, new List<Field> { f4, e5, e6, f6, g6, g5} },
            { g5, new List<Field> { g4, f4, f5, g6, h5, h4} },
            { h5, new List<Field> { h4, g5, g6, h6, i6, i5} },
            { i5, new List<Field> { i4, h4, h5, i6} },

            { a6, new List<Field> { a5, a7, b6, b5} },
            { b6, new List<Field> { b5, a6, a7, c7, c6} },
            { c6, new List<Field> { c5, b5, b6, c7, d6, d5} },
            { d6, new List<Field> { d5, c6, c7, e7, e6} },
            { e6, new List<Field> { e5, d5, d6, e7, f6, f5} },
            { f6, new List<Field> { f5, e6, e7, g7, g6} },
            { g6, new List<Field> { g5, f5, f6, g7, h6, h5} },
            { h6, new List<Field> { h5, g6, g7, i7, i6} },
            { i6, new List<Field> { i5, h5, h6, i7} },

            { a7, new List<Field> { a6, b6} },
            { c7, new List<Field> { c6, b6, d6} },
            { e7, new List<Field> { e6, d6, f6} },
            { g7, new List<Field> { g6, f6, h6} },
            { i7, new List<Field> { i6, h6} },
        };

        private static Dictionary<Field, List<Field>> iMoves = dMoves;

        private static Dictionary<Field, List<Field>> lnMoves = dMoves;

        private static Dictionary<Field, List<Field>> lfMoves = new Dictionary<Field, List<Field>>
        {
            { a1, new List<Field> { a3, c2} },
            { b1, new List<Field> { b3, d2} },
            { c1, new List<Field> { a2, c3, e2} },
            { d1, new List<Field> { b2, d3, f2} },
            { e1, new List<Field> { c2, e3, g2} },
            { f1, new List<Field> { d2, f3, h2} },
            { g1, new List<Field> { e2, g3, i2} },
            { h1, new List<Field> { f2, h3} },
            { i1, new List<Field> { g2, i3} },

            { a2, new List<Field> { a4, c3, c1} },
            { b2, new List<Field> { b4, d3, d1} },
            { c2, new List<Field> { a1, a3, c4, e3, e1} },
            { d2, new List<Field> { b1, b3, d4, f3, f1} },
            { e2, new List<Field> { c1, c3, e4, g3, g1} },
            { f2, new List<Field> { d1, d3, f4, h3, h1} },
            { g2, new List<Field> { e1, e3, g4, i3, i1} },
            { h2, new List<Field> { f1, f3, h4} },
            { i2, new List<Field> { g1, g3, i4} },

            { a3, new List<Field> { a1, a5, c4, c2} },
            { b3, new List<Field> { b1, b5, d4, d2} },
            { c3, new List<Field> { c1, a2, a4, c5, e4, e2} },
            { d3, new List<Field> { d1, b2, b4, d5, f4, f2} },
            { e3, new List<Field> { e1, c2, c4, e5, g4, g2} },
            { f3, new List<Field> { f1, d2, d4, f5, h4, h2} },
            { g3, new List<Field> { g1, e2, e4, g5, i4, i2} },
            { h3, new List<Field> { h1, f2, f4, h5} },
            { i3, new List<Field> { i1, g2, g4, i5} },

            { a4, new List<Field> { a2, a6, c5, c3} },
            { b4, new List<Field> { b2, b6, d5, d3} },
            { c4, new List<Field> { c2, a3, a5, c6, e5, e3} },
            { d4, new List<Field> { d2, b3, b5, d6, f5, f3} },
            { e4, new List<Field> { e2, c3, c5, e6, g5, g3} },
            { f4, new List<Field> { f2, d3, d5, f6, h5, h3} },
            { g4, new List<Field> { g2, e3, e5, g6, i5, i3} },
            { h4, new List<Field> { h2, f3, f5, h6} },
            { i4, new List<Field> { i2, g3, g5, i6} },

            { a5, new List<Field> { a3, a7, c6, c4} },
            { b5, new List<Field> { b3, d6, d4} },
            { c5, new List<Field> { c3, a4, a6, c7, e6, e4} },
            { d5, new List<Field> { d3, b4, b6, f6, f4} },
            { e5, new List<Field> { e3, c4, c6, e7, g6, g4} },
            { f5, new List<Field> { f3, d4, d6, h6, h4} },
            { g5, new List<Field> { g3, e4, e6, g7, i6, i4} },
            { h5, new List<Field> { h3, f4, f6} },
            { i5, new List<Field> { i3, g4, g6, i7} },

            { a6, new List<Field> { a4, c7, c5} },
            { b6, new List<Field> { b4, d5} },
            { c6, new List<Field> { c4, a5, a7, e7, e5} },
            { d6, new List<Field> { d4, b5, f5} },
            { e6, new List<Field> { e4, c5, c7, g7, g5} },
            { f6, new List<Field> { f4, d5, h5} },
            { g6, new List<Field> { g4, e5, e7, i7, i5} },
            { h6, new List<Field> { h4, f5} },
            { i6, new List<Field> { i4, g5, g7} },

            { a7, new List<Field> { a5, c6} },
            { c7, new List<Field> { c5, a6, e6} },
            { e7, new List<Field> { e5, c6, g6} },
            { g7, new List<Field> { g5, e6, i6} },
            { i7, new List<Field> { i5, g6} },
        };

        private static Dictionary<Field, List<Field>> aMoves = new Dictionary<Field, List<Field>>
        {
            { a1, new List<Field> { b2, c4, d5, e7, u, c1, e1, g1, i1 } },
            { c1, new List<Field> { a1, u, b2, a4, u, d2, e4, f5, g7, u, e1, g1, i1 } },
            { e1, new List<Field> { c1, a1, u, d2, c4, b5, a7, u, f2, g4, h5, i7, u, g1, i1 } },
            { g1, new List<Field> { e1, c1, a1, u, f2, e4, d5, c7, u, h2, i4, u, i1 } },
            { i1, new List<Field> { g1, e1, c1, a1, u, h2, g4, f5, e7 } },

            { b2, new List<Field> { a1, u,  a4, u, c4, d5, e7, u, d2, f2, h2, u, c1 } },
            { d2, new List<Field> { c1, u, b2, u, c4, b5, a7, u, e4, f5, g7, u, f2, h2, u, e1 } },
            { f2, new List<Field> { e1, u, d2, b2, u, e4, d5, c7, u, g4, h5, i7, u, h2, u, g1 } },
            { h2, new List<Field> { g1, u, f2, d2, b2, u, g4, f5, e7, u, i4, u, i1 } },

            { a4, new List<Field> { b5, c7, u, c4, e4, g4, i4, u, b2, c1 } },
            { c4, new List<Field> { b2, a1, u, a4, u, b5, a7, u, d5, e7, u, e4, g4, i4, u, d2, e1 } },
            { e4, new List<Field> { d2, c1, u, c4, a4, u, d5, c7, u, f5, g7, u, g4, i4, u, f2, g1 } },
            { g4, new List<Field> { f2, e1, u, e4, c4, a4, u, f5, e7, u, h5, i7, u, i4, u, h2, i1 } },
            { i4, new List<Field> { h2, g1, u, g4, e4, c4, a4, u, h5, g7 } },

            { b5, new List<Field> { a4, u, a7, u, c7, u, d5, f5, h5, u, c4, d2, e1 } },
            { d5, new List<Field> { c4, b2, a1, u, b5, u, c7, u, e7, u, f5, h5, u, e4, f2, g1 } },
            { f5, new List<Field> { e4, d2, c1, u, d5, b5, u, e7, u, g7, u, h5, u, g4, h2, i1 } },
            { h5, new List<Field> { g4, f2, e1, u, f5, d5, b5, u, g7, u, i7, u, i4 } },

            { a7, new List<Field> { c7, e7, g7, i7, u, b5, c4, d2, e1 } },
            { c7, new List<Field> { b5, a4, u, a7, u, e7, g7, i7, u, d5, e4, f2, g1 } },
            { e7, new List<Field> { d5, c4, b2, a1, u, c7, a7, u, g7, i7, u, f5, g4, h2, i1 } },
            { g7, new List<Field> { f5, e4, d2, c1, u, e7, c7, a7, u, i7, u, h5, i4 } },
            { i7, new List<Field> { h5, g4, f2, e1, u, g7, e7, c7, a7 } },
        };

        private static Dictionary<Field, List<Field>> mMoves = new Dictionary<Field, List<Field>>
        {
            { a1, new List<Field> { a2, a3, a4, a5, a6, a7, u, b1, c2, d2, e3, f3, g4, h4, i5 } },
            { b1, new List<Field> { a1, u, a2, u, b2, b3, b4, b5, b6, u, c2, d2, e3, f3, g4, h4, i5, u, c1 } },
            { c1, new List<Field> { b1, a2, u, c2, c3, c4, c5, c6, c7, u, d1, e2, f2, g3, h3, i4 } },
            { d1, new List<Field> { c1, u, c2, b2, a3, u, d2, d3, d4, d5, d6, u, e2, f2, g3, h3, i4, u, e1 } },
            { e1, new List<Field> { d1, c2, b2, a3, u, e2, e3, e4, e5, e6, e7, u, f1, g2, h2, i3 } },
            { f1, new List<Field> { e1, u, e2, d2, c3, b3, a4, u, f2, f3, f4, f5, f6, u, g2, h2, i3, u, g1 } },
            { g1, new List<Field> { f1, e2, d2, c3, b3, a4, u, g2, g3, g4, g5, g6, g7, u, h1, i2 } },
            { h1, new List<Field> { g1, u, g2, f2, e3, d3, c4, b4, a5, u, h2, h3, h4, h5, h6, u, i2, u, i1 } },
            { i1, new List<Field> { h1, g2, f2, e3, d3, c4, b4, a5, u, i2, i3, i4, i5, i6, i7 } },

            { a2, new List<Field> { a1, u, a3, a4, a5, a6, a7, u, b2, c3, d3, e4, f4, g5, h5, i6, u, b1, c1 } },
            { b2, new List<Field> { b1, u, a2, u, a3, u, b3, b4, b5, b6, u, c3, d3, e4, f4, g5, h5, i6, u, c2, d1, e1 } },
            { c2, new List<Field> { c1, u, b1, a1, u, b2, a3, u, c3, c4, c5, c6, c7, u, d2, e3, f3, g4, h4, i5, u, d1, e1 } },
            { d2, new List<Field> { d1, u, c2, b1, a1, u, c3, b3, a4, u, d3, d4, d5, d6, u, e3, f3, g4, h4, i5, u, e2, f1, g1 } },
            { e2, new List<Field> { e1, u, d1, c1, u, d2, c3, b3, a4, u, e3, e4, e5, e6, e7, u, f2, g3, h3, i4, u, f1, g1 } },
            { f2, new List<Field> { f1, u, e2, d1, c1, u, e3, d3, c4, b4, a5, u, f3, f4, f5, f6, u, g3, h3, i4, u, g2, h1, i1 } },
            { g2, new List<Field> { g1, u, f1, e1, u, f2, e3, d3, c4, b4, a5, u, g3, g4, g5, g6, g7, u, h2, i3, u, h1, i1 } },
            { h2, new List<Field> { h1, u, g2, f1, e1, u, g3, f3, e4, d4, c5, b5, a6, u, h3, h4, h5, h6, u, i3, u, i2 } },
            { i2, new List<Field> { i1, u, h1, g1, u, h2, g3, f3, e4, d4, c5, b5, a6, u, i3, i4, i5, i6, i7 } },

            { a3, new List<Field> { a2, a1, u, a4, a5, a6, a7, u, b3, c4, d4, e5, f5, g6, h6, i7, u, b2, c2, d1, e1 } },
            { b3, new List<Field> { b2, b1, u, a3, u, a4, u, b4, b5, b6, u, c4, d4, e5, f5, g6, h6, i7, u, c3, d2, e2, f1, g1 } },
            { c3, new List<Field> { c2, c1, u, b2, a2, u, b3, a4, u, c4, c5, c6, c7, u, d3, e4, f4, g5, h5, i6, u, d2, e2, f1, g1 } },
            { d3, new List<Field> { d2, d1, u, c3, b2, a2, u, c4, b4, a5, u, d4, d5, d6, u, e4, f4, g5, h5, i6, u, e3, f2, g2, h1, i1 } },
            { e3, new List<Field> { e2, e1, u, d2, c2, b1, a1, u, d3, c4, b4, a5, u, e4, e5, e6, e7, u, f3, g4, h4, i5, u, f2, g2, h1, i1 } },
            { f3, new List<Field> { f2, f1, u, e3, d2, c2, b1, a1, u, e4, d4, c5, b5, a6, u, f4, f5, f6, u, g4, h4, i5, u, g3, h2, i2 } },
            { g3, new List<Field> { g2, g1, u, f2, e2, d1, c1, u, f3, e4, d4, c5, b5, a6, u, g4, g5, g6, g7, u, h3, i4, u, h2, i2 } },
            { h3, new List<Field> { h2, h1, u, g3, f2, e2, d1, c1, u, g4, f4, e5, d5, c6, b6, a7, u, h4, h5, h6, u, i4, u, i3 } },
            { i3, new List<Field> { i2, i1, u, h2, g2, f1, e1, u, h3, g4, f4, e5, d5, c6, b6, a7, u, i4, i5, i6, i7 } },

            { a4, new List<Field> { a3, a2, a1, u, a5, a6, a7, u, b4, c5, d5, e6, f6, g7, u, b3, c3, d2, e2, f1, g1 } },
            { b4, new List<Field> { b3, b2, b1, u, a4, u, a5, u, b5, b6, u, c5, d5, e6, f6, g7, u, c4, d3, e3, f2, g2, h1, i1 } },
            { c4, new List<Field> { c3, c2, c1, u, b3, a3, u, b4, a5, u, c5, c6, c7, u, d4, e5, f5, g6, h6, i7, u, d3, e3, f2, g2, h1, i1 } },
            { d4, new List<Field> { d3, d2, d1, u, c4, b3, a3, u, c5, b5, a6, u, d5, d6, u, e5, f5, g6, h6, i7, u, e4, f3, g3, h2, i2 } },
            { e4, new List<Field> { e3, e2, e1, u, d3, c3, b2, a2, u, d4, c5, b5, a6, u, e5, e6, e7, u, f4, g5, h5, i6, u, f3, g3, h2, i2 } },
            { f4, new List<Field> { f3, f2, f1, u, e4, d3, c3, b2, a2, u, e5, d5, c6, b6, a7, u, f5, f6, u, g5, h5, i6, u, g4, h3, i3 } },
            { g4, new List<Field> { g3, g2, g1, u, f3, e3, d2, c2, b1, a1, u, f4, e5, d5, c6, b6, a7, u, g5, g6, g7, u, h4, i5, u, h3, i3 } },
            { h4, new List<Field> { h3, h2, h1, u, g4, f3, e3, d2, c2, b1, a1, u, g5, f5, e6, d6, c7, u, h5, h6, u, i5, u, i4 } },
            { i4, new List<Field> { i3, i2, i1, u, h3, g3, f2, e2, d1, c1, u, h4, g5, f5, e6, d6, c7, u, i5, i6, i7 } },

            { a5, new List<Field> { a4, a3, a2, a1, u, a6, a7, u, b5, c6, d6, e7, u, b4, c4, d3, e3, f2, g2, h1, i1 } },
            { b5, new List<Field> { b4, b3, b2, b1, u, a5, u, a6, u, b6, u, c6, d6, e7, u, c5, d4, e4, f3, g3, h2, i2 } },
            { c5, new List<Field> { c4, c3, c2, c1, u, b4, a4, u, b5, a6, u, c6, c7, u, d5, e6, f6, g7, u, d4, e4, f3, g3, h2, i2 } },
            { d5, new List<Field> { d4, d3, d2, d1, u, c5, b4, a4, u, c6, b6, a7, u, d6, u, e6, f6, g7, u, e5, f4, g4, h3, i3 } },
            { e5, new List<Field> { e4, e3, e2, e1, u, d4, c4, b3, a3, u, d5, c6, b6, a7, u, e6, e7, u, f5, g6, h6, i7, u, f4, g4, h3, i3 } },
            { f5, new List<Field> { f4, f3, f2, f1, u, e5, d4, c4, b3, a3, u, e6, d6, c7, u, f6, u, g6, h6, i7, u, g5, h4, i4 } },
            { g5, new List<Field> { g4, g3, g2, g1, u, f4, e4, d3, c3, b2, a2, u, f5, e6, d6, c7, u, g6, g7, u, h5, i6, u, h4, i4 } },
            { h5, new List<Field> { h4, h3, h2, h1, u, g5, f4, e4, d3, c3, b2, a2, u, g6, f6, e7, u, h6, u, i6, u, i5 } },
            { i5, new List<Field> { i4, i3, i2, i1, u, h4, g4, f3, e3, d2, c2, b1, a1, u, h5, g6, f6, e7, u, i6, i7 } },

            { a6, new List<Field> { a5, a4, a3, a2, a1, u, a7, u, b6, c7, u, b5, c5, d4, e4, f3, g3, h2, i2 } },
            { b6, new List<Field> { b5, b4, b3, b2, b1, u, a6, u, a7, u, c7, u, c6, d5, e5, f4, g4, h3, i3 } },
            { c6, new List<Field> { c5, c4, c3, c2, c1, u, b5, a5, u, b6, a7, u, c7, u, d6, e7, u, d5, e5, f4, g4, h3, i3 } },
            { d6, new List<Field> { d5, d4, d3, d2, d1, u, c6, b5, a5, u, c7, u, e7, u, e6, f5, g5, h4, i4 } },
            { e6, new List<Field> { e5, e4, e3, e2, e1, u, d5, c5, b4, a4, u, d6, c7, u, e7, u, f6, g7, u, f5, g5, h4, i4 } },
            { f6, new List<Field> { f5, f4, f3, f2, f1, u, e6, d5, c5, b4, a4, u, e7, u, g7, u, g6, h5, i5 } },
            { g6, new List<Field> { g5, g4, g3, g2, g1, u, f5, e5, d4, c4, b3, a3, u, f6, e7, u, g7, u, h6, i7, u, h5, i5 } },
            { h6, new List<Field> { h5, h4, h3, h2, h1, u, g6, f5, e5, d4, c4, b3, a3, u, g7, u, i7, u, i6 } },
            { i6, new List<Field> { i5, i4, i3, i2, i1, u, h5, g5, f4, e4, d3, c3, b2, a2, u, h6, g7, u, i7 } },

            { a7, new List<Field> { a6, a5, a4, a3, a2, a1, u, b6, c6, d5, e5, f4, g4, h3, i3 } },
            { c7, new List<Field> { c6, c5, c4, c3, c2, c1, u, b6, a6, u, d6, e6, f5, g5, h4, i4 } },
            { e7, new List<Field> { e6, e5, e4, e3, e2, e1, u, d6, c6, b5, a5, u, f6, g6, h5, i5 } },
            { g7, new List<Field> { g6, g5, g4, g3, g2, g1, u, f6, e6, d5, c5, b4, a4, u, h6, i6 } },
            { i7, new List<Field> { i6, i5, i4, i3, i2, i1, u, h6, g6, f5, e5, d4, c4, b3, a3 } },
        };

        public Dictionary<Field, Figure> pos = new Dictionary<Field, Figure>(qFields); // позиция

        public static Dictionary<Field, int> mQMoves = new Dictionary<Field, int>
        {
            { a1, 14 }, { b1, 15 }, { c1, 14 }, { d1, 15 }, { e1, 14 }, { f1, 15 }, { g1, 14 }, { h1, 15 }, { i1, 14 },
            { a2, 16 }, { b2, 17 }, { c2, 18 }, { d2, 19 }, { e2, 18 }, { f2, 19 }, { g2, 18 }, { h2, 17 }, { i2, 16 },
            { a3, 18 }, { b3, 19 }, { c3, 20 }, { d3, 21 }, { e3, 22 }, { f3, 21 }, { g3, 20 }, { h3, 19 }, { i3, 18 },
            { a4, 18 }, { b4, 19 }, { c4, 22 }, { d4, 21 }, { e4, 22 }, { f4, 21 }, { g4, 22 }, { h4, 19 }, { i4, 18 },
            { a5, 18 }, { b5, 17 }, { c5, 20 }, { d5, 19 }, { e5, 22 }, { f5, 19 }, { g5, 20 }, { h5, 17 }, { i5, 18 },
            { a6, 16 }, { b6, 15 }, { c6, 18 }, { d6, 15 }, { e6, 18 }, { f6, 15 }, { g6, 18 }, { h6, 15 }, { i6, 16 },
            { a7, 14 },             { c7, 14 },             { e7, 14 },             { g7, 14 },             { i7, 14 },
        };

        public static Dictionary<Field, int> dQMoves = new Dictionary<Field, int>
        {
            { a1, 2 }, { b1, 5 }, { c1, 3 }, { d1, 5 }, { e1, 3 }, { f1, 5 }, { g1, 3 }, { h1, 5 }, { i1, 2 },
            { a2, 4 }, { b2, 6 }, { c2, 6 }, { d2, 6 }, { e2, 6 }, { f2, 6 }, { g2, 6 }, { h2, 6 }, { i2, 4 },
            { a3, 4 }, { b3, 6 }, { c3, 6 }, { d3, 6 }, { e3, 6 }, { f3, 6 }, { g3, 6 }, { h3, 6 }, { i3, 4 },
            { a4, 4 }, { b4, 6 }, { c4, 6 }, { d4, 6 }, { e4, 6 }, { f4, 6 }, { g4, 6 }, { h4, 6 }, { i4, 4 },
            { a5, 4 }, { b5, 6 }, { c5, 6 }, { d5, 6 }, { e5, 6 }, { f5, 6 }, { g5, 6 }, { h5, 6 }, { i5, 4 },
            { a6, 4 }, { b6, 5 }, { c6, 6 }, { d6, 5 }, { e6, 6 }, { f6, 5 }, { g6, 6 }, { h6, 5 }, { i6, 4 },
            { a7, 2 },            { c7, 3 },            { e7, 3 },            { g7, 3 },            { i7, 2 },
        };

        public static Dictionary<Field, int> lnQMoves = dQMoves;

        public static Dictionary<Field, int> lfQMoves = new Dictionary<Field, int>
        {
            { a1, 2 }, { b1, 2 }, { c1, 3 }, { d1, 3 }, { e1, 3 }, { f1, 3 }, { g1, 3 }, { h1, 2 }, { i1, 2 },
            { a2, 3 }, { b2, 3 }, { c2, 5 }, { d2, 5 }, { e2, 5 }, { f2, 5 }, { g2, 5 }, { h2, 3 }, { i2, 3 },
            { a3, 4 }, { b3, 4 }, { c3, 6 }, { d3, 6 }, { e3, 6 }, { f3, 6 }, { g3, 6 }, { h3, 4 }, { i3, 4 },
            { a4, 4 }, { b4, 4 }, { c4, 6 }, { d4, 6 }, { e4, 6 }, { f4, 6 }, { g4, 6 }, { h4, 4 }, { i4, 4 },
            { a5, 4 }, { b5, 3 }, { c5, 6 }, { d5, 5 }, { e5, 6 }, { f5, 5 }, { g5, 6 }, { h5, 3 }, { i5, 4 },
            { a6, 3 }, { b6, 2 }, { c6, 5 }, { d6, 3 }, { e6, 5 }, { f6, 3 }, { g6, 5 }, { h6, 2 }, { i6, 3 },
            { a7, 2 },            { c7, 3 },            { e7, 3 },            { g7, 3 },            { i7, 2 },
        };

        public static Dictionary<Field, int> aQMoves = new Dictionary<Field, int>
        {
            { a1, 8 }, { c1, 10 }, { e1, 12 }, { g1, 10 }, { i1, 8 },
            { b2, 9 }, { d2, 11 }, { f2, 11 }, { h2, 9 },
            { a4, 8 }, { c4, 12 }, { e4, 12 }, { g4, 12 }, { i4, 8 },
            { b5, 9 }, { d5, 11 }, { f5, 11 }, { h5, 9 },
            { a7, 8 }, { c7, 10 }, { e7, 12 }, { g7, 10 }, { i7, 8 },
        };

        public Color turn; // W - белых, B - черных
        public Field iPos; // положение белого интеллектора
        public Field IPos; // положение черного интеллектора
        public List<Field> near = new List<Field>();  //поля, близкие к интеллектору

        public Position()
        {
            turn = W;
            iPos = e1;
            IPos = e7;

            pos[a1] = m; pos[b1] = l; pos[c1] = a; pos[d1] = d; pos[e1] = i;
            pos[f1] = d; pos[g1] = a; pos[h1] = l; pos[i1] = m;
            pos[a2] = p; pos[c2] = p; pos[e2] = p; pos[g2] = p; pos[i2] = p; // белые

            pos[a7] = M; pos[b6] = L; pos[c7] = A; pos[d6] = D; pos[e7] = I;
            pos[f6] = D; pos[g7] = A; pos[h6] = L; pos[i7] = M;
            pos[a6] = P; pos[c6] = P; pos[e6] = P; pos[g6] = P; pos[i6] = P; // черные

            pos[b2] = N; pos[d2] = N; pos[f2] = N; pos[h2] = N;
            pos[a3] = N; pos[b3] = N; pos[c3] = N; pos[d3] = N;
            pos[e3] = N; pos[f3] = N; pos[g3] = N; pos[h3] = N; pos[i3] = N;
            pos[a4] = N; pos[b4] = N; pos[c4] = N; pos[d4] = N;
            pos[e4] = N; pos[f4] = N; pos[g4] = N; pos[h4] = N; pos[i4] = N;
            pos[a5] = N; pos[b5] = N; pos[c5] = N; pos[d5] = N;
            pos[e5] = N; pos[f5] = N; pos[g5] = N; pos[h5] = N; pos[i5] = N; // пустые
        }

        public static Position StartPos()
        {
            return new Position();
        }

        public Position(Position position)
        {
            pos = new Dictionary<Field, Figure>(position.pos);
            turn = position.turn;
            iPos = position.iPos;
            IPos = position.IPos;
        }

        public static Color Color(Figure figure) // возвращает цвет фигуры
        {
            switch (figure)
            {
                case m: case l: case a: case d: case i: case p: return W;
                case M: case L: case A: case D: case I: case P: return B;
                default: return None;
            }
        }

        private bool IspTransform(Field field) // является ли поле превращательным для белых
        {
            if ((field == a7) ||
                (field == c7) ||
                (field == e7) ||
                (field == g7) ||
                (field == i7)) return true;
            return false;
        }

        private bool IsPTransform(Field field) // является ли поле превращательным для черных
        {
            if ((field == a1) ||
                (field == c1) ||
                (field == e1) ||
                (field == g1) ||
                (field == i1)) return true;
            return false;
        }

        private Figure Reverse(Figure figure) // возвращает фигуру противоположного цвета
        {
            switch (figure)
            {
                case m: return M;
                case l: return L;
                case a: return A;
                case d: return D;
                case i: return I;
                case M: return m;
                case L: return l;
                case A: return a;
                case D: return d;
                case I: return i;
            }
            return N;
        }

        public List<Move> GetMoves()
        {
            var moves = new List<Move>();

            // обозначаем поля, с которыми граничит интеллектор
            Field inPos;
            if (turn == W) inPos = iPos;
                      else inPos = IPos;

            near = new List<Field>(dMoves[inPos]);
            ///////////////////////////////////////////////////

            foreach (Field field in Enum.GetValues(typeof(Field)))
            if (field != u)
              if (Color(pos[field]) == turn)
                switch (pos[field]) {
                    case m: moves.AddRange(GetmMoves(field)); break;
                    case l: moves.AddRange(GetlMoves(field)); break;
                    case a: moves.AddRange(GetaMoves(field)); break;
                    case d: moves.AddRange(GetdMoves(field)); break;
                    case i: moves.AddRange(GetiMoves(field)); break;
                    case p: moves.AddRange(GetpMoves(field)); break;

                    case M: moves.AddRange(GetmMoves(field)); break;
                    case L: moves.AddRange(GetlMoves(field)); break;
                    case A: moves.AddRange(GetaMoves(field)); break;
                    case D: moves.AddRange(GetdMoves(field)); break;
                    case I: moves.AddRange(GetiMoves(field)); break;
                    case P: moves.AddRange(GetPMoves(field)); break;
                }

            return moves;
        }

        private List<Move> GetpMoves(Field field)
        {
            var moves = new List<Move>();

            foreach (Field toField in pMoves[field])
                if (Color(pos[toField]) != turn)
                {
                    if (IspTransform(toField))
                    {
                        moves.Add(new Move(field, toField, m));
                        moves.Add(new Move(field, toField, a));
                        moves.Add(new Move(field, toField, l));
                        moves.Add(new Move(field, toField, d));
                    }
                    else
                    {
                        moves.Add(new Move(field, toField, p));
                    }
                }

            return moves;
        }

        private List<Move> GetPMoves(Field field)
        {
            var moves = new List<Move>();

            foreach (Field toField in PMoves[field])
                if (Color(pos[toField]) != turn)
                {
                    if (IsPTransform(toField))
                    {
                        moves.Add(new Move(field, toField, M));
                        moves.Add(new Move(field, toField, A));
                        moves.Add(new Move(field, toField, L));
                        moves.Add(new Move(field, toField, D));
                    }
                    else
                    {
                        moves.Add(new Move(field, toField, P));
                    }
                }

            return moves;
        }

        private List<Move> GetdMoves(Field field)
        {
            var moves = new List<Move>();

            foreach (Field toField in dMoves[field])
                if (Color(pos[toField]) != turn)
                {
                    moves.Add(new Move(field, toField, pos[field])); // d или D

                    if ((near.Contains(field)) && (pos[toField] != N) && (Color(pos[toField]) != turn))
                        moves.Add(new Move(field, toField, Reverse(pos[toField]))); // превращение в сбитую
                }

            return moves;
        }

        private List<Move> GetiMoves(Field field)
        {
            var moves = new List<Move>();

            foreach (Field toField in iMoves[field])
                if (pos[toField] == N) // если клетка пустая
                {
                    moves.Add(new Move(field, toField, pos[field])); // i или I
                }
                else
                if (((pos[field] == i) && (pos[toField] == d)) || // рокировка
                    ((pos[field] == I) && (pos[toField] == D)))
                {
                   moves.Add(new Move(field, toField, pos[field])); // i или I
                }

            return moves;
        }

        private List<Move> GetlMoves(Field field)
        {
            var moves = new List<Move>();

            foreach (Field toField in lnMoves[field]) // ходы на одну клетку без боя
                if (pos[toField] == N) // если клетка пустая
                {
                    moves.Add(new Move(field, toField, pos[field])); // l или L
                }

            foreach (Field toField in lfMoves[field]) // ходы на две клетки
                if (Color(pos[toField]) != turn)
                {
                    moves.Add(new Move(field, toField, pos[field])); // l или L

                    if ((near.Contains(field)) && (pos[toField] != N) && (Color(pos[toField]) != turn))
                        moves.Add(new Move(field, toField, Reverse(pos[toField]))); // превращение в сбитую
                }

            return moves;
        }

        private List<Move> GetaMoves(Field field)
        {
            var moves = new List<Move>();

            bool isWall = false;
            foreach (Field toField in aMoves[field])
            if (toField != u)
            {
                if (!isWall)
                {
                    if (Color(pos[toField]) != turn)
                        moves.Add(new Move(field, toField, pos[field])); // a или A

                    if ((near.Contains(field)) && (pos[toField] != N) && (Color(pos[toField]) != turn))
                        moves.Add(new Move(field, toField, Reverse(pos[toField]))); // превращение в сбитую

                    if (pos[toField] != N) isWall = true;
                }
            }
            else
            {
                isWall = false;
            }

            return moves;
        }

        private List<Move> GetmMoves(Field field)
        {
            var moves = new List<Move>();

            bool isWall = false;
            foreach (Field toField in mMoves[field])
            if (toField != u)
            {
                if (!isWall)
                {
                    if (Color(pos[toField]) != turn)
                        moves.Add(new Move(field, toField, pos[field])); // m или M

                    if ((near.Contains(field)) && (pos[toField] != N) && (Color(pos[toField]) != turn))
                        moves.Add(new Move(field, toField, Reverse(pos[toField]))); // превращение в сбитую

                    if (pos[toField] != N) isWall = true;
                }
            }
            else
            {
                isWall = false;
            }

            return moves;
        }

        public Position Move(Move move)
        {
            Position newPos = new Position(this);

            if (((newPos.turn == W) && (newPos.pos[move.to] == d)) ||
                ((newPos.turn == B) && (newPos.pos[move.to] == D))) // если рокировка
            {
                Figure figure = newPos.pos[move.from];
                newPos.pos[move.from] = newPos.pos[move.to];
                newPos.pos[move.to] = figure;
            }
            else
            { // обычный ход
                newPos.pos[move.to] = move.figure;
                newPos.pos[move.from] = N;
            }

            if (newPos.turn == W) newPos.turn = B; // смена хода
                             else newPos.turn = W;

            if (newPos.pos[move.to] == i) newPos.iPos = move.to; else
            if (newPos.pos[move.to] == I) newPos.IPos = move.to;
            return newPos;
        }

        public static bool IsOtherTeam(Figure f1, Figure f2)
        {
            if ((f1 == N) || (f2 == N)) return false;
            bool res = false;

            if (f1 == p) res = !res; else
            if (f1 == m) res = !res; else
            if (f1 == l) res = !res; else
            if (f1 == a) res = !res; else
            if (f1 == d) res = !res; else
            if (f1 == i) res = !res;

            if (f2 == p) res = !res; else
            if (f2 == m) res = !res; else
            if (f2 == l) res = !res; else
            if (f2 == a) res = !res; else
            if (f2 == d) res = !res; else
            if (f2 == i) res = !res;

            return res;
        }

        public static int MovesToTransform(Field field, Color color)
        {
            if (color == W)
            switch (field)
            {
                case a2: return 5;
                case b2: return 5;
                case c2: return 5;
                case d2: return 5;
                case e2: return 5;
                case f2: return 5;
                case g2: return 5;
                case h2: return 5;
                case i2: return 5;

                case a3: return 4;
                case b3: return 4;
                case c3: return 4;
                case d3: return 4;
                case e3: return 4;
                case f3: return 4;
                case g3: return 4;
                case h3: return 4;
                case i3: return 4;

                case a4: return 3;
                case b4: return 3;
                case c4: return 3;
                case d4: return 3;
                case e4: return 3;
                case f4: return 3;
                case g4: return 3;
                case h4: return 3;
                case i4: return 3;

                case a5: return 2;
                case b5: return 2;
                case c5: return 2;
                case d5: return 2;
                case e5: return 2;
                case f5: return 2;
                case g5: return 2;
                case h5: return 2;
                case i5: return 2;

                case a6: return 1;
                case b6: return 1;
                case c6: return 1;
                case d6: return 1;
                case e6: return 1;
                case f6: return 1;
                case g6: return 1;
                case h6: return 1;
                case i6: return 1;
            }

            if (color == B)
            switch (field)
            {
                case b1: return 1;
                case d1: return 1;
                case f1: return 1;
                case h1: return 1;

                case a2: return 1;
                case b2: return 2;
                case c2: return 1;
                case d2: return 2;
                case e2: return 1;
                case f2: return 2;
                case g2: return 1;
                case h2: return 2;
                case i2: return 1;

                case a3: return 2;
                case b3: return 3;
                case c3: return 2;
                case d3: return 3;
                case e3: return 2;
                case f3: return 3;
                case g3: return 2;
                case h3: return 3;
                case i3: return 2;

                case a4: return 3;
                case b4: return 4;
                case c4: return 3;
                case d4: return 4;
                case e4: return 3;
                case f4: return 4;
                case g4: return 3;
                case h4: return 4;
                case i4: return 3;

                case a5: return 4;
                case b5: return 5;
                case c5: return 4;
                case d5: return 5;
                case e5: return 4;
                case f5: return 5;
                case g5: return 4;
                case h5: return 5;
                case i5: return 4;

                case a6: return 5;
                case c6: return 5;
                case e6: return 5;
                case g6: return 5;
                case i6: return 5;
            }

            return -1;
        }

        public static bool Same(Position a, Position b)
        {
            if (a.turn != b.turn) return false;
            foreach (Field f in Enum.GetValues(typeof(Field)))
                if (f != u)
                if (a[f] != b[f]) return false;
            return true;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Field field in Enum.GetValues(typeof(Field)))
                if (field != u)
                {
                    result += this[field].ToString();
                }
            result += turn.ToString();
            return result;
        }
    }
}
