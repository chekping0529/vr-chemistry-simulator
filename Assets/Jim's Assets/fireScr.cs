using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class fireScr : MonoBehaviour
{
    public GameObject frame;
    public GameObject grabCompo;
    public AudioSource wearAudioSource;
    public GameObject fire;
    public bool wore;
    public bool isFire;
    float startTime;
    static float timeRecord;
    public Test timeReset;
    public crucibleInteractionManager allowFire;


    // Start is called before the first frame update
    void Start()
    {
        isFire = false;
        wore = false;
        wearAudioSource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFire)
        {
            timeRecord = Time.time - startTime;
        }
    }

    public void disableFrame()
    {
        wearAudioSource.Play();
        grabCompo.GetComponent<XRGrabInteractable>().enabled=false;
        wore = true;
        frame.SetActive(false);
    }

    public void activateFire()
    {
        if(allowFire.setUpCompleted&&isFire==false)
        {
            fire.SetActive(true);
            isFire = true;
            //startTime = Time.time;
        }
        else if (allowFire.setUpCompleted && isFire == true)
        {
            timeReset.timeRecording = 0;
            fire.SetActive(false);
            isFire = false;
        }



    }
}
