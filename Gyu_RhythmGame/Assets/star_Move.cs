using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_Move : MonoBehaviour
{
    [SerializeField] float move_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.back* move_Speed;
        if(transform.position.z <-131)
        {
            transform.localPosition = new Vector3(0,0,50);
        }
    }
}
