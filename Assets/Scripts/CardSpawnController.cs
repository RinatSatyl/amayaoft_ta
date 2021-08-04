using System.Collections.Generic;
using UnityEngine;

public class CardSpawnController : MonoBehaviour
{
    [SerializeField]
    CardsOnField cardsOnField;
    [SerializeField]
    GameObject cardPrefab;
    [SerializeField]
    GameObject grid;

    public void AddCard(CardData thisCard)
    {
        GameObject newCardObject = Instantiate(cardPrefab);
        CardObjectData newCardObjectData = newCardObject.GetComponent<CardObjectData>();
        newCardObjectData.SetCardData(thisCard);
        newCardObject.transform.parent = grid.transform;
        cardsOnField.cards.Add(newCardObjectData);
    }

    public void RemoveCard(CardData thisCard)
    {
        foreach(CardObjectData card in cardsOnField.cards)
        {
            if (card.Identifier == thisCard.Identifier)
            {
                cardsOnField.cards.Remove(card);
                Destroy(card.gameObject);
            }
        }
    }

    public bool AllReadyPreset(CardData thisCard)
    {
        bool contains = false;
        foreach (CardObjectData card in cardsOnField.cards)
        {
            if (card.Identifier == thisCard.Identifier)
            {
                contains = true;
            }
        }
        return contains;
    }
}
