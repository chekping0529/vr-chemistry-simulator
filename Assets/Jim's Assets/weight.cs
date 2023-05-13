using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class weight : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI weightValue;
    public meltMG mMG;
    public string crucibleName = "Crucible",solidMGName= "SolidMG";
    float crucibleWeight, MGWeight, meltedMGWithCrucWeight;

    void Start()
    {
        crucibleWeight = 10.00f;
        MGWeight = 2.39f;
        meltedMGWithCrucWeight = 13.78f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(mMG.melted)
        {
            if (collision.gameObject.name == crucibleName)
            {
                weightValue.text = meltedMGWithCrucWeight.ToString() + "g";

            }
        }
        else if(!mMG.melted)
        {
            if (collision.gameObject.name == crucibleName)
            {
                weightValue.text = crucibleWeight.ToString() + "g";

            }
            else if (collision.gameObject.name == solidMGName)
            {
                weightValue.text = MGWeight.ToString() + "g";
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        weightValue.text = "0" + "g";
    }
}
