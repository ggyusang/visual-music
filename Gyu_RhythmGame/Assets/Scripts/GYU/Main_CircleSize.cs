using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RhythmTool.Examples
{
    public class Main_CircleSize : MonoBehaviour
    {
        [SerializeField] float plusScale;
        public GameObject theObject;
        private Vector3 oldLocalScale;
        // Start is called before the first frame update
        void Start()
        {

            oldLocalScale = theObject.transform.localScale;
        }

        // Update is called once per frame
        void Update()
        {
            if (Hit.hit == true)

            {
                Debug.Log("hit = true");
                theObject.transform.localScale += new Vector3(plusScale, plusScale, plusScale);
                Hit.hit = false;
                Debug.Log("hit = false");



            }
            else
            {
                theObject.transform.localScale = Vector3.Lerp(theObject.transform.localScale, oldLocalScale, 3 * Time.deltaTime);
            }
        }
    }
}