using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardRemover : MonoBehaviour
{
    [SerializeField]
    CardsOnField cardsOnField;
    [SerializeField]
    UnityEvent<CardObjectData> RemoveThisCard = new UnityEvent<CardObjectData>();
    [SerializeField]
    UnityEvent RemoveAllCard = new UnityEvent();
    public void RemoveCards()
    {
        RemoveAllCard.Invoke();
    }

    public void RemoveSpecificCard(string id)
    {
        foreach (CardObjectData card in cardsOnField.cards)
        {
            if (card.Identifier == id)
            {
                RemoveThisCard.Invoke(card);
                break;
            }
        }
    }
}
