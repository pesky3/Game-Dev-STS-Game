using UnityEngine;

public class CardPlayLogic : MonoBehaviour
{
    private Enemy selectedEnemy;
    //singleton implementation for this clas 
    private CardPlayLogic cardManager;
    public CardPlayLogic CardManager
    {
        get { return cardManager; }
    }

    public void SelectEnemy(Enemy enemy)
    {
        CardManager.selectedEnemy = enemy;
    }


    public void PlayCard(Card card)
    {
        if (card.TypeCard == Card.CardType.Attack)
        {
            CardManager.selectedEnemy.TakeDamage(1);
        }

        if (card.TypeCard == Card.CardType.Healing)
        {

        }

        if (card.TypeCard == Card.CardType.Utility)
        {
        
        }
    }
}
