using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Note_instantiate_test : MonoBehaviour
{
    
    [SerializeField] GameObject mainNote;
    public int bpm = 0;
    [SerializeField] Vector3 asdf;
    double currentTime = 0d;
    int random_color;
    float random_x;
    float random_y;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
       // randomAppear = Random.Range(1, 20);
        random_x = Random.Range(-3, 3);
        random_y = Random.Range(-3, 3);
        asdf = new Vector3(random_x, random_y, -100);
        

     /*   switch (randomAppear)
        {
            case 1:
                asdf = new Vector3(-3,-3 , 0);
                break;
            case 2:
                asdf = new Vector3(-2.5f, 2.5f, -143);
                break;
            case 3:
                asdf = new Vector3(-2, -2, -143);
                break;
            case 4:
                asdf = new Vector3(-1.5f, -1.5f, -143);
                break;
            case 5:
                asdf = new Vector3(-1, -1, -143);
                break;
            case 6:
                asdf = new Vector3(-0.5f, -0.5f, -143);
                break;
            case 7:
                asdf = new Vector3(0, 0, -143);
                break;
            case 8:
                asdf = new Vector3(0.5f, 0.5f, -143);
                break;
            case 9:
                asdf = new Vector3(8, 10, -143);
                break;
            case 10:
                asdf = new Vector3(-8, -10, -143);
                break;
                }
                */
        
        if (currentTime >= 180d / bpm)
        {
            GameObject t_note = Instantiate(mainNote, asdf, Quaternion.identity);
            random_color = Random.Range(1, 4);
            switch (random_color)
            {
                case 1:
                    t_note.gameObject.tag = "Emerald";
                    t_note.GetComponent<MeshRenderer>().material.color = new Color(27, 255, 250);
                   
                    break;
                case 2:
                    t_note.gameObject.tag = "Red";
                    t_note.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 111);
                   
                    break;
                case 3:
                    t_note.gameObject.tag = "Blue";
                    t_note.GetComponent <MeshRenderer>().material.color = new Color(40, 0, 255);
                   
                    break; 
            }
            currentTime -= 180d / bpm;

           
        }
    }
}
