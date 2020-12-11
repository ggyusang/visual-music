using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject Main_Object;
    public static bool hit; 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("HitZone"))
        {
            hit = true;
            Debug.Log("hit");
            Note_Archive.instance.InsertQueue(this.gameObject);
            
        }
       
        if (collision.tag =="MainCircle")
        {

            hit = true;
            Debug.Log("hit");
            Note_Archive.instance.InsertQueue(this.gameObject);
           
        }
    }
}
