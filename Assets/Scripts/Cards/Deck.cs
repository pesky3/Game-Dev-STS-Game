using UnityEngine;
using System.Collections.Generic;

public class Deck : MonoBehaviour
{
    public List<Card> startingDeck = new List<Card>();
    public List<Card> hand = new List<Card>();
    public List<Card> drawPile = new List<Card>();
    public List<Card> discardPile = new List<Card>();

    public Transform handArea;
    public GameObject prefabCard;
    public float cardSpacing;
    private int cardCount = 0;

    public void Start()
    {
        drawPile = new List<Card>(startingDeck); 
        Shuffle(drawPile); //draw pile randomised but still have the same cards as the deck to start
    }
    public void DrawCard()
    {
        hand.Add(drawPile[0]); // hand will take the first card in the draw pile
        drawPile.RemoveAt(0); // draw pile depletes that card

        GameObject card = Instantiate(prefabCard, handArea); // Apparently putting a transform in the Instantiate method will tell unity that that gameobject would be the parent of the instantiated Object;
        PrefabController controller = card.GetComponent<PrefabController>(); //getting the prefab PrefabController Script
        controller.card = hand[hand.Count - 1];
        controller.cardSetup(hand[hand.Count-1]); // hand.Count-1 is the last index in the list aka the most recent one.
        cardCount = hand.Count; //checking how many cards are in hand


        card.transform.localPosition = new Vector2(cardCount * cardSpacing, 0); //hand card count check is used here to space the instantiated cards based on hand count

        

    }

    public void Shuffle(List<Card> cardList)
    {
        for (int i = 0; i < cardList.Count; i++)
        {
            int rndNum;
            rndNum = Random.Range(i, cardList.Count); //creating a function to shuffle the deck for my drawing pile, I am using a for loop and basically swapping the places of TWO cards to make sure the deck remains the same
            Card swappedCard = cardList[i];
            cardList[i] = cardList[rndNum]; // here the iterated card will change to become the randomly selected card in the list.
            cardList[rndNum] = swappedCard; //because the iterated card disappeared I will need to use the "backup" i got earlier to swap the index of the card that was used to copy the iterated index
        }
    }

}
