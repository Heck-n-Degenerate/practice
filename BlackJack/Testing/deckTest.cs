Random random = new Random();

List<int> deckList = new List<int>();
deckList.AddRange(Enumerable.Range(1, 52));

//      void drawCard() {
int listIndex = random.Next(deckList.Count);
int deckIndex = deckList[listIndex];
deckList.RemoveAt(listIndex);
//                      }

int suit = 1;
    while (deckIndex  > 13)
    {
        suit++;
        deckIndex = deckIndex - 13;
    }
int type = deckIndex;

string sType = "";
string sSuit = "";

switch (suit)
{
    case 1: sSuit = "Clubs";
    break;
    case 2: sSuit = "Hearts";
    break;
    case 3: sSuit = "Spades";
    break;
    case 4: sSuit = "Diamonds";
    break;
    default: Console.WriteLine("Error, switch suit defaulted.");
    break;
}
switch (type)
{
    case 1: sType = "Ace";
    break;
    case 2: sType = "Two";
    break;
    case 3: sType = "Three";
    break;
    case 4: sType = "Four";
    break;
    case 5: sType = "Five";
    break;
    case 6: sType = "Six";
    break;
    case 7: sType = "Seven";
    break;
    case 8: sType = "Eight";
    break;
    case 9: sType = "Nine";
    break;
    case 10: sType = "Ten";
    break;
    case 11: sType = "Jack";
    break;
    case 12: sType = "Queen";
    break;
    case 13: sType = "King";
    break;
    default: Console.WriteLine("Error, switch type defaulted.");
    break;
}

Console.WriteLine(sType+ " of " + sSuit + ".");
