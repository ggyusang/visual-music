using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square_Archive : MonoBehaviour
{
    [SerializeField] GameObject square_Prefab;
    [SerializeField] Queue<GameObject> square_Archive = new Queue<GameObject>();
    [SerializeField] GameObject parent;
    public static Square_Archive Square_Archive_instance;

    [SerializeField] float max_Square = 35;
  
    // Start is called before the first frame update
    void Start()
    {
        Square_Archive_instance = this;
        for (int i = 0; i<max_Square; i++)
        {
            GameObject clone_Square = Instantiate(square_Prefab);
            clone_Square.transform.SetParent(parent.transform);
            clone_Square.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 45+(i * 10)));
            clone_Square.transform.position += new Vector3(0, 0,-100+ (i * 2));
            square_Archive.Enqueue(clone_Square);
        }
    }
    public void InsertQueue(GameObject p_object)
    {
        square_Archive.Enqueue(p_object);
        
     
    }
   public GameObject GetQueue()
    {
        GameObject t_clone = square_Archive.Dequeue();
        t_clone.transform.position += Vector3.forward * max_Square*2;
    
        return t_clone;

    }

 
}
