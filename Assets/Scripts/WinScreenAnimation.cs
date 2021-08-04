using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.Events;

public class WinScreenAnimation : MonoBehaviour
{
    Image image;
    [SerializeField]
    UnityEvent ProceedFoward = new UnityEvent();
    [SerializeField]
    UnityEvent OnStart = new UnityEvent();

    void OnEnable()
    {
        if (image == null)
        {
            image = GetComponent<Image>();
        }
        image.color = new Color(0, 0, 0, 0);
        image.DOFade(0.5f, 0.5f);
        OnStart.Invoke();
    }

    public void RestartAnimation()
    {
        image.DOFade(1f, 1.5f).OnComplete(InvokeEvent);
    }

    void InvokeEvent()
    {
        ProceedFoward.Invoke();
        gameObject.SetActive(false);
    }
}
