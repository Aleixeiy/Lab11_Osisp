using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intellector
{
    using static Intellector.Position;
    using static Intellector.Figure;
    using static Intellector.Color;
    using static Intellector.Field;
    using static Math;

    public class Player
    {
        private static Random rnd = new Random();

        public float mMark = 9;
        public float aMark = 5;
        public float lMark = 3;
        public float dMark = 4;
        public float pMark = 1;
        public float iMark = 1000;

        public float kQMoves = 10.0F;
        public float kMovesToTransform = 10.0F;

        private const float unknow = 10000;

        private Dictionary<string, Tuple<float, int>> hash;

        public static int count = 0;
        public static int hashCount;

        public Player()
        {
            mMark = rnd.Next(1, 1000) / 100.0F;
            aMark = rnd.Next(1, 1000) / 100.0F;
            lMark = rnd.Next(1, 1000) / 100.0F;
            dMark = rnd.Next(1, 1000) / 100.0F;
            pMark = rnd.Next(1, 1000) / 100.0F;
            kQMoves = rnd.Next(1, 1000) / 10.0F;
            kMovesToTransform = rnd.Next(1, 1000) / 10.0F;

            Normalize();
        }

        public Player(float mMark, float aMark, float lMark, float dMark, float pMark, float kQMoves, float kMovesToTransform)
        {
            this.mMark = mMark;
            this.aMark = aMark;
            this.lMark = lMark;
            this.dMark = dMark;
            this.pMark = pMark;
            this.kQMoves = kQMoves;
            this.kMovesToTransform = kMovesToTransform;

            Normalize();
        }

        private float WorstMark(Color turn)
        {
            if (turn == W) return -10000;
            else return 10000;
        }

        private static bool IsBetterMark(float mark1, float mark2, Color turn)
        {
            if ((mark1 > mark2) && (turn == W)) return true;
            if ((mark1 < mark2) && (turn == B)) return true;
            return false;
        }

        public float Mark(Position pos)
        {
            if ((pos.iPos == a7) || (pos.iPos == c7) || (pos.iPos == e7) ||
                (pos.iPos == g7) || (pos.iPos == i7)) return iMark;
            if ((pos.IPos == a1) || (pos.IPos == c1) || (pos.IPos == e1) ||
                (pos.IPos == g1) || (pos.IPos == i1)) return -iMark;

            float res = 0;
            foreach (Field field in Enum.GetValues(typeof(Field)))
                if (field != u)
                    switch (pos[field])
                    {
                        case m: res += mMark + mQMoves[field] / kQMoves; break;
                        case a: res += aMark + aQMoves[field] / kQMoves; break;
                        case l: res += lMark + (lnQMoves[field] / 2.0F + lfQMoves[field]) / kQMoves; break;
                        case d: res += dMark + dQMoves[field] / kQMoves; break;
                        case p: res += pMark + (6 - MovesToTransform(field, W)) / (float)kMovesToTransform; break;
                        case i: res += iMark; break;

                        case M: res -= mMark + mQMoves[field] / kQMoves; break;
                        case A: res -= aMark + aQMoves[field] / kQMoves; break;
                        case L: res -= lMark + (lnQMoves[field] / 2.0F + lfQMoves[field]) / kQMoves; break;
                        case D: res -= dMark + dQMoves[field] / kQMoves; break;
                        case P: res -= pMark + (6 - MovesToTransform(field, B)) / (float)kMovesToTransform; break;
                        case I: res -= iMark; break;
                    }

            return res;
        }

        private float NewMark(Position pos, float oldMark, Move move)
        {
            if (((move.to == a7) || (move.to == c7) ||
                (move.to == e7) || (move.to == g7) || (move.to == i7)) &&
                (move.figure == i)) return iMark; // белый интеллектор на последнем ряду

            if (((move.to == a1) || (move.to == c1) ||
                (move.to == e1) || (move.to == g1) || (move.to == i1)) &&
                (move.figure == I)) return -iMark; // черный интеллектор на первом ряду

            if (((pos.turn == W) && (pos[move.to] == d)) ||
                ((pos.turn == B) && (pos[move.to] == D))) return oldMark; // рокировка

            float delMark = 0;
            switch (pos[move.from])
            {
                case m: delMark -= mMark + mQMoves[move.from] / kQMoves; break;
                case a: delMark -= aMark + aQMoves[move.from] / kQMoves; ; break;
                case l: delMark -= lMark + (lnQMoves[move.from] / 2.0F + lfQMoves[move.from]) / kQMoves; break;
                case d: delMark -= dMark + dQMoves[move.from] / kQMoves; ; break;
                case p: delMark -= pMark + (6 - MovesToTransform(move.from, W)) / (float)kMovesToTransform; break;
                case i: delMark -= iMark; break;

                case M: delMark += mMark + mQMoves[move.from] / kQMoves; break;
                case A: delMark += aMark + aQMoves[move.from] / kQMoves; ; break;
                case L: delMark += lMark + (lnQMoves[move.from] / 2.0F + lfQMoves[move.from]) / kQMoves; break;
                case D: delMark += dMark + dQMoves[move.from] / kQMoves; ; break;
                case P: delMark += pMark + (6 - MovesToTransform(move.from, B)) / (float)kMovesToTransform; break;
                case I: delMark += iMark; break;
            }

            switch (move.figure)
            {
                case m: delMark += mMark + mQMoves[move.to] / kQMoves; break;
                case a: delMark += aMark + aQMoves[move.to] / kQMoves; ; break;
                case l: delMark += lMark + (lnQMoves[move.to] / 2.0F + lfQMoves[move.to]) / kQMoves; break;
                case d: delMark += dMark + dQMoves[move.to] / kQMoves; break;
                case p: delMark += pMark + (6 - MovesToTransform(move.to, W)) / (float)kMovesToTransform; break;
                case i: delMark += iMark; break;

                case M: delMark -= mMark + mQMoves[move.to] / kQMoves; break;
                case A: delMark -= aMark + aQMoves[move.to] / kQMoves; ; break;
                case L: delMark -= lMark + (lnQMoves[move.to] / 2.0F + lfQMoves[move.to]) / kQMoves; break;
                case D: delMark -= dMark + dQMoves[move.to] / kQMoves; break;
                case P: delMark -= pMark + (6 - MovesToTransform(move.to, B)) / (float)kMovesToTransform; break;
                case I: delMark -= iMark; break;
            }

            switch (pos[move.to])
            {
                case m: delMark -= mMark + mQMoves[move.to] / kQMoves; break;
                case a: delMark -= aMark + aQMoves[move.to] / kQMoves; ; break;
                case l: delMark -= lMark + (lnQMoves[move.to] / 2.0F + lfQMoves[move.to]) / kQMoves; break;
                case d: delMark -= dMark + dQMoves[move.to] / kQMoves; break;
                case p: delMark -= pMark + (6 - MovesToTransform(move.to, W)) / (float)kMovesToTransform; break;
                case i: delMark -= iMark; break;

                case M: delMark += mMark + mQMoves[move.to] / kQMoves; break;
                case A: delMark += aMark + aQMoves[move.to] / kQMoves; ; break;
                case L: delMark += lMark + (lnQMoves[move.to] / 2.0F + lfQMoves[move.to]) / kQMoves; break;
                case D: delMark += dMark + dQMoves[move.to] / kQMoves; break;
                case P: delMark += pMark + (6 - MovesToTransform(move.to, B)) / (float)kMovesToTransform; break;
                case I: delMark += iMark; break;
            }

            return oldMark + delMark;
        }

        private void SortMoves(List<Move> moves, Position pos)
        {
            for (int i = moves.Count - 2; i >= 1; i--)
                for (int j = 0; j <= i; j++)
                {
                    float mark0 = WorstMark(pos.turn);
                    float mark1 = WorstMark(pos.turn);

                    Tuple<float, int> tuple0 = new Tuple<float, int>(mark0, 0);
                    if (hash.TryGetValue(pos.Move(moves[j]).ToString(), out tuple0))
                    mark0 = tuple0.Item1;

                    Tuple<float, int> tuple1 = new Tuple<float, int>(mark1, 0);
                    if (hash.TryGetValue(pos.Move(moves[j+1]).ToString(), out tuple1))
                    mark1 = tuple1.Item1;

                    if (pos[moves[i].to] != N) mark0 = -WorstMark(pos.turn);
                    if (pos[moves[i + 1].to] != N) mark0 = -WorstMark(pos.turn);

                    if ((tuple1 != null) && 
                       ((tuple0 == null) ||
                        (tuple1.Item2 > tuple0.Item2) ||
                        ((tuple1.Item2 == tuple0.Item2) && IsBetterMark(mark1, mark0, pos.turn))))
                    {
                        Move tempMove = moves[j + 1];
                        moves[j + 1] = moves[j];
                        moves[j] = tempMove;
                    }
                }
        }

        private float Unknown(Color turn)
        {
            if (turn == Color.W) return unknow;
            return -unknow;
        }

        private float Alpha(Position pos, int depth, int maxDepth, float a, float mark)
        {
            //if (maxDepth > 4)
            //{
               if ((depth >= maxDepth) && (pos.turn == W) && (mark >= a - pMark / 10)) return Unknown(pos.turn);
               if ((depth >= maxDepth) && (pos.turn == B) && (mark <= a + pMark / 10)) return Unknown(pos.turn);
            //}

            float bestMark = WorstMark(pos.turn);

            if (Math.Abs(mark) > iMark / 2)
            {
                if (pos.turn == W) return -iMark + depth;
                if (pos.turn == B) return +iMark - depth;
            }

            List<Move> moves = pos.GetMoves();
            if (maxDepth - depth > 3) SortMoves(moves, pos);

            for (int i = 0; i < moves.Count; i++)
            {
                Move move = moves[i];
                float currentMark = 0;
                Tuple<float, int> tuple = null;
                if (maxDepth - depth > 1)
                hash.TryGetValue(pos.Move(move).ToString(), out tuple);
                if ((tuple == null) || (tuple.Item2 < maxDepth - depth))
                {
                    float newMark = NewMark(pos, mark, move);

                    bool beat = IsOtherTeam(pos[move.from], pos[move.to]);

                    currentMark = (depth > maxDepth) || ((depth == maxDepth) && (!beat)) ?
                        newMark :
                        Alpha(pos.Move(move), depth + 1, maxDepth, bestMark, newMark);
                }
                else
                {
                    currentMark = tuple.Item1;
                    hashCount++;
                }

                count++;

                if ((maxDepth - depth > 1) && (Abs(currentMark) < unknow / 2))
                {
                    if ((tuple == null) || (tuple.Item2 < maxDepth - depth))
                       hash[pos.Move(move).ToString()] = new Tuple<float, int>(currentMark, maxDepth - depth);
                }

                if (IsBetterMark(currentMark, bestMark, pos.turn))
                {
                    bestMark = currentMark;
                    if (IsBetterMark(bestMark, a, pos.turn)) return Unknown(pos.turn);
                }
            }

            return bestMark;
        }

        public Tuple<Move, float> BestMove(Position pos, int maxDepth)
        {
            count = 0;
            hashCount = 0;
            hash = new Dictionary<string, Tuple<float, int>>();

            float bestMark = 0;
            Move bestMove = new Move(u, u, N);
            List<Move> moves = pos.GetMoves();

            for (int currentDepth = 1; currentDepth <= maxDepth; currentDepth++)
            {
                bestMark = WorstMark(pos.turn);
                if (currentDepth > 3) SortMoves(moves, pos);

                for (int i = 0; i < moves.Count; i++)
                {
                    Move move = moves[i];
                    
                    Position newPos = pos.Move(move);
                    float currentMark = Alpha(newPos, 1, currentDepth, bestMark, Mark(newPos));

                    if  (Abs(currentMark) < unknow / 2)
                        hash[pos.Move(move).ToString()] = new Tuple<float, int>(currentMark, currentDepth);

                    if (IsBetterMark(currentMark, bestMark, pos.turn))
                    {
                        bestMark = currentMark;
                        bestMove = move;
                    }
                }
            }

            return new Tuple<Move, float>(bestMove, bestMark);
        }

        private void Normalize()
        {
            float sum = mMark + aMark + lMark + dMark + pMark;
            float k = 100 / sum;

            mMark *= k;
            aMark *= k;
            lMark *= k;
            dMark *= k;
            pMark *= k;
        }

        public static Player Reproduction(Player player0, Player player1)
        {
            Player player = new Player();

            player.mMark = ((rnd.Next(0, 2) == 0) ? player0.mMark : player1.mMark) * (1 + rnd.Next(-100, 100) / 400.0F);
            player.aMark = ((rnd.Next(0, 2) == 0) ? player0.aMark : player1.aMark) * (1 + rnd.Next(-100, 100) / 400.0F);
            player.lMark = ((rnd.Next(0, 2) == 0) ? player0.lMark : player1.lMark) * (1 + rnd.Next(-100, 100) / 400.0F);
            player.dMark = ((rnd.Next(0, 2) == 0) ? player0.dMark : player1.dMark) * (1 + rnd.Next(-100, 100) / 400.0F);
            player.pMark = ((rnd.Next(0, 2) == 0) ? player0.pMark : player1.pMark) * (1 + rnd.Next(-100, 100) / 400.0F);
            player.kQMoves = ((rnd.Next(0, 2) == 0) ? player0.kQMoves : player1.kQMoves) * (1 + rnd.Next(-100, 100) / 400.0F);
            player.kMovesToTransform = ((rnd.Next(0, 2) == 0) ? player0.kMovesToTransform : player1.kMovesToTransform) * (1 + rnd.Next(-100, 100) / 400.0F);

            player.Normalize();
            return player;
        }
    }
}
