using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emerlad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("부딫혔다");
        if(other.CompareTag ("Emerald"))
        {
            GameObject obj = other.gameObject;
            Destroy(obj);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
