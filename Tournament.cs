using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Intellector
{
    class Tournament
    {
        private List<Player> players = new List<Player>();

        public void Add(Player player)
        {
            players.Add(player);
        }

        public static int Play(Player player0, Player player1, FrmMain form)
        {

            string s = player0.mMark.ToString() + " " + player0.aMark.ToString() + " " + player0.lMark.ToString() + " " +
                     player0.dMark.ToString() + " " + player0.pMark.ToString() + " " + player0.kQMoves.ToString() + " " +
                     player0.kMovesToTransform.ToString() + "\n";
            form.textBoxPlayers.Text = s;
            s =  player1.mMark.ToString() + " " + player1.aMark.ToString() + " " + player1.lMark.ToString() + " " +
                 player1.dMark.ToString() + " " + player1.pMark.ToString() + " " + player1.kQMoves.ToString() + " " +
                 player1.kMovesToTransform.ToString() + "\n";
            form.textBoxPlayers.Text += "\r\n" + s;

            Position pos = Position.StartPos();
            form.board.position = pos;
            Position predPos = Position.StartPos();
            int qMoves = 0;
            while (++qMoves < 100)
            {
                if ((qMoves > 3) && (Position.Same(predPos, pos))) return 0;
                if (qMoves % 2 == 0) predPos = new Position(pos);
                predPos.turn = Color.W;
                Move move0 = player0.BestMove(pos, 4).Item1;
                pos = pos.Move(move0);
                form.board.position = pos;
                if (player0.Mark(pos) > player0.iMark / 2) return 1;

                form.Refresh();
                //Thread.Sleep(100);

                Move move1 = player1.BestMove(pos, 4).Item1;
                pos = pos.Move(move1);
                form.board.position = pos;
                if (player1.Mark(pos) < -player1.iMark / 2) return -1;

                form.Refresh();
                //Thread.Sleep(100);
            }
            return 0;
        }

        public List<Player> PlayTournament(FrmMain form) // возвращает половину лучших
        {
            List<int> results = new List<int>(players.Count);
            for (int i = 0; i < players.Count; i++)
                results.Add(0);

            for (int i = 0; i < players.Count; i++)
                for (int j = 0; j < players.Count; j++)
                    if (i != j)
                    {
                        Player player0 = players[i];
                        Player player1 = players[j];
                        int result = Play(player0, player1, form);
                        results[i] += result;
                        results[j] -= result;
                    }

            for (int i = 0; i < players.Count; i++)
                for (int j = 0; j < players.Count - 1; j++)
                    if (results[j] < results[j + 1])
                    {
                        int r = results[j];
                        results[j] = results[j + 1];
                        results[j + 1] = r;

                        Player p = players[j];
                        players[j] = players[j + 1];
                        players[j + 1] = p;
                    }

            //List<Player> winners = new List<Player>(players);
            //winners.RemoveRange(winners.Count / 2, winners.Count - winners.Count / 2);


            string s = "";
            foreach (Player p in players)
                s += p.mMark.ToString() + " " + p.aMark.ToString() + " " + p.lMark.ToString() + " " +
                     p.dMark.ToString() + " " + p.pMark.ToString() + " " + p.kQMoves.ToString() + " " +
                     p.kMovesToTransform.ToString() + " " + results[players.IndexOf(p)].ToString() + "\n";
            MessageBox.Show(s);

            return players;
        }
    }
}
