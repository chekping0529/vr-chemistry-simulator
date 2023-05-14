using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider BGM_Slider;
    public Slider SFX_Slider;

    private float tempBGM;
    private float savedBGM;

    private float tempSFX;
    private float savedSFX;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("BGM_Volume"))
        {
            LoadBGMVolume();
        }
        else
        {
            SetBGMVolume();
        }

        if (!PlayerPrefs.HasKey("SFX_Volume"))
        {
            LoadSFXVolume();
        }
        else
        {
            SetSFXVolume();
        }
    }

    void OnEnable()
    {
        LoadBGMVolume();
        LoadSFXVolume();
        savedBGM = tempBGM;
        savedSFX = tempSFX;
    }

    public void SetBGMVolume()
    {
        tempBGM = BGM_Slider.value;
        audioMixer.SetFloat("BGM", Mathf.Log10(tempBGM) * 20);

    }

    public void LoadBGMVolume()
    {
        BGM_Slider.value = PlayerPrefs.GetFloat("BGM_Volume");

        SetBGMVolume();
    }

    public void SetSFXVolume()
    {
        tempSFX = SFX_Slider.value;
        audioMixer.SetFloat("SFX", Mathf.Log10(tempSFX) * 20);

    }

    public void LoadSFXVolume()
    {
        SFX_Slider.value = PlayerPrefs.GetFloat("SFX_Volume");

        SetSFXVolume();
    }

    public void ApplySetting()
    {
        PlayerPrefs.SetFloat("BGM_Volume", tempBGM);
        PlayerPrefs.SetFloat("SFX_Volume", tempSFX);
        savedBGM = tempBGM;
        savedSFX = tempSFX;
    }

    public void BackSetting()
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(savedBGM) * 20);
        audioMixer.SetFloat("SFX", Mathf.Log10(savedSFX) * 20);
    }
}
