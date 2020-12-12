using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Flash_Test : MonoBehaviour
{
    private Vector3 oldLocalScale;
    public GameObject main_Flash_as;
    public float scaleFactorX = 4.0f;
    public float scaleFactorY = 4.0f;
    public float scaleFactorZ = 4.0f;
    public float lerpTime = 5.0f;

    // Start is called before the first frame update
    void Start()


    {
        oldLocalScale = main_Flash_as.transform.localScale;
    }

   /* public void  Main_Flash()
    {
        main_Flash_as.transform.localScale = new Vector3(scaleFactorX, scaleFactorY, scaleFactorZ);

        main_Flash_as.transform.localScale = Vector3.Lerp(main_Flash_as.transform.localScale, oldLocalScale, lerpTime * Time.deltaTime);
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
