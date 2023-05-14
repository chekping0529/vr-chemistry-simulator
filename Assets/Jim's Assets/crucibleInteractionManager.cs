using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class crucibleInteractionManager : MonoBehaviour
{
    public XRSocketInteractor socketOnBunsen;
    public XRSocketInteractor socketOnTripod;
    public Animation animationComponent; // Reference to the Animation component
    public string animationName = "ResultLevel1"; // Name of the animation clip

    //used to check if the object is same with id
    IXRSelectInteractable tripod;
    IXRSelectInteractable crucible;

    public bool setUpCompleted = false;
    public GameObject canvasObj;
    //names of items
    string tripodName= "TripodStand", crucibleName = "Crucible";
    public mgInPot mgInPotDetec;
    // Start is called before the first frame update
    void Start()
    {
        animationComponent = GetComponent<Animation>();
        //socketOnBunsen = GetComponent<XRSocketInteractor>();
        //socketOnTripod = GetComponent<XRSocketInteractor>();
        //socketOnRetord = GetComponent<XRSocketInteractor>();
        //socketOnBoilingTube = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        tripod = socketOnBunsen.GetOldestInteractableSelected();
        crucible = socketOnTripod.GetOldestInteractableSelected();
        
        
        
        if (tripod.transform.name== tripodName&& crucible.transform.name==crucibleName&& mgInPotDetec.mgcolli)
        {
            //the shit is done
            setUpCompleted = true;
            canvasObj.SetActive(true);
            animationComponent.Play(animationName);
        }
        else
        {
            setUpCompleted = false;
            canvasObj.SetActive(false);
        }

    }


}
