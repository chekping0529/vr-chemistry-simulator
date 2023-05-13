using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StepController : MonoBehaviour
{
    public TextMeshProUGUI stepText;
    public Image stepImage;
    public Sprite[] images;
    public bool step1Completed;
    public bool step2Completed;
    public bool step3Completed;
    public bool step4Completed;
    public GameObject sodium;
    private ParticleSystem particle;
    public string sceneName ="Level Tut";
    void Start()
    {
        particle = sodium.GetComponent<ParticleSystem>();
        particle.Pause();

        // Initialize the UI with the first step
        UpdateUI();
    }

    public void CompleteStep1()
    {
        CompleteStep(1);
        Debug.Log("checked");
        particle.Play();
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
            case 3:
                step3Completed = true;
                break;
            case 4:
                step4Completed = true;
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
            stepText.text = "Step 1: ...";
            //stepImage.sprite = images[0];
        }
        else if (!step2Completed)
        {
            stepText.text = "Step 2: ...";
            //stepImage.sprite = images[1];
        }
        else if (!step3Completed)
        {
            stepText.text = "Step 3: ...";
            //stepImage.sprite = images[2];
        }
        else if (!step4Completed)
        {
            stepText.text = "Step 4: ...";
            //stepImage.sprite = images[3];
        }
        else
        {
            // All steps completed, show a message or perform some other action
            Debug.Log("All steps completed!");
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
