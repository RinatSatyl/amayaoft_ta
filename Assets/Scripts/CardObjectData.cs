using UnityEngine;
using UnityEngine.UI;

public class CardObjectData : MonoBehaviour
{
    [SerializeField]
    Image sprite;
    [SerializeField]
    string identifier;

    public string Identifier => identifier;

    public void SetCardData(CardData thisCardData)
    {
        sprite = thisCardData.Image;
        identifier = thisCardData.Identifier;
    }
}
