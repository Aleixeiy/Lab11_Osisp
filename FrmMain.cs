using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Intellector
{
    using static Intellector.Player;

    public partial class FrmMain : Form
    {
        public Board board = new Board();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            board.Draw(e.Graphics);
        }

        private void FrmMain_MouseClick(object sender, MouseEventArgs e)
        {
            string name = "";
            if (radioMove.Checked) name = radioMove.Name; else
            if (radioClear.Checked) name = radioClear.Name; else
            if (radiom.Checked) name = radiom.Name; else
            if (radioa.Checked) name = radioa.Name; else
            if (radiol.Checked) name = radiol.Name; else
            if (radiod.Checked) name = radiod.Name; else
            if (radiop.Checked) name = radiop.Name; else
            if (radioi.Checked) name = radioi.Name; else
            if (radiomb.Checked) name = radiomb.Name; else
            if (radioab.Checked) name = radioab.Name; else
            if (radiolb.Checked) name = radiolb.Name; else
            if (radiodb.Checked) name = radiodb.Name; else
            if (radiopb.Checked) name = radiopb.Name; else
            if (radioib.Checked) name = radioib.Name; 

                board.SetActiveField(e.Location, name);
            Refresh();
        }

        private void buttonThink_Click(object sender, EventArgs e)
        {
            //Tournament tournament = new Tournament();
            //for (int i = 0; i < 0; i++)
            //    tournament.Add(new Player());
            //tournament.Add(new Player(100, 20, 25, 20, 15, (float)0.7, (float)0.7));
            //tournament.Add(new Player(50, 10, 12, 8, 5, 2, 2));
            //tournament.Add(new Player(16, 12, 8, 10, 5, 2, 2));
            //tournament.Add(new Player(50, 10, 12, 8, 5, 10000, 2));
            //List<Player> winners = tournament.PlayTournament(this);

            //for (int i = 0; i < 100; i++)
            //{
            //    Tournament t = new Tournament();
            //    t.Add(winners[0]);
            //    t.Add(winners[1]);
            //    t.Add(Reproduction(winners[0], winners[1]));
            //    t.Add(Reproduction(winners[0], winners[1]));
            //    winners = t.PlayTournament(this);
            //}
            //return;

            long start = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            Player player = new Player(50, 18, 15, 12, 5, 2, 2);
            Tuple<Move, float> tuple = player.BestMove(board.position, (int)numericDepth.Value);
            board.activeField = Field.u;
            labelBestMove.Text = tuple.Item1.ToString();
            labelMark.Text = Math.Round(tuple.Item2 / 5.0F, 2).ToString();

            long finish = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            long dTime = finish - start;
            labelTime.Text = dTime.ToString();
            labelCount.Text = Player.count.ToString();
            labelHashCount.Text = Player.hashCount.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
