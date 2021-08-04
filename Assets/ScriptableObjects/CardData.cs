using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CardData
{
    [SerializeField] private string _identifier;

    [SerializeField] private Image _image;

    public string Identifier => _identifier;

    public Image Image => _image;
}
