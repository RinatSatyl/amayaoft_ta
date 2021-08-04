using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRemover : MonoBehaviour
{
    [SerializeField]
    CardsOnField cardsOnField;
    public void RemoveCards()
    {
        foreach (CardObjectData card in cardsOnField.cards)
        {
            Destroy(card.gameObject);
        }
    }

    public void RemoveSpecificCard(string id)
    {
        foreach (CardObjectData card in cardsOnField.cards)
        {
            if (card.Identifier == id)
            {
                Destroy(card.gameObject);
                break;
            }
        }
    }
}
