using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
   public  GameObject asdf;
    public float noteSpeed = 1;
    public Rigidbody noterigid;
   



    private void Start()
    {
      
   
        
    }
    

    // Update is called once per frame
    void Update()
    {

        // noterigid.velocity = new Vector3(0, 0, 1);
        // transform.localPosition += new Vector3(0, 0, 1);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), noteSpeed * Time.deltaTime);
        //target 위치로 이동하는 함수 

        
    }
}

