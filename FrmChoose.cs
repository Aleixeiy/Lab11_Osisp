using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intellector
{
    public partial class FrmChoose : Form
    {
        public List<Move> moves = new List<Move>();

        public FrmChoose()
        {
            InitializeComponent();
        }

        public void AddMove(Move move)
        {
            moves.Add(move);
            ListMoves.Items.Add(move.ToString());
        }
    }
}
