using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    public Deck deck;
    public int maxHandSize = 5;
    public Transform handContainer;
    public GameObject cardPrefab; 

    private List<Card> currentHand = new List<Card>();

    void Start()
    {
        DrawInitialHand();
    }

    public void DrawInitialHand()
    {
        for (int i = 0; i < maxHandSize; i++)
        {
            DrawCardToHand();
        }
    }

    public void DrawCardToHand()
    {
        if (currentHand.Count >= maxHandSize) return;

        Card newCard = deck.DrawCard();
        if (newCard != null)
        {
            currentHand.Add(newCard);
            CreateCardUI(newCard);
        }
    }

    private void CreateCardUI(Card card)
    {
        GameObject cardGO = Instantiate(cardPrefab, handContainer);
        Image img = cardGO.GetComponent<Image>();
        if (img != null)
        {
            img.sprite = card.CardSprite;
        }

    }

    public void PlayCard(Card card)
    {
        if (!currentHand.Contains(card)) return;

        CardPlayLogic.CardManager.PlayCard(card);
        currentHand.Remove(card);

        foreach (Transform child in handContainer)
        {
            Image img = child.GetComponent<Image>();
            if (img != null && img.sprite == card.CardSprite)
            {
                Destroy(child.gameObject);
                break;
            }
        }
        deck.DiscardCard(card);
    }
}