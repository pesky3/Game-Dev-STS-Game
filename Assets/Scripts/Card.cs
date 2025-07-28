using UnityEngine;

[CreateAssetMenu(menuName = "Card")]

public class Card : ScriptableObject
{
    [SerializeField] private string cardName;
    [SerializeField] private string cardDesc;
    [SerializeField] private int manaCost;
    [SerializeField] private float powerScaling;
    [SerializeField] private Sprite cardSprite;
    [SerializeField] private CardType typeCard;

    public string CardName { get => cardName;  }
    public string CardDesc { get => cardDesc; }
    public int ManaCost { get => manaCost; }
    public float PowerScaling { get => powerScaling; }
    public Sprite CardSprite { get => cardSprite; }
    public CardType TypeCard { get => typeCard; }


    public enum CardType
    {
        Attack, Healing, Utility
    }

    
}
