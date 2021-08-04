using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardPressesLogic : MonoBehaviour
{
    CardObjectData cardObjectData;
    AsnwerChecker answerCheck;
    [SerializeField]
    IconAnimation iconAnimation;

    void Start()
    {
        answerCheck = FindObjectOfType<AsnwerChecker>();
        cardObjectData = GetComponent<CardObjectData>();
    }

    public void Pressed()
    {
        if (answerCheck.CheckAnswer(cardObjectData.Identifier) == true)
        {
            iconAnimation.ShakeGood();
        }
        else if (answerCheck.CheckAnswer(cardObjectData.Identifier) == false)
        {
            iconAnimation.ShakeBad();
        }
    }

    public void Proceed()
    {
        if (answerCheck.IsLastLevel == false)
        {
            answerCheck.ProceedFoward.Invoke();
        }
        else
        {
            answerCheck.ActivateWinScreen();
        }
    }
}
