using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardPressesLogic : MonoBehaviour
{
    CardObjectData cardObjectData;
    AsnwerChecker asnwerChecker;

    void Start()
    {
        asnwerChecker = FindObjectOfType<AsnwerChecker>();
        cardObjectData = GetComponent<CardObjectData>();
    }

    public void Pressed()
    {
        asnwerChecker.CheckAnswer(cardObjectData.Identifier);
    }
}
