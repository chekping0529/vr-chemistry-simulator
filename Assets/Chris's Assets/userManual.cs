using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class userManual : XRBaseInteractor
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public GameObject rightHan;
    const string tripodName = "TripodStand", beaker1Name = "Beaker", boilingTubeName = "BoilingTube", thermometerName = "Thermometer", burnerName = "Bunsen Burner";
    RaycastHit hit;


    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }



    public void itemDesc()
    {
        rightHan.GetComponent<XRRayInteractor>().TryGetCurrent3DRaycastHit(out hit);
        title.text = hit.collider.gameObject.name;
        //if(Physics.Raycast(rightHan.TryGetCurrent3DRaycastHit.,hit))

        //desc for beaker,

        switch (this.gameObject.name)
        {
            case tripodName:
                description.text = "This is test1";
                break;
            case beaker1Name:
                break;
            case boilingTubeName:
                break;
            case thermometerName:
                break;
            case burnerName:
                break;
            default: 
                break;





        }
        
    }

    protected void OnHoverEntered(XRBaseInteractable interactable)
    {
        base.OnHoverEntered(interactable);

        // Get the GameObject that was hit by the raycast
        GameObject hitObject = interactable.gameObject;

        // Update the text object with information about the hit object
        title.text = "Hit object: " + hitObject.name;
    }




}
