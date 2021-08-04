using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCardGenerator : MonoBehaviour
{
    [SerializeField]
    CardBundleData[] cardsToSpawn;
    [SerializeField]
    CardSpawnController cardSpawner;
    [SerializeField]
    int cardsPerLevel = 3;
    public void GenerateRandomCard(int level)
    {
        // Calculate amount of cards that needs to be spawned
        int cardsToAdd = level * cardsPerLevel;
        // Get total amount of cards
        int totalAmountOfCards = 0;
        for (int i = 0; i < cardsToSpawn.Length; i++)
        {
            totalAmountOfCards += cardsToSpawn[i].CardData.Length;
        }
        // Add cards to the field 
        int cardsAdded = 0;
        for (int i = 0; i < totalAmountOfCards; i++)
        {
            CardData newCard = GetRandomCard();
            if (cardSpawner.AllReadyPreset(newCard) == false)
            {
                cardSpawner.AddCard(newCard);
                cardsAdded++;
            }
            if (cardsAdded == cardsToAdd)
            {
                break;
            }
        }
    }

    CardData GetRandomCard()
    {
        int bundle = Random.Range(0, cardsToSpawn.Length);
        int card = Random.Range(0, cardsToSpawn[bundle].CardData.Length);
        return cardsToSpawn[bundle].CardData[card];
    }
}
