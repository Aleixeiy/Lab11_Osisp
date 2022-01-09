using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Intellector
{
    class Element
    {
        public Position pos; // позиция
        public List<Move> moves; // список ходов
        public int mark; // оценка
        public int depth; // глубина

        public Element(Position pos, List<Move> moves, int mark, int depth)
        {
            this.pos = pos;
            this.moves = moves;
            this.mark = mark;
            this.depth = depth;
        }
    }

    class Hash
    {
        public int t { get; set; }
        public int size = 0;
        private Element[] table;

        public Hash(int size)
        {
            this.size = size;
            table = new Element[size];
        }

        public void Add(Element element)
        {
            table[element.pos.GetHashCode() % size] = element;
        }

        public Element Get(Position pos)
        {
            Element element = table[pos.GetHashCode() % size];
            if (element == null) return null;

            foreach (Field field in Enum.GetValues(typeof(Field)))
                if (field != Field.u)
                  if (element.pos[field] != pos[field]) return null;

            if (element.pos.turn != pos.turn) return null;

            return element;
        }
    }
}
