using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class TutorWearScrib : MonoBehaviour
{
    public GameObject frame;
    public GameObject grabCompo;
    public AudioSource wearAudioSource;
    public bool wore;
    // Start is called before the first frame update
    void Start()
    {
        wore = false;
        wearAudioSource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void disableFrame()
    {
        wearAudioSource.Play();
        grabCompo.GetComponent<XRGrabInteractable>().enabled=false;
        wore = true;
        frame.SetActive(false);
    }
}
