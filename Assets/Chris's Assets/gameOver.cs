using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject danger;
    string nameLeft = "LeftHand Controller", nameRight = "RightHand Controller";

    static bool gamestatus = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == nameLeft || collision.gameObject.name == nameRight|| collision.gameObject.tag=="Player")
        {
            gamestatus = false;
        }
        Debug.Log(gamestatus);
    }
    
}
