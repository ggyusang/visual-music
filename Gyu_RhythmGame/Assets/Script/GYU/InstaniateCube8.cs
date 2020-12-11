using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaniateCube8 : MonoBehaviour
{
  
    public GameObject cubePrefab;
 
    public float _startScale, _scaleMultiplier;
     GameObject[] cube8 = new GameObject[8];
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++) 
        {
            GameObject instanceCube = Instantiate(cubePrefab, new Vector3(-3+i*0.5f,transform.position.y,  transform.position.z), transform.rotation);
            cube8[i] = instanceCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
     
        
        for (int i = 0; i < 8; i++)
        {
            cube8[i].transform.localScale= new Vector3(transform.localScale.x+3, (Audio._freqBand[i] * _scaleMultiplier) + _startScale, transform.localScale.z);
        }
        
    }
}
