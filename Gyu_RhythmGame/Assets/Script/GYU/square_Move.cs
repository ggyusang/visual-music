using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_Move : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    private void FixedUpdate()
    {
        transform.position += Vector3.back*moveSpeed;
        if (transform.localPosition.z < -120)
        {
            Square_Archive.Square_Archive_instance.InsertQueue(this.gameObject);
         
            Square_Archive.Square_Archive_instance.GetQueue();
       
        }
    }
}
