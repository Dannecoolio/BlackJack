using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Drawing;

namespace Blackjack
{
    class Deck
    {
        private LinkedList<Card> pile = new LinkedList<Card>();

        //Konstruktor för Deck.
        public Deck()
        {

            //Skapar 52 nya kort.
            for (int Suit = 0; Suit <= 3; Suit++)
            {
                for (int Value = 2; Value <= 14; Value++)
                {
                    pile.AddLast(new Card(Suit, Value)); //Skapar ett nytt kort.
                }

            }


            //Shuffle();
        }
        //Hämtar bilder till korten.
        private void getImg()
        {
            // DirectoryInfo searchpath = new DirectoryInfo("cardImages"); // Sökväg till bilderna.
            //a          FileInfo[] bildArr = /*searchpath.*/GetFiles("*.png", SearchOption.TopDirectoryOnly);

            //Läser in bilderna till listan.
            //a    foreach (FileInfo img in imgArr)
            {
                //acardImg.Add(Image.FromFile(img.FullName));
            }


        }
        public Deck(bool withImg)
        {
            int bildNr = 0;

            getImg(); //Läser in bilderna till kortbilder.

            //Skapar 52 nya kort.
            for (int f = 0; f <= 3; f++)
            {
                for (int v = 2; v <= 14; v++)
                {
                    //a Image b = cardImage.ElementAt(bildNr);
                    //ab.Tag = f.ToString() + v.ToString();
                    //adeck.AddLast(new Card(f, v, b)); //Skapar ett nytt kort.
                    bildNr++;
                }
            }


        }

        public Card GiveCard()
        {
            Card tmpCard;
            tmpCard = pile.ElementAt(0); //Kopiera översta kortet.
            pile.RemoveFirst(); //Ta bort kortet från högen.

            return tmpCard; //Returnerar kortet som ges ut.

        }
        public void Shuffle()
        {
            List<Card> tmpLek = new List<Card>();
            //a  short slump;
            Random rnd = new Random();

            /* //a  for (int i = Deck.Count() - 1; i >= 0; i--)
               {
                   slump = (short)rnd.Next(0, i);
                   tmpLek.Add(Deck.ElementAt[slump]); //Kopiera ett kort från en slumpad plats 
                                                      //i listan till en temporär lista.
                   Deck.Remove(deck.ElementAt[slump]); //Ta bort kortet från listan.
               } */
            // Deck.Clear(); //Töm listan.

            //Kopiera tillbaka från temporär lista.
            foreach (Card tmpKort in tmpLek)
            {
                //a Deck.AddLast(tmpKort);
            }

        }
    }
}
