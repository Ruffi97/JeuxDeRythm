using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    [SerializeField] 
    private Profiles m_profiles;

    [SerializeField] 
    private List<SoundSliders> m_volumeSiders = new List<SoundSliders>();

    private void Awake()
    {
        m_profiles.setProfiles(m_profiles);
    }

    private void Start()
    {
        if (Settings.profiles && Settings.profiles.audioMixer != null)
        {
            Settings.profiles.GetAudioLevels();    
        }
    }

    public void ApplyChanges()
    {
        if (Settings.profiles && Settings.profiles.audioMixer != null)
        {
            Settings.profiles.SaveAudioLevels();    
        }
    }

    public void CancelChanges()
    {
        for (int i = 0; i < m_volumeSiders.Count; i++)
        {
            m_volumeSiders[i].ResetSliderValue();
        }
    }
}
