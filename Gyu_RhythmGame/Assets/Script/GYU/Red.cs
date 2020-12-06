using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("부딫혔다");
        if (other.CompareTag("Red"))
        {
            GameObject obj = other.gameObject;
            Destroy(obj);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
