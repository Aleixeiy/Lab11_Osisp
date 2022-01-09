using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intellector
{
    public class Move
    {
        public Field from;
        public Field to;
        public Figure figure;

        public Move(Field from, Field to, Figure figure)
        {
            this.from = from;
            this.to = to;
            this.figure = figure;
        }

        public override string ToString()
        {
            return from.ToString() + "-" + to.ToString() + " " + figure.ToString();
        }

        public string ToHashString()
        {
            return from.ToString() + to.ToString() + figure.ToString();
        }
    }
}
