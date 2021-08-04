using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AsnwerChecker : MonoBehaviour
{
    [SerializeField]
    GameObject WinScreen;
    [SerializeField]
    TaskCreator taskCreator;
    [SerializeField]
    public UnityEvent<bool> AsnwerCorrect = new UnityEvent<bool>();
    [SerializeField]
    public UnityEvent ProceedFoward = new UnityEvent();
    [SerializeField]
    int lastLevel = 3;
    public bool IsLastLevel
    {
        get
        {
            return taskCreator.Level == lastLevel;
        }
    }

    public bool CheckAnswer(string id)
    {
        bool isRight = id == taskCreator.Asnwer;
        return isRight;
    }
    public void ActivateWinScreen()
    {
        WinScreen.SetActive(true);
    }
}
