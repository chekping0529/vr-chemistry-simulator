using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class meltMG : MonoBehaviour
{
    // Start is called before the first frame update
    public crucibleInteractionManager crsIM;
    public fireScr fire;
    public GameObject canv;
    public float Timetomelt = 20f;

    public bool melted = false;
    public bool begin = false;

    public GameObject solidMG, meltedMG;

    public TextMeshProUGUI stateValue;

    void Start()
    {

        stateValue.text = "Solid";
    }

    // Update is called once per frame
    void Update()
    {
        if(crsIM.setUpCompleted)
        {
            canv.SetActive(true);
            if(fire.isFire)
            {
                if (begin == false)
                {
                    Debug.Log("FAQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ");
                    StartCoroutine(meltTimer());
                }
                
            }

        }

        

        if(melted==true)
        {
            solidMG.SetActive(false);
            meltedMG.SetActive(true);
            stateValue.text = "Liquid";
        }



    }

    private IEnumerator meltTimer()
    {
        begin = true;
        yield return new WaitForSeconds(Timetomelt);
        melted = true;

    }
}
