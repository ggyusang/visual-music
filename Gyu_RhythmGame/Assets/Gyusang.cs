using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RhythmTool.Examples
{
    public class Gyusang : MonoBehaviour
    {
        public RhythmData rhythmData;
        public AudioSource audioSource;
      
        // Start is called before the first frame update
        private float prevTime;

     
        private List<Onset> onsets;
        
        void Awake()
        {
            onsets = new List<Onset>();
        }

        // Update is called once per frame
        void Update()
        {
            float time = audioSource.time;
            onsets.Clear();

            rhythmData.GetFeatures<Onset>(onsets, prevTime, time);
            foreach (Onset onset in onsets)
            {
                Note_Archive.instance.Getqueue(onset.strength*41.3f);
            }
            prevTime = time;
        }
    }
}