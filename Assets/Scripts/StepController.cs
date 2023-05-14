using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StepController : MonoBehaviour
{
    public TextMeshProUGUI stepText;
    public bool step1Completed;
    public GameObject contin;

    public string sceneName ="Level4";
    void Start()
    {
        // Initialize the UI with the first step
        UpdateUI();
    }

    public void CompleteStep1()
    {
        CompleteStep(1);
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
           
        }

        // Update the UI based on the current step
        UpdateUI();
    }

    // Update the UI with the current step
    private void UpdateUI()
    {
        
        if (!step1Completed)
        {
            stepText.text = "Step 1: put the metal ball in one by one and record the result. After that is done, the task is completed";
            //stepImage.sprite = images[0];
        }
       
        else 
        {
            stepText.text = "Congratulations!! You have completed the experiment";
            contin.SetActive(true);
        }
    }
  

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }


    public void Quit()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif


    }

}
