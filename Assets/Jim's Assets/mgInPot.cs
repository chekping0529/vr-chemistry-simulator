using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mgInPot : MonoBehaviour
{
    // Start is called before the first frame update

    public bool mgcolli;
    void Start()
    {
        mgcolli = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Crucible")
        {
            
            mgcolli = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Crucible")
        {
            
            mgcolli = false;
        }
    }

}
