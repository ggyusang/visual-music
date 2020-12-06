using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instaniatesssss : MonoBehaviour
{
    [SerializeField] GameObject Note ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Notei = Instantiate(Note, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
