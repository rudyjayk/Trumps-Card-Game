using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class GameSetup : MonoBehaviour
{

    //String of Deck Of cards
    // S - Spades, H - Hearts, D - Diamonds, C - Clubs
    // 1 - Ace, A - 10, B - Jack, C - Queen, D - King
    // Examples: S1 -  Ace of Spades, HA - 10 of Hearts, CC - Queen of Clubs
    private string [] deck = {"S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD","H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "HA", "HB", "HC", "HD","D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD","C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD"};
    //List<string> cardPriority = new List<string>() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
    public Sprite spade;
    public Sprite heart;
    public Sprite diamond;
    public Sprite club;
    public Player playerPrefab;
    
    
    int deck_length = 51;
    int hand_length = 11;
    int kitty_length = 4;
    bool firstGame = true;

    Player player1;
    Player player2;
    Player player3;
    Player player4;

    List<string> Player1Hand = new List<string>(){};
    List<string> Player2Hand = new List<string>(){};
    List<string> Player3Hand = new List<string>(){};
    List<string> Player4Hand = new List<string>(){};
    List<string> Kitty = new List<string>(){};

    Random random = new Random();

    // Shuffles a deck of cards
    async public void ShuffleCards(){
        for (int i = deck.Length; i > 0; i--){
            int rand = random.Next(i);
            string temp = deck[rand];
            deck[rand] = deck[i - 1];
            deck[i - 1] = temp;
        }

        // foreach(string a in deck){
        //     Debug.Log(a);
        // }
    }

    private bool DealToKitty(){
        int num = random.Next(10);

        if (num % 3 == 1){
            return true;
        }

        return false;
    }

    async public void DealCards(){
        int indexOfDeck = 0;
        

        for (int i = 0; i <= hand_length; i++){
            Player1Hand.Add(deck[indexOfDeck]);
            indexOfDeck++;
            if(Kitty.Count != kitty_length){
                if(DealToKitty()){
                    Kitty.Add(deck[indexOfDeck]);
                    indexOfDeck++;
                }
            }

            Player2Hand.Add(deck[indexOfDeck]);
            indexOfDeck++;
            if(Kitty.Count != kitty_length){
                if(DealToKitty()){
                    Kitty.Add(deck[indexOfDeck]);
                    indexOfDeck++;
                }
            }

            Player3Hand.Add(deck[indexOfDeck]);
            indexOfDeck++;
            if(Kitty.Count != kitty_length){
                if(DealToKitty()){
                    Kitty.Add(deck[indexOfDeck]);
                    indexOfDeck++;
                }
            }

            Player4Hand.Add(deck[indexOfDeck]);
            indexOfDeck++;
            if(Kitty.Count != kitty_length){
                if(DealToKitty()){
                    Kitty.Add(deck[indexOfDeck]);
                    indexOfDeck++;
                }
            }
        }

        Player1Hand.Sort((c1,c2)=> c1.CompareTo(c2));
        Player2Hand.Sort((c1,c2)=> c1.CompareTo(c2));
        Player3Hand.Sort((c1,c2)=> c1.CompareTo(c2));
        Player4Hand.Sort((c1,c2)=> c1.CompareTo(c2));

        Debug.Log("Player1");
        player1 = new Player(Player1Hand);
        foreach(string a in Player1Hand){
            Debug.Log(a);
        }
        Debug.Log("Player2");
        player2 = new Player(Player2Hand);
        foreach(string a in Player2Hand){
            Debug.Log(a);
        }
        Debug.Log("Player3");
        player3 = new Player(Player3Hand);
        foreach(string a in Player3Hand){
            Debug.Log(a);
        }
        Debug.Log("Player4");
        player4 = new Player(Player4Hand);
        foreach(string a in Player4Hand){
            Debug.Log(a);
        }
        Debug.Log("Kitty");
        foreach(string a in Kitty){
            Debug.Log(a);
        }

    }

    async public void Bidding(){

        List<Player> players =  new List<Player>(){player1,player2,player3,player4};

        foreach(Player a in players){
            //Debug.Log(a.hand.Count);
            Instantiate(a);
            
            
        }

        Debug.Log("Place your bid:");

        
    }


    public void Start(){
        ShuffleCards();
        DealCards();
        Bidding();

    }
    

}
