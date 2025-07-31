using UnityEngine;

public class CardPlayLogic : MonoBehaviour
{
    private Player player;
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
        if (player.currentMana >= card.ManaCost)
        {
            if (card.TypeCard == Card.CardType.Attack)
            {
                CardManager.selectedEnemy.TakeDamage((int)(card.PowerScaling * player.baseStrength));
            }

            if (card.TypeCard == Card.CardType.Healing)
            {

            }

            if (card.TypeCard == Card.CardType.Utility)
            {

            }
        }
    }
}
