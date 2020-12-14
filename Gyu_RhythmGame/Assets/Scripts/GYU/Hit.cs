using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class Hit : MonoBehaviour
    {
    public static bool on_and_on = false;


    public void Update()
    {
        
    }
        public static bool hit;
        private void OnTriggerEnter(Collider collision)
        {
        on_and_on = true;

        if (collision.CompareTag("HitZone"))
            {
                hit = true;
            
                Note_Archive.instance.InsertQueue(this.gameObject);

            }

            if (collision.tag == "MainCircle")
            {

                hit = true;

           
            Note_Archive.instance.InsertQueue(this.gameObject);

            }
        }
    }
