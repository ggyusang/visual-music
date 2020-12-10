using UnityEngine;

public class Note_test : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward*moveSpeed;
        if (this.gameObject.transform.position.z <-119.7)
        {
            Note_Archive.instance.InsertQueue(this.gameObject);
        }
        /*
        //transform.LookAt(new Vector3(random_x, random_y, -120));
        random_x = Random.Range(-4.0f, 4.0f);
        random_y =Mathf.Sqrt(16 - Mathf.Pow(random_x, 2))*random_mark;
        random_mark *= -1;
        Debug.Log(random_y);
       
       // transform.position = Vector3.MoveTowards(transform.position, new Vector3(random_x, random_y, -120), moveSpeed * Time.deltaTime);
        //    transform.position += Vector3.back*Time.deltaTime*moveSpeed;
        */
    }
}
