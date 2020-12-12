using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_Move : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float old_MoveSpeed;
    [SerializeField] GameObject theObject;

    public int audioChannel = 1;
    public float audioSensibility = 0.15f;

    public float plusScale;
    public float lerpTime = 5.0f;
    public float threshold = 3.0f;


    private void Start()
    {
        old_MoveSpeed = moveSpeed;
  
    }
    private void FixedUpdate()
    {
      
        transform.position += Vector3.back*moveSpeed;
        if (Audio._freqBand[audioChannel] * threshold >= audioSensibility)
        {
            moveSpeed = old_MoveSpeed + plusScale;
        }
        else
        {
            moveSpeed = old_MoveSpeed;
        }
        
      
        /*
    }

    else
    {
        theObject.transform.localScale = Vector3.Lerp(theObject.transform.localScale, oldLocalScale, lerpTime * Time.deltaTime);
    }*/
        if (transform.localPosition.z < -130)
            {
            
            Square_Archive.Square_Archive_instance.InsertQueue(this.gameObject);
         
            Square_Archive.Square_Archive_instance.GetQueue();
       
        }
    }
}
