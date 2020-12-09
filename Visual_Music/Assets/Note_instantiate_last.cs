using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_instantiate_last : MonoBehaviour
{
   
    public List<GameObject> Note_Archive;
    [SerializeField] GameObject mainNote;
 
    [SerializeField] Vector3 start_Point = new Vector3(0, 0, -70);


    float random_x;
    int random_mark = 1;
    float random_y;

    private void Start()
    {

        InvokeRepeating("Instantiate_Note", 1, 1);


    }
    void Instantiate_Note()
    {
        random_x = Random.Range(-4.0f, 4.0f);
        random_y = Mathf.Sqrt(16 - Mathf.Pow(random_x, 2)) * random_mark;
        random_mark *= -1;
        Instantiate(mainNote, start_Point, Quaternion.LookRotation(new Vector3(random_x, random_y, -120)));

    }
}
