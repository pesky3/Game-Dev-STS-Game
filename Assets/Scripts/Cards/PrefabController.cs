using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PrefabController : MonoBehaviour
{
    public TMP_Text manaText;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public Sprite spriteArt;


    public void cardSetup(Card card)
    {
        manaText.text = card.ManaCost.ToString(); //text won't accept int which mana cost is so has to be converted
        nameText.text = card.CardName;
        descriptionText.text = card.CardDesc;
        spriteArt = card.CardSprite;
    }

}