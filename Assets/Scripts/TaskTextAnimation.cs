using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TaskTextAnimation : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    public void StartMe()
    {
        if (text == null)
        {
            text = GetComponent<Text>();
        }
        text.DOFade(1, 1f);
    }

    public void StopMe()
    {
        text.DOFade(0, 0.2f);
    }

}
