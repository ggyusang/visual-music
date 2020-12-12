using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  

public class Note_Archive : MonoBehaviour
{
    [SerializeField] GameObject parent;
    public GameObject note_Prefab;
    public static Note_Archive instance;
    public int archive_Max;
    public Queue<GameObject> note_Queue = new Queue<GameObject>();


    

   

    // Start is called before the first frame update
    void Start()
    {
 
        instance = this;
        for(int i=0; i< archive_Max; i++)
        {
            GameObject clone_Note = Instantiate(note_Prefab, new Vector3(0, 0, -70), Quaternion.LookRotation(new Vector3(-4,0,-120)-new Vector3(0,0,-70)));
         
            clone_Note.transform.SetParent(parent.transform);
           
            InsertQueue(clone_Note);
        
        }

    }

    public void InsertQueue(GameObject p_Object)
    {
     
        note_Queue.Enqueue(p_Object);
        p_Object.SetActive(false);
     

    }
    public GameObject Getqueue(float set_rotation)
    {
        GameObject t_Object = note_Queue.Dequeue();
        t_Object.transform.Rotate(new Vector3(0, 0, -set_rotation),Space.World);
        t_Object.transform.position = new Vector3(0, 0, -70);
        t_Object.SetActive(true);
       
        return t_Object;
    }

}
