using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; 

public class fx_takerot : MonoBehaviour
{
    [SerializeField] RectTransform FxHolder;
    [SerializeField] Image CircleImg;
    [SerializeField] private Text txtProgress;

    [SerializeField] [Range(0,1)] float progress = 0f;
    void Update()
    {
        CircleImg.fillAmount = progress;
        txtProgress.text = Mathf.Floor(progress * 100).ToString();
        FxHolder.rotation = Quaternion.Euler(new Vector3(0f,0f, -progress * 360));
    }
}
