using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    //public Button level1Button;
    public Button level2Button;
    public Button level3Button;

    private void Start()
    {
        // Add onClick listeners to the level buttons
        //level1Button.onClick.AddListener(OnLevel1ButtonClick);
        level2Button.onClick.AddListener(OnLevel2ButtonClick);
        level3Button.onClick.AddListener(OnLevel3ButtonClick);
    }

    //private void OnLevel1ButtonClick()
    //{
    //    // Load Level 1 scene
    //    LoadLevel("Level 1");
    //}

    private void OnLevel2ButtonClick()
    {
        // Load Level 2 scene
        LoadLevel("Level 2");
    }

    private void OnLevel3ButtonClick()
    {
        // Load Level 3 scene
        LoadLevel("Level 3");
    }

    private void LoadLevel(string levelName)
    {
        // Load the specified scene
        SceneManager.LoadScene(levelName);
    }
}
