using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    public float temperature;
    public float timeRecording =0;
    public string state;
    float rateOfTemRise=1f;
    int roomTemp = 50;
    public bool meltingTestComp, freezingTestComp;
    int maxTime = 360;
    string initialState = "Solid";
    string midState = "Solid and Liquid";
    string finalState = "Liquid";
    public bool continueTemp = false;
    //state for melitng     = initialState  midState    finalState
    //state for freezing    = finalState    midState    initialState
    //total time=360

    //begin recording when temp reach 60
    //78 change state, stay for 180 seconds

    public TextMeshProUGUI tempValue;
    public TextMeshProUGUI timeValue;
    public TextMeshProUGUI stateValue;

    public TutorWearScrib fireDetect;

    public bool startRecord=false;

    // Start is called before the first frame update
    void Start()
    {
        temperature = roomTemp;
        state = initialState;
    }

    // Update is called once per frame
    void Update()
    {
        if(temperature > 90)
        {
            meltingTestComp = true;
        }
        else if(temperature<=60)
        {
            freezingTestComp = true;
        }


        if(fireDetect.isFire==true&&temperature<=90)
        {
            meltTempCalculation();
        }
        else if (fireDetect.isFire == false&&meltingTestComp)
        {

            freezingTempCalculation();
        }

        //Debug.Log(temperature);
        tempValue.text = temperature.ToString("F0");

        timeValue.text = timeRecording.ToString("F0");
        stateValue.text = state.ToString();





    }

    private void meltTempCalculation()
    {
        if (temperature < 60)
        {

            temperature += rateOfTemRise * Time.deltaTime;
            state = initialState;
        }

        else if (temperature >= 60 && temperature < 78)
        {
            startRecord = true;
            timeRecording += Time.deltaTime;
            temperature += rateOfTemRise * Time.deltaTime;
            state = initialState;
        }
        else if (continueTemp == true)
        {
            state = finalState;
            timeRecording += Time.deltaTime;
            temperature += rateOfTemRise * Time.deltaTime;
        }
        else if (temperature >= 78 && temperature < 79)
        {
            state = midState;
            timeRecording += Time.deltaTime;
            if (continueTemp == false)
            {
                StartCoroutine(continueTime());
            }
        }
        
    }
    private void freezingTempCalculation()
    {
        if (temperature > 90)
        {

            temperature -= rateOfTemRise * Time.deltaTime;
            state = finalState;
        }

        else if (temperature <= 90 && temperature > 78)
        {
            startRecord = true;
            timeRecording += Time.deltaTime;
            temperature -= rateOfTemRise * Time.deltaTime;
            state = finalState;
        }
        else if (continueTemp == true&&temperature>roomTemp)
        {
            state = finalState;
            timeRecording += Time.deltaTime;
            temperature -= rateOfTemRise * Time.deltaTime;
        }
        else if (temperature <= 78 && temperature > 77)
        {
            state = midState;
            timeRecording += Time.deltaTime;
            if (continueTemp == false)
            {
                StartCoroutine(continueTime());
            }
        }
    }

    IEnumerator continueTime()
    {
        yield return new WaitForSeconds(15);
        continueTemp = true;
    }


}
