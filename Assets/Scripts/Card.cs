using UnityEngine;

[CreateAssetMenu(menuName = "Card")]

public class Card : ScriptableObject
{
    private string cardName;
    private string cardDesc;
    private int manaCost;
    private float powerScaling;
    private CardType cardType;

    public enum CardType
    {
        Attack, Healing, Utility
    }

    
}
