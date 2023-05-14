using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Ani : MonoBehaviour
{

    public Animation animationComponent; // Reference to the Animation component
    public string animationName = "ResultLevel3"; // Name of the animation clip
    // Start is called before the first frame update
    void Start()
    {
        animationComponent = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        animationComponent.Play(animationName);
    }
}
