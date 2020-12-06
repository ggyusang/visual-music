using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beat_effect : MonoBehaviour
{

    public GameObject theObject;
    public int audioChannel = 4;
    public float audioSensibility = 0.15f;
    public float scaleFactorX = 4.0f;
    public float scaleFactorY = 4.0f;
    public float scaleFactorZ = 4.0f;
    public float lerpTime = 5.0f;

    private Vector3 oldLocalScale;

    void Start()
    {
        oldLocalScale = theObject.transform.localScale;

    }
    /*
    void Beat_effect2()
    {

        theObject.SetActive(false);
    }
    void Beat_effect()
    {
        // If i find the beat

        if (SpectrumKernel.spects[audioChannel] * SpectrumKernel.threshold >= audioSensibility)
        {
            //theObject.transform.Rotate ((Vector3.forward * Random.Range(-180.0f, 180.0f)) * Time.deltaTime);
            theObject.transform.localScale = new Vector3(scaleFactorX, scaleFactorY, scaleFactorZ);

            /*
               theObject.SetActive(true);

               Invoke("Beat_effect2", 0.3f);
          
        }
        else
        {

            // Retrieve the old position smoothly
            theObject.transform.localScale = Vector3.Lerp(theObject.transform.localScale, oldLocalScale, lerpTime * Time.deltaTime);
        }

    
    }
        */

    void Update()
    {

        // If i find the beat

        if (SpectrumKernel.spects[audioChannel] * SpectrumKernel.threshold >= audioSensibility)
        {
            //theObject.transform.Rotate ((Vector3.forward * Random.Range(-180.0f, 180.0f)) * Time.deltaTime);
            theObject.transform.localScale = new Vector3(scaleFactorX, scaleFactorY, scaleFactorZ);



        }
        else
        {

         
            theObject.transform.localScale = Vector3.Lerp(theObject.transform.localScale, oldLocalScale, lerpTime * Time.deltaTime);
        }

    }
}

     