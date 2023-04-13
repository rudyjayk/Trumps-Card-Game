using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string value; //Card Value: A, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, K, Q
    public string suit; //Card Suit
    
    public Sprite artwork;

    public Card(string val, string s, Sprite a){
        value = val;
        suit = s;
        artwork = a;
    }

    public void Print(){
        Debug.Log(value + " of " + suit);
    }

}
