using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour
{
    float a = 0;
    float s = 0;
    public float e;
    
    void Start()
    {
        
    }
    void Average()
    {


        for (int t = 0; t < 43; t++)
        {
            for (int i = 0; i < SpectrumKernel.spects.Length; i++)
            {
                a = a + SpectrumKernel.spects[i] * SpectrumKernel.spects[i];
                //a 는 순간 에너지

            }
            s += a;

        }
        s = s / 43;
        s = s * e;





        if (a > s)
        {
            Debug.Log("now");
            s = 0;
            a = 0;
        }
        if (s > a)
        {

            a = 0;
            s = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Average();
    }
}
