using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    public TextMeshProUGUI stepText;
    public Image stepImage;
    public Sprite[] images;
    public bool step1Completed;
    public bool step2Completed;
    public bool step3Completed;
    public bool step4Completed;
    public bool step5Completed;
    public GameObject sodium;
    private ParticleSystem particle;
    public string sceneName = "Level 4";
    public GameObject contin;
    public InteractionManager interactionManager;
    public TutorWearScrib fire;
    public Test test;

    void Start()
    {

        // Initialize the UI with the first step
        UpdateUI();
    }
    private void Update()
    {



        if (interactionManager.setUpCompleted && !step1Completed)
        {
            CompleteStep(1);
        }
        if (fire.isFire && !step2Completed)
        {
            CompleteStep(2);
        }
        if ((test.temperature == 90) && !step3Completed)
        {
            CompleteStep(3);
        }
        if (!(fire.isFire) && !step4Completed&& step3Completed)
        {
            CompleteStep(4);
        }
        if ((test.temperature == 60) && !step5Completed)
        {
            CompleteStep(5);
        }


    }

    public void CompleteStep()
    {
       
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
            stepText.text = "Step 1: Set up the lab equipment as the image below";
            stepImage.sprite = images[0];
        }
        else if (!step2Completed)
        {
            stepText.text = "Step 2: Turn on the fire";
            //stepImage.sprite = images[1];
        }
        else if (!step3Completed)
        {
            stepText.text = "Step 3: Record the temperature and matter state each 30s  after 60 degree until 90 degree";
            //stepImage.sprite = images[2];
        }
        else if (!step4Completed)
        {
            stepText.text = "Step 4: Turn off the fire";
            //stepImage.sprite = images[3];
        }
        else if (!step5Completed)
        {
            stepText.text = "Step 5: Record the temperature and matter state each 30s from 90 degree to 60 degree";
            //stepImage.sprite = images[3];
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
