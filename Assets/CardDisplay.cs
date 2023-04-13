using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TMP_Text TopNumberText;
    public TMP_Text BottomNumberText;

    public Image artworkImage;

    public CardDisplay(Card c){
        card = c;
    }

    // Start is called before the first frame update
    void Start()
    {
        //card.Print();

        TopNumberText.text = card.value;
        BottomNumberText.text = card.value;

        artworkImage.sprite = card.artwork;
    }


}
