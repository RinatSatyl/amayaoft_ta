using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using DG.Tweening;

public class IconAnimation : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particleSystem;
    [SerializeField]
    public UnityEvent ProceedFoward = new UnityEvent();

    public void ShakeBad()
    {
        transform.DOShakePosition(0.4f, strength: 40, vibrato: 20, randomness: 90, snapping: true, fadeOut: false);
    }

    public void ShakeGood()
    {
        transform.DOShakePosition(1.5f, strength: 40, vibrato: 4, randomness: 90, snapping: true, fadeOut: false).OnComplete(Proceed);
        particleSystem.Play();
    }

    public void Proceed()
    {
        ProceedFoward.Invoke();
    }
}
