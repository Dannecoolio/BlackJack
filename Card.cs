using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public enum cardsuit //Skapar konceptet om kortfärg
        {
            Hearts = 0,
            Spades = 1,
            Clubs = 2,
            Diamonds = 3

        }

        private int value;
        private cardsuit suit;

        //Property for Cardsuit
        public int Value
        {
            get { return value; }
        }

        public cardsuit Suit
        {
            get { return suit; }
        }

        public Card(int s, int v)
        {
            suit = (cardsuit)s;
            value = v;
        }
       /* private void getImg()
        {
            DirectoryInfo searchpath = new DirectoryInfo("cardImages"); // Sökväg till bilderna.
            FileInfo[] bildArr = searchpath.GetFiles("*.png", SearchOption.TopDirectoryOnly);

            //Läser in bilderna till listan.
            foreach (FileInfo img in imgArr)
                cardImg.Add(Image.FromFile(img.FullName));

        }*/
    }
}
