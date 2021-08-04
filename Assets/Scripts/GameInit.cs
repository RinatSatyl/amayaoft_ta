using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameInit : MonoBehaviour
{
    [SerializeField]
    UnityEvent StartGame = new UnityEvent();

    void Start()
    {
        StartGame.Invoke();
    }
}
