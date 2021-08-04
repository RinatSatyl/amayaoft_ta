using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections.Generic;

public class TaskCreator : MonoBehaviour
{
    [SerializeField]
    Text AnswerText;
    [SerializeField]
    CardsOnField cardsOnField;
    string _asnwer = "";
    int _level = 0;
    [SerializeField]
    int cardsPerLevel = 3;
    [SerializeField]
    UnityEvent<int> AddCardEvent = new UnityEvent<int>();
    [SerializeField]
    UnityEvent<string> LoadedAnswerEvent = new UnityEvent<string>();
    List<string> recordedAsnwers = new List<string>();

    public string Asnwer => _asnwer;
    public int Level => _level;

    public void CreateTask()
    {
        _level++;
        AddCardEvent.Invoke(cardsPerLevel * _level);
        _asnwer = GetAsnwer();
        LoadedAnswerEvent.Invoke(_asnwer);
    }

    public void ResetLevel()
    {
        _level = 0;
    }

    string GetAsnwer()
    {
        string newAnswer = cardsOnField.cards[Random.Range(0, cardsOnField.cards.Count)].Identifier;
        while (recordedAsnwers.Contains(newAnswer) == true)
        {
            newAnswer = cardsOnField.cards[Random.Range(0, cardsOnField.cards.Count)].Identifier;
        }
        recordedAsnwers.Add(newAnswer);
        return newAnswer;
    }
        
}