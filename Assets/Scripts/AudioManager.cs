using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    public AudioSource BGMSource;
    public AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip bgm;
    public AudioClip[] audioClip;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        BGMSource.clip = bgm;
        BGMSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}