using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AlkaliMetalController : MonoBehaviour
{
 
    public GameObject sodium;
    private ParticleSystem particle;
    public float SodiumShowTime, PotassiumShowTime, LithiumShowTime, CesiumShowTime;
    public float SodiumTime=8f, PotassiumTime=6f, LithiumTime=10f, CesiumTime=4f;
    

    public TextMeshProUGUI SodiumTimeValue, PotassiumTimeValue, LithiumTimeValue, CesiumTimeValue;

    public string SodiumName = "Sodium", PotassiumName = "Potassium", LithiumName = "Lithium", CesiumName = "Cesium";
    private void Start()
    {
        particle = sodium.GetComponent<ParticleSystem>();
        particle.Pause();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Water"))
        {
            particle.Play();

            metalMelt(collision);

            SodiumTimeValue.text= SodiumShowTime.ToString();
            PotassiumTimeValue.text= PotassiumShowTime.ToString();
            LithiumTimeValue.text= LithiumShowTime.ToString();
            CesiumTimeValue.text= CesiumShowTime.ToString();


        }
    }

    IEnumerator metalMelt(Collision collision)
    {
        if(collision.gameObject.name== SodiumName)
        {
            SodiumShowTime += Time.deltaTime;
            yield return new WaitForSeconds(SodiumTime);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == LithiumName)
        {
            LithiumTime += Time.deltaTime;
            yield return new WaitForSeconds(LithiumTime);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == CesiumName)
        {
            CesiumTime += Time.deltaTime;
            yield return new WaitForSeconds(CesiumTime);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == PotassiumName)
        {
            PotassiumShowTime += Time.deltaTime;
            yield return new WaitForSeconds(PotassiumTime);
            collision.gameObject.SetActive(false);
        }

    }


}
