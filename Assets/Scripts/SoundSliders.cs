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
    private Text volumeLabel;

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
            volumeLabel.text = Mathf.Round(value * 100.0f).ToString() + "%";

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