using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card someCard = deck.GiveCard();
            TbS1.Text = someCard.Suit.ToString();
            TbV1.Text = someCard.Value.ToString();

        }

        private void TbS1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
