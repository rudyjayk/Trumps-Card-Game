using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class Player : ScriptableObject
{
    public List<string> hand;
    public int bid;
    public bool dealer;
    public bool myTurn;
    public string name;

    // Player(){
    //     hand = new List<string> {};
    //     bid = -1;
    //     dealer = false;
    //     myTurn = false;
    // }

    public Player(List<string> curHand){
        hand = curHand;
        bid = -1;
        dealer = false;
        myTurn = false;
        name = "test";
    }

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
