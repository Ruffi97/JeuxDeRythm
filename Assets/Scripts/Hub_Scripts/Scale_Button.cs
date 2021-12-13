using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Scale_Button : MonoBehaviour
{
    [SerializeField]
    private float _scaleValue;
    [SerializeField]
    private AnimationCurve _curve;
    [SerializeField]
    private float _duration;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _duration)
        {
            Scale();
            _timer = 0f;
        }
    }

    public void Scale()
    {
        transform.DOPause();
        transform.DOScale(_scaleValue,  _duration).SetEase(_curve);
    }
}