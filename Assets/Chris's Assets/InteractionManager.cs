using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionManager : MonoBehaviour
{
    public XRSocketInteractor socketOnBunsen;
    public XRSocketInteractor socketOnTripod;
    public XRSocketInteractor socketOnRetord;
    public XRSocketInteractor socketOnBoilingTube;

    //used to check if the object is same with id
    IXRSelectInteractable tripod;
    IXRSelectInteractable beaker;
    IXRSelectInteractable boilingTube;
    IXRSelectInteractable thermometer;

    public bool setUpCompleted = false;
    public GameObject canvasObj;
    //names of items
    string tripodName= "TripodStand", beaker1Name= "Beaker", boilingTubeName= "BoilingTube", thermometerName= "Thermometer";
    // Start is called before the first frame update
    void Start()
    {
        //socketOnBunsen = GetComponent<XRSocketInteractor>();
        //socketOnTripod = GetComponent<XRSocketInteractor>();
        //socketOnRetord = GetComponent<XRSocketInteractor>();
        //socketOnBoilingTube = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        tripod = socketOnBunsen.GetOldestInteractableSelected();
        beaker= socketOnTripod.GetOldestInteractableSelected();
        boilingTube =socketOnRetord.GetOldestInteractableSelected();
        thermometer =socketOnBoilingTube.GetOldestInteractableSelected();
        
        
        if (tripod.transform.name== tripodName&& (beaker.transform.name==beaker1Name)&&boilingTube.transform.name==boilingTubeName&&thermometer.transform.name==thermometerName)
        {
            //the shit is done
            setUpCompleted = true;
            canvasObj.SetActive(true);
        }

    }
}
