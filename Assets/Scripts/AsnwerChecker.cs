using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AsnwerChecker : MonoBehaviour
{
    [SerializeField]
    TaskCreator taskCreator;
    [SerializeField]
    UnityEvent AsnwerCorrect = new UnityEvent();
    public void CheckAnswer(string id)
    {
        if (id == taskCreator.Asnwer)
        {
            AsnwerCorrect.Invoke();
        }
    }
}
