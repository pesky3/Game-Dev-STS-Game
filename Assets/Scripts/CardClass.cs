using UnityEngine;

public abstract class Card : ScriptableObject
{

    public string cardName = "New Card";
    public Sprite artwork;
    public string description;
    public int cost = 1;

    public CardType cardType;



    public abstract void Play(GameObject target);

}

public enum CardType
{
    Attack,
    Skill,
    Power,
    Special
}
