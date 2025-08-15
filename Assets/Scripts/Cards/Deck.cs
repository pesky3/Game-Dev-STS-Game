using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> allCards; 
    private List<Card> deck = new List<Card>();
    private List<Card> discardPile = new List<Card>();

    void Start()
    {
        ResetDeck();
        ShuffleDeck();
    }

    public void ResetDeck()
    {
        deck.Clear();
        deck.AddRange(allCards);
        discardPile.Clear();
    }

    public void ShuffleDeck()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            Card temp = deck[i];
            int randomIndex = Random.Range(i, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

    public Card DrawCard()
    {
        if (deck.Count == 0)
        {

            deck.AddRange(discardPile);
            discardPile.Clear();
            ShuffleDeck();
        }

        if (deck.Count == 0)
        {
            Debug.LogWarning("No cards to draw!");
            return null;
        }

        Card drawn = deck[0];
        deck.RemoveAt(0);
        return drawn;
    }

    public void DiscardCard(Card card)
    {
        discardPile.Add(card);
    }
}