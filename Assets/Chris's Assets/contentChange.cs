using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class contentChange : MonoBehaviour
{
    int material;
    public GameObject beaker1, beaker2, boilingTube;
    public Renderer[] contentRendererbeaker1 = new Renderer[0];
    public Renderer[] contentRendererbeaker2 = new Renderer[0];
    public Renderer[] contentRendererboilingTube = new Renderer[0];
    Collision collision=null;
    UnityEngine.Color color;
    static float currentFloatValuebeaker1 = 0f;
    static float currentFloatValuebeaker2 = 0f;
    static float currentFloatValueboilingTube = 0f;
    float targetFloatValue = 0.0005f;
    
    bool colide = false;
    // water is 0,nepthalene is 1
    void Start()
    {
        if(this.gameObject.name=="Water")
        {
            color = UnityEngine.Color.blue;
        }
        else if(this.gameObject.name== "Naphthalene ")
        {
            color = UnityEngine.Color.white;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(colide)
        {
            
            if (collision.gameObject.name == beaker1.name)
            {
                currentFloatValuebeaker1 += targetFloatValue;
                contentRendererbeaker1[0].material.SetFloat("_Fill", currentFloatValuebeaker1);
                contentRendererbeaker1[0].material.SetColor("_Top", color);
            }
            else if (collision.gameObject.name == beaker2.name)
            {
                currentFloatValuebeaker2 += targetFloatValue;
                contentRendererbeaker2[0].material.SetFloat("_Fill", currentFloatValuebeaker2);
                contentRendererbeaker2[0].material.SetColor("_Top", color);
            }
            else if (collision.gameObject.name == boilingTube.name)
            {
                currentFloatValueboilingTube += targetFloatValue;
                contentRendererboilingTube[0].material.SetFloat("_Fill", currentFloatValueboilingTube);
                contentRendererboilingTube[0].material.SetColor("_Top", color);
            }



        }
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        colide = true;
        this.collision = collision;
        if(this.name=="ClearContent")
        {
            if (collision.gameObject.name == beaker1.name)
            {
                currentFloatValuebeaker1 = 0;
                contentRendererbeaker1[0].material.SetFloat("_Fill", currentFloatValuebeaker1);
            }
            else if (collision.gameObject.name == beaker2.name)
            {
                currentFloatValuebeaker2 = 0;
                contentRendererbeaker2[0].material.SetFloat("_Fill", currentFloatValuebeaker2);
            }
            else if (collision.gameObject.name == boilingTube.name)
            {
                currentFloatValueboilingTube = 0;
                contentRendererboilingTube[0].material.SetFloat("_Fill", currentFloatValueboilingTube);
            }
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        this.collision = collision;
        colide = false;
    }

}
