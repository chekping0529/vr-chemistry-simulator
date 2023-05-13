using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlkaliMetalController : MonoBehaviour
{
    public GameObject water;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
    
            Debug.Log("touched");
        }
    }
}
