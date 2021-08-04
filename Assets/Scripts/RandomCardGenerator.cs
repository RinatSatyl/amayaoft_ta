using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomCardGenerator : MonoBehaviour
{
    [SerializeField]
    CardBundleData[] cardsToSpawn;
    [SerializeField]
    CardSpawnController cardSpawner;
    int totalAmountOfCards = 0;

    void GetCardTotalAmount()
    {
        if (totalAmountOfCards == 0)
        {
            // Get total amount of cards
            for (int i = 0; i < cardsToSpawn.Length; i++)
            {
                totalAmountOfCards += cardsToSpawn[i].CardData.Length;
            }
        }
    }
    public void GenerateRandomCard(int toAdd)
    {
        GetCardTotalAmount();
        // Add cards to the field 
        for (int i = 0; i < toAdd; i++)
        {
            CardData newCard = GetRandomCard();
            while (cardSpawner.AllReadyPreset(newCard) == true)
            {
                newCard = GetRandomCard();
            }
            cardSpawner.AddCard(newCard);
        }
    }

    void SpawnCards()
    {

    }

    CardData GetRandomCard()
    {
        int bundle = Random.Range(0, cardsToSpawn.Length);
        int card = Random.Range(0, cardsToSpawn[bundle].CardData.Length);
        return cardsToSpawn[bundle].CardData[card];
    }
}
