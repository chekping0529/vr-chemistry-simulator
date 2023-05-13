using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI stepText;
    public GameObject labCoat;
    public GameObject glasses;
    public bool step1Completed;
    public bool step2Completed;
    public GameObject nextButton;

    void Start()
    {
        // Initialize the UI with the first step
        UpdateUI();
    }

    private void Update()
    {
        steps();
    }
    public void steps()
    {
        if (!labCoat.activeSelf)
        { 
        
        CompleteStep(1);
        Debug.Log("checked");

        }

        if (!glasses.activeSelf)
        {

            CompleteStep(2);
            Debug.Log("checked2");

        }

        

    }

    

    // This method can be called when the user completes a step
    public void CompleteStep(int stepIndex)
    {
        // Update the completion status of the appropriate step
        switch (stepIndex)
        {
            case 1:
                step1Completed = true;
                break;
            case 2:
                step2Completed = true;
                break;
         
        }

        // Update the UI based on the current step
        UpdateUI();
    }

    // Update the UI with the current step
    private void UpdateUI()
    {
        if (!step1Completed)
        {
            stepText.text = "Please wear your lab coats";
            //stepImage.sprite = images[0];
        }
        else if (!step2Completed)
        {
            stepText.text = "Please wear your glasses";
            //stepImage.sprite = images[1];
        }
        else
        {
            // All steps completed, show a message or perform some other action
            stepText.text = "congratulations! now you are all set";
            nextButton.SetActive(true);
            Debug.Log("done");
        }
    }
}
