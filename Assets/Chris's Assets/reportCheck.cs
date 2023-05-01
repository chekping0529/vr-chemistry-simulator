using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reportCheck : MonoBehaviour
{
    // Start is called before the first frame update
    int totalTime=100;
    int intervalRecord=20;
    public Test testResult;

    float[] meltResult;
    float[] freezeResult;
    bool saved=true;
    int intervalNum;
    void Start()
    {
        meltResult = new float[totalTime / intervalRecord];
        freezeResult = new float[totalTime / intervalRecord];
        intervalNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (testResult.startRecord && testResult.timeRecording <= totalTime)
        {
            StartCoroutine(MeltUpdateVariable());

        }
        else if (testResult.meltingTestComp)
        {
            StartCoroutine(FreezeUpdateVariable());
        }
    }
    private IEnumerator MeltUpdateVariable()
    {
        if (saved)
        {
            meltResult[intervalNum] = testResult.temperature;
            saved= false;
            intervalNum++;
            yield return new WaitForSeconds(10f);
            Debug.Log(meltResult[intervalNum-1]);
            saved = true;

        }
    }
    private IEnumerator FreezeUpdateVariable()
    {
        if (saved)
        {
            freezeResult[intervalNum] = testResult.temperature;
            saved = false;
            intervalNum++;
            yield return new WaitForSeconds(10f);
            Debug.Log(freezeResult[intervalNum - 1]);
            saved = true;

        }
    }
}
