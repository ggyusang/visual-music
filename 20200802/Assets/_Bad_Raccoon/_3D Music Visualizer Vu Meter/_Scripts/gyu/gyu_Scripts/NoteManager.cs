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
    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject mainNote = null;
    
    private void Start()
    {
        for (int i = 0; i < noteMaxCount; ++i)
        {
            GameObject t_note = Instantiate(mainNote, tfNoteAppear.position, Quaternion.identity);
            t_note.SetActive(false);
            NoteArchive.Add(t_note);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("ASDF"))
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
                tfNoteAppear.transform.position = new Vector3(-20, 40, 0);
                break;
            case 2:
                tfNoteAppear.transform.position = new Vector3(-15, 40,0);
                break;
            case 3:
                tfNoteAppear.transform.position = new Vector3(-10, 40, 0);
                break;
            case 4:
                tfNoteAppear.transform.position = new Vector3(-5, 40, 0);
                break;
            case 5:
                tfNoteAppear.transform.position = new Vector3(-0, 40, 0);
                break;
            case 6:
                tfNoteAppear.transform.position = new Vector3(5, 40, 0);
                break;
            case 7:
                tfNoteAppear.transform.position = new Vector3(10, 40, 0);
                break;
            case 8:
                tfNoteAppear.transform.position = new Vector3(15, 40, 0);
                break;
            case 9:
                tfNoteAppear.transform.position = new Vector3(20, 40, 0);
                break;
            case 10:
                tfNoteAppear.transform.position = new Vector3(-20, -40, 0);
                break;
            case 11:
                tfNoteAppear.transform.position = new Vector3(-15, -40,0);
                break;
            case 12:
                tfNoteAppear.transform.position = new Vector3(-10, -40, 0);
                break;
            case 13:
                tfNoteAppear.transform.position = new Vector3(-5, -40, 0);
                break;
            case 14:
                tfNoteAppear.transform.position = new Vector3(0, -40,0);
                break;
            case 15:
                tfNoteAppear.transform.position = new Vector3(5, -40, 0);
                break;
            case 16:
                tfNoteAppear.transform.position = new Vector3(10, -40, 0);
                break;
            case 17:
                tfNoteAppear.transform.position = new Vector3(15, -40, 0);
                break;
            case 18:
                tfNoteAppear.transform.position = new Vector3(20, -40, 0);
                break;

        }
      
        
        if (currentTime >= 180d / bpm)
        {

        

            if (NoteArchive[active_Note].gameObject.activeSelf)
            {
                return;
            }
            NoteArchive[active_Note].transform.position = tfNoteAppear.position;
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