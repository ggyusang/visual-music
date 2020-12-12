using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{

    Main_Flash_Test Main_Flash_Test = new Main_Flash_Test();

    public List<GameObject> NoteArchive = new List<GameObject>();
    //public List<GameObject> NoteArchive_active = new List<GameObject>();
    public int noteMaxCount = 15;
    private int active_Note = 0;
    int randomAppear;
    public int bpm = 0;
    double currentTime = 0d;
    Vector3 asdf = new Vector3();
    
    [SerializeField] GameObject mainNote = null;
    
    private void Start()
    {
        for (int i = 0; i < noteMaxCount; ++i)
        {
            GameObject t_note = Instantiate(mainNote, asdf, Quaternion.identity);
            t_note.SetActive(false);
            NoteArchive.Add(t_note);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Note"))
        {

            GameObject obj = collision.gameObject;
            obj.SetActive(false);


        }
     
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        randomAppear = Random.Range(1, 20);
        switch (randomAppear)
        {
            case 1:
                asdf = new Vector3(-8, 10, -143);
                break;
            case 2:
                asdf = new Vector3(-6, 10, -143);
                break;
            case 3:
                asdf = new Vector3(-4, 10, -143);
                break;
            case 4:
                asdf = new Vector3(-2, 10, -143);
                break;
            case 5:
                asdf = new Vector3(0, 10, -143);
                break;
            case 6:
                asdf = new Vector3(2, 10, -143);
                break;
            case 7:
                asdf = new Vector3(4, 10, -143);
                break;
            case 8:
                asdf = new Vector3(6, 10, -143);
                break;
            case 9:
                asdf = new Vector3(8, 10, -143);
                break;
            case 10:
                asdf = new Vector3(-8, -10, -143);
                break;
            case 11:
                asdf = new Vector3(-6, -10, -143);
                break;
            case 12:
                asdf = new Vector3(-4, -10, -143);
                break;
            case 13:
                asdf = new Vector3(-2, -10, -143);
                break;
            case 14:
                asdf = new Vector3(0, -10, -143);
                break;
            case 15:
                asdf = new Vector3(2, -10, -143);
                break;
            case 16:
                asdf = new Vector3(4, -10, -143);
                break;
            case 17:
                asdf = new Vector3(6, -10, -143);
                break;
            case 18:
                asdf = new Vector3(8, -10, -143);
                break;

        }
      
        
        if (currentTime >= 180d / bpm)
        {

        

            if (NoteArchive[active_Note].gameObject.activeSelf)
            {
                return;
            }
            NoteArchive[active_Note].transform.position = asdf;
            NoteArchive[active_Note].gameObject.SetActive(true);
            if (active_Note >= noteMaxCount - 1)
            {
                active_Note = 0;
            }
            else
            {
               active_Note++;
            }



            //t_note.transform.SetParent(this.transform);
            currentTime -= 180d / bpm;
        }
        
    }
    
    
}