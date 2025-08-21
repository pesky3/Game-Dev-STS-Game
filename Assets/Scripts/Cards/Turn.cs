using UnityEngine;
using UnityEngine.SceneManagement;

public class Turn : MonoBehaviour
{   
    public Deck deck;


    public void ClickEndTurn()
    {
        deck.DrawCard();
    }
}
