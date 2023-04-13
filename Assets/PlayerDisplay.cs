using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public Player player;
    public Sprite spade;
    public Sprite heart;
    public Sprite diamond;
    public Sprite club;
    
    public PlayerDisplay(Player p, Sprite s, Sprite h, Sprite d, Sprite c){
        player = p;
        spade = s;
        heart = h;
        club = c;
    }
    
    List<Card> hand = new List<Card>(){};

    void createCards(){
        foreach(string a in player.hand){
            switch(a){
                case "S1":
                    hand.Add(new Card("A","spades",spade));
                    break;
                case "S2":
                    hand.Add(new Card("2", "spades",spade));
                    break;
                case "S3":
                    hand.Add(new Card("3", "spades",spade));
                    break;
                case "S4":
                    hand.Add(new Card("4", "spades",spade));
                    break;
                case "S5":
                    hand.Add(new Card("5", "spades",spade));
                    break;
                case "S6":
                    hand.Add(new Card("6", "spades",spade));
                    break;
                case "S7":
                    hand.Add(new Card("7", "spades",spade));
                    break;
                case "S8":
                    hand.Add(new Card("8", "spades",spade));
                    break;
                case "S9":
                    hand.Add(new Card("9", "spades",spade));
                    break;
                case "SA":
                    hand.Add(new Card("10", "spades",spade));
                    break;
                case "SB":
                    hand.Add(new Card("J", "spades",spade));
                    break;
                case "SC":
                    hand.Add(new Card("Q", "spades",spade));
                    break;
                case "SD":
                    hand.Add(new Card("K", "spades",spade));
                    break;
                case "H1":
                    hand.Add(new Card("A", "hearts",heart));
                    break;
                case "H2":
                    hand.Add(new Card("2", "hearts",heart));
                    break;
                case "H3":
                    hand.Add(new Card("3", "hearts",heart));
                    break;
                case "H4":
                    hand.Add(new Card("4", "hearts",heart));
                    break;
                case "H5":
                    hand.Add(new Card("5", "hearts",heart));
                    break;
                case "H6":
                    hand.Add(new Card("6", "hearts",heart));
                    break;
                case "H7":
                    hand.Add(new Card("7", "hearts",heart));
                    break;
                case "H8":
                    hand.Add(new Card("8", "hearts",heart));
                    break;
                case "H9":
                    hand.Add(new Card("9", "hearts",heart));
                    break;
                case "HA":
                    hand.Add(new Card("10", "hearts",heart));
                    break;
                case "HB":
                    hand.Add(new Card("J", "hearts",heart));
                    break;
                case "HC":
                    hand.Add(new Card("Q", "hearts",heart));
                    break;
                case "HD":
                    hand.Add(new Card("K", "hearts",heart));
                    break;
                case "D1":
                    hand.Add(new Card("A", "diamonds",diamond));
                    break;
                case "D2":
                    hand.Add(new Card("2", "diamonds",diamond));
                    break;
                case "D3":
                    hand.Add(new Card("3", "diamonds",diamond));
                    break;
                case "D4":
                    hand.Add(new Card("4", "diamonds",diamond));
                    break;
                case "D5":
                    hand.Add(new Card("5", "diamonds",diamond));
                    break;
                case "D6":
                    hand.Add(new Card("6", "diamonds",diamond));
                    break;
                case "D7":
                    hand.Add(new Card("7", "diamonds",diamond));
                    break;
                case "D8":
                    hand.Add(new Card("8", "diamonds",diamond));
                    break;
                case "D9":
                    hand.Add(new Card("9", "diamonds",diamond));
                    break;
                case "DA":
                    hand.Add(new Card("10", "diamonds",diamond));
                    break;
                case "DB":
                    hand.Add(new Card("J", "diamonds",diamond));
                    break;
                case "DC":
                    hand.Add(new Card("Q", "diamonds",diamond));
                    break;
                case "DD":
                    hand.Add(new Card("K", "diamonds",diamond));
                    break;
                case "C1":
                    hand.Add(new Card("A", "clubs",club));
                    break;
                case "C2":
                    hand.Add(new Card("2", "clubs",club));
                    break;
                case "C3":
                    hand.Add(new Card("3", "clubs",club));
                    break;
                case "C4":
                    hand.Add(new Card("4", "clubs",club));
                    break;
                case "C5":
                    hand.Add(new Card("5", "clubs",club));
                    break;
                case "C6":
                    hand.Add(new Card("6", "clubs",club));
                    break;
                case "C7":
                    hand.Add(new Card("7", "clubs",club));
                    break;
                case "C8":
                    hand.Add(new Card("8", "clubs",club));
                    break;
                case "C9":
                    hand.Add(new Card("9", "clubs",club));
                    break;
                case "CA":
                    hand.Add(new Card("10", "clubs",club));
                    break;
                case "CB":
                    hand.Add(new Card("J", "clubs",club));
                    break;
                case "CC":
                    hand.Add(new Card("Q", "clubs",club));
                    break;
                case "CD":
                    hand.Add(new Card("K", "clubs",club));
                    break;                                                                                 
            };
        }
    }

    void displayCard(){
        // foreach(Card c in hand){
        //     Instantiate(c);
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        createCards();
        displayCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
