using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TaskCreator : MonoBehaviour
{
    [SerializeField]
    Text AnswerText;
    [SerializeField]
    CardsOnField cardsOnField;
    string _asnwer = "";
    int _level = 0;
    [SerializeField]
    UnityEvent<int> AddCardEvent = new UnityEvent<int>();
    [SerializeField]
    UnityEvent<string> LoadedAnswerEvent = new UnityEvent<string>();

    public string Asnwer => _asnwer;
    public int Level => _level;

    public void CreateTask()
    {
        _level++;
        AddCardEvent.Invoke(_level);
        _asnwer = GetAsnwer();
        LoadedAnswerEvent.Invoke(_asnwer);
    }

    string GetAsnwer()
    {
        return cardsOnField.cards[Random.Range(0, cardsOnField.cards.Count)].Identifier;
    }
        
}