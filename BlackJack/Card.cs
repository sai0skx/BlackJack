using System;
using System.Text;

namespace BlackJack
{
    class Card
    {
        private string cardName;
        private int point;
        public string getCardName() {return cardName; }
        public int getPoint() { return point; }

        public Card(string cardName, int point)
        {
            this.cardName = cardName;
            this.point = point;
        }

        
    }
}
