using UnityEngine;

public class CardPlayLogic : MonoBehaviour
{
    private Player player;
    private Enemy selectedEnemy;
    //singleton implementation for this clas 
    private static CardPlayLogic cardManager;

    public Enemy SelectedEnemy
    {
        get { return selectedEnemy; }
        set { selectedEnemy = value; }
    }
    public static CardPlayLogic CardManager
    {
        get { return cardManager; }
    }

    void Awake()
    {
        if (cardManager != null && cardManager != this)
        {
            Destroy(gameObject);
            return;
        }

        cardManager = this;
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
                player.ReceiveHealing(1);
            }

            if (card.TypeCard == Card.CardType.Utility)
            {

            }
        }
    }
}
