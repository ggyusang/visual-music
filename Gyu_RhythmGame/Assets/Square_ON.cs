using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square_ON : MonoBehaviour
{
    [SerializeField] GameObject square_asd;
   
    // Start is called before the first frame update
    
    private void Update()
    {
           if (Hit.on_and_on == true)
            {
                Set_Active();
            }
    }
    void Set_Active()
    {
        square_asd.SetActive(true);
    }
}
