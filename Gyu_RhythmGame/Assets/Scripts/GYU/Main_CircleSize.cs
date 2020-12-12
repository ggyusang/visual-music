using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RhythmTool.Examples
{
    public class Main_CircleSize : MonoBehaviour
    {
        [SerializeField] float plusScale;
        [SerializeField] GameObject Main_Object;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Hit.hit == true)

            {
                Debug.Log("hit = true");
                Main_Object.transform.localScale += new Vector3(plusScale, plusScale, plusScale);
                Hit.hit = false;
                Debug.Log("hit = false");



            }
            else
            {
                Main_Object.transform.localScale = Vector3.Lerp(Main_Object.transform.localScale, new Vector3(3.4f, 3.4f, 3.4f), 3 * Time.deltaTime);
            }
        }
    }
}