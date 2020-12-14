using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
  
    public Material material;
    // Start is called before the first frame update
   
    private void Update()
    {
        if (Hit.on_and_on == true)
        {
            Change_color();
        }
    }
    void Change_color()
    {
        
        material.color = new Color(0, 191/255f, 150/255f);
        material.SetColor("_EmissionColor", new Color(0, 0.75f, 0.58f)*1.6f );
    }
    private void OnApplicationQuit()
    {
        material.color = Color.black;
        material.SetColor("_EmissionColor", Color.black);
    }
}
