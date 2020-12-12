using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class Hit : MonoBehaviour
    {


    double a = 0;
    public void Update()
    {
        a += Time.deltaTime;
    }
        public static bool hit;
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.CompareTag("HitZone"))
            {
                hit = true;
            Debug.Log(a);
                Note_Archive.instance.InsertQueue(this.gameObject);

            }

            if (collision.tag == "MainCircle")
            {

                hit = true;

            Debug.Log(a);
            Note_Archive.instance.InsertQueue(this.gameObject);

            }
        }
    }
