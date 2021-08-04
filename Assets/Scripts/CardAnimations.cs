using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardAnimations : MonoBehaviour
{
    void Awake()
    {
        transform.DOShakeScale(0.5f);
    }
}
