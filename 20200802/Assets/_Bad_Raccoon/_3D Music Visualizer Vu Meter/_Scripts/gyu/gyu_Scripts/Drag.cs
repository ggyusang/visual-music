using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Drag : MonoBehaviour
{
    public GameObject circle;
    public Camera MainCamera;
   Vector3 asdf= new Vector3(0,0,0);

    [SerializeField] private Vector3 FirstTouch;
    [SerializeField] private Vector3 LastTouch;
    public float rotationSpeed = 10f;

    

    void Update()

    {

        if (Input.GetMouseButtonDown(0))
        {

           FirstTouch = new Vector3 (Input.mousePosition.x,Input.mousePosition.y,20.62f);
            FirstTouch = MainCamera.ScreenToWorldPoint(FirstTouch);
         
         
        }
      

              if (Input.GetMouseButton(0))
        {

            LastTouch = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20.62f);
            
            LastTouch = MainCamera.ScreenToWorldPoint(LastTouch);
            float angle = Vector3.SignedAngle(transform.up, LastTouch - FirstTouch, -transform.forward);


            /*float o1 = Mathf.Atan((FirstTouch.y - asdf.y) / (FirstTouch.x - asdf.x));
            float o2 = Mathf.Atan((LastTouch.y - asdf.y) / (LastTouch.x - asdf.x));
         float  angle=  Mathf.Abs((o1 - o2) * Mathf.Rad2Deg);*/
            // float angle = Mathf.Atan2(LastTouch.x - FirstTouch.x, LastTouch.y - FirstTouch.y) * Mathf.Rad2Deg;

            Debug.Log(angle);
           /* 
            if(FirstTouch.x>0 && FirstTouch.y >0)
             {
                 if(FirstTouch.x <LastTouch.x || LastTouch.y < FirstTouch.y)
                 {
                    transform.Rotate(new Vector3(0, 0, -angle));
                }
              
             }
             */
            transform.Rotate(new Vector3(0, 0, angle)*Time.deltaTime);
            // Quaternion asdf = Quaternion.Euler(new Vector3(0, 0, -angle));
            

            FirstTouch = LastTouch;
            

        }
        
      


        //  Quaternion target = Quaternion.LookRotation(Center.position - transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime* 3f);
    }
}
    
    


    /*public Transform circle;
    public Transform main;
    float first;
    float moved;
    float subtraction;


    float GetDegree(Vector3 from, Vector3 to)
    {
        Vector3 v = to - from;
        return Mathf.Atan2(v.y, v.x) * 180 / Mathf.PI;
    }



    private void Update()
    {
        if (Input.touchCount > 0)
        {




            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 firstTouch = Input.GetTouch(0).position;
                Vector3 cir = circle.localPosition;
                // firstTouch.x -= Screen.width * 0.5f;
                // firstTouch.y -= Screen.height * 0.5f;
                first = GetDegree(firstTouch, cir);
                Debug.Log("첫번째" + first);
            }
            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 currentTouch = Input.GetTouch(0).position;

                Vector3 cir = circle.localPosition;
                // firstTouch.x -= Screen.whitewidth * 0.5f;
                //  firstTouch.y -= Screen.height * 0.5f;
                moved = GetDegree(currentTouch, cir);
                subtraction = moved - first;
                Debug.Log("두번째" + moved);
                Debug.Log("뺄셈" + subtraction);
                if (subtraction > 0)
                {

                    circle.Rotate(new Vector3(0, 0, 1), subtraction, Space.World);
                }
                if (subtraction < 0)
                {

                    circle.Rotate(new Vector3(0, 0, -1), subtraction, Space.World);

                }




            }
        }
    }
}





    */