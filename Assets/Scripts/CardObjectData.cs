using UnityEngine;
using UnityEngine.UI;

public class CardObjectData : MonoBehaviour
{
    [SerializeField]
    Image image;
    [SerializeField]
    string identifier;

    public string Identifier => identifier;

    public void SetCardData(CardData thisCardData)
    {
        image.sprite = thisCardData.Sprite;
        identifier = thisCardData.Identifier;
    }
}
