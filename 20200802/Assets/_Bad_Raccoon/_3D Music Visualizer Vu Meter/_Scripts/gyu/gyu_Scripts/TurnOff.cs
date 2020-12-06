using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
   public  GameObject asdf;
    double currentTime = 0d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

// Update is called once per frame
void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= 10)
        {
            asdf.SetActive(false);
        }
        
    }
}
