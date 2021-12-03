using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof(Slider))]
public class SoundSliders : MonoBehaviour

{
    public string volumeName;
    public Text volumeLabel;
    [SerializeField] private RectTransform FxHolder;

    Slider _Slider
    {
        get { return GetComponent<Slider>(); }
    }

    private void Start()
    {
        ResetSliderValue();

        _Slider.onValueChanged.AddListener(delegate { UpdateValueOnChange(_Slider.value); });
    }

    public void UpdateValueOnChange(float value)
    {
        if (volumeLabel != null)
            volumeLabel.text = volumeName + "\n" +  Mathf.Round(value * 100.0f).ToString() + "%";
        FxHolder.rotation = Quaternion.Euler(new Vector3(0f, 0f, -value * 360));

        if (Settings.profiles)
        {
            Settings.profiles.SetAudioLevels(volumeName, value);
        }
    }

    public void ResetSliderValue()
    {
        if (Settings.profiles)
        {
            float volume = Settings.profiles.GetAudioLevels(volumeName);
            UpdateValueOnChange(volume);
            _Slider.value = volume;
        }
    }
}