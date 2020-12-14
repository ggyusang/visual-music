using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_ON : MonoBehaviour
{
   
    [SerializeField] GameObject star_asd;
    public static float background_Time =5.8f;
    // Start is called before the first frame update
 
    void Set_Active()
    {
        star_asd.SetActive(true);
    }
    private void Update()
    {
        if (Hit.on_and_on == true)
        {
            Set_Active();
        }
    }
}
