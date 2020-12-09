using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  

public class Note_Archive : MonoBehaviour
{

    public GameObject note_Prefab;
    public static Note_Archive instance;

    public Queue<GameObject> note_Queue = new Queue<GameObject>();



   

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        for(int i=0; i<15; i++)
        {
            GameObject clone_Note = Instantiate(note_Prefab);
            note_Queue.Enqueue(clone_Note);
            clone_Note.SetActive(false);
        }

    }

    public void InsertQueue(GameObject p_object)
    {
        note_Queue.Enqueue(p_object);
        p_object.SetActive(false);
    }
    public GameObject Getqueue()
    {
        GameObject t_Object = note_Queue.Dequeue();
        t_Object.SetActive(true);
        return t_Object;
    }

}
